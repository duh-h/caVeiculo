using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caVeiculo
{
    public abstract class Veiculo
    {
        protected string placa { get; set; }
        
        protected int ano {get; set; }
        public Veiculo()
        {

        }
        public Veiculo(string placa, int ano)
        {
            this.placa = placa;
            this.ano = ano;
        }


        public virtual double Alugar()
        {
            return 0.0;

        }
    }
}
