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
        GameBoard _board;

        public Sudoku() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            OpenSudokuFile();
        }

        private void OpenSudokuFile() {
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
                        size = 0;
                        break;
                }
                _board = new GameBoard(size);

                while (!reader.EndOfStream) {
                    //Read the locked tiles.
                    string tileLine = reader.ReadLine();
                    string[] tileDetails = tileLine.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    _board.SetUpTile(Convert.ToInt32(tileDetails[0]), Convert.ToInt32(tileDetails[1]), Convert.ToInt32(tileDetails[2]), true);
                }

                reader.Close();
                BindGameBoardToUI();
            }
        }

        private void BindGameBoardToUI() {
            DGGameBoardView.ColumnCount = _board.Size;

            for (int r = 0; r < _board.Size; r++) {
                DataGridViewRow row = new DataGridViewRow();
                for (int c = 0; c < _board.Size; c++) {
                    DataGridViewTextBoxCell cell = new DataGridViewTextBoxCell();
                    cell.Value = _board.Tiles[r, c].Value;
                   
                    row.Cells.Add(cell);
                    FormatCell(cell);
                    if (c % 3 == 0) {
                        //Style the cell accordingly
                       
                    }

                    if (_board.Tiles[r, c].Locked) {
                        cell.ReadOnly = true;
                        DataGridViewCellStyle style = cell.Style;
                        style.BackColor = Color.Red;
                        cell.Style = style;

                    }
                }
                DGGameBoardView.Rows.Add(row);
            }
        }

      

        private void FormatCell(DataGridViewTextBoxCell cell) {
        }

        private void CellDidChange(object sender, DataGridViewCellEventArgs e) {
            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)DGGameBoardView.CurrentCell;
            _board.SetUpTile(cell.RowIndex, cell.ColumnIndex, Convert.ToInt32(cell.Value), false);

           bool rowSolved = _board.CheckRow(cell.RowIndex);
           bool colSolved = _board.CheckCol(cell.ColumnIndex);
           List<bool> listOfAllRegionStatus = new List<bool> { };
           int rowsInRegion = 0;
           switch (_board.Size) {
               case 9:
                   rowsInRegion = 3;
                   break;
               case 6:
                   rowsInRegion = 2;
                   break;
               default:
                   break;
           }
           for (int r = 0; r < (_board.Size ); r+=rowsInRegion) {
               for (int c = 0; c < (_board.Size); c += 3) {
                   bool regionSolved = _board.CheckRegion(r, c, rowsInRegion);
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
               SolvedLabel.Text = "SOLVED";
           }

        }

       
    }
}
