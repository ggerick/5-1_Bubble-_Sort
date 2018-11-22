using System;

namespace BubbleSort
{
    public class BubbleSort
    {
        int[] arreglo;
        int tam = 0, temp = 0;
        public void Captura()//Captura del tamaño del arreglo y de los datos
        {
            Console.WriteLine("Inserta el tamaño del arreglo: ");//Entrada del tamaño del array
            tam = int.Parse(Console.ReadLine());
            arreglo = new int[tam];

            for (int i = 0; i < tam; i++)
            {
                Console.WriteLine("Inserta el valor {0} del arreglo: ", i + 1);//Entrada de datos de los n numeros
                arreglo[i] = int.Parse(Console.ReadLine());
            }
            Ordernamiento();//Llamada al metodo para ordenar el arreglo
        }

        public void Ordernamiento()
        {
            for (int i = 0; i < arreglo.Length; i++)//Ciclo for que va desde el primer elemento hasta el ultimo
            {
                for (int j = 0; j < arreglo.Length -1; j++)//Otro ciclo for para poder ir comparando uno con otro
                {
                    if(arreglo[j] > arreglo[j + 1])//La comparacion del "primer" elemento con el siguiente
                    {
                        temp = arreglo[j]; //La variable temporal toma el valor de la posicion j ya que es el mas grande
                        arreglo[j] = arreglo[j + 1]; //El numero de la posicion actual se iguala por el de la siguiente posicion
                        arreglo[j + 1] = temp; // El valor de la siguiente posicion se iguala al valor que teniamos almacenado en temporal
                    }

                }
            }
            Console.Clear();
            Console.WriteLine("Los valores ordenados son: ");
            foreach (var item in arreglo)//Un foreach para imprimir todos los elementos del arreglo
            {
                Console.Write(item + " ");//Imprime el elemento con un espacio despues del numero
            }
        }
        
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            BubbleSort burbuja = new BubbleSort();//Instanciacion de la clase
            burbuja.Captura();  //Llamada del metodo
            Console.ReadKey();
        }
    }
}
