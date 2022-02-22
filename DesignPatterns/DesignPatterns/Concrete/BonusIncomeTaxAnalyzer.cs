using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    internal class BonusIncomeTaxAnalyzer : IncomeTaxAnalyzerAbstractFactory
    {
        public override AbstractTaxAnalyzer CreateAnalyzer()
        {
            return new BonusTaxAnalyzer();
        }
    }
}
