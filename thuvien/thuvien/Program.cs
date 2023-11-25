
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using thuvien;
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
            sach s = new sach();
            Iquanly q = s.Creatsach(2);
            Iquanly ql = s.Creatsach(1);
            ql.loaisach();
            q.loaisach();
           
            sachrandom r = new sachrandom();
            Iquanly iq = r.Creatsach();
            iq.loaisach();
            Console.ReadKey();
        }
    }
}

