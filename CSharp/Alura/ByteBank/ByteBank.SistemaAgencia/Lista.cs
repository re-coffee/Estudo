using ByteBank.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class Lista<T>
    {
        public T[] arrayT;
        private int _proximaPosicao;

        public Lista(int tamanhoInicial = 5)
        {
            _proximaPosicao = 0;
            arrayT = new T[tamanhoInicial];
        }

        public void Adicionar(T conta)
        {
            if (_proximaPosicao == arrayT.Length)
            {
                AjustarTamanho();
            }
            arrayT[_proximaPosicao] = conta;
            _proximaPosicao++;

        }

        public void AdicionarVarios(params T[] contas)
        {
            foreach(T conta in contas)
            {
                Adicionar(conta);
            }

        }

        private void AjustarTamanho()
        {
            Console.WriteLine("Ajustando tamanho\nContando: ");
            T[] novoArray = new T[arrayT.Length * 2];

            for (int i = 0; i < _proximaPosicao; i++)
            {
                Console.Write($"{i}. ");
                novoArray[i] = arrayT[i];
            }
            Console.Write("\n\n");
            arrayT = novoArray;

        }
        public void ExcluirItem(T conta)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                T itemAtual = arrayT[i];
                if (itemAtual.Equals(conta))
                {
                    indiceItem = i;
                    break;
                }
            }
            for (int i = indiceItem; i < _proximaPosicao-1; i++)
                arrayT[i] = arrayT[i + 1];
            _proximaPosicao--;
            //arrayT[_proximaPosicao] = null;
        }
        public void ExibirLista()
        {
            for(int i = 0; i < _proximaPosicao; i++)
            {
                Console.WriteLine($"{arrayT[i]}\n");
            }
        }

        public T GetItemPorIndice(int indice)
        {
            if(indice <= 0 && indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }
            return arrayT[indice];
        }

        public T this[int indice]
        {
            get
            {
                return GetItemPorIndice(indice);
            }
        }

    }
}

