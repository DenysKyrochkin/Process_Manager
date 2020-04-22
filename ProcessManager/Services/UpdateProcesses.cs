using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace ProcessManager.Services
{
    public class UpdateProcesses : BackgroundService
    {
        private readonly ProcessesList _processesList;
        public UpdateProcesses(ProcessesList processesList)
        {
            _processesList = processesList;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            return Task.Run(async () =>
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    try
                    {
                        await _processesList.Update();
                        await Task.Delay(TimeSpan.FromSeconds(3), stoppingToken);
                    }
                    catch (OperationCanceledException) { }
                }
            }, stoppingToken);
        }
    }
}
