using System;

namespace CS8Null
{

    class Program
    {
        public static void Main(string[] args)
        {

            Message msg = new Message
            {
                Text = null!,
                From = null

            };

            Console.WriteLine(msg.Text);

            // Use of Null Coalescing operator 
            //  Console.WriteLine(msg.From ?? "no from");

            MessagePopulator.Populate(msg);
            Console.WriteLine(msg.From);
            Console.WriteLine(msg.From!.Length);
            Console.WriteLine(msg.ToUpperFrom());

            Console.WriteLine("Press Enter to end.");
            Console.ReadLine();

        }
    }
}
