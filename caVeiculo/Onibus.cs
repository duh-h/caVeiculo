using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVeiculo
{
    public class Onibus:Veiculo
    {
        private int eixos { get; set; }

        public Onibus()
        {

        }
        public Onibus(int eixos, string placa, int ano):base(placa,ano)
        {
            this.eixos = eixos;
        }

        public override double Alugar()
        {
            return (300 * eixos) - (DateTime.Now.Year - ano) * 50;
        }
    }
}
