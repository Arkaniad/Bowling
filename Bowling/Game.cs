using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling {
    //Class that wraps frames up into a Game wrapper for totalling & interfacing with UI
    class Game {
        private Frame[] frames;
        private int[] subtotals;
        private int[] incremtotals;
        private int total;

        //Create Game from array of Frames
        public Game(Frame[] _frames) {
            if(_frames.Length != 10) {
                throw new Exception("Cannot create a game without 10 frames!");
            } else {
                frames = _frames;
                Calculate();
            }
        }

        //Create Game from array of rolls (Used for testing)
        public Game(int[][] rolls) {
            Frame[] _frames = new Frame[rolls.Length];
            for (int i = 0; i < rolls.Length; i++) {
                _frames[i] = new Frame(i, rolls[i]);
            }
            frames = _frames;
            Calculate();
        }

        //Replace current frame set with new frame set
        public void UpdateFrames(Frame[] _frames) {
            frames = _frames;
            Calculate();
        }

        //Get total score of game
        public int GetTotal() {
            return total;
        }

        //Get subtotals for game (totals of each frame)
        public int[] GetSubtotals() {
            return subtotals;
        }

        //Get subtotal for specific frame
        public int GetSubtotal(int _frameindex) {
            return subtotals[_frameindex];
        }

        //Get incremental totals for game (score for each frame + previous frames, per frame. What's shown below each frame.)
        public int[] GetIncremTotals() {
            return incremtotals;
        }

        //Get incremental total for a specific frame
        public int GetIncremTotal(int _frameindex) {
            return incremtotals[_frameindex];
        }

        //Calculate the total score for the game, as well as the subtotals and incremental totals
        private void Calculate() {
            CombSpares();

            int _total = 0;
            int[] _subtotals = new int[10];
            int[] _incremtotals = new int[10];
            //Loop over every frame and create a subtotal for each frame
            for (int i = 0; i < frames.Length; i++) {

                //Initialize frame variables, easier to have access via a variable reference than to constantly be using array indices.
                Frame _frame = frames[i];
                Frame _framenext = null;
                Frame _framenext2 = null;

                //Don't try to grab the next frame if it doesn't exist
                if (i < 9) {
                    _framenext = frames[i + 1];
                }
                if (i < 8) {
                    _framenext2 = frames[i + 2];
                }

                //Open frame is worth the total pins knocked down
                if (_frame.GetFrameType() == FrameType.open) {
                    _subtotals[i] = _frame.GetTotal();
                    _total += _subtotals[i];
                    _incremtotals[i] = _total;

                    //Spare is 10 + next roll
                } else if (_frame.GetFrameType() == FrameType.spare) {
                    _subtotals[i] = _framenext.GetRoll1() + _frame.GetTotal();
                    _total += _subtotals[i];
                    _incremtotals[i] = _total;

                    //Strike is.. kind of complicated.
                } else if (_frame.GetFrameType() == FrameType.strike) {
                    _subtotals[i] = _frame.GetTotal(); //Worth AT LEAST 10 points (since strikes are represented by 10s)

                    //If the next frame is also a strike, the "2nd roll" will be part of the NEXT NEXT frame. Otherwise, add the next two rolls (the total of the next frame).
                    if (_framenext != null && _framenext.GetFrameType() != FrameType.final) {
                        if (_framenext.IsStrike()) {
                            _subtotals[i] += _framenext.GetTotal() + _framenext2.GetRoll1();
                        } else {
                            _subtotals[i] += _framenext.GetTotal();
                        }
                        //If the next frame is the final frame, just add the next 2 rolls.
                    } else if (_framenext != null && _framenext.GetFrameType() == FrameType.final) {
                        _subtotals[i] += _framenext.GetRoll1() + _framenext.GetRoll2();
                    }
                    _total += _subtotals[i];
                    _incremtotals[i] = _total;

                    //Just total up the final frame
                } else if (_frame.GetFrameType() == FrameType.final) {
                    _subtotals[i] = _frame.GetTotal();
                    _total += _subtotals[i];
                    _incremtotals[i] = _total;
                }
            }

            //Update the object fields with updated values
            subtotals = _subtotals;
            total = _total;
            incremtotals = _incremtotals;

        }

        //Spares code to a -1 in the form, run through scores and replace -1 with the difference of 10 and the first roll
        private void CombSpares() {
            for(int i = 0; i < frames.Length; i++) {
                frames[i].CombSpare();
            }
        }
    }
}
