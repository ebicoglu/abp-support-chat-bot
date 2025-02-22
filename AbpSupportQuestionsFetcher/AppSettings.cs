namespace AbpSupportQuestionsFetcher;

public static class AppSettings
{
    //TODO UPDATE THESE OPTIONS
    //------------------------------------------------------------------------------------------------
    public static string OutputPdfPath = $"D:\\temp\\abp-support-{DateTime.Now:yyyy-MM-dd}.pdf";
    public static string ConnectionString = "";//todo enter the connection string
    public static int? MaxRecordCount = null;
    public static bool? OnlyAcceptedAnswers = true;
    //------------------------------------------------------------------------------------------------

}