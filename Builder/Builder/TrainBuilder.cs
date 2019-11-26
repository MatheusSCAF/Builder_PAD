using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class TrainBuilder : VeiculoBuilder
    {
        public TrainBuilder ()
        {
            veiculo = new Veiculo("Trem");
        }

        public override void BuildFrame()
        {
            veiculo["frame"] = "Trem Frame";
        }

        public override void BuildMotor()
        {
            veiculo["motor"] = "3200cc";
        }

        public override void BuildPortas()
        {
            veiculo["portas"] = "16";
        }

        public override void BuildRodas()
        {
            veiculo["rodas"] = "128";
        }
    }
}
