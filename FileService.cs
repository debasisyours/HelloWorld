using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace FileWatcherService
{
    public partial class FileService : ServiceBase
    {
        public FileService()
        {
            InitializeComponent();
            ServiceBase[] servicesToRun = new ServiceBase[]{new FileService()};
            ServiceBase.Run(servicesToRun);
        }

        protected override void OnStart(string[] args)
        {
            EventLog.WriteEntry("FileWatcher started", EventLogEntryType.Information);
        }

        protected override void OnStop()
        {
            EventLog.WriteEntry("FileWatcher stopped", EventLogEntryType.Information);
        }
    }
}
