/* 159212 Assignment 6 by Michael Coleman 07315554.
 * Notes: I used the DataGridView to display the game. I will not make this mistake again.
 * I have not figured out how to darken the cell borders to indicate 'regions'.
 * Nor have I figured out how to loop through specific cells (e.g. 0,0 - 2,2) to colour a solved 'regions'.
 * I did, however manage to figure out if a region is solved, just not indicate it.
 * MSDN Documentation is sometimes terrible.
 * Essentially 90% of my time on this assignment was spent battling the insane DataGridView system, where you can't say DataGridView.Cells[0,0];
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SudokuManager;
using System.IO;

namespace Sudoku {
    public partial class Sudoku : Form {
        //A Gameboard for holding any sudoku game, even crazy ones I hadn't heard of Like 4x4.
        GameBoard _board;

        public Sudoku() {
            InitializeComponent();
        }

    
        //Form Methods
        private bool OpenSudokuFile() {
            //Read a .txt file containing the sudoku puzzle.

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text |*.txt";
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                FileStream fs = (FileStream)dialog.OpenFile();
                StreamReader reader = new StreamReader(fs);
                string boardSize = reader.ReadLine();
                int size;
                switch (boardSize) {
                    case "4x4":
                        size = 4; 
                        break;
                    case "6x6":
                        size = 6;
                        break;
                    case "9x9":
                        size = 9;
                        break;
                    default:
                        //Crazy size. We can't handle that.
                        size = 0;
                        StatusLabel.Text = String.Format("Error, can't make a {0} board.", boardSize);
                        StatusLabel.ForeColor = Color.Red;
                        StatusLabel.Visible = true;
                        return false;
                }

                
                _board = new GameBoard(size);

                while (!reader.EndOfStream) {
                    //Read the 'locked' tiles from the file.

                    string tileLine = reader.ReadLine();
                    string[] tileDetails = tileLine.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    try {
                        _board.SetUpTile(Convert.ToInt32(tileDetails[0]), Convert.ToInt32(tileDetails[1]), Convert.ToInt32(tileDetails[2]), true);
                    } catch {
                        //The file was not correct.
                        StatusLabel.Text = "Error: The File Could Not Be Read";
                        StatusLabel.Visible = true;
                        StatusLabel.ForeColor = Color.Red;
                        reader.Close();
                        return false;
                    }
                }

                reader.Close();
            } else {
                //User cancelled finding a file, bad user.
                return false;
            }
            return true;
        }

        private void BindGameBoardToUI() {
            //Take the tiles set up on reading the file, and bind them to the DGGameBoardView.

            DGGameBoardView.ColumnCount = _board.Size;
            
            //Loop through the board, and add Rows and Cells to match the tile array.
            for (int r = 0; r < _board.Size; r++) {
                DataGridViewRow row = new DataGridViewRow();
                
                for (int c = 0; c < _board.Size; c++) {
                    //Set up a new cell to display the tile data.
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    
                    cell.Value = _board.Tiles[r, c].Value;
                    cell.MaxInputLength = 1;
                    row.Cells.Add(cell);

                    if (_board.Tiles[r, c].Locked) {
                        //If the tiles read are from the file, color them grey to indicate they can't be changed.
                        cell.ReadOnly = true;
                        DataGridViewCellStyle style = cell.Style;
                        style.ForeColor = Color.Gray;
                        cell.Style = style;

                    }
                }
                DGGameBoardView.Rows.Add(row);
            }
        }

      
        private void ResetGame() {
            //Reset all the rows in the GameBoardView, and hide the StatusLabel.
            foreach (DataGridViewRow row in DGGameBoardView.Rows) {
                foreach (DataGridViewTextBoxCell cell in row.Cells) {
                    cell.OwningColumn.DefaultCellStyle.BackColor = Color.White;                    
                }
            }

            DGGameBoardView.Rows.Clear();
            DGGameBoardView.Refresh();
            StatusLabel.Visible = false;
            
        }

        //Event Handlers
        private void BtnOpenSudokuClick(object sender, EventArgs e) {
            //Handle opening the file, and process the gameboard if successful.
            if (OpenSudokuFile()) {
                ResetGame();
                BindGameBoardToUI();
                StatusLabel.Visible = false;
            }
        }


        private void CellDidChange(object sender, DataGridViewCellEventArgs e) {
            //User entered something into a cell, figure out if it is valid, and check if they solved any regions, rows, columns, or the whole thing.
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)DGGameBoardView.CurrentCell;
            try {
                _board.SetUpTile(cell.RowIndex, cell.ColumnIndex, Convert.ToInt32(cell.Value), false);

            } catch {
                //User entered something other than a number. Sudoku != Crossword.
                StatusLabel.Text = "Error: Please enter a number from 1 - 9";
                StatusLabel.ForeColor = Color.Red;
                StatusLabel.Visible = true;
                cell.Value = null;
            }

            bool rowSolved = _board.CheckRow(cell.RowIndex);
            if (rowSolved) {
                for (int i = 0; i < _board.Size; i++) {
                    cell.OwningRow.Cells[i].Style.BackColor = Color.LightGreen;
                }


            }
            bool colSolved = _board.CheckCol(cell.ColumnIndex);
            if (colSolved) {
                for (int i = 0; i < _board.Size; i++) {
                    cell.OwningColumn.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
            List<bool> listOfAllRegionStatus = new List<bool> { };

            for (int r = 0; r < (_board.Size); r += _board.RowsInRegion) {
                for (int c = 0; c < (_board.Size); c += _board.ColsInRegion) {
                    bool regionSolved = _board.CheckRegion(r, c);
                    
                    if (regionSolved) {
                        listOfAllRegionStatus.Add(true);
                    }
                }

            }

            bool regionsComplete = false;
            if (listOfAllRegionStatus.Count == _board.Size) {
                regionsComplete = true;
            }

            if (rowSolved && colSolved && regionsComplete) {
                //User did a sudoku.
                StatusLabel.Text = "Puzzle Solved!";
                StatusLabel.ForeColor = Color.Black;
                StatusLabel.Visible = true;
            }
        }
    }
}
