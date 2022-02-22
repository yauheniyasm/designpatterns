using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class TaxReport
    {
        private readonly AbstractTaxAnalyzer salaryAnalyzer;

        private readonly AbstractTaxAnalyzer bonusAnalyzer;

        public TaxReport(IncomeTaxAnalyzerAbstractFactory salaryAnalyzerFactory, IncomeTaxAnalyzerAbstractFactory bonusAnalyzerFactory)
        {
            salaryAnalyzer = salaryAnalyzerFactory.CreateAnalyzer();
            bonusAnalyzer = bonusAnalyzerFactory.CreateAnalyzer();
        }

        public string BuildReport(decimal salary, decimal bonus)
        {
            var salaryTaxAmount = salaryAnalyzer.CalculateTaxes(salary);
            var bonusTaxAmount = bonusAnalyzer.CalculateTaxes(bonus);

            return $"Salary tax amount = {salaryTaxAmount}; bonus tax amount = {bonusTaxAmount}; total amount = {salaryTaxAmount + bonusTaxAmount}";
        }
    }
}
