using System;
using  C = System.Console;

namespace _1_NumeroMayor
{
    class Program
    {
        /// Practica 1
        /// 1.- Encontrar el mayor de dos números.

        /// Chávez Pérez Melissa
        /// #M21210035


        static void Main(string[] args)
        {
            C.BackgroundColor = ConsoleColor.Blue;
            C.ForegroundColor = ConsoleColor.White;

            int cant, num, mayor = 0, menor = 0;
          
            C.Write("\nFavor de Ingresar cuantos numeros desea comparar ");
            cant = int.Parse(C.ReadLine());
            for (int i=0; i<cant;i++)
            {
                C.WriteLine("Escriba un numero ");
                num = int.Parse(C.ReadLine());

                if (i == 0)
                {
                    mayor = num;
                    menor = num;
                }
                else if (i != 0)
                {
                    if (num < menor)
                    {
                        menor = num;
                    }
                    if (num > mayor)
                    {
                        mayor = num;
                    }

                }
            }
            C.WriteLine("El numero mayor es " + mayor);
            C.WriteLine("El numero menor es " + menor);
            Console.ReadKey();
        }
    }
}
