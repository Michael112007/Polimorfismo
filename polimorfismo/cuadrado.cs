using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismo
{
    public class cuadrado:FiguraGeometrica
    {
        public double ladoA {  get; set; }  
        public double ladoB { get; set;}

        public override double calcularArea()
        {
            return ladoA * ladoB;
        }
        public override double calcularPerimetro()
        {
            return 2*ladoA*ladoB;
        }
    }
}
