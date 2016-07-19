using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SolverFoundation.Services;

// ReSharper disable LocalizableElement
// ReSharper disable SpecifyACultureInStringConversionExplicitly
// ReSharper disable ImplicitlyCapturedClosure

namespace EDMissionSolver
{
    public partial class frmMain : Form
    {
        private int ids;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            //lsvMissions.Items[0].BackColor = Color.LimeGreen;
            //lsvMissions.Items[1].BackColor = Color.PaleVioletRed;
        }

        private void btnAddMission_Click(object sender, EventArgs e)
        {
            ++ids;
            lsvMissions.Items.Add(new ListViewItem(new[] {ids.ToString(), nmcCargo.Value.ToString(), nmcPay.Value.ToString(), tbDest.Text}));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lsvMissions.SelectedItems.Count < 1)
                MessageBox.Show("No missions selected.", "EDMS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                foreach (ListViewItem lvi in lsvMissions.SelectedItems) lsvMissions.Items.Remove(lvi);
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lsvMissions.Items) lvi.BackColor = SystemColors.Window;
            var missions = lsvMissions.Items.Cast<ListViewItem>().Select(lvi => new Mission(int.Parse(lvi.SubItems[0].Text), int.Parse(lvi.SubItems[1].Text),int.Parse(lvi.SubItems[2].Text), lvi.SubItems[3].Text)).ToList();
            var holdCapacity = (int)nmcHoldCapacity.Value;

            // initialize model
            var sc = SolverContext.GetContext();
            sc.ClearModel();
            var model = sc.CreateModel();

            // definitions
            var mSet = new Set(Domain.Any, "missions");
            var acc = new Decision(Domain.Boolean, "accept", mSet);
            var cargo = new Parameter(Domain.IntegerNonnegative, "cargo", mSet);
            var pay = new Parameter(Domain.IntegerNonnegative, "pay", mSet);

            // bind data
            cargo.SetBinding(missions, nameof(Mission.Cargo), nameof(Mission.Id));
            pay.SetBinding(missions, nameof(Mission.Pay), nameof(Mission.Id));

            // add to model
            model.AddDecision(acc);
            model.AddParameters(cargo, pay);
            model.AddConstraints("holdCapacity", Model.Sum(Model.ForEach(mSet, c => cargo[c] * acc[c])) <= holdCapacity);
            model.AddGoal("maxPay", GoalKind.Maximize, Model.Sum(Model.ForEach(mSet, c => pay[c] * acc[c])));

            sc.Solve(new SimplexDirective());

            var i = 0;
            var dec = acc.GetValuesByIndex().ToArray();
            foreach (ListViewItem lvi in lsvMissions.Items) lvi.BackColor = Convert.ToBoolean(dec[i++]) ? Color.LimeGreen : Color.PaleVioletRed;
        }
    }
}
