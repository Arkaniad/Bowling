﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling {
    //Enumeration to make frame type handling easy to write
    enum FrameType {open, spare, strike, final, empty}

    //Class to make performing certain tasks on frames less repetitive
    class Frame {
        private FrameType type;
        private int index;
        private int[] scores;

        public Frame(int _index, int[] _scores) {
            if(_scores.Length != 2 && _scores.Length != 3) {
                throw new Exception("Frame must have either 2 or 3 rolls.");
            } else {
                index = _index;
                scores = _scores;
                if(scores.Length == 3) {
                    type = FrameType.final;
                } else if(scores[0] == 10) {
                    type = FrameType.strike;
                } else if (scores[0]+scores[1] == 10) {
                    type = FrameType.spare;
                } else {
                    type = FrameType.open;
                }
            }
        }

        //Get all rolls for this frame
        public int[] GetRolls() {
            return scores;
        }

        //Set rolls for this frame
        public void SetRolls(int[] _scores) {
            scores = _scores;
        }

        //Get the frame total
        public int GetTotal() {
            if(type == FrameType.final) {
                return scores[0] + scores[1] + scores[2];
            } else {
                return scores[0] + scores[1];
            }
        }

        //Get an individual roll
        public int GetRoll1() {
            return scores[0];
        }

        public int GetRoll2() {
            return scores[1];
        }
        public int GetRoll3() {
            return scores[2];
        }

        //Set an individual roll
        public void SetRoll1(int _roll) {
            scores[0] = _roll;
        }

        public void SetRoll2(int _roll) {
            scores[1] = _roll;
        }
        public void SetRoll3(int _roll) {
            scores[2] = _roll;
        }

        //Get the frame type
        public FrameType GetFrameType() {
            return type;
        }

        //Get the frame number
        public int GetIndex() {
            return index;
        }

        //Determine if the frame is a strike
        public Boolean IsStrike() {
            if(scores[0] == 10) {
                return true;
            }
            return false;
        }

        //Correct spares from GUI input (slashes input as -1)
        public void CombSpare() {
            if(scores[1] == -1) {
                scores[1] = 10 - scores[0];
                type = FrameType.spare;
            }
        }
    }
}
