using System;
namespace hoppa
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hej Elin! Hur långt hoppade du i meter på längdhoppstävlingen igår?");
            float längd1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Aaah! Nice. Kommer du ihåg hur långt Alma hoppade också?");
            float längd2 = float.Parse(Console.ReadLine());
            float minus = längd1 - längd2;
            Console.WriteLine("Ok! Så du hoppade " + minus + " meter längre än Alma. bra");
        }

    }


}