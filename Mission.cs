namespace EDMissionSolver
{
    public class Mission
    {
        public int Id { get; }
        public int Cargo { get; }
        public int Pay { get; }
        public string Destination { get; }

        public Mission(int id, int cargo, int pay, string dest)
        {
            Id = id;
            Cargo = cargo;
            Pay = pay;
            Destination = dest;
        }
    }
}
