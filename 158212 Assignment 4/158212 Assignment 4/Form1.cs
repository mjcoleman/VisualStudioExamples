/* 158.212 Assignment 4 by Michael Coleman 07315554. 
 * Credit to MSDN for List and sorting clarification and code examples.
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
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;


namespace _158212_Assignment_4 {

   
    public partial class TextAnalyst : Form {
        List<string> wordsFromText = new List<string> { }; //This list will hold all the words read from the text file.

        public TextAnalyst() {
            InitializeComponent();
        }

        public List<string> GetShortestWords(List<string> wordList) {
            //Create a new list of shortest words. Then set a string to the first word in the wordlist to use as a base line for the shortest word.
            List<string> shortestWords = new List<string> { };
            string shortest = wordList[0];

            //If any words are shorter than our base line, set the new shortest word as the base line.
            foreach (string word in wordList) {
                if (word.Length < shortest.Length) {
                    shortest = word;
                }
            }
            
            //Add the shortest to the shortestWords list.
            shortestWords.Add(shortest);

            //Then find every word of that length and add it to the shortestwords list.
            foreach (string word in wordList) {
                if (word.Length == shortest.Length && !(shortestWords.Contains(word, StringComparer.OrdinalIgnoreCase))) { //So We don't get two or more of the same shortest word.
                    shortestWords.Add(word);
                }
            }

            return shortestWords;
        } 

        public List<string> GetLongestWords(List<string> wordList) {
            //Create a new list of longest words. Then set a string to the first word in the wordlist to use as a base line for the longest word.
            List<string> longestWords = new List<string> { };
            string longest = wordList[0];

            //If any words are longer than our base line, set the new longest word as the base line.
            foreach (string word in wordList) {
                if (word.Length > longest.Length) {
                    longest = word;
                }
            }

            //Add the longest to the longestWords list.
            longestWords.Add(longest);

            //Then find every word of that length and add it to the longestWords list.
            foreach (string word in wordList) {
                if (word.Length == longest.Length && !(word.Equals(longest, StringComparison.OrdinalIgnoreCase))) { //So we don't get two or more of the same longest word.
                    longestWords.Add(word);     
                }
            }

            return longestWords;
        }

        public List<string> GetUniqueWords(List<string> wordList) {
            //Create a new list to hold all the unique words in the text.
            List<string> uniqueWords = new List<string> { };

            //Go through every word in the wordList, and if it doesn't match up to a word already in the unique words list, add it.
            foreach (string word in wordList) {
                if (!(uniqueWords.Contains(word, StringComparer.OrdinalIgnoreCase))) {
                    uniqueWords.Add(word);
                }
            }

            return uniqueWords;
        }

        public List<string> GetMostCommonWords(List<string> wordList) {
            //Create two new lists, one to hold the most common words, and a second to keep track of the count of every word.
            List<string> mostCommonWords = new List<string> { };
            List<int> countOfWords = new List<int> { };

            //Go through the whole word list, and assign a count to every word, placing the count in the countOfWords list.
            for (int i = 0; i < wordList.Count; i++) {
                int count = 0;
                foreach (string word in wordList) {
                    if (word.Equals(wordList[i], StringComparison.OrdinalIgnoreCase)) {
                        count++;
                    }
                }
                countOfWords.Add(count);
            }

            //Now, find the highest 'count' in the count of wordsList. This is our Highest frequency.
            int highestFreq = countOfWords.Max();

            //And loop through the count of words list to find where those highest frequencys are, and match them to the word list.
            for(int i =0; i < countOfWords.Count; i++){
                if (countOfWords[i] == highestFreq) {
                    if(!(mostCommonWords.Contains(wordList[i], StringComparer.OrdinalIgnoreCase))){
                        //Finally, add the found word to the mostCommonWords list.
                        mostCommonWords.Add(wordList[i]);
                    }
                }
            }

            return mostCommonWords;
        }

        public double GetAverageWordLength(List<string> wordList) {
            //Set a double to keep track of every letter in the words contained in wordList.
            double letterCount=0;
            
            //Loop through the wordList and add the count of letters in each word to the count.
            foreach (string word in wordList) {
                letterCount += word.Length;
            }

            //Then divide the total count by the number of words in wordList.
            letterCount = (letterCount / wordList.Count);

            return letterCount;
        }

        public List<string> GetWordsOfLength(int length, List<string> wordList) {
            //Set up a new list to hold words of the user defined length.
            List<string> wordsOfLength = new List<string> { };
            
            //Using the wordList passed, make a new list of all the unique words in it, so we don't get double-ups.
            List<string> uniqueList = GetUniqueWords(wordList);

            //Then loop through the unique word list looking for words that match the user defined length.
            foreach (string word in uniqueList) {
                if (word.Length == length) {
                    //If one is found, add it to the wordsOfLength List.
                    wordsOfLength.Add(word);
                }
            }

            return wordsOfLength;
        }

        public int GetNumberOfOccurancesOfWordInWordList(string searchedWord, List<string>wordList) {
            //Set up an int to keep track of how many times we've come across the user defined searchedWord in the passed wordList.
            int wordCount = 0;

            //Loop through the wordlist and compare the current word to the searched word, ignoring case differences. 
            //If a match is found, increase the word count.
            foreach (string word in wordList) {
               if (word.Equals(searchedWord, StringComparison.OrdinalIgnoreCase)) {
                   wordCount++;
               }
           }

            return wordCount;
        }

        public void readFile() {
            //Set up an openfiledialog and give it some restrictions to txt only files, and a message for the user.
            OpenFileDialog dialog;
            dialog = new OpenFileDialog();
            dialog.Filter = "Text|*.txt|All|*.*";
            dialog.Title = "Choose a .txt file";

            //Show the dialog.
            DialogResult result = dialog.ShowDialog();

            //If the result was ok, set up a streamreader and start reading the chosen file.
            if (result == DialogResult.OK) {
                StreamReader reader;
                reader = new StreamReader(dialog.FileName);

                //Update the title text to show the file we are reading.
                TitleLabel.Text = String.Format("Analysis of {0}", dialog.SafeFileName);
                
                //Split the words from the streamreader into the wordsFromText list we set up at the start.
                wordsFromText = new List<string>(reader.ReadToEnd().Split(new Char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries));

                //If there are no words in the file, the user has given us an empty file to parse. Thanks user, I'll handle that for you.
                if (wordsFromText.Count < 1) {
                    //By showing you an error message.
                    string errorMessage = String.Format("Error, the file \"{0}\" could not be read.", dialog.SafeFileName);
                    var errorResult = MessageBox.Show(errorMessage, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    //And giving you the chance to try again. Run this function again.
                    if (errorResult == DialogResult.Retry) {
                        readFile();
                    } else {
                        //If the user gave up trying, kick them back to the main interface.
                        return;
                    }

                } else {
                    //If the user gave us a proper file, go ahead and process it.
                    ProcessWordsAndUpdateUI(wordsFromText);
                }
            }
        }

        public void ProcessWordsAndUpdateUI(List<string> wordList) {
            //Using the passed list, process the shortest words and place them into the ShortestWordsBox
            List<string> shortestWords = GetShortestWords(wordList);
            ShortestWordsTextBox.Text = (String.Format("Shortest Words: {1} Letters. : {0}", string.Join(", ", shortestWords), shortestWords[0].Length));

            //Using the passed list, process the longest words and place them into the LongestWordsBox
            List<string> longestWords = GetLongestWords(wordList);
            LongestWordsTextBox.Text = (String.Format("Longest Words: {1} Letters. : {0}, ", string.Join(",", longestWords), longestWords[0].Length));

            //Using the passed list, process the most common words and place them into the MostCommonWordsBox
            List<string> mostCommonWords = GetMostCommonWords(wordList);
            MostCommonWordsTextBox.Text = (String.Format("Most Common Words: {1} Occurances. : {0} ", string.Join(", ", mostCommonWords), GetNumberOfOccurancesOfWordInWordList(mostCommonWords[0], wordList)));

            //Using the passed list, process the unique words and place them into the UniqueWordsBox
            List<string> uniqueWords = GetUniqueWords(wordList);
            UniqueWordsTextBox.Text = string.Join(" ", uniqueWords);

            //Using the passed list,create a new list, and get all the unique words into it, so we can get the average for the unique words.
            List<string> uniqueList = GetUniqueWords(wordList);
            AverageWordLengthTextBox.Text = string.Format("{0:F2}", GetAverageWordLength(uniqueWords)).ToString();

            //Process the Total Words Statistics and place it into the Statistics Label.
            TotalWordsStatisticsLabel.Text = string.Format("Absolute number of words is: {0}. Average Word Length of All Words is {1:F2}", wordList.Count, GetAverageWordLength(wordList));

            //Make The Statistics Controls Visible.
            WordTabControl.Visible = true;
            TotalWordsStatisticsLabel.Visible = true;

            //Hide The Open File Prompt
            OpenFilePromptLabel.Visible = false;
            OpenFileButton.Visible = false;

            //Build the Chart 
            buildChart(wordList);

        }

        public void buildChart(List<string> wordList) {
            //Clear any existing details from the word frequency chart.
            WordFreqChart.Titles.Clear();
            WordFreqChart.Series.Clear();

            //Now set the chart details up.
            WordFreqChart.Series.Add("Frequency");
            WordFreqChart.ChartAreas[0].AxisX.LabelStyle.Angle =90;
            WordFreqChart.ChartAreas[0].AxisX.Interval = 1;
            WordFreqChart.ChartAreas[0].AxisY.Interval = 5;

            //Get a list of the unique words from wordlist, so we don't get any doubles on the chart.
            List<string> unique = GetUniqueWords(wordList);

            //We want to have up to 50 data points if there are 50 words in the unique list. Otherwise, just make it the count of the words in unique
            int max = unique.Count > 50 ? 50 : unique.Count;

            //Set the title of the chart based on the number of data points we'll have.
            WordFreqChart.Titles.Add(String.Format("Frequency of the first {0} words.", max));


            //Go through the unique list, and count how many times the words appear in the main word list.
            //Then add them to the chart.
            for (int i = 0; i < max; i++) {
                int freq = GetNumberOfOccurancesOfWordInWordList(unique[i], wordList);
                DataPoint dp = new DataPoint();
                dp.SetValueXY(unique[i], freq);
                WordFreqChart.Series[0].Points.Add(dp);
            }
        }   
      
        public void resetErrors() {
            //Get rid of any existing error label that is displaying.
            ErrorLabel.Visible = false;
        }

        public void SearchTextForWordsOfLength(int length) {
            //Create a new list, using the GetWordsOfLength function, holding all words meeting the user defined length criteria.
            List<string> sortedWordsOfLength = GetWordsOfLength(length, wordsFromText);

            //If there is nothing in the list, no words meeting the criteria were found, display this result.
            if (sortedWordsOfLength.Count < 1) {
                SearchResultTextBox.Text = String.Format("No {0} letter words found in the text.", length);
            } else {
                //If there were words matching, sort them alphabetically, and display them in the result text box.
                sortedWordsOfLength.Sort();
                SearchResultTextBox.Text = String.Format("The following {0} letter words were found in the text: {1}", length, string.Join(", ", sortedWordsOfLength));
            }

            SearchResultTextBox.Visible = true;
        }

        public void SearchTextForExactWord(string word) {
            //Use the GetNumberOfOccurances function to find the count of the user defined word in the text.
            int searchResult = GetNumberOfOccurancesOfWordInWordList(word, wordsFromText);

            //If the function returned 0, nothing was found. Communicate this via the results box.
            if (searchResult == 0) {
                SearchResultTextBox.Text = String.Format("The word: \"{0}\" was not found in the text.", word);
            } else {
                //Otherwise, show how many times the word was found.
                SearchResultTextBox.Text = String.Format("Found {0} occurances of the word \"{1}\" in the text.", searchResult, word);
            }
            //And make the result box visible to the user.
            SearchResultTextBox.Visible = true;
        }

        //Event Handlers Below:

        private void openToolStripMenuItemClick(object sender, EventArgs e) {
            //Start trying to read a file the user selects.
            readFile();
        }

        private void SearchLengthButtonClick(object sender, EventArgs e) {
            //Set a int to hold the user defined search.
            int searchTerm = 0;

            //Reset any error we might have been showing before.
            resetErrors();

            //Try and convert the text entered in the search field to an int. If it failed, they didn't enter an appropriate number, so show an error.
            try {
                searchTerm = Convert.ToInt32(SearchBoxTextBox.Text);
            } catch {
                //Error, user didn't enter a number.
                ErrorLabel.Text = "Error: Invalid Number Entered.";
                ErrorLabel.Visible = true;
                return;
            }

            //Everything was as expected, search for the user defined length.
            SearchTextForWordsOfLength(searchTerm);

        }

        private void SearchWordButtonClick(object sender, EventArgs e) {
            //Reset any errors we may be showing.
            resetErrors();

            //Set a string to the user defined search criteria.
            string searchTerm = SearchBoxTextBox.Text;

            //If the user hasn't entered anything, and got button-click happy, show an error.
            if (searchTerm.Equals("")) {
                ErrorLabel.Text = "Error: Invalid Text Entered.";
                ErrorLabel.Visible = true;
            } else {
                //Everything was as expected, search for the user defined word.
                SearchTextForExactWord(searchTerm);
            }
        }

        private void OpenFileButtonClick(object sender, EventArgs e) {
            //Start trying to read a file the user selects.
            readFile();
        }

        private void openToolStripMenuItemClick(object sender, EventArgs e) {
            //Start trying to read a file the user selects.
            readFile();
        }

    }


}
