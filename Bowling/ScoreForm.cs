using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowling {
    public partial class ScoreForm : Form {
        private Game game = null;
        public ScoreForm() {
            InitializeComponent();
            RefreshFrames();
        }

        //When File > New Game is pressed, clear all frames and start over.
        private void NewGame(object sender, EventArgs e) {
            ResetFrames();
        }

        //Get values for all cells & organize it into the Game / Frame structure properly.
        private void RefreshFrames() {

            //Create an array of Frame objects representative of the current state of all input boxes.
            Frame[] _frames = new Frame[10];
            _frames[0] = new Frame(1, new int[] { frame1r1.IntValue, frame1r2.IntValue });
            _frames[1] = new Frame(2, new int[] { frame2r1.IntValue, frame2r2.IntValue });
            _frames[2] = new Frame(3, new int[] { frame3r1.IntValue, frame3r2.IntValue });
            _frames[3] = new Frame(4, new int[] { frame4r1.IntValue, frame4r2.IntValue });
            _frames[4] = new Frame(5, new int[] { frame5r1.IntValue, frame5r2.IntValue });
            _frames[5] = new Frame(6, new int[] { frame6r1.IntValue, frame6r2.IntValue });
            _frames[6] = new Frame(7, new int[] { frame7r1.IntValue, frame7r2.IntValue });
            _frames[7] = new Frame(8, new int[] { frame8r1.IntValue, frame8r2.IntValue });
            _frames[8] = new Frame(9, new int[] { frame9r1.IntValue, frame9r2.IntValue });
            _frames[9] = new Frame(10, new int[] { frame10r1.IntValue, frame10r2.IntValue, frame10r3.IntValue });

            //If this is the first update, instantiate the Game object for this window. If not, just update the frames in the pre-existing one.
            if (game == null) {
                game = new Game(_frames);
            } else {
                game.UpdateFrames(_frames);
            }

            //Set subtotal boxes (as long as the frame has been modified)
            int[] _subtotals = game.GetIncremTotals();
            if (frame1r1.Text != string.Empty) {
                frame1total.Text = _subtotals[0].ToString();
            }
            if (frame2r1.Text != string.Empty) {
                frame2total.Text = _subtotals[1].ToString();
            }
            if (frame3r1.Text != string.Empty) {
                frame3total.Text = _subtotals[2].ToString();
            }
            if (frame4r1.Text != string.Empty) {
                frame4total.Text = _subtotals[3].ToString();
            }
            if (frame5r1.Text != string.Empty) {
                frame5total.Text = _subtotals[4].ToString();
            }
            if (frame6r1.Text != string.Empty) {
                frame6total.Text = _subtotals[5].ToString();
            }
            if (frame7r1.Text != string.Empty) {
                frame7total.Text = _subtotals[6].ToString();
            }
            if (frame8r1.Text != string.Empty) {
                frame8total.Text = _subtotals[7].ToString();
            }
            if (frame9r1.Text != string.Empty) {
                frame9total.Text = _subtotals[8].ToString();
            }
            if (frame10r1.Text != string.Empty) {
                frame10total.Text = _subtotals[9].ToString();
            }

            //Set game total status
            gameTotal.Text = ("Game Total: " + game.GetTotal());
        }

        //Reset form and game
        private void ResetFrames() {
            frame1r1.Text = string.Empty;
            frame1r2.Text = string.Empty;
            frame2r1.Text = string.Empty;
            frame2r2.Text = string.Empty;
            frame3r1.Text = string.Empty;
            frame3r2.Text = string.Empty;
            frame4r1.Text = string.Empty;
            frame4r2.Text = string.Empty;
            frame5r1.Text = string.Empty;
            frame5r2.Text = string.Empty;
            frame6r1.Text = string.Empty;
            frame6r2.Text = string.Empty;
            frame7r1.Text = string.Empty;
            frame7r2.Text = string.Empty;
            frame8r1.Text = string.Empty;
            frame8r2.Text = string.Empty;
            frame9r1.Text = string.Empty;
            frame9r2.Text = string.Empty;
            frame10r1.Text = string.Empty;
            frame10r2.Text = string.Empty;
            frame10r3.Text = string.Empty;

            game = null;

            RefreshFrames();
        }


        //Run any time a score is updated in any box
        private void ScoreUpdated(object sender, EventArgs e) {
            RefreshFrames();
        }

        //Opens the instructions form
        private void OpenInstructions(object sender, EventArgs e) {
            Form instructions = new InstructionsForm();
            instructions.Show();
        }
    }
}
