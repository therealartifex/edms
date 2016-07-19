namespace EDMissionSolver
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lsvMissions = new System.Windows.Forms.ListView();
            this.chMission = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chCargo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDest = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnAddMission = new System.Windows.Forms.Button();
            this.gbMission = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nmcPay = new System.Windows.Forms.NumericUpDown();
            this.tbDest = new System.Windows.Forms.TextBox();
            this.nmcCargo = new System.Windows.Forms.NumericUpDown();
            this.nmcHoldCapacity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcHoldCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvMissions
            // 
            this.lsvMissions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chMission,
            this.chCargo,
            this.chPay,
            this.chDest});
            this.lsvMissions.FullRowSelect = true;
            this.lsvMissions.GridLines = true;
            this.lsvMissions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvMissions.Location = new System.Drawing.Point(12, 36);
            this.lsvMissions.Name = "lsvMissions";
            this.lsvMissions.Size = new System.Drawing.Size(233, 214);
            this.lsvMissions.TabIndex = 0;
            this.lsvMissions.UseCompatibleStateImageBehavior = false;
            this.lsvMissions.View = System.Windows.Forms.View.Details;
            // 
            // chMission
            // 
            this.chMission.Text = "Mission";
            this.chMission.Width = 50;
            // 
            // chCargo
            // 
            this.chCargo.Text = "Cargo";
            this.chCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chCargo.Width = 40;
            // 
            // chPay
            // 
            this.chPay.Text = "Pay";
            this.chPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPay.Width = 50;
            // 
            // chDest
            // 
            this.chDest.Text = "Destination";
            this.chDest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDest.Width = 70;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(269, 198);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(174, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Mission";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(269, 227);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(174, 23);
            this.btnSolve.TabIndex = 2;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnAddMission
            // 
            this.btnAddMission.Location = new System.Drawing.Point(6, 103);
            this.btnAddMission.Name = "btnAddMission";
            this.btnAddMission.Size = new System.Drawing.Size(162, 23);
            this.btnAddMission.TabIndex = 3;
            this.btnAddMission.Text = "Add";
            this.btnAddMission.UseVisualStyleBackColor = true;
            this.btnAddMission.Click += new System.EventHandler(this.btnAddMission_Click);
            // 
            // gbMission
            // 
            this.gbMission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMission.Controls.Add(this.label5);
            this.gbMission.Controls.Add(this.label4);
            this.gbMission.Controls.Add(this.label1);
            this.gbMission.Controls.Add(this.nmcPay);
            this.gbMission.Controls.Add(this.tbDest);
            this.gbMission.Controls.Add(this.btnAddMission);
            this.gbMission.Controls.Add(this.nmcCargo);
            this.gbMission.Location = new System.Drawing.Point(269, 36);
            this.gbMission.Name = "gbMission";
            this.gbMission.Size = new System.Drawing.Size(174, 135);
            this.gbMission.TabIndex = 4;
            this.gbMission.TabStop = false;
            this.gbMission.Text = "New Mission";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Destination:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pay:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cargo:";
            // 
            // nmcPay
            // 
            this.nmcPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcPay.Location = new System.Drawing.Point(75, 48);
            this.nmcPay.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nmcPay.Name = "nmcPay";
            this.nmcPay.Size = new System.Drawing.Size(93, 23);
            this.nmcPay.TabIndex = 8;
            // 
            // tbDest
            // 
            this.tbDest.Location = new System.Drawing.Point(75, 77);
            this.tbDest.Name = "tbDest";
            this.tbDest.Size = new System.Drawing.Size(93, 20);
            this.tbDest.TabIndex = 8;
            // 
            // nmcCargo
            // 
            this.nmcCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcCargo.Location = new System.Drawing.Point(75, 19);
            this.nmcCargo.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmcCargo.Name = "nmcCargo";
            this.nmcCargo.Size = new System.Drawing.Size(93, 23);
            this.nmcCargo.TabIndex = 6;
            // 
            // nmcHoldCapacity
            // 
            this.nmcHoldCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmcHoldCapacity.Location = new System.Drawing.Point(253, 7);
            this.nmcHoldCapacity.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmcHoldCapacity.Name = "nmcHoldCapacity";
            this.nmcHoldCapacity.Size = new System.Drawing.Size(55, 23);
            this.nmcHoldCapacity.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ship Hold Capacity:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 264);
            this.Controls.Add(this.nmcHoldCapacity);
            this.Controls.Add(this.gbMission);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lsvMissions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "Elite: Dangerous Mission Solver";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbMission.ResumeLayout(false);
            this.gbMission.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmcPay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmcHoldCapacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvMissions;
        private System.Windows.Forms.ColumnHeader chMission;
        private System.Windows.Forms.ColumnHeader chCargo;
        private System.Windows.Forms.ColumnHeader chPay;
        private System.Windows.Forms.ColumnHeader chDest;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnAddMission;
        private System.Windows.Forms.GroupBox gbMission;
        private System.Windows.Forms.TextBox tbDest;
        private System.Windows.Forms.NumericUpDown nmcPay;
        private System.Windows.Forms.NumericUpDown nmcCargo;
        private System.Windows.Forms.NumericUpDown nmcHoldCapacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

