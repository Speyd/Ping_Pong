using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClass
{
    public class Pong(Ping? ping = null)
    {
        private static Random random = new Random();
        public int Point { get; set; }

        public void setPing() => ping = new Ping(this);
        public bool move()
        {
            if (random.Next(1, 100) <= 20)
            {
                ping.Point++;
                return false;
            }

            Point++;
            Console.WriteLine("Pong received Ping");
            return true;
        }
    }
}
