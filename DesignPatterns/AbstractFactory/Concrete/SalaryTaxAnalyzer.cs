using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class SalaryTaxAnalyzer : AbstractTaxAnalyzer
    {
        public override decimal CalculateTaxes(decimal income)
        {
            return income * 0.4M;
        }
    }
}
