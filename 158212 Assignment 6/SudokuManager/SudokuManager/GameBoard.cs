/* A Class to play Sudoku by.
 * Holds an array of 'Tiles' which have a value.
 * Works out if a row, column or region of tiles are solved.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SudokuManager {
   public class GameBoard {
        private int _size;
        private Tile[,] _tiles;
        private bool _solved;
        private int _rowsInRegion;
        private int _colsInRegion;

        public int Size {
            get {
                return _size;
            }

            set {
                _size = value;
            }
        }

        public Tile[,] Tiles {
            get {
                return _tiles;
            }
        } 

        public bool Solved {
            get {
                return _solved;
            }
            set {
                _solved = value;
            }
        }

        public int RowsInRegion {
            get {
                return _rowsInRegion;
            }
          
        }

        public int ColsInRegion {
            get {
                return _colsInRegion;
            }
           
        }

        //Constructor
        public GameBoard(int size) {
            _size = size;
            switch (size) {
                case 9:
                    _rowsInRegion = 3;
                    _colsInRegion = 3;
                    break;
                case 6:
                    _rowsInRegion = 2;
                    _colsInRegion = 3;
                    break;
                case 4:
                    _rowsInRegion = 2;
                    _colsInRegion = 2;
                    break;
                default:
                    break;
            }
            _tiles = new Tile[size, size];
            for (int r = 0; r < size; r++) {
                for (int c = 0; c < size; c++) {
                    _tiles[r, c] = new Tile(r, c, null, false);
                }
            }
        }

    
       
        public void SetUpTile(int r, int c, int v, bool l) {
            //Set up a tile at row, col with the value v and locked status l.
            _tiles[r, c].Value = v;
            _tiles[r, c].Locked = l;
        }


        public bool CheckRow(int r) {
            //Check if row at r is solved.
            List<int> tileNumbers = new List<int>{ };
            for (int c = 0; c < _size; c++) {
                if (_tiles[r, c].Value == null) {
                    return false;
                }
                if (tileNumbers.Contains((int)_tiles[r, c].Value)) {
                    return false;
                } else {
                    tileNumbers.Add((int)_tiles[r, c].Value);
                }
            }
            if (tileNumbers.Count == _size) {
                return true;
            }
            return false;
        }

        public bool CheckCol(int c) {
            //Check if col at c is solved.
            List<int> tileNumbers = new List<int> { };
            for (int r = 0; r < _size; r++) {
                if (_tiles[r, c].Value == null) {
                    return false;
                }
                if (tileNumbers.Contains((int)_tiles[r, c].Value)) {
                    return false;
                } else {
                    tileNumbers.Add((int)_tiles[r, c].Value);
                }
               
            }
            if (tileNumbers.Count == _size) {
                return true;
            }
            return false;
        }


        public bool CheckRegion(int r, int c) {
            //Check if region starting at r,c and going to +rows/colsInRegion is solved.
            List<int> tileNumbers = new List<int> { };
                
            for (int i = r; i < r + _rowsInRegion; i++) {
                for (int y = c; y < c + _colsInRegion; y++) {
                    if (_tiles[i, y].Value == null) {
                        return false;
                    }
                    
                    if(tileNumbers.Contains((int)_tiles[i,y].Value)){
                        return false;
                    } else {
                        tileNumbers.Add((int)_tiles[i, y].Value);
                    }
                }
            }
                   
            if (tileNumbers.Count == _size) {
                return true;
            }
            
            return false;
        }
       
       
    }
}
