using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoDatastructuresApp
{
    public class Worker
    {

        protected delegate int CalculateType(int x, int y);

        public void Run()
        {
            CalculateType Sum = (k, l) =>
            {
                Console.WriteLine("summen er " + (k + l));
                return k + l;
            };
           


            Console.WriteLine("Sum er " + Sum(7,9));


            Sum += Gange;
            Console.WriteLine("med gange " + Sum(7, 9));
            Sum -= Gange;

        }


        public int Gange(int i, int j)
        {
            return i * j;
        }
     

    }
}
