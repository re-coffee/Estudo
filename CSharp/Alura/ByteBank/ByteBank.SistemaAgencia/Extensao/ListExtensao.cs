using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public static class ListExtensao
    {
        public static void AdicionarVarios<T>(this List<T> itens, params T[] valores)
        {
            foreach(T item in valores)
            {
                itens.Add(item);
            }
        }
        public static void EscreverNaTela<T>(this List<T> itens)
        {
            foreach(T item in itens)
            {
                Console.WriteLine(item);
            }
        }
        public static void TesteVariavel<T>(this string texto) { }
        public static int SomaTudo(this int[] numero)
        {
            int soma = 0;
            foreach (int item in numero)
            {
                soma += item;
            }
            return soma;
        }
        public static void EscreverNaTela<T>(this IOrderedEnumerable<T> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
