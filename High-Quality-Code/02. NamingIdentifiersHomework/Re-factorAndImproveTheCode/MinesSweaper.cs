namespace MineSweeper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    public class Mines
    {
        public class Points
        {
            private string name;
            private int points;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Points
            {
                get { return points; }
                set { points = value; }
            }

            public Points() { }

            public Points(string name, int points)
            {
                this.name = name;
                this.points = points;
            }
        }

        static void Main(string[] arguments)
        {
            string command = string.Empty;
            char[,] field = CreateGameField();
            char[,] bombs = LocateBombs();
            int counter = 0;
            bool explode = false;
            List<Points> champions = new List<Points>(6);
            int row = 0;
            int col = 0;
            bool flag = true;
            const int max = 35;
            bool notFlag = false;

            do
            {
                if (flag)
                {
                    Console.WriteLine("Let's play MineSweeper. Try to find the fields without mines." +
                    "Command 'top' shows the results, 'restart' starts new game, 'exit' finishes the game!");
                    PrintBoard(field);
                    flag = false;
                }
                Console.Write("Please enter row and column: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        Results(champions);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = LocateBombs();
                        PrintBoard(field);
                        explode = false;
                        flag = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye-bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                Move(field, bombs, row, col);
                                counter++;
                            }
                            if (max == counter)
                            {
                                notFlag = true;
                            }
                            else
                            {
                                PrintBoard(field);
                            }
                        }
                        else
                        {
                            explode = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command!\n");
                        break;
                }
                if (explode)
                {
                    PrintBoard(bombs);
                    Console.Write("\nHrrrrrr! Lost game with {0} points. " +
                        "Enter your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Points points = new Points(nickname, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(points);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < points.Points)
                            {
                                champions.Insert(i, points);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((Points player1Points, Points player2Points) => player2Points.Name.CompareTo(player1Points.Name));
                    champions.Sort((Points player1Points, Points player2Points) => player2Points.Points.CompareTo(player1Points.Points));
                    Results(champions);

                    field = CreateGameField();
                    bombs = LocateBombs();
                    counter = 0;
                    explode = false;
                    flag = true;
                }
                if (notFlag)
                {
                    Console.WriteLine("\nWell done! You have opened 35 cells without mines.");
                    PrintBoard(bombs);
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    Points points = new Points(name, counter);
                    champions.Add(points);
                    Results(champions);
                    field = CreateGameField();
                    bombs = LocateBombs();
                    counter = 0;
                    notFlag = false;
                    flag = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria!");
            Console.WriteLine("URAAAAAAAA.");
            Console.Read();
        }

        private static void Results(List<Points> points)
        {
            Console.WriteLine("\nPOINTS:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} squares",
                        i + 1, points[i].Name, points[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No results!\n");
            }
        }

        private static void Move(char[,] field,
            char[,] bombs, int row, int col)
        {
            char bombsCounter = CountAsterics(bombs, row, col);
            bombs[row, col] = bombsCounter;
            field[row, col] = bombsCounter;
        }

        private static void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] LocateBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] gameField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> asterics = new List<int>();
            while (asterics.Count < 15)
            {
                Random randomValue = new Random();
                int asfd = randomValue.Next(50);
                if (!asterics.Contains(asfd))
                {
                    asterics.Add(asfd);
                }
            }

            foreach (int i in asterics)
            {
                int col = (i / cols);
                int row = (i % cols);
                if (row == 0 && i != 0)
                {
                    col--;
                    row = cols;
                }
                else
                {
                    row++;
                }
                gameField[col, row - 1] = '*';
            }

            return gameField;
        }

        private static void smetki(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char kolkoo = CountAsterics(field, i, j);
                        field[i, j] = kolkoo;
                    }
                }
            }
        }

        private static char CountAsterics(char[,] rowsAndCols, int row, int col)
        {
            int counter = 0;
            int rows = rowsAndCols.GetLength(0);
            int cols = rowsAndCols.GetLength(1);

            if (row - 1 >= 0)
            {
                if (rowsAndCols[row - 1, col] == '*')
                {
                    counter++;
                }
            }
            if (row + 1 < rows)
            {
                if (rowsAndCols[row + 1, col] == '*')
                {
                    counter++;
                }
            }
            if (col - 1 >= 0)
            {
                if (rowsAndCols[row, col - 1] == '*')
                {
                    counter++;
                }
            }
            if (col + 1 < cols)
            {
                if (rowsAndCols[row, col + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (rowsAndCols[row - 1, col - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (rowsAndCols[row - 1, col + 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (rowsAndCols[row + 1, col - 1] == '*')
                {
                    counter++;
                }
            }
            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (rowsAndCols[row + 1, col + 1] == '*')
                {
                    counter++;
                }
            }
            return char.Parse(counter.ToString());
        }
    }
}
