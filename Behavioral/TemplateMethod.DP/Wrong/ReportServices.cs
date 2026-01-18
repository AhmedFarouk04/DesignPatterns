namespace TemplateMethod.DP.Wrong;

public class PdfReportService
{
    public void Generate()
    {
        LoadData();
        Console.WriteLine("Formatting PDF");
        Export();
    }

    void LoadData() => Console.WriteLine("Loading data");
    void Export() => Console.WriteLine("Exporting file");
}

public class ExcelReportService
{
    public void Generate()
    {
        LoadData();
        Console.WriteLine("Formatting Excel");
        Export();
    }

    void LoadData() => Console.WriteLine("Loading data");
    void Export() => Console.WriteLine("Exporting file");
}
