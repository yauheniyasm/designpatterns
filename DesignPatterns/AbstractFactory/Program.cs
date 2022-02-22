using AbstractFactory.Abstract;
using AbstractFactory.Concrete;

IncomeTaxAnalyzerFactory salaryIncomeAnalyzer = new SalaryIncomeTaxAnalyzer();
IncomeTaxAnalyzerFactory bonusIncomeAnalyzer = new BonusIncomeTaxAnalyzer();

var taxReport = new TaxReport(salaryIncomeAnalyzer, bonusIncomeAnalyzer);
var reportString = taxReport.BuildReport(100, 20);

Console.WriteLine(reportString);
Console.ReadKey();
