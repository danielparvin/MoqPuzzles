using MoqPuzzles.Models;

namespace MoqPuzzles.Services {
    public sealed class BillProcessor {
        private const string DEFAULT_REASON_CODE = "JUST 'CUZ";
        private readonly ILineItemProcessor lineItemProcessor;

        public BillProcessor(ILineItemProcessor LineItemProcessor) {
            lineItemProcessor = LineItemProcessor;
        }

        public Bill ProcessBill(Bill Bill) {
            var processedBill = new Bill();
            foreach (var lineItem in Bill.LineItems) {
                var codeDescriptionAndAllowance = lineItemProcessor.GetCodeDescriptionAndAllowance(lineItem);
                decimal? allowance = codeDescriptionAndAllowance.MedicareAllowance;
                if (allowance != null && allowance < lineItem.Charge) {
                    var adjustmentAmount = lineItem.Charge - allowance.Value;
                    var adjustment = new LineItemAdjustment(adjustmentAmount, DEFAULT_REASON_CODE);
                    lineItem.Adjustments.Add(adjustment);
                }
            }
            return processedBill;
        }
    }
}
