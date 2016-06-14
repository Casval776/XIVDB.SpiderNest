using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XIVDBQueueService;


namespace SpiderNest
{
    public class SpiderNest
    {
        private static readonly SpiderNest _instance = new SpiderNest();
        private static int SleepTime = TimeSpan.FromMinutes(5).Milliseconds;
        private static QueueServiceClient QueueClient = new QueueServiceClient();
        private static List<Thread> Spiders = new List<Thread>();

        private SpiderNest()
        {

        }

        static SpiderNest()
        {

        }

        public static SpiderNest Instance
        {
            get
            {
                return _instance;
            }
        }

        public static void Start()
        {
            //Pop item off the queue
            string workItem = QueueClient.Dequeue();

            //If item isn't empty, work on it
            if (workItem != string.Empty 
                && workItem != null)
            {
                Thread spiderling = new Thread(new ThreadStart(HatchSpider));
                Spiders.Add(spiderling);
                spiderling.Start();
            }
        }

        private static void HatchSpider()
        {
            Spider littleBoy = new Spider();
            littleBoy.Start();
        }
    }
}
