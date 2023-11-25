
using Bai_lam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thuvien;

namespace thuvienrandom
{
    internal class sachrandom
    {

        private Random random;

        public sachrandom()
        {
            random = new Random();
        }
        public Iquanly Creatsach()
        {
            int so = random.Next(1, 2);
            Console.WriteLine(" so random la " + so);
            switch (so)
            {
                case 1:
                    return new xahoi();
                case 2:
                    return new tunhien();
                default:
                    return null;
            }
        }
    }


}


