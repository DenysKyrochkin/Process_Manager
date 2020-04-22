using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using ProcessManager.Models;

namespace ProcessManager.Services
{
    public class ProcessesList : IDisposable
    {
        public List<Processes> ProcessList { get; set; }
        private readonly object _lock = new object();

        public int SortId { get; set; } = 0;
        public string Sort { get; set; } = "None";
        public ProcessesList()
        {
            Reload().Wait();
        }

        public async Task Reload()
        {
            lock (_lock)
            {
                var list = Process.GetProcesses().Where(p =>
                {
                    try
                    {
                        var canBeRead = p.MainModule;
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                });
                ProcessList = new List<Processes>(list.Select(p => new Processes(p)));
            }
            await SortAsync();
        }

        public async Task Update()
        {
            lock (_lock)
            {
                ProcessList = new List<Processes>(
                    ProcessList.Where(p =>
                    {
                        try
                        {
                            p.GetData();
                            return true;
                        }
                        catch (Exception)
                        {
                            return false;
                        }
                    }));
            }

            await SortAsync();
        }

        public Task SortAsync()
        {
            return Task.Run(() =>
            {
                lock (_lock)
                {
                    switch (SortId)
                    {
                        case 1:
                            if (Sort != "None")
                            {
                                ProcessList = Sort == "Ascending" ?
                                    ProcessList.OrderBy(p => p.Name).ToList() :
                                    ProcessList.OrderByDescending(p => p.Name).ToList();
                            }
                            break;
                        case 2:
                            if (Sort != "None")
                            {
                                ProcessList = Sort == "Ascending" ?
                                    ProcessList.OrderBy(p => p.Id).ToList() :
                                    ProcessList.OrderByDescending(p => p.Id).ToList();
                            }
                            break;
                        case 3:
                            if (Sort != "None")
                            {
                                ProcessList = Sort == "Ascending" ?
                                    ProcessList.OrderBy(p => p.IsActive).ToList() :
                                    ProcessList.OrderByDescending(p => p.IsActive).ToList();
                            }
                            break;
                        case 4:
                            if (Sort != "None")
                            {
                                ProcessList = Sort == "Ascending" ?
                                    ProcessList.OrderBy(p => p.Cpu).ToList() :
                                    ProcessList.OrderByDescending(p => p.Cpu).ToList();
                            }
                            break;
                        case 5:
                            if (Sort != "None")
                            {
                                ProcessList = Sort == "Ascending" ?
                                    ProcessList.OrderBy(p => p.Memory).ToList() :
                                    ProcessList.OrderByDescending(p => p.Memory).ToList();
                            }
                            break;
                        case 6:
                            if (Sort != "None")
                            {
                                ProcessList = Sort == "Ascending" ?
                                    ProcessList.OrderBy(p => p.Thread).ToList() :
                                    ProcessList.OrderByDescending(p => p.Thread).ToList();
                            }
                            break;
                        case 7:
                            if (Sort != "None")
                            {
                                ProcessList = Sort == "Ascending" ?
                                    ProcessList.OrderBy(p => p.Username).ToList() :
                                    ProcessList.OrderByDescending(p => p.Username).ToList();
                            }
                            break;
                        case 8:
                            if (Sort != "None")
                            {
                                ProcessList = Sort == "Ascending" ?
                                    ProcessList.OrderBy(p => p.FilePath).ToList() :
                                    ProcessList.OrderByDescending(p => p.FilePath).ToList();
                            }
                            break;
                        case 9:
                            if (Sort != "None")
                            {
                                ProcessList = Sort == "Ascending" ?
                                    ProcessList.OrderBy(p => p.StartTime).ToList() :
                                    ProcessList.OrderByDescending(p => p.StartTime).ToList();
                            }
                            break;
                    }
                }
            });
        }

        public void Remove(int id)
        {
            lock (_lock)
            {
                var p = ProcessList.Find(process => process.Id == id);
                if (p == null) return;
                p.Kill();
                ProcessList.Remove(p);
            }
        }

        public void OpenFolder(int id)
        {
            lock (_lock)
            {
                var p = ProcessList.Find(process => process.Id == id);
                if (p != null)
                {
                    Process.Start("explorer.exe", "/select, " + p.FilePath);
                }
            }
        }

        private bool _disposed;
        public void Dispose()
        {
            if (_disposed) return;
            foreach (var runningProcess in ProcessList)
            {
                runningProcess.Dispose();
            }

            _disposed = true;
        }
    }
}
