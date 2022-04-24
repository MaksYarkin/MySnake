using System;
using System.Numerics;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake(new Vector2(1, 0), new Vector2(3, 2));
            snake.IncreaseSize();
            Console.WriteLine(snake.GetSize());
            Console.WriteLine(snake.GetPoint(0));
            Console.WriteLine();
            snake.MoveForward();
            Console.WriteLine(snake.GetPoint(0));
            Console.WriteLine();
            snake.SetMoveDirectionToDown();
            snake.MoveForward();
            Console.WriteLine(snake.GetPoint(0));
            Console.WriteLine();
        }
    }
}