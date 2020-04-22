using System;
using System.Diagnostics;
using System.Security.Principal;

namespace ProcessManager.Models
{
    public class Processes
    {
        public readonly Process Process;
        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public double Memory { get; set; }
        public int Thread { get; set; }
        public string Username { get; set; }
        public string FilePath { get; set; }
        public DateTime StartTime { get; set; }
        public double Cpu { get; set; }
        public ProcessModuleCollection Modules { get; set; }
        public ProcessThreadCollection Threads { get; set; }


        private DateTime _cpuStartTime;
        private TimeSpan _cpuStartUsage;
        public Processes(Process process)
        {
            Process = process;
            _cpuStartTime = DateTime.UtcNow;
            _cpuStartUsage = process.TotalProcessorTime;
            GetData();
        }

        public void GetData()
        {
            Process.Refresh();
            Username = WindowsIdentity.GetCurrent().Name;
            FilePath = Process.MainModule?.FileName;
            Threads = Process.Threads;
            Id = Process.Id;
            Name = Process.ProcessName;
            StartTime = Process.StartTime;
            Memory = Process.WorkingSet64 / 1024.0 / 1024;
            IsActive = Process.Responding;
            Thread = Threads.Count;
            Modules = Process.Modules;
            Cpu = CpuCalculate();
        }

        private double CpuCalculate()
        {
            var endTime = DateTime.UtcNow;
            var endUsage = Process.TotalProcessorTime;
            var usesedMs = (endUsage - _cpuStartUsage).TotalMilliseconds;
            var passed = (endTime - _cpuStartTime).TotalMilliseconds;
            var totalUsage = usesedMs / (Environment.ProcessorCount * passed);

            _cpuStartTime = endTime;
            _cpuStartUsage = endUsage;

            return totalUsage * 100;
        }


        public void Kill()
        {
            Process.Kill();
            Process.WaitForExit();
            Dispose();
        }

        private bool _disposed;
        public void Dispose()
        {
            if (_disposed) return;
            Process.Close();
            _disposed = true;
        }
    }
}
