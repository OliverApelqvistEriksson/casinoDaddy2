using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casinoDaddy2
{
    internal class randomOutput
    {
        private Random random = new Random();
        public int randomNumber(int amount)
        {
            int randomTal = random.Next(1, amount);
            return randomTal;
        }
    }
}
