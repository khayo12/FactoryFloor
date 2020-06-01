using System;
using System.Collections.Generic;

namespace FactoryFloor
{
    public class Move
    {
        public string MoveBlocks(string moveSeq)
        {
            int countN = 0, countS = 0;
            int countW = 0, countE = 0;
            string direction = string.Empty, visited = string.Empty, previousDirection = string.Empty;
            int numberOfMoves = 0, rightTurns = 0;
            List<string> visitedBlocks = new List<string>();

            try
            {
                string[] moves = SplitTheString(moveSeq);

                foreach (var move in moves)
                {
                    direction = move.Substring(0, 1);
                    numberOfMoves = Convert.ToInt32(move.Substring(1, move.Length - 1));

                    for (var count = numberOfMoves; count > 0; count--)
                    {
                        switch (direction)
                        {
                            case "N":
                                countN++;
                                rightTurns = previousDirection.Equals("W") ? ++rightTurns : rightTurns;
                                break;
                            case "E":
                                countE++;
                                rightTurns = previousDirection.Equals("N") ? ++rightTurns : rightTurns;
                                break;
                            case "S":
                                countS++;
                                rightTurns = previousDirection.Equals("E") ? ++rightTurns : rightTurns;
                                break;
                            case "W":
                                countW++;
                                rightTurns = previousDirection.Equals("S") ? ++rightTurns : rightTurns;
                                break;
                            default:
                                return $"Invalid: {direction} direction.";
                        }
                        visited = (countE - countW) + ", " + (countN - countS);
                        if (!visitedBlocks.Contains(visited))
                        {
                            visitedBlocks.Add(visited);
                        }
                        previousDirection = direction;
                    }
                }
                return visitedBlocks.Count + " visited blocks\n" + rightTurns + " right turns";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Please enter the sequence in the following format: N4,E2,S2,W4\n{ex.Message}");
            }

            return string.Empty;
        }

        private string[] SplitTheString(string moveSeq)
        {
            return moveSeq.Split(',');
        }
    }
}