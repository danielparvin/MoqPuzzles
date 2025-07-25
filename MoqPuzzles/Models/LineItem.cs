namespace MoqPuzzles.Models {
    public sealed class LineItem {
        public LineItem(string ProcedureCode, decimal Charge, DateTime DateOfService) {
            this.ProcedureCode = ProcedureCode;
            this.Charge = Charge;
            this.DateOfService = DateOfService;
            Adjustments = new();
        }

        public List<LineItemAdjustment> Adjustments { get; }
        public DateTime DateOfService { get; }
        public string ProcedureCode { get; }
        public decimal Charge { get; }
    }
}
