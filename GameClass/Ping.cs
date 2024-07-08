using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameClass
{
    public class Ping(Pong? pong = null)
    {
        private static Random random = new Random();
        public int Point { get; set; }


        public void setPong() => pong = new Pong(this);
        public bool move()
        {
            if (random.Next(1, 100) <= 20)
            {
                pong.Point++;
                return false;
            }

            Point++;
            Console.WriteLine("Ping received Pong");
            return true;
        }
    }
}
