
using System;
using HumanProject.Models;

namespace HumanProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Dave = new Human("Dave");
            Human Bob = new Human("Bob");
            Human Steve = new Human("Steve");

            Wizard Izac = new Wizard("Izac");
            Ninja Collin = new Ninja("Collin");
            Samurai Zach = new Samurai("Zach");

            Izac.Attack(Dave);
            Collin.Attack(Bob);
            for (int i = 0; i < 6; i++)
            {
                Zach.Attack(Steve);
            }

            Izac.FirstAid(Dave);
            Collin.Takes(Bob);
            Collin.Attack(Zach);
            Zach.Meditate();
        }

    }
}