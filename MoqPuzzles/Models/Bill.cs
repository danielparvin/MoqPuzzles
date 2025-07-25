namespace MoqPuzzles.Models {
    public sealed class Bill {
        public Bill() {
            LineItems = new();
        }

        public Bill(Bill Bill) {
            LineItems = Bill.LineItems
                .Select(lineItem => new LineItem(lineItem.ProcedureCode, lineItem.Charge, lineItem.DateOfService))
                .ToList();
        }

        public List<LineItem> LineItems { get; }
    }
}
