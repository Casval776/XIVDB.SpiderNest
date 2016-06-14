using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XIVDB;
using XIVDB.Enums;

namespace SpiderNest
{
    public class Spider
    {
        #region Private Variables
        private XIVDBClient apiClient;
        private bool IsRunning;
        #endregion

        /// <summary>
        /// Static Constructor to initialize class level variables
        /// for static Spider
        /// </summary>
        public Spider()
        {
            //SearchList = new List<SearchType> { SearchType.recipes };
            apiClient = XIVDBClient.Instance;
            IsRunning = false;
        }

        /// <summary>
        /// Starts the Spider's crawling
        /// </summary>
        public void Start()
        {
            //Start the working method of the Spider
            IsRunning = true;
            //WorkThread.Start();
        }

        /// <summary>
        /// Stops the Spider's crawling
        /// </summary>
        public void Stop()
        {
            IsRunning = false;
        }
    }
}

