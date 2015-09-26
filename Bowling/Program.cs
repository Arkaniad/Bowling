using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowling {
    class Program {
        [STAThread]
        static void Main(string[] args) {

            Application.EnableVisualStyles();
            Application.Run(new ScoreForm());
            //Run the test cases!
            //TestGames();
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
            Game game1 = new Game(test1);
            Game game2 = new Game(test2);
            Game game3 = new Game(test3);
            Game game4 = new Game(test4);
            Game game5 = new Game(test5);
            Game gamePerfect = new Game(testperfect);
            System.Console.WriteLine("Game 1 total: " + game1.GetTotal());
            System.Console.WriteLine("Game 2 total: " + game2.GetTotal());
            System.Console.WriteLine("Game 3 total: " + game3.GetTotal());
            System.Console.WriteLine("Game 4 total: " + game4.GetTotal());
            System.Console.WriteLine("Game 5 total: " + game5.GetTotal());
            System.Console.WriteLine("Perfect game: " + gamePerfect.GetTotal());

            //Pause until you can see all the scores and then quit!
            System.Console.ReadKey();
        }
    }
}
