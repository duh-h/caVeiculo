using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVeiculo
{
    public class Caminhao:Veiculo
    {
        int assentos {  get; set; }

        public Caminhao()
        {

        }
        public Caminhao(int assentos,string placa,int ano):base(placa,ano)
        {
            this.assentos = assentos;
        }

        public override double Alugar()
        {

            return (30 * assentos) - (DateTime.Now.Year - ano) * 70;
        }
    }
}
