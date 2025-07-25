using MoqPuzzles.Models;
using MoqPuzzles.Repositories;

namespace MoqPuzzles.Services {
    /// <summary>
    /// Processes line items from a medical claim.
    /// </summary>
    public sealed class LineItemProcessor : ILineItemProcessor {
        private readonly ICodeInfoRepository codeInfoRepository;
        private readonly IMedicareRepository medicareRepository;

        public LineItemProcessor(ICodeInfoRepository CodeInfoRepository, IMedicareRepository MedicareRepository) {
            codeInfoRepository = CodeInfoRepository;
            medicareRepository = MedicareRepository;
        }

        public CodeDescriptionAndAllowance GetCodeDescriptionAndAllowance(LineItem LineItem) {
            string procedureCode = LineItem.ProcedureCode;
            DateTime dateOfService = LineItem.DateOfService;
            string? description = codeInfoRepository.GetDescriptionOfCode(procedureCode);
            decimal? medicareAllowance = medicareRepository.GetMedicareAllowance(procedureCode, dateOfService);
            return new CodeDescriptionAndAllowance(procedureCode) {
                Description = description,
                MedicareAllowance = medicareAllowance
            };
        }
    }
}
