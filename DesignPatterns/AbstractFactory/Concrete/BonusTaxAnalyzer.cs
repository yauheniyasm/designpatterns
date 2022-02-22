using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class BonusTaxAnalyzer : AbstractTaxAnalyzer
    {
        public override decimal CalculateTaxes(decimal income)
        {
            return income * 0.3M;
        }
    }
}
