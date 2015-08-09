using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Game
{
    public class Game
    {

        public int CounterC { get; set; }
        public int CounterP { get; set; }

        private Random rn = new Random();

        public int CreatePlayerNumbers()
        {
            
            return rn.Next(1,6);

        }
        public int CreateComputerNumbers()
        {
            return rn.Next(1, 6);

        }


    }
}
