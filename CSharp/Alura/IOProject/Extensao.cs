using IOProject.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOProject
{
    public static class Extensao
    {
        public static void EscreverNaTela<T>(this T[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item}-");
            }
        }
        public static void EscreverNaTela(this string generico)
        {
            Console.Write(generico);
        }
        public static void EscreverNaTela(this List<ContaCorrente> listaConta)
        {
            foreach (var item in listaConta)
            {
                Console.WriteLine(item.ToString()); 
            }
        }
    }
}
