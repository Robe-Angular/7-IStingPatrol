using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_IStingPatrol
{
    class Bee:IStingPatrol
    {
        private int alertLevel;
        private int stingerLength;
        public int AlertLevel
        {
            get
            {
                return alertLevel;
            }
        }
        public int StingerLength
        {
            get
            {
                return stingerLength;
            }
            set
            {
                stingerLength = value;
            }
        }
        public bool LookForEnemies()
        {
            return true;
        }

        public int SharpenStinger(int length)
        {
            return 0;
        }
    }
}
