namespace AbpSupportQuestionsFetcher;

public static class AppSettings
{
    //TODO UPDATE THESE OPTIONS
    //------------------------------------------------------------------------------------------------
    public static string OutputPdfPath = $"D:\\temp\\abp-support-{DateTime.Now:yyyy-MM-dd}.pdf";
    public static string ConnectionString = "...Enter-Here...";
    public static int? MaxRecordCount = null;
    public static bool? OnlyAcceptedAnswers = true;
    //------------------------------------------------------------------------------------------------

}