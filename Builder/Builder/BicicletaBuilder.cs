using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class BicicletaBuilder : VeiculoBuilder
    {
        public BicicletaBuilder()
        {
            veiculo = new Veiculo("Bicicleta");
        }
        public override void BuildFrame()
        {
            veiculo["frame"] = "Bicicleta Frame";
        }
        public override void BuildMotor()
        {
            veiculo["motor"] = "canelinha cc";
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
