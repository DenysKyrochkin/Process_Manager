using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;

namespace ProcessManager.Services
{
    public class ReloadProcesses : BackgroundService
    {
        private readonly ProcessesList _processesList;
        public ReloadProcesses(ProcessesList processesList)
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
                        await _processesList.Reload();
                        await Task.Delay(TimeSpan.FromSeconds(5), stoppingToken);
                    }
                    catch (OperationCanceledException) { }
                }
            }, stoppingToken);
        }
    }
}
