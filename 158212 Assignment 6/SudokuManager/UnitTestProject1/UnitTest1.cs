using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuManager;
using Sudoku;

namespace UnitTestProject1 {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void TestSetGameBoardSize() {
            GameBoard gb = new GameBoard(1);
            int expected, actual;
            expected = 5;
            gb.Size = 5;
            actual = gb.Size;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGameBoardGetSize() {
            GameBoard gb = new GameBoard(2);
            int expected, actual;
            expected = 2;
            actual = gb.Size;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestGameBoardSetSolved() {
            GameBoard gb = new GameBoard(4);
            bool expected, actual;
            expected = true;
            actual = gb.Solved = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGameBoardGetSolved() {
            GameBoard gb = new GameBoard(4);
            bool expected, actual;
            expected = false;
            actual = gb.Solved;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGameBoardCalculatesCorrectRowsInRegion() {
            GameBoard gb = new GameBoard(9);
            int expected, actual;
            expected = 3;
            actual = gb.RowsInRegion;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGameBoardCalculateCorrectColsInRegion() {
            GameBoard gb = new GameBoard(9);
            int expected, actual;
            expected = 3;
            actual = gb.ColsInRegion;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGameBoardSetUpTileValueCorrectly() {
            GameBoard gb = new GameBoard(9);
            int expected, actual;
            expected = 5;
            gb.SetUpTile(0, 0, 5, false);
            actual = (int)gb.Tiles[0, 0].Value;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGameBoardSetUpTileLockedCorrectly() {
            GameBoard gb = new GameBoard(9);
            bool expected, actual;
            expected = true;
            gb.SetUpTile(0, 0, 5, true);
            actual = gb.Tiles[0, 0].Locked;
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestGameBoardCheckColIsSolvedWithSolution() {
            GameBoard gb = new GameBoard(9);
            bool expected, actual;
            expected = true;

            for (int i = 0; i < 9; i++) {
                gb.SetUpTile(i, 0, i + 1, false);
            }

            actual = gb.CheckCol(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGameBoardCheckColIsSolvedNoSolution() {
            GameBoard gb = new GameBoard(9);
            bool expected, actual;
            expected = false;
            actual = gb.CheckCol(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGameBoardCheckRegionIsSolvedWithSolution() {
            GameBoard gb = new GameBoard(9);
            bool expected, actual;
            expected = true;
            int value = 0;
            for (int i = 0; i < 3; i++){
                for(int y = 0; y < 3; y++){
                    gb.SetUpTile(i,y,value+1,false);
                    value++;
                }
            }

            actual = gb.CheckRegion(0,0);
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void TestGameBoardCheckRegionIsSolvedNoSolution() {
            GameBoard gb = new GameBoard(9);
            bool expected, actual;
            expected = false;
            actual = gb.CheckRegion(0, 0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGameBoardCheckRowIsSolvedWithSolution() {
            GameBoard gb = new GameBoard(9);
            bool expected, actual;
            expected = true;

            for (int i = 0; i < 9; i++){
                gb.SetUpTile(0,i,i+1,false);
            }

            actual = gb.CheckRow(0);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCheckBoardCheckRowIsSolvedNoSolution() {
            GameBoard gb = new GameBoard(9);
            bool expected, actual;
            expected = false;
            actual = gb.CheckRow(0);
            Assert.AreEqual(expected, actual);
        }

        
        [TestMethod]
        public void TestTileSetRow() {
            Tile t = new Tile(0, 0, 1, false);
            int expected, actual;
            expected = 1;
            t.Row = 1;
            actual = t.Row;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestTileSetCol() {
            Tile t = new Tile(0, 0, 1, false);
            int expected, actual;
            expected = 1;
            t.Col = 1;
            actual = t.Col;
            Assert.AreEqual(expected, actual);
        }
      
    }
}
