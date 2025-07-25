namespace MoqPuzzles.Repositories {
    public interface ICodeInfoRepository {
        public string? GetDescriptionOfCode(string ProcedureCode);
        public string? GetDescriptionOfCode(string ProcedureCode, string SubCode);
    }
}
