using System;

namespace TicTacToe
{
    class Program
    {
        static void Main()
        {
            Game game = new Game();
            game.Start();
        }
    }

    class Game
    {
        private Player[] players;
        private GameBoard board;

        public Game()
        {
            players = new Player[2];
            players[0] = new Player("Mike", Marker.X);
            players[1] = new Player("CPU", Marker.O);
            board = new GameBoard();
        }

        public void Start()
        {
            int currentPlayerIndex = 0;

            Console.WriteLine("Welcome to Tic-Tac-Toe!");

            while (true)
            {
                Player currentPlayer = players[currentPlayerIndex];

                board.Display();

                Console.WriteLine($"{currentPlayer.Name}'s turn ({currentPlayer.Marker})");
                int position = GetPositionFromPlayer();

                if (board.IsPositionAvailable(position))
                {
                    board.PlaceMarker(position, currentPlayer.Marker);

                    if (board.CheckForWin(currentPlayer.Marker))
                    {
                        board.Display();
                        Console.WriteLine($"{currentPlayer.Name} wins!");
                        break;
                    }
                    else if (board.IsBoardFull())
                    {
                        board.Display();
                        Console.WriteLine("It's a draw!");
                        break;
                    }

                    currentPlayerIndex = (currentPlayerIndex + 1) % 2; // Switch players
                }
                else
                {
                    Console.WriteLine("That position is already taken. Please try again.");
                }
            }
        }

        private int GetPositionFromPlayer()
        {
            int position;
            while (true)
            {
                Console.Write("Enter position (1-9): ");
                if (int.TryParse(Console.ReadLine(), out position) && position >= 1 && position <= 9)
                {
                    return position;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                }
            }
        }
    }

    class GameBoard
    {
        private Marker?[] cells;

        public GameBoard()
        {
            cells = new Marker?[9];
        }

        public void Display()
        {
            Console.WriteLine($"|{GetMarker(0)}||{GetMarker(1)}||{GetMarker(2)}|");
            Console.WriteLine($"|{GetMarker(3)}||{GetMarker(4)}||{GetMarker(5)}|");
            Console.WriteLine($"|{GetMarker(6)}||{GetMarker(7)}||{GetMarker(8)}|");
        }

        public void PlaceMarker(int position, Marker marker)
        {
            cells[position - 1] = marker;
        }

        public bool IsPositionAvailable(int position)
        {
            return cells[position - 1] == null;
        }

        public bool CheckForWin(Marker marker)
        {
          // Check rows
    if ((cells[0] == marker && cells[1] == marker && cells[2] == marker) ||
        (cells[3] == marker && cells[4] == marker && cells[5] == marker) ||
        (cells[6] == marker && cells[7] == marker && cells[8] == marker))
    {
        return true;
    }

    // Check columns
    if ((cells[0] == marker && cells[3] == marker && cells[6] == marker) ||
        (cells[1] == marker && cells[4] == marker && cells[7] == marker) ||
        (cells[2] == marker && cells[5] == marker && cells[8] == marker))
    {
        return true;
    }

    // Check diagonals
    if ((cells[0] == marker && cells[4] == marker && cells[8] == marker) ||
        (cells[2] == marker && cells[4] == marker && cells[6] == marker))
    {
        return true;
    }

    return false;
        }

        public bool IsBoardFull()
        {
            foreach (var cell in cells)
            {
                if (cell == null)
                    return false;
            }
            return true;
        }

        private string GetMarker(int index)
        {
            return cells[index]?.ToString() ?? " ";
        }
    }

    class Player
    {
        public string Name { get; }
        public Marker Marker { get; }

        public Player(string name, Marker marker)
        {
            Name = name;
            Marker = marker;
        }
    }

    enum Marker
    {
        X, O
    }
}
