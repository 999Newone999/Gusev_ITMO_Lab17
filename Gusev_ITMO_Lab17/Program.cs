using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab17
{
    class Program
    {
        static void Main(string[] args)
        {
            Accaunt <int> johnDeerAccaunt = new Accaunt<int>();
            Accaunt<string> fordAccaunt = new Accaunt<string>();
            Accaunt<decimal> jiguliAccaunt = new Accaunt<decimal>();

            johnDeerAccaunt.AccauntNumber = 10;
            johnDeerAccaunt.AccauntBalance = 10000;
            johnDeerAccaunt.UserName = "Джон Дир";

            fordAccaunt.AccauntNumber = "51";
            fordAccaunt.AccauntBalance = 15000;
            fordAccaunt.UserName = "Генри Форд";

            jiguliAccaunt.AccauntNumber = (decimal)10.002;
            jiguliAccaunt.AccauntBalance = (decimal)1.05;
            jiguliAccaunt.UserName = "Дядя Вася";

            Console.Write(johnDeerAccaunt.UserName);
            Console.Write("  ");
            Console.Write(johnDeerAccaunt.AccauntNumber);
            Console.Write("  ");
            Console.Write(johnDeerAccaunt.AccauntBalance);
            Console.WriteLine();


            Console.Write(fordAccaunt.UserName);
            Console.Write("  ");
            Console.Write(fordAccaunt.AccauntNumber);
            Console.Write("  ");
            Console.Write(fordAccaunt.AccauntBalance);
            Console.WriteLine();


            Console.Write(jiguliAccaunt.UserName);
            Console.Write("  ");
            Console.Write(jiguliAccaunt.AccauntNumber);
            Console.Write("  ");
            Console.Write(jiguliAccaunt.AccauntBalance);
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    class Accaunt <T>
    { 
        private T accauntNumber;
        private decimal accauntBalance;
        private string userName;

        public T AccauntNumber
        {
            get
            {
                return accauntNumber;
            }
            set
            {
                accauntNumber = value;
            }
        }

        public decimal AccauntBalance
        {
            get
            {
                return accauntBalance;
            }
            set
            {
                accauntBalance = value;
            }
        }

        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                userName = value;
            }
        }
    }
}
