using AbstractFactory.Abstract;
using AbstractFactory.Concrete;

IncomeTaxAnalyzerAbstractFactory salaryIncomeAnalyzer = new SalaryIncomeTaxAnalyzer();
IncomeTaxAnalyzerAbstractFactory bonusIncomeAnalyzer = new BonusIncomeTaxAnalyzer();

var taxReport = new TaxReport(salaryIncomeAnalyzer, bonusIncomeAnalyzer);
var reportString = taxReport.BuildReport(100, 20);

Console.WriteLine(reportString);
Console.ReadKey();
