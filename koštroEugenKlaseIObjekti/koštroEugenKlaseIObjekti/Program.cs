using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koštroEugenKlaseIObjekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla();
            Kvadar y = new Kvadar();
            Kocka z = new Kocka();
            Console.WriteLine(GeometrijskoTijelo.BrojacTijela);
            Console.ReadKey();
        }
    }
}
