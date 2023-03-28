namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the name of Player One: ");
            string playerOneName = Console.ReadLine() ?? "Player One";
            Console.Write("Choose a symbol for Player One (X or O): ");
            string playerOneSymbol = Console.ReadLine() ?? "X";
            playerOneSymbol = playerOneSymbol == "" ? "X" : playerOneSymbol;

            Console.Write("Enter the name of Player Two: ");
            string playerTwoName = Console.ReadLine() ?? "Player Two";
            string playerTwoSymbol = playerOneSymbol == "X" ? "O" : "X";

            Player pl1 = new(name: playerOneName == "" ? "Player One" : playerOneName, symbol: playerOneSymbol);
            Player pl2 = new(name: playerTwoName == "" ? "Player Two" : playerTwoName, symbol: playerTwoSymbol);

            Square[,] squares = new Square[3,3];
            for(int row = 0; row < 3; row++)
            {
                for(int column = 0; column < 3; column++)
                {
                    squares[row, column] = new(row, column);
                }
            }
            Console.Clear();
            Board board = new(currentPlayer: pl1, squares: squares);
            while (!board.IsFinished)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine();
                Console.WriteLine($"It is {board.CurrentPlayer.Symbol}'s turn");
                board.PrintBoard();
                Console.WriteLine();
                Console.WriteLine("What square do you want to play in? Enter the number:");
                Console.WriteLine(" 1 | 2 | 3 ");
                Console.WriteLine("---+---+---");
                Console.WriteLine(" 4 | 5 | 6 ");
                Console.WriteLine("---+---+---");
                Console.WriteLine(" 7 | 8 | 9 ");

                string? chosenNumber = Console.ReadLine();
                if(chosenNumber == null)
                {
                    continue;
                }

                int row = -1;
                int column = -1;
                switch (chosenNumber)
                {
                    case "1":
                        row = 0;
                        column = 0;
                        break;
                    case "2":
                        row = 0;
                        column = 1;
                        break;
                    case "3":
                        row = 0;
                        column = 2;
                        break;
                    case "4":
                        row = 1;
                        column = 0;
                        break;
                    case "5":
                        row = 1;
                        column = 1;
                        break;
                    case "6":
                        row = 1;
                        column = 2;
                        break;
                    case "7":
                        row = 2;
                        column = 0;
                        break;
                    case "8":
                        row = 2;
                        column = 1;
                        break;
                    case "9":
                        row = 2;
                        column = 2;
                        break;
                    default:
                        break;
                }
                if(row == -1 || column == -1)
                {
                    continue;
                }
                else
                {
                    if(board.SetSquareValue(row, column))
                    {
                        board.IsThereWinner();
                        if (!board.IsFinished)
                        {
                            board.CurrentPlayer = pl1.Symbol == board.CurrentPlayer.Symbol ? pl2 : pl1;
                        }
                        
                    }
                }

            }
            Console.Clear();
            board.PrintBoard();
            if (board.IsWinner)
            {
                Console.WriteLine($"Player: {board.CurrentPlayer.Name} with Symbol: {board.CurrentPlayer.Symbol} is the Winner!");
            }
            else
            {
                Console.WriteLine("No Winner! It's a Draw!");
            }
        }
    }
}