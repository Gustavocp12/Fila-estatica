using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilaEstatica
{
    class Fila
    {
        string[] valores;
        int inicio, fim, limite;
        
        //Construtor tem que ter o mesmo nome da classe e não retorna com o "void"
        public Fila(int Tamanho)
        {
            valores = new string[Tamanho];
            inicio = -1;
            fim = -1;
            limite = Tamanho;
        }

        //Criando o método para inserir valores na Fila
        public void Enfileirar(string Valor)
        {
            
            if(inicio == -1)
            {

                inicio++;
                valores[inicio] = Valor;
                fim++;

            }
            else
            {
                if (fim < (limite-1))
                {

                    fim++;
                    valores[fim] = Valor;

                }
                else
                {

                    Console.WriteLine("Fila Cheia!");

                }

            }
            
        }

        public void Desenfileirar()
        {

            if (inicio <= fim)
            {

                valores[inicio] = "";
                inicio++;

            }
            else
            {

                Console.WriteLine("Fila vazia!");

            }

        }

        public void Imprimir()
        {
            if (inicio < fim)
            {

                for (int i = inicio; i <= fim; i++)
                {

                    Console.WriteLine(valores[i]);

                }

            }
            else
            {

                Console.WriteLine("Fila vazia!");

            }

        }

    }
}
