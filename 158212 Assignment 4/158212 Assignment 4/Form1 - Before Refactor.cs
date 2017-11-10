using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace _158212_Assignment_4 {

   
    public partial class TextAnalyst : Form {
        List<string> wordsFromText = new List<string> { }; //This will hold all the words. Maybe.

        public TextAnalyst() {
            InitializeComponent();
        }

        public List<string> GetShortestWords(List<string> wordList) {
            List<string> shortestWords = new List<string> { };
            string shortest = wordList[0];
            //Find the shortest word in the list and make an int or something.
            foreach (string word in wordList) {
                if (word.Length < shortest.Length) {
                    shortest = word;
                }
            }
            shortestWords.Add(shortest);

            //Then find every word of that length and add it to the shortestwords list.
            foreach (string word in wordList) {
                if (word.Length == shortest.Length && !(word.Equals(shortest, StringComparison.OrdinalIgnoreCase))) {
                    shortestWords.Add(word);
                }
            }

            return shortestWords;
        }

        public List<string> GetLongestWords(List<string> wordList) {
            List<string> longestWords = new List<string> { };
            string longest = wordList[0];
            //Find the longest word in the list and make an int.
            foreach (string word in wordList) {
                if (word.Length > longest.Length) {
                    longest = word;
                }
            }
          
            longestWords.Add(longest);

            foreach (string word in wordList) {
                if (word.Length == longest.Length && !(word.Equals(longest, StringComparison.OrdinalIgnoreCase))) { //So we don't get two or more of the same longest word.
                    longestWords.Add(word);
                    
                }
            }
            //Then find every word of that length and add it to the longestwords list.
            return longestWords;
        }

  

        public List<string> GetUniqueWords(List<string> wordList) {
            List<string> uniqueWords = new List<string> { };
            foreach (string word in wordList) {
                if (!(uniqueWords.Contains(word, StringComparer.OrdinalIgnoreCase))) {
                    uniqueWords.Add(word);
                }
            }
            return uniqueWords;
        }

        public List<string> GetMostCommonWords(List<string> wordList) {
            List<string> mostCommonWords = new List<string> { };
            List<int> countOfWords = new List<int> { };
            for (int i = 0; i < wordList.Count; i++) {
                int count = 0;
                foreach (string word in wordList) {
                    if (word.Equals(wordList[i], StringComparison.OrdinalIgnoreCase)) {
                        count++;
                    }
                }
                countOfWords.Add(count);
            }

            int highestFreq = countOfWords.Max();
           for(int i =0; i < countOfWords.Count; i++){
                if (countOfWords[i] == highestFreq) {
                    if(!(mostCommonWords.Contains(wordList[i]))){
                        mostCommonWords.Add(wordList[i]);
                    }
                }
            }
            //GREASY

            return mostCommonWords;
        }

        public double GetAverageWordLength(List<string> wordList) {
            List<string> uniqueList = GetUniqueWords(wordList);
            double letterCount=0;
            foreach (string word in uniqueList) {
                letterCount += word.Length;
            }
            letterCount = (letterCount / uniqueList.Count());

            return letterCount;
        }

        public List<string> GetWordsOfLength(int length, List<string> wordList) {
            List<string> wordsOfLength = new List<string> { };
            List<string> uniqueList = GetUniqueWords(wordList);
            foreach (string word in uniqueList) {
                if (word.Length == length) {
                    wordsOfLength.Add(word);
                }
            }
            return wordsOfLength;
        }

        public int GetNumberOfOccurancesOfWordInWordList(string searchedWord, List<string>wordList) {
           int wordCount = 0;
           foreach (string word in wordList) {
               if (word.Equals(searchedWord, StringComparison.OrdinalIgnoreCase)) {
                   wordCount++;
               }
           }
            return wordCount;
        }

        

        public List<string> ReadFileIntoList() {
            List<string> wordList = new List<string> { };
            return wordList;

        }

        private void openToolStripMenuItemClick(object sender, EventArgs e) {
        //Refactor and put in a new method.
            
            OpenFileDialog dialog;
            dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) {

                StreamReader reader;
                reader = new StreamReader(dialog.FileName);

                wordsFromText = new List<string>(reader.ReadToEnd().Split(new Char[]{' ', '\n', '\r'}, StringSplitOptions.RemoveEmptyEntries));
                ProcessWordsAndUpdateUI(wordsFromText);
            }
        }


        public void ProcessWordsAndUpdateUI(List<string>wordList) {
            //Do stuff with the list.
            ShortestWordsTextBox.Text = (String.Format("Shortest {1} Letters. : {0}", string.Join(", ", GetShortestWords(wordList)), 1));
            LongestWordsTextBox.Text = string.Join(", ", GetLongestWords(wordList));
            MostCommonWordsTextBox.Text = string.Join(", ", GetMostCommonWords(wordList));
            UniqueWordsTextBox.Text = string.Join(" ", GetUniqueWords(wordList));
            AverageWordLengthTextBox.Text = string.Format("{0:F2}",GetAverageWordLength(wordList)).ToString();

            //Make the chart
            buildChart();

            //Statistics Label
            TotalWordsStatisticsLabel.Text = string.Format("Absolute number of words is: {0}. Average Word Length of All Words is {1:F2}", wordsFromText.Count, GetAverageWordLength(wordsFromText));
            

            //Make Everything Visible.
            WordTabControl.Visible = true;
            TotalWordsStatisticsLabel.Visible = true;

            //Hide The Prompt
            OpenFilePromptLabel.Visible = false;
            OpenFileButton.Visible = false;
        
        
        }

       

        public void buildChart() {
            WordFreqChart.Series.Clear();
            WordFreqChart.Titles.Add("Frequency of the First 50 Words in filename.txt");

            WordFreqChart.Series.Add("Frequency");
            WordFreqChart.ChartAreas[0].AxisX.LabelStyle.Angle =90;
            WordFreqChart.ChartAreas[0].AxisX.Interval = 1;
            WordFreqChart.ChartAreas[0].AxisY.Interval = 5;


            for (int i = 0; i < 49; i++) {
                int freq = GetNumberOfOccurancesOfWordInWordList(wordsFromText[i], wordsFromText);
                DataPoint dp = new DataPoint();
               
                dp.SetValueXY(wordsFromText[i], freq);

                WordFreqChart.Series[0].Points.Add(dp);
            }
          
        }

      

        private void OpenFileButtonClick(object sender, EventArgs e) {
            openToolStripMenuItemClick(sender, e);
        }

        private void SearchLengthButtonClick(object sender, EventArgs e) {
            int searchTerm = Convert.ToInt32(SearchBoxTextBox.Text);
            List<string> sortedWordsOfLength = GetWordsOfLength(searchTerm, wordsFromText);

            SearchResultTextBox.Text = string.Join(", ", GetWordsOfLength(searchTerm, wordsFromText));
            SearchResultTextBox.Visible = true;
        }

        private void SearchWordButtonClick(object sender, EventArgs e) {
            string searchTerm = SearchBoxTextBox.Text;
            SearchResultTextBox.Text = GetNumberOfOccurancesOfWordInWordList(searchTerm, wordsFromText).ToString();
            SearchResultTextBox.Visible = true;
        }

    
      

       
    }

}
