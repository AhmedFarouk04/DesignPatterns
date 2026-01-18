namespace TemplateMethod.DP.Correct;

public class ExcelReport : ReportGenerator
{
    protected override void Format()
    {
        Console.WriteLine("Formatting Excel report");
    }
}
