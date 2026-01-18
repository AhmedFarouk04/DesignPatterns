namespace TemplateMethod.DP.Correct;

public abstract class ReportGenerator
{
    public void GenerateReport()
    {
        LoadData();
        Format();      
        Export();
    }

    protected virtual void LoadData()
    {
        Console.WriteLine("Loading data");
    }

    protected abstract void Format(); 

    protected virtual void Export()
    {
        Console.WriteLine("Exporting report");
    }
}
