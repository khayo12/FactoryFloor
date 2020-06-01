using System;

namespace FactoryFloor
{    
    public static class Floor
    {        
        static void Main(string[] args)
        {
            var move = new Move();
            Console.Write("Please enter the sequence of steps: ");
            var sequence = Console.ReadLine();
            var visitedBlocks = move.MoveBlocks(sequence.ToUpper());
            if (!string.IsNullOrWhiteSpace(visitedBlocks))
            {
                Console.WriteLine(visitedBlocks);
            }
            Console.ReadLine();
        }
    }
}