namespace AbpSupportQuestionsFetcher;

class Program
{
    private static void Main()
    {
        var outputPdfPath = new QuestionFetcher().CreatePdf();
        if (outputPdfPath != null)
        {
            Console.WriteLine($"PDF created successfully: {outputPdfPath}");
        }

        Console.ReadKey();
    }
}