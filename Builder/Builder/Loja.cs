using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Loja
    {
        public void Construtor(VeiculoBuilder veiculoBuilder)
        {
            veiculoBuilder.BuildFrame();
            veiculoBuilder.BuildMotor();
            veiculoBuilder.BuildRodas();
            veiculoBuilder.BuildPortas();
        }
    }
}
