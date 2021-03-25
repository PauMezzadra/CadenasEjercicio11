using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CadenasEjercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadenaConTildes = "";

            do
            {
                Console.WriteLine("Ingrese una palabra o frase que contenga tildes");
                cadenaConTildes = Console.ReadLine();
                if (cadenaConTildes == "")
                {
                    Console.WriteLine("No puede ser vacío");
                }
                else
                {
                    Regex reg = new Regex("[^a-zA-Z0-9 ]");
                    string textoNormalizado = cadenaConTildes.Normalize(NormalizationForm.FormD);
                    string textoSinAcentos = reg.Replace(textoNormalizado, "");
                    Console.WriteLine($"El texto sin tildes es: {textoSinAcentos}");
                }

            } while (cadenaConTildes == "");

            Console.ReadKey();
        }


    }
}
