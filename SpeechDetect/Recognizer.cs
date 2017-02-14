using Microsoft.Speech.Recognition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechDetect
{
    // singleton zawierajacy w sobie silnik rozpoznawania mowy
    public sealed class Recognizer 
    {
        private static Recognizer instance = null;
        private static readonly object objLock = new object();

        private SpeechRecognitionEngine sre; //silnik rozponawania mowy
        private Recognizer()
        {
            sre = new SpeechRecognitionEngine(System.Globalization.CultureInfo.CurrentCulture); //utworzenie silnika dla aktualnego jezyka systemu
            sre.SpeechRecognized += sre_SpeechRecognized; // podpiecie eventow
            sre.SpeechRecognitionRejected += sre_SpeechRejected;
        }

        //implentacja singleton'a
        public static Recognizer Instance 
        {
            get
            {
                lock(objLock)
                {
                    if (instance == null)
                    {
                        instance = new Recognizer();
                    }
                }
                return instance;
            }
        }


        //rozpoczecie rozpoznawania mowy
        public void StartRecognize()
        {
            sre.SetInputToDefaultAudioDevice(); //ustawienie wejscia na domyslne urzadzenie
            sre.RecognizeAsync(RecognizeMode.Single); //start rozpoznawania w trybie rozopoznawania tylko jednego slowa
        }
        //utworzenie gramatyki na podstawie listy slow
        public void CreateGrammarFromList(List<string> words)
        {
            Choices c = new Choices(words.ToArray());
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(c);
            sre.UnloadAllGrammars();
            sre.LoadGrammar(new Grammar(gb));
        }

        #region Events
        //utworzenie odpowiednich eventow w celu umozliwienia stosowania ich poza klasa
        public event EventHandler<SpeechRecognizedEventArgs> SpeechRecognized;
        private void OnSpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (SpeechRecognized != null)
            {
                SpeechRecognized(sender, e);
            }
        }

        public event EventHandler<SpeechRecognitionRejectedEventArgs> SpeechRejected;
        private void OnSpeechRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            if (SpeechRejected != null)
            {
                SpeechRejected(sender, e);
            }
        }
        //obsluga eventow silnika, wywolanie wlasnych eventow
        private void sre_SpeechRejected(object sender, SpeechRecognitionRejectedEventArgs e)
        {
            OnSpeechRejected(sender, e);
        }

        private void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            OnSpeechRecognized(sender, e);
        }
        #endregion

    }
}
