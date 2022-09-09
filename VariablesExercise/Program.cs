using System;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string catName = "Nala";
            int catAge = 7;
            char Excited = '!';
            bool isCat = true;
            double Weight = 7.8;
            decimal numberOfToys = 22.8m;

            Console.WriteLine($"My cat's name is {catName}. She is {catAge} years old and weighs {Weight} pounds.  " +
                $"She has {numberOfToys} toys as some are broken{Excited}  True or False Do you like cats? {isCat}");

        }
    }
}
