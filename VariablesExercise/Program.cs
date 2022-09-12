using System;

namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice
            string firstName = "Kaylie";
            int personAge = 35;
            char middleInitial = 'R';
            bool isMarried = true;
            double height = 67.2;
            decimal costofDress = 95.26m;

            Console.WriteLine($"My name is {firstName} and my middle initial is {middleInitial}.\nI am {height} inches tall." +
                $"My dress costs ${costofDress}.\nTrue or False - Am I married? {isMarried}");

            Console.WriteLine();
            Console.WriteLine();

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
