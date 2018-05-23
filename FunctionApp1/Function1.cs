using System;
using System.ServiceModel;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionApp1
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, TraceWriter log)
        {
            log.Info($"C# Timer trigger function executed at: {DateTime.Now}");

            new TestClass();
        }
    }

    public class TestClass
    {
        public TestClass()
        {
            var binding = new BasicHttpsBinding();
        }
    }
}
