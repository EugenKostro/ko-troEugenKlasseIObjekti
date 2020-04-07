using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace koštroEugenKlaseIObjekti
{
    class GeometrijskoTijelo
    {
        double oplosje;
        double volumen;
        static int brojacTijela;

        public double Oplosje { get => oplosje; set => oplosje = value; }
        public double Volumen { get => volumen; set => volumen = value; }
        public static int BrojacTijela { get => brojacTijela; set => brojacTijela = value; }

        public GeometrijskoTijelo()
        {
            brojacTijela++;
        }
    }
}
