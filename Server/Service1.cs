using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public partial class TCPService : ServiceBase
    {
        public TCPService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //Start TCP Listener
        }

        protected override void OnStop()
        {
            //Stop TCP Listener
        }
    }
}
