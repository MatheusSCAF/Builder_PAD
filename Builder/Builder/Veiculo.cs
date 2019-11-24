using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// The 'product' class
/// </summary>
namespace Builder
{
    class Veiculo
    {
        private string _tipoVeiculo;
        private Dictionary<string, string> _partes = new Dictionary<string, string>();

        //Construtor 
        public Veiculo(string tipoVeiculo)
        {
            this._tipoVeiculo = tipoVeiculo;
        }
        //Indexador
        public string this[string key]
        {
            get { return _partes[key]; }
            set { _partes[key] = value; }
        }
        public void Printar()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", _tipoVeiculo);
            Console.WriteLine(" #Frame : {0}", _partes["frame"]);
            Console.WriteLine(" #Motor : {0}", _partes["motor"]);
            Console.WriteLine(" #Rodas: {0}", _partes["rodas"]);
            Console.WriteLine(" #Portas : {0}", _partes["portas"]);
        }

    }
}
