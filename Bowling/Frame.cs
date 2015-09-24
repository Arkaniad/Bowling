using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling {
    enum FrameType {open, spare, strike, final}
    class Frame {
        private FrameType type;
        private int[] scores;

        public Frame(int[] _scores) {
            if(_scores.Length != 2 && _scores.Length != 3) {
                throw new Exception("Frame must have either 2 or 3 rolls.");
            } else {
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

        public int[] getScores() {
            return scores;
        }

        public FrameType getFrameType() {
            return type;
        }
        public int getTotal() {
            return scores[0] + scores[1];
        }
    }
}
