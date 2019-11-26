using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class JetSkiBuilder: VeiculoBuilder
    {
        public JetSkiBuilder ()
        {
            veiculo = new Veiculo("JetSki");
        }

        public override void BuildFrame()
        {
            veiculo["frame"] = "Jetski Frame";
        }

        public override void BuildMotor()
        {
            veiculo["motor"] = "300cc";
        }

        public override void BuildPortas()
        {
            veiculo["portas"] = "0";
        }

        public override void BuildRodas()
        {
            veiculo["portas"] = "0";
        }
    }
}
