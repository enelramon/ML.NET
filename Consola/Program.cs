using MyMLAppML.Model;
using System;

namespace myMLApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var input = new ModelInput();
            input.SentimentText = Console.ReadLine();

            var output = ConsumeModel.Predict(input);

            Console.WriteLine($"Es negativo? {output.Prediction}");

        }
    }
}
