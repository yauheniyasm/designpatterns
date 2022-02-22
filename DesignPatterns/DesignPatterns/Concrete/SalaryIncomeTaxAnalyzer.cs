using AbstractFactory.Abstract;

namespace AbstractFactory.Concrete
{
    public class SalaryIncomeTaxAnalyzer : IncomeTaxAnalyzerAbstractFactory
    {
        public override AbstractTaxAnalyzer CreateAnalyzer()
        {
            return new SalaryTaxAnalyzer();
        }
    }
}
