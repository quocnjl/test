// See https://aka.ms/new-console-template for more information
using Nuget.JobLogicSDK;

if (args == null || args.Length != 2)
    throw new ArgumentException("Please provide 2 arguments: <delay in seconds> <job name>");
var allArgs = string.Join(" | ", args);

Console.WriteLine("Hello, " + allArgs);
await Task.Delay(int.Parse(args[0]) * 1000);
var sdk = new JobLogicSDK();
sdk.CreateJob(args[1]);

