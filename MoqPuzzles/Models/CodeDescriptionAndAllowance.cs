namespace MoqPuzzles.Models {
    public sealed class CodeDescriptionAndAllowance {
        public CodeDescriptionAndAllowance(string ProcedureCode) {
            this.ProcedureCode = ProcedureCode;
        }

        public string ProcedureCode { get; set; }
        public string? Description { get; set; }
        public decimal? MedicareAllowance { get; set; }
    }
}
