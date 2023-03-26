using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePoint
{
    class Door
    {
        private string Passcode { get; set; }
        public Enums.DoorState State { get; private set; } = Enums.DoorState.Locked;

        public Door(string passcode)
        {
            Passcode = passcode;
        }

        private bool IsPasscodeCorrect(string passcode) => Passcode == passcode;

        public void SetNewPasscode()
        {
            Console.WriteLine("Enter current passcode: ");
            string? currentPasscode = Console.ReadLine();
            if (currentPasscode == null)
            {
                Console.WriteLine("Incorrect passcode");
            }
            else
            {
                if (IsPasscodeCorrect(currentPasscode))
                {
                    Console.WriteLine("Enter new passcode: ");
                    string? newPasscode = Console.ReadLine();
                    if (newPasscode == null)
                    {
                        Console.WriteLine("Invalid new passcode");
                    }
                    else
                    {
                        Passcode = newPasscode;
                        Console.WriteLine("Passcode changed!");
                    }
                }
                else
                {
                    Console.WriteLine("Passcode is incorrect");
                }
            }
        }


        public void SetDoorState()
        {
            while (true)
            {
                Console.WriteLine($"Door is currently {State}");
                Console.Write($"What do you want to do? (Unlock, Lock, Close, Open) or exit: ");
                string? action = Console.ReadLine();

                switch (action?.ToLower())
                {
                    case null:
                        goto default;
                    case "exit":
                        return;
                    case "unlock":
                        if (State == Enums.DoorState.Locked)
                        {
                            Console.WriteLine("Please enter passcode: ");
                            string? passcode = Console.ReadLine();
                            if (passcode != null && IsPasscodeCorrect(passcode))
                            {
                                State = Enums.DoorState.Closed;
                            }
                            else
                            {
                                Console.WriteLine("Passcode is incorrect");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Door first needs to be Locked to perform this action");
                        }
                        break;
                    case "lock":
                        if (State == Enums.DoorState.Closed)
                        {
                            State = Enums.DoorState.Locked;
                        }
                        else
                        {
                            Console.WriteLine("Door first needs to be Closed to perform this action");
                        }
                        break;
                    case "close":

                        if (State == Enums.DoorState.Open)
                        {
                            State = Enums.DoorState.Closed;
                        }
                        else
                        {
                            Console.WriteLine("Door first needs to be Open to perform this action");
                        }
                        break;
                    case "open":

                        if (State == Enums.DoorState.Closed)
                        {
                            State = Enums.DoorState.Open;
                        }
                        else
                        {
                            Console.WriteLine("Door first needs to be Closed to perform this action");
                        }
                        break;
                    default:
                        Console.WriteLine("Unable to determine the action.");
                        break;
                }
            }

        }
    }
}
