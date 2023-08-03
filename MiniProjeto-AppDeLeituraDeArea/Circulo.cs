using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjeto_AppDeLeituraDeArea
{
    internal class Circulo
    {
        public double raio;

        double pi = 3.14159;
        public double AreaCirculo ()
        {
            return pi * Math.Pow(raio, 2);
        }
    }
}
