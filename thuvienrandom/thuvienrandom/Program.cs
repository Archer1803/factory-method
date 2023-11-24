
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thuvienrandom;

namespace Bai_lam
{
    interface Iquanly
    {
        public void loaisach();
    }
    class thuvien
    {
        static void Main(string[] args)
        {
            sachrandom S = new sachrandom();
            Iquanly q = S.Creatsach();
            q.loaisach();
            Console.ReadKey();
        }
    }
}

