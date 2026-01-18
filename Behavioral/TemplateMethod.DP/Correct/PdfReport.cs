namespace TemplateMethod.DP.Correct;

public class PdfReport : ReportGenerator
{
    protected override void Format()
    {
        Console.WriteLine("Formatting PDF report");
    }
}
