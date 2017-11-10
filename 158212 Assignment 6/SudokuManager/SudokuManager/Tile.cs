/* The Tile class.
 * Holds a value, and a position on the gameboard indication by _row, _col.
 * Initial value, indicated by _number can be null.
 * The tile can be locked so the user can't change it.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuManager
{
    public class Tile
    {
        private int? _number;
        private bool _locked;
        private int _row;
        private int _col;

        public Tile(int r, int c, int? v, bool l) {
            _row = r;
            _col = c;
            _number = v;
            _locked = l;


        }

        public int? Value {
            get {
                return _number;
            }

            set {
                _number = value;
            }
        }
        public int Row {
            get {
                return _row;
            }
            set {
                _row = value;
            }
        }

        public int Col {
            get {
                return _col;
            }

            set {
                _col = value;
            }
        }

        public bool Locked {
            get {
                return _locked;
            }

            set {
                _locked = value;
            }
        }
    }

   
}
