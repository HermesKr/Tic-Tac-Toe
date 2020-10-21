using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToetally
{
    class Program
    {
        static void  player1win()
        {
            Console.WriteLine("Congratulations player 1, you won!");
        }
        static void player2win()
        {
            Console.WriteLine("Congratulations player 2, you won!");
        }
        static void Main(string[] args)
        {
            string[,] ttt = new string[3, 3] { { "0", "0", "0" },{ "0", "0", "0" },{ "0", "0", "0" } };
            string rowstring = "";
            bool game = false; // when it becomes true, the game ends
            Random random = new Random();
            int counter = 0; // a counter that when it reaches 9 gets a draw
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rowstring = rowstring + ttt[i, j];

                }
                rowstring += Environment.NewLine;
            }
            Console.WriteLine(rowstring);
            Console.WriteLine("Player 1 marks the board with Xs and Player 2 marks the board with Os.");
            Console.WriteLine("Because I'm not smart enough to program it, flip a coin to see who goes first.");

            while (game == false)
            {
                bool freespace1 = false; // bool to check if the space we want to put the X is free
                while (freespace1 == false)
                {
                    Console.WriteLine("Player 1, what is the column (y axis) you want to place your X?");
                    bool check = false; // bool to check if we are within the matrix in the y axis
                    int y = 0;
                    int x = 0;
                    while (check == false)

                    {
                        y = int.Parse(Console.ReadLine());
                        if (y == 1 || y == 2 || y == 3)
                            check = true;
                        else
                            Console.WriteLine("The number has to be between 1 and 3.");

                    }
                    Console.WriteLine("Player 1, what is the row (x axis) you want to place your X?");
                    bool check1 = false; // bool to check if we are within the matrix in the x axis
                    while (check1 == false)
                    {
                        x = int.Parse(Console.ReadLine());
                        if (x == 1 || x == 2 || x == 3)
                            check1 = true;
                        else
                            Console.WriteLine("The number has to be between 1 and 3.");
                    }
                    if (ttt[x - 1, y - 1] == "0")
                    {
                        ttt[x - 1, y - 1] = "X";
                        freespace1 = true;
                        counter += 1;
                    }
                    else
                        Console.WriteLine("That space is already taken.");

                }
                rowstring = ""; // erase the old matrix and print a new one
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        rowstring = rowstring + ttt[i, j];

                    }
                    rowstring += Environment.NewLine;
                }
                Console.WriteLine(rowstring); // check if player one has won

                if (ttt[0, 0] == "X" && ttt[1, 1] == "X" && ttt[2, 2] == "X")
                {
                    game = true;
                    player1win();
                }
                else if (ttt[0, 2] == "X" && ttt[1, 1] == "X" && ttt[2, 0] == "X")
                {
                    game = true;
                    player1win();
                }
                else if (ttt[0, 0] == "X" &&  ttt[1, 0] == "X" && ttt[2, 0] == "X")
                {
                    game = true;
                    player1win();
                }
                else if (ttt[0, 1] == "X" && ttt[1, 1] == "X" && ttt[2, 1] == "X")
                {
                    game = true;
                    player1win();
                }
                else if (ttt[0, 2] == "X" && ttt[1, 2] == "X" && ttt[2, 2] == "X")
                {
                    game = true;
                    player1win();
                }
                else if (ttt[0, 0] == "X" && ttt[0, 1] == "X"  && ttt[0, 2] == "X")
                {
                    game = true;
                    player1win();
                }
                else if (ttt[1, 0] == "X" && ttt[1, 1] == "X"  && ttt[1, 2] == "X")
                {
                    game = true;
                    player1win();
                }
                else if (ttt[2, 0] == "X" &&  ttt[2, 1] == "X" && ttt[2, 2] == "X")
                {
                    game = true;
                    player1win();
                }
                else if (counter == 9) // when the counter hits 9, there are no more moves and the game ends in a draw
                {
                    game = true;
                    Console.WriteLine("It's a draw");
                }


                if (game != true) // check if user one has won, if not it's time for player two
                {
                    bool freespace2 = false;
                    while (freespace2 == false)
                    {
                        Console.WriteLine("Player 2, what is the column (y axis) you want to place your O?");
                        bool check = false; // bool to check if we are within the matrix in the y axis
                        int y = 0;
                        int x = 0;
                        while (check == false)

                        {
                            y = int.Parse(Console.ReadLine());
                            if (y == 1 || y == 2 || y == 3)
                                check = true;
                            else
                                Console.WriteLine("The number has to be between 1 and 3.");

                        }
                        Console.WriteLine("Player 2, what is the row (x axis) you want to place your 0?");
                        bool check1 = false; // bool to check if we are within the matrix in the x axis
                        while (check1 == false)
                        {
                            x = int.Parse(Console.ReadLine());
                            if (x == 1 || x == 2 || x == 3)
                                check1 = true;
                            else
                                Console.WriteLine("The number has to be between 1 and 3.");
                        }
                        if (ttt[x - 1, y - 1] == "0")
                        {
                            ttt[x - 1, y - 1] = "O";
                            freespace2 = true;
                            
                        }
                        else
                            Console.WriteLine("That space is already taken.");

                    }
                    rowstring = ""; // erase the old matrix and print a new one
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            rowstring = rowstring + ttt[i, j];

                        }
                        rowstring += Environment.NewLine;
                    }
                    Console.WriteLine(rowstring); // check if player two has won

                    if (ttt[0, 0] == "O" && ttt[1, 1] == "O" && ttt[2, 2] == "O")
                    {
                        game = true;
                        player2win();
                    }
                    else if (ttt[0, 2] == "O" && ttt[1, 1] == "O" && ttt[2, 0] == "O")
                    {
                        game = true;
                        player2win();
                    }
                    else if (ttt[0, 0] == "O" && ttt[1, 0] == "O" && ttt[2, 0] == "O")
                    {
                        game = true;
                        player2win();
                    }
                    else if (ttt[0, 1] == "O" && ttt[1, 1] == "O" && ttt[2, 1] == "O")
                    {
                        game = true;
                        player2win();
                    }
                    else if (ttt[0, 2] == "O" && ttt[1, 2] == "O" && ttt[2, 2] == "O")
                    {
                        game = true;
                        player2win();
                    }
                    else if (ttt[0, 0] == "O" && ttt[0, 1] == "O" && ttt[0, 2] == "O")
                    {
                        game = true;
                        player2win();
                    }
                    else if (ttt[1, 0] == "O" && ttt[1, 1] == "O" && ttt[1, 2] == "O")
                    {
                        game = true;
                        player2win();
                    }
                    else if (ttt[2, 0] == "O" && ttt[2, 1] == "O" && ttt[2, 2] == "O")
                    {
                        game = true;
                        player2win();
                    }
                }
                
                






            }
            
        }
    }
}
