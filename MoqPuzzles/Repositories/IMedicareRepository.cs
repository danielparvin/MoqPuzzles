namespace MoqPuzzles.Repositories {
    public interface IMedicareRepository {
        public decimal? GetMedicareAllowance(string ProcedureCode, DateTime DateOfService);
        public decimal? GetMedicareAllowance(string ProcedureCode, DateTime DateOfService, string[] Modifiers);
    }
}
