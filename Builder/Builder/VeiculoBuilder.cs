using System;
using System.Collections.Generic;
using System.Text;
 /// <summary>
 /// 'Builder' class 
 /// </summary>
namespace Builder
{
    abstract class VeiculoBuilder
    {
        protected Veiculo veiculo;

        //Instancia do veiculo
        public Veiculo Veiculo
        {
            get { return veiculo;}
        }
        //Método Abstrato Build
        public abstract void BuildFrame();
        public abstract void BuildMotor();
        public abstract void BuildRodas();
        public abstract void BuildPortas();
    }

}
