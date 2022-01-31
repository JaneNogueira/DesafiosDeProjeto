using System;
using JogoRPG.src.Entities;

namespace dotnet_poo
{
    class Program
    {
        static void Main(string[]args)
        {
            Arus hero = new Arus("Arus", 23, "Knight");
            Arus oponnet = new Arus("Maleficus", 99, "Devil");
            Arus wizard = new Arus("Jennica", 25, "White Wizard");
       
            Console.WriteLine(wizard.Attack());
            
        }
    }
}

