using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        var board = BoardGenerator.generateRandomBoard();
        var sw = new Stopwatch();
        sw.Start();

        int iterations = 100000;
        for(int i = 0; i < iterations; i++) {
            board = BoardGenerator.generateRandomBoard();
        }
        sw.Stop();
        Console.WriteLine($"Total time: {sw.ElapsedMilliseconds}ms");
        Console.WriteLine($"Average time per board: {sw.ElapsedMilliseconds / (iterations * 1.0)}ms");
    }
}

