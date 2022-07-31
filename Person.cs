using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.PracticeApp
{
    [Serializable]
    public class Person
    {
        private string? Name;

        private int? Age;

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
