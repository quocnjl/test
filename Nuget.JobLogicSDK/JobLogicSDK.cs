namespace Nuget.JobLogicSDK
{
    public class JobLogicSDK
    {
        public void CreateJob(string jobName)
        {
            Console.WriteLine($"Create Job. with Name = '{jobName}', by invoking api [POST] {Environment.GetEnvironmentVariable("JL_SDK_API")}/tenancy/{Environment.GetEnvironmentVariable("JL_SDK_TENANTID")}/jobs" );
        }

    }
}
