using System;
using System.Collections.Generic;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
            List<int> intLista = new List<int>() {1,1,2,3,4,4,5,6,7,8,10};
            ClassB cb = new ClassB();
            Console.WriteLine("Corriendo metodo B");
            cb.compare();
            cb.Imetodo();
            cb.orderListBy(lista, 'd');
            lista = cb.filtrar(lista);

            intLista = cb.quitarRepetidos(intLista);

            foreach(int num in intLista){
                Console.WriteLine(num);
            }
        }
    }
}
