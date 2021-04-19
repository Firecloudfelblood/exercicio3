using System;
using System.Collections.Generic;
using System.Linq;

namespace exercicio3
{
    public class ClassB : ClassA, Interfaces
    {
        //public ClassB()
        //{
        //}
        public void compare() => Console.WriteLine(CompareStringLength("Hola", "Hello"));
        public void Imetodo() => Console.WriteLine("Hello Interface");
        public List<string> orderListBy(List<string> lista, char direccion = 'a')
        {
            if(direccion.ToString().ToLower().Equals("a")){
            lista.OrderBy(i => i);
            }
            else if (direccion.ToString().ToLower().Equals("d"))
            {
                lista.Sort();
            }
            

            return lista;
        }

        public List<string> filtrar(List<string> lista) => lista.FindAll(x => x != " ");

        public List<int> quitarRepetidos(List<int> lista) => lista.Distinct().ToList();
    }
}
