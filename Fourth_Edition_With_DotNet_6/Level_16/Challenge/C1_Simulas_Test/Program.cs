using System;

namespace C1_Simulas_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // The output text does not match exactly what is written in the book
            // but it should suffice

            State current = State.Locked;

            bool isLooping = true;
            while (isLooping)
            {
                Console.Write($"The chest is {current}. What do you want to do? ");
                string action = Console.ReadLine();
                switch (action)
                {
                    case "unlock":
                        if(current == State.Locked)
                            current = State.Closed;
                        break;
                    case "lock":
                        if(current == State.Closed)
                            current = State.Locked;
                        break;
                    case "close":
                        if(current == State.Open)
                            current = State.Closed;
                        break;
                    case "open":
                        if(current == State.Closed)
                            current= State.Open;
                        break;
                    case "exit":
                        isLooping = false;
                        break;
                    default:
                        break;
                }
            }
        }

        enum State { Open, Closed, Locked };
    }
}