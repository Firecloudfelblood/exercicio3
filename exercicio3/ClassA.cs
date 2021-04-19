using System;
using System.Collections.Generic;

namespace exercicio3
{
    public class ClassA
    {
        //public ClassA()
        //{
        //}

        public bool CompareStringLength(string a, string b) =>  a.Length == b.Length? true : false;
        public bool CompareListsSize<T>(List<T> l1, List<T> l2) => l1.Count == l2.Count ? true : false;
    }
}
