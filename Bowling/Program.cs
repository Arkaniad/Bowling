using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling {
    class Program {
        static void Main(string[] args) {
            TestGames();
        }

        static Frame[] Load(int[][] rolls) {
            Frame[] _frames = new Frame[rolls.Length];
            for (int i = 0; i < rolls.Length; i++) {
                _frames[i] = new Frame(rolls[i]);
            }
            return _frames;
        }

        //This function will total out a set of frames. We don't really need to score any game that isn't
        //ten frames, so throw an exception if we're over or under.
        static int Tally( Frame[] frames) {
            if (frames.Length != 10) {
                throw new Exception("You can only score a game with 10 frames total.");
            }
            int[] _total = new int[frames.Length];
            int _grandtotal = 0;
            for (int i = 0; i < frames.Length; i++) {
                Frame _frame = frames[i];
                if (_frame.getFrameType() == FrameType.open) {
                    _total[i] = frames[i].getScores()[0] + frames[i].getScores()[1];
                    _grandtotal += _total[i];
                } else if (_frame.getFrameType() == FrameType.spare) {
                    _total[i] = frames[i + 1].getScores()[0] + frames[i].getScores()[0] + frames[i].getScores()[1];
                    _grandtotal += _total[i];
                } else if (_frame.getFrameType() == FrameType.strike) {
                    _total[i] = frames[i + 1].getScores()[0] + frames[i + 1].getScores()[1] + frames[i].getScores()[0] + frames[i].getScores()[1];
                    _grandtotal += _total[i];
                } else if (_frame.getFrameType() == FrameType.final) {
                    _total[i] = frames[i].getScores()[0] + frames[i].getScores()[1] + frames[i].getScores()[2];
                    _grandtotal += _total[i];
                }
            }
            return _grandtotal;
        }

        static void TestGames() {
            //Initialize the game's frames
            int[][] test1 = {
                new int[] { 6, 1 },
                new int[] { 3, 4 },
                new int[] { 2, 8 },
                new int[] { 8, 2 },
                new int[] { 5, 0 },
                new int[] { 3, 0 },
                new int[] { 2, 2 },
                new int[] { 6, 2 },
                new int[] { 8, 0 },
                new int[] { 5, 1 }
            };

            int[][] test2 = {
                new int[] { 1, 8 },
                new int[] { 5, 0 },
                new int[] { 10, 0 },
                new int[] { 8, 0 },
                new int[] { 8, 0 },
                new int[] { 10, 0 },
                new int[] { 7, 2 },
                new int[] { 7, 1 },
                new int[] { 8, 2 },
                new int[] { 5, 0 }
            };

            int[][] test3 = {
                new int[] { 9, 1 },
                new int[] { 8, 2 },
                new int[] { 6, 0 },
                new int[] { 10, 0 },
                new int[] { 9, 1 },
                new int[] { 0, 8 },
                new int[] { 7, 2 },
                new int[] { 0, 10 },
                new int[] { 7, 3 },
                new int[] { 7, 2 }
            };

            int[][] test4 = {
                new int[] { 7, 2 },
                new int[] { 10, 0 },
                new int[] { 3, 6 },
                new int[] { 7, 3 },
                new int[] { 7, 2 },
                new int[] { 7, 3 },
                new int[] { 8, 0 },
                new int[] { 8, 1 },
                new int[] { 8, 2 },
                new int[] { 9, 0 }
            };

            int[][] test5 = {
                new int[] { 9, 0 },
                new int[] { 9, 0 },
                new int[] { 8, 0 },
                new int[] { 6, 0 },
                new int[] { 7, 1 },
                new int[] { 10, 0 },
                new int[] { 9, 1 },
                new int[] { 8, 0 },
                new int[] { 7, 1 },
                new int[] { 7, 2 }
            };

            int[][] testperfect = {
                new int[] { 10, 0 },
                new int[] { 10, 0 },
                new int[] { 10, 0 },
                new int[] { 10, 0 },
                new int[] { 10, 0 },
                new int[] { 10, 0 },
                new int[] { 10, 0 },
                new int[] { 10, 0 },
                new int[] { 10, 0 },
                new int[] { 10, 10, 10 }
            };

            //Stack up all the games and test!
            System.Console.WriteLine("Game 1 total: " + Tally(Load(test1)));
            System.Console.WriteLine("Game 2 total: " + Tally(Load(test2)));
            System.Console.WriteLine("Game 3 total: " + Tally(Load(test3)));
            System.Console.WriteLine("Game 4 total: " + Tally(Load(test4)));
            System.Console.WriteLine("Game 5 total: " + Tally(Load(test5)));
            System.Console.WriteLine("Perfect game: " + Tally(Load(testperfect)));
            System.Console.ReadKey();
        }
    }
}
