using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnagramApp
{
    public partial class Form1 : Form
    {
  
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //The code here will generate 10 random characters
        private void randomCharacters_Click(object sender, EventArgs e)
        {
            //clear the initial random letters
            tbRandChar.Clear();

            string tenChars = "";

            //create a string with all the alphabets
            string alphabets = "abcdefghijklmnopqrstuvwxyz";
            Random random = new Random();

            for(var i =0; i <10; i++)
            {
                //get a random index that will represent the alphabet in the string of alphabets
                var randomIndex = random.Next(0, 26);

                tenChars += alphabets[randomIndex];
            }

            tbRandChar.Text = tenChars;

        }

        private void generateWords_Click(object sender, EventArgs e)
        {

            var anagramList = new List<string>();

            //list of alphabets
            string alphabets = "abcdefghijklmnopqrstuvwxyz";

            var alphaList = alphabets.ToList();

            //get all of the random characters
            var randChars = tbRandChar.Text;
            

            //convert to character array
            var ranCharArr = randChars.ToCharArray();
            //sort the characters
            Array.Sort(ranCharArr);

            //in the event of duplicate characters, create an array with all unique characters
            var ranCharArrUnique = ranCharArr.Distinct();

            //loop through the random characters and remove them from the alphabets
            //The objective here is to get all the characters that are not present in the random letters generated
            foreach(var character in ranCharArrUnique)
            {
                alphaList.Remove(character);
            }

            //call the file for the dictionary of words
            var allWords = System.IO.File.ReadAllLines($@"D:\WORLD SKILLS\AnagramApp\words_alpha.txt");

            //given that are 10 characters, get only the words that are maximum 10 characters long
            var possibleWords = allWords.ToList();

            //all characters that should be excluded when finding anagrams
            var excludeCharacters = alphaList.ToArray();
            
            //remove all words that have the characters not found in the 10 random characters
            foreach(var exclude in excludeCharacters)
            {
                possibleWords.RemoveAll(a => a.Contains(exclude));
            }

            ///check through the random characters and see their count
            ///the objective here is to find the words that have characters that are higher than the stipulated number in the random generated
            foreach(var ranLetter in ranCharArrUnique)
            {
                //get the letter that is being checked
                var checkLetter = ranLetter;
                //get the count of that letter in the bunch of randomly generated characters
                var charCount = ranCharArr.Where(a => a.Equals(checkLetter)).Count();

                //remove all words where the count of the specified character is higher than the number of the character randomly given
                var filterWords = possibleWords.Where(a => a.Contains(checkLetter)).ToList();
                foreach(var word in filterWords)
                {
                    var count = word.Where(a => a.Equals(checkLetter)).Count();
                    if(count > charCount)
                    {
                        possibleWords.Remove(word);
                    }
                }
            }

            foreach(var a in possibleWords)
            {
                anagramList.Add(a);
            }

            lbAnagrams.DataSource = new BindingSource(anagramList.OrderBy(a => a.Count()), null);
        }

    }
}
