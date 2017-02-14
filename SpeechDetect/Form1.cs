using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Speech.Recognition;

namespace SpeechDetect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Fields
        private string wordToSpeach = String.Empty; //aktualne slowo do powiedzenia
        private List<string> wordsInDictionary = new List<string>(); //lista wszystkich slow w slowniku
        #endregion



        private void Form1_Load(object sender, EventArgs e)
        {
            //ustawienie wlasciowosci formy i kontrolek
            labelScore.BackColor = Color.Transparent;
            labelWord.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            panel1.BackColor = Color.Transparent;

            btnRandomWord.Enabled = false;
            btnStartRecognize.Enabled = false;
            comboBoxWords.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Text = "Speech detect";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximumSize = new Size(712, 640);
            this.MinimumSize = new Size(712, 640);
            this.MaximizeBox = false;

            //podpiecie eventow pod recognizer
            Recognizer.Instance.SpeechRecognized += sre_SpeechRecognized; //rozpoznanie mowy
            Recognizer.Instance.SpeechRejected += sre_SpeechRejected; //odrzucenie mowy

        }

        // losowanie slowa
        private void btnRandomWord_Click(object sender, EventArgs e)
        {
            GetRandomWordFromGrammar();
        }

        private void GetRandomWordFromGrammar()
        {
            Random rand = new Random();
            wordToSpeach = wordsInDictionary.ElementAt(rand.Next(0, wordsInDictionary.Count - 1));
            this.labelWord.Text = wordToSpeach;
            this.comboBoxWords.SelectedIndex = wordsInDictionary.IndexOf(wordToSpeach);
            SetZeroScore();
        }

        //rozpoczecie rozpoznawania
        private void btnStartRecognize_Click(object sender, EventArgs e)
        {
            this.btnStartRecognize.Enabled = false;
            Recognizer.Instance.StartRecognize();
        }

        //obsluga eventu rozopznania mowy, sprawdzenie czy powiedziana wlasciwe slowo ze slownika i wyswietlenie wyniku
        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == wordToSpeach)
                this.labelScore.Text = "Wynik: " + Math.Round(e.Result.Confidence * 100) + " %";
            else
                SetZeroScore();
            this.btnStartRecognize.Enabled = true;
        }
        //obsluga eventu odrzucenia mowy - sytuacja gdy powiedziano slowo nieznajdujace sie w slowniku
        private void sre_SpeechRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            SetZeroScore();
            this.btnStartRecognize.Enabled = true;
        }

        //wczytwywanie gramatyki z pliku
        private void btnLoadGrammar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); //utworzenie dialogu do wyboru pliku
            dlg.Filter = "Pliki tekstowe (*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK) // jesli wybrano plik
            {
                LoadWordsFromFile(dlg.FileName);  //czytaj slowa z pliku do listy
                Recognizer.Instance.CreateGrammarFromList(wordsInDictionary); // stworz i zaladuj gramtyke na podstawie listy
                this.comboBoxWords.DataSource = wordsInDictionary;
                btnStartRecognize.Enabled = true;
                btnRandomWord.Enabled = true;
            }
        }

        private void LoadWordsFromFile(string filePath)
        {
            wordsInDictionary.Clear();
            StreamReader reader = new StreamReader(filePath);
            string word;
            while ((word = reader.ReadLine()) != null)
            {
                wordsInDictionary.Add(word);
            }

        }
        //wybranie slowa z rozwijanej listy
        private void comboBoxWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            wordToSpeach = comboBoxWords.SelectedValue.ToString();
            this.labelWord.Text = wordToSpeach;
            SetZeroScore();
        }
        //zerowanie informacji o wyniku
        private void SetZeroScore()
        {
            this.labelScore.Text = "Wynik: 0 %";
        }
    }
}
