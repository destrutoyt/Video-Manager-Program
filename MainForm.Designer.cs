
namespace Garces_CourseProject_Part1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Title;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.Label artist;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.titleText = new System.Windows.Forms.TextBox();
            this.artistText = new System.Windows.Forms.TextBox();
            this.yearText = new System.Windows.Forms.TextBox();
            this.urlText = new System.Windows.Forms.TextBox();
            this.outputText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.songList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.allSongsButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.findButtom = new System.Windows.Forms.Button();
            this.clearButtom = new System.Windows.Forms.Button();
            this.webViewDisplay = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.playButtom = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            Title = new System.Windows.Forms.Label();
            artist = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            resources.ApplyResources(Title, "Title");
            Title.Name = "Title";
            Title.Tag = "title.label";
            Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // artist
            // 
            resources.ApplyResources(artist, "artist");
            artist.Name = "artist";
            artist.Tag = "artist.label";
            artist.Click += new System.EventHandler(this.Artist_Click);
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            label2.Tag = "genreLabel";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            label3.Tag = "yearLabel";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            label4.Tag = "urlLabel";
            // 
            // titleText
            // 
            resources.ApplyResources(this.titleText, "titleText");
            this.titleText.Name = "titleText";
            this.titleText.Tag = "titleText";
            this.titleText.TextChanged += new System.EventHandler(this.titleText_TextChanged);
            // 
            // artistText
            // 
            resources.ApplyResources(this.artistText, "artistText");
            this.artistText.Name = "artistText";
            this.artistText.Tag = "artist.textBox";
            // 
            // yearText
            // 
            resources.ApplyResources(this.yearText, "yearText");
            this.yearText.Name = "yearText";
            this.yearText.Tag = "year.textBox";
            // 
            // urlText
            // 
            resources.ApplyResources(this.urlText, "urlText");
            this.urlText.Name = "urlText";
            this.urlText.Tag = "url.textLabel";
            // 
            // outputText
            // 
            resources.ApplyResources(this.outputText, "outputText");
            this.outputText.Name = "outputText";
            this.outputText.TabStop = false;
            this.outputText.Tag = "outputText.Text";
            this.outputText.TextChanged += new System.EventHandler(this.outputText_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Name = "label1";
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.AddButton, "AddButton");
            this.AddButton.Name = "AddButton";
            this.AddButton.Tag = "AddButton";
            this.AddButton.UseVisualStyleBackColor = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // songList
            // 
            this.songList.FormattingEnabled = true;
            resources.ApplyResources(this.songList, "songList");
            this.songList.Name = "songList";
            this.songList.TabStop = false;
            this.songList.SelectedIndexChanged += new System.EventHandler(this.songList_SelectedIndexChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Name = "label6";
            // 
            // allSongsButton
            // 
            this.allSongsButton.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.allSongsButton, "allSongsButton");
            this.allSongsButton.Name = "allSongsButton";
            this.allSongsButton.Tag = "AllSongsButton";
            this.allSongsButton.UseVisualStyleBackColor = false;
            this.allSongsButton.Click += new System.EventHandler(this.allSongsButton_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Name = "label7";
            // 
            // findButtom
            // 
            this.findButtom.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.findButtom, "findButtom");
            this.findButtom.Name = "findButtom";
            this.findButtom.Tag = "f";
            this.findButtom.UseVisualStyleBackColor = false;
            this.findButtom.Click += new System.EventHandler(this.findButtom_Click);
            // 
            // clearButtom
            // 
            this.clearButtom.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.clearButtom, "clearButtom");
            this.clearButtom.Name = "clearButtom";
            this.clearButtom.Tag = "f";
            this.clearButtom.UseVisualStyleBackColor = false;
            this.clearButtom.Click += new System.EventHandler(this.clearButtom_Click);
            // 
            // webViewDisplay
            // 
            this.webViewDisplay.AllowExternalDrop = true;
            this.webViewDisplay.CreationProperties = null;
            this.webViewDisplay.DefaultBackgroundColor = System.Drawing.Color.White;
            resources.ApplyResources(this.webViewDisplay, "webViewDisplay");
            this.webViewDisplay.Name = "webViewDisplay";
            this.webViewDisplay.Source = new System.Uri("https://www.google.com/", System.UriKind.Absolute);
            this.webViewDisplay.ZoomFactor = 1D;
            this.webViewDisplay.Click += new System.EventHandler(this.webViewDisplay_Click);
            // 
            // playButtom
            // 
            this.playButtom.BackColor = System.Drawing.SystemColors.Info;
            resources.ApplyResources(this.playButtom, "playButtom");
            this.playButtom.Name = "playButtom";
            this.playButtom.Tag = "";
            this.playButtom.UseVisualStyleBackColor = false;
            this.playButtom.Click += new System.EventHandler(this.playButtom_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            resources.GetString("genreComboBox.Items"),
            resources.GetString("genreComboBox.Items1"),
            resources.GetString("genreComboBox.Items2"),
            resources.GetString("genreComboBox.Items3"),
            resources.GetString("genreComboBox.Items4"),
            resources.GetString("genreComboBox.Items5"),
            resources.GetString("genreComboBox.Items6"),
            resources.GetString("genreComboBox.Items7"),
            resources.GetString("genreComboBox.Items8")});
            resources.ApplyResources(this.genreComboBox, "genreComboBox");
            this.genreComboBox.Name = "genreComboBox";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.playButtom);
            this.Controls.Add(this.webViewDisplay);
            this.Controls.Add(this.clearButtom);
            this.Controls.Add(this.findButtom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.allSongsButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.songList);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputText);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.artistText);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(artist);
            this.Controls.Add(this.titleText);
            this.Controls.Add(Title);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webViewDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.TextBox artistText;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.TextBox outputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox songList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button allSongsButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button findButtom;
        private System.Windows.Forms.Button clearButtom;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewDisplay;
        private System.Windows.Forms.Button playButtom;
        private System.Windows.Forms.ComboBox genreComboBox;
    }
}

