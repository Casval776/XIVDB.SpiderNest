using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SpiderNest
{
    public partial class SpiderService : ServiceBase
    {
        public SpiderService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            //Start the SpiderNest object
            SpiderNest nest = SpiderNest.Instance;
        }

        protected override void OnStop()
        {
        }
    }
}
