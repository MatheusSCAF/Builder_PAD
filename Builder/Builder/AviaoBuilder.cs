using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class AviaoBuilder : VeiculoBuilder
    {
        public AviaoBuilder()
        {
            veiculo = new Veiculo("Avião");
        }
        public override void BuildFrame()
        {
            veiculo["frame"] = "Avião Frame";
        }
        public override void BuildMotor()
        {
            veiculo["motor"] = "165K HP";
        }
        public override void BuildPortas()
        {
            veiculo["portas"] = "6";
        }
        public override void BuildRodas()
        {
            veiculo["rodas"] = "8";
        }
    }
}
