using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace Garces_CourseProject_Part1
{
    public partial class MainForm : Form
    {
        //Class level references
        string[] titleArray = new string[5];
        string[] artistArray = new string[5];
        string[] genreArray = new string[5];
        int[] yearArray = new int[5];
        string[] urlArray = new string[5];

        int songCount = 0;

        public MainForm()
        {
            InitializeComponent();
        }
        
        public bool ValidInput()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(titleText.Text))
            {
                //Title is blank
                MessageBox.Show("The song title cannot be blank!");
                isValid = false;
            }

            else if (string.IsNullOrEmpty(artistText.Text))
            {
                MessageBox.Show("The artist cannot be blank!");
                isValid = false;

            }

            else if (string.IsNullOrEmpty(genreComboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("The GENRE cannot be blank!");
                isValid = false;

            }

            else if (string.IsNullOrEmpty(yearText.Text))
            {
                MessageBox.Show("The YEAR cannot be blank!");
                isValid = false;

            }

            else if (string.IsNullOrEmpty(urlText.Text))
            {
                MessageBox.Show("The URL cannot be blank!");
                isValid = false;
            }
            return isValid;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Artist_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";

            if(ValidInput() )
            {

                // Add title to ListBox and song list
                songList.Items.Add(titleText.Text);
                titleArray[songCount] = titleText.Text;
                artistArray[songCount] = artistText.Text;
                genreArray[songCount] = genreComboBox.SelectedItem.ToString();
                yearArray[songCount] = int.Parse(yearText.Text); //Convert string into number
                urlArray[songCount] = urlText.Text;

                //Increment song counter
                songCount++;

                // Build the output text
            sb.Append(titleText.Text);
            sb.Append(nl);
            sb.Append(artistText.Text);
            sb.Append(nl);
            sb.Append(genreComboBox.SelectedItem.ToString());
            sb.Append(nl);
            sb.Append(yearText.Text);
            sb.Append(nl);
            sb.Append(urlText.Text);
            sb.Append(nl);

            outputText.Text = sb.ToString();
         }
        }

        private bool SongInList(string songTitle)
        {
            bool found = false;

            foreach(var item in songList.Items)
            {
                string currentSong = item as string;
                //lowercase comparasion
                if(songTitle.ToLower() == currentSong.ToLower())
                {
                    found = true;
                }
            }

            return found;
        }

        private int GetSongIndex(string songTitle)
        {
            int songIndex = songList.Items.IndexOf(songTitle);
            return songIndex;
        }

        private void allSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(String.Empty);
            string nl = "\r\n";

            //build the output text
            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);
            }

            //Put the output text into the output textbox
            outputText.Text = sb.ToString();
        }

        private void findButtom_Click(object sender, EventArgs e)
        {
            if(SongInList(titleText.Text))
            {
                StringBuilder sb = new StringBuilder(String.Empty);
                string nl = "\r\n";

                int songIndex = GetSongIndex(titleText.Text);

                //Build the output text
                sb.Append(titleArray[songIndex]);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex]);
                sb.Append(nl);
                sb.Append(urlArray[songIndex]); ;
                sb.Append(nl);

                outputText.Text = sb.ToString();
            }
        }

        private void clearButtom_Click(object sender, EventArgs e)
        {
            titleText.Text = "";
            artistText.Text = String.Empty;
            yearText.Clear(); //Alternate way to clear text box
            urlText.Clear();

        }

        private void webViewDisplay_Click(object sender, EventArgs e)
        {

        }

        private void playButtom_Click(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;
            string url = urlArray[songIndex];
            webViewDisplay.CoreWebView2.Navigate(url);
        }

        private void songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int songIndex = songList.SelectedIndex;

            //If song is selected (index greater than -1), show details
            if(songIndex > -1)
            {
                StringBuilder sb = new StringBuilder(string.Empty);
                string nl = "\r\n";

                sb.Append(titleArray[songIndex]);
                sb.Append(nl);
                sb.Append(artistArray[songIndex]);
                sb.Append(nl);
                sb.Append(genreArray[songIndex]);
                sb.Append(nl);
                sb.Append(yearArray[songIndex]);
                sb.Append(nl);
                sb.Append(urlArray[songIndex]); ;
                sb.Append(nl);

                outputText.Text = sb.ToString();
            }
        }

        private void outputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void titleText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
