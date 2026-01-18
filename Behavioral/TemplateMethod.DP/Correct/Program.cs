using TemplateMethod.DP.Correct;

Console.WriteLine("=== Template Method Demo ===");

ReportGenerator pdf = new PdfReport();
pdf.GenerateReport();

Console.WriteLine();

ReportGenerator excel = new ExcelReport();
excel.GenerateReport();
