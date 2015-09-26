using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling {
    class Program {
        static void Main(string[] args) {
            //Run the test cases!
            TestGames();
        }

        //This function loads an array of rolls into an array of Frames
        static Frame[] Load(int[][] rolls) {
            Frame[] _frames = new Frame[rolls.Length];
            for (int i = 0; i < rolls.Length; i++) {
                _frames[i] = new Frame(i, rolls[i]);
            }
            return _frames;
        }

        //This function will total out a set of frames. We don't really need to score any game that isn't
        //ten frames, so throw an exception if we're over or under.
        static int Tally( Frame[] frames) {
            if (frames.Length != 10) { //Refuse to score an incomplete set of frames
                throw new Exception("You can only score a game with 10 frames total.");
            }
            int[] _total = new int[frames.Length];
            int _grandtotal = 0;

            //Loop over every frame and create a subtotal for each frame
            for (int i = 0; i < frames.Length; i++) {

                //Initialize frame variables, easier to have access via a variable reference than to constantly be using array indices.
                Frame _frame = frames[i];
                Frame _framenext = null;
                Frame _framenext2 = null;

                //Don't try to grab the next frame if it doesn't exist
                if(i < 9) {
                    _framenext = frames[i + 1];
                }
                if(i < 8) {
                    _framenext2 = frames[i + 2];
                }

                //Open frame is worth the total pins knocked down
                if (_frame.GetFrameType() == FrameType.open) {
                    _total[i] = _frame.GetTotal();
                    _grandtotal += _total[i];

                //Spare is 10 + next roll
                } else if (_frame.GetFrameType() == FrameType.spare) {
                    _total[i] = _framenext.GetRoll1() + _frame.GetTotal();
                    _grandtotal += _total[i];

                //Strike is.. kind of complicated.
                } else if (_frame.GetFrameType() == FrameType.strike) {
                    _total[i] = _frame.GetTotal(); //Worth AT LEAST 10 points (since strikes are represented by 10s)

                    //If the next frame is also a strike, the "2nd roll" will be part of the NEXT NEXT frame. Otherwise, add the next two rolls (the total of the next frame).
                    if(_framenext != null && _framenext.GetFrameType() != FrameType.final) {
                        if (_framenext.IsStrike()) {
                            _total[i] += _framenext.GetTotal() + _framenext2.GetRoll1();
                        } else {
                            _total[i] += _framenext.GetTotal();
                        }
                    //If the next frame is the final frame, just add the next 2 rolls.
                    } else if(_framenext != null && _framenext.GetFrameType() == FrameType.final) {
                        _total[i] += _framenext.GetRoll1() + _framenext.GetRoll2();
                    }
                    _grandtotal += _total[i];

                //Just total up the final frame
                } else if (_frame.GetFrameType() == FrameType.final) {
                    _total[i] = _frame.GetTotal();
                    _grandtotal += _total[i];
                }
            }
            return _grandtotal;
        }

        static void TestGames() {
            //Initialize a bunch of test games, from http://farm4.static.flickr.com/3326/3191334120_4b716b1d90.jpg (and a test perfect game to validate strike handling)
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

            //Pause until you can see all the scores and then quit!
            System.Console.ReadKey();
        }
    }
}
