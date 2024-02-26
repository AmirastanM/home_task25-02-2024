using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Practice_22_02_2024
{
    internal class Animal
    {
        public int id;
        public string name;
        public Animal(string text)
        {
            Console.WriteLine(text);
        }

        public void Sound()
        {
            Console.WriteLine("Animal sound");
        }
    }
}
