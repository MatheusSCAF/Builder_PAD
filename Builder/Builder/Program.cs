using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VeiculoBuilder builder;
            //Criando a loja para o veiculoBuilder
            Loja loja = new Loja();
            //Veiculos e tipos

            //Avião
            builder = new AviaoBuilder();
            loja.Construtor(builder);
            builder.Veiculo.Printar();

            //Bicicleta
            builder = new BicicletaBuilder();
            loja.Construtor(builder);
            builder.Veiculo.Printar();

            //Trem
            builder = new TrainBuilder();
            loja.Construtor(builder);
            builder.Veiculo.Printar();

            //JetSki
        }
    }
}
