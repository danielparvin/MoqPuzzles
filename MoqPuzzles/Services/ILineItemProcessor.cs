using MoqPuzzles.Models;

namespace MoqPuzzles.Services {
    public interface ILineItemProcessor {
        CodeDescriptionAndAllowance GetCodeDescriptionAndAllowance(LineItem LineItem);
    }
}