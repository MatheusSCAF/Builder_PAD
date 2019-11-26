using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class MotoBuilder : VeiculoBuilder
    {
        public MotoBuilder()
        {
            veiculo = new Veiculo("Moto");
        }
        public override void BuildFrame()
        {
            veiculo["frame"] = "Suzuki Hayabuza";
        }

        public override void BuildMotor()
        {
            veiculo["motor"] = "1400cc";
        }

        public override void BuildPortas()
        {
            veiculo["portas"] = "0";
        }

        public override void BuildRodas()
        {
            veiculo["rodas"] = "2";
        }
    }
}
