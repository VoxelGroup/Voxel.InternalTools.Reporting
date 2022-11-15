using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace ServiceBusTriggerTest.Function
{
    public class ServiceBusTopicTriggerTest
    {
        private readonly ILogger<ServiceBusTopicTriggerTest> _logger;

        public ServiceBusTopicTriggerTest(ILogger<ServiceBusTopicTriggerTest> log)
        {
            _logger = log;
        }

        [FunctionName("ServiceBusTopicTriggerTest")]
        public void Run([ServiceBusTrigger("sbt-vx-we-billback-t-01", "sbsub-vx-we-notifier-d-00", 
        Connection = "sbvxwenotifierd01_SERVICEBUS")]
        string message)
        {
            _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {message}");
        }
    }
}
