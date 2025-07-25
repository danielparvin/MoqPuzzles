namespace MoqPuzzles.Models {
    public sealed class LineItemAdjustment {
        public LineItemAdjustment(decimal Amount, string ReasonCode) {
            this.Amount = Amount;
            this.ReasonCode = ReasonCode;
        }

        public decimal Amount { get; }
        public string ReasonCode { get; }
    }
}
