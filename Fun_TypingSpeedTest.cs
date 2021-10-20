using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireFun
{
    public partial class Fun_TypingSpeedTest : Form
    {

        List<long> times = new List<long>();
        List<string> texts = new List<string>();
        List<string> words = new List<string>();
        List<long> typingSpeeds = new List<long>();
        DateTime gameStart;
        int timer;
        int characters = 0;
        int charsPerSec = 0;
        int lastSec = 0;
        int spelledWords = 0;
        int topTypingSpeed = 0;
        Random rnd = new Random();
        DateTime appStart = DateTime.Now;

        public Fun_TypingSpeedTest()
        {
            InitializeComponent();
            GoToMenu();
        }

        public int GetDefaultTime()
        {
            return 60 * 1000;
        }

        public void RefreshTexts()
        {
            texts = "że|już|przez|może|ich|który|przed|tu|przy|żeby|potem|też|u|dobrze|niż|aż|przecież|drzwi|chyba|sposób|razem|także|mój|choć|lub|trzeba|niech|ku|twarz|którego|znowu|tutaj|również|życie|znów|zupełnie|iż|wciąż|jeżeli|trzy|ponieważ|długo|natychmiast|cóż|każdy|wśród|zresztą|chociaż|gdyż|swój|wokół|wrażenie|skąd|dużo|drugi|bowiem|przynajmniej|mężczyzna|mówić|cicho|rzecz|czasem|stąd|wkrótce|dół|pół|całkiem|wówczas|dom|trudno|rzeczywiście|tuż|usta|równie|ciągle|tymczasem|przykład|przede|żaden|twój|powietrze|och|jutro|zatem|ach|czemu|możliwe|mąż|dopóki|wieczorem|dotąd|żona|przedtem|ów|według|zewnątrz|bądź|choćby|król|ostrożnie|spojrzenie|spokój|pokój|chłopiec|wzdłuż|przeciwko|ależ|ból|ciężko|żyć|owszem|dokąd|szczególnie|ruch|jakże|wieczór|uśmiech|długi|chwila|uważnie|chłopak|wyłącznie|zrozumieć|akurat|samochód|naprzód|numer|wrócić|krótko|strach|zapach|wziąć|tłum|toteż|trzydzieści|jednakże|oddech|późno|przeciw|oprócz|zarówno|czyż|chętnie|szukać|mnóstwo|uczucie|południe|poważnie|stamtąd|morze|może|naturalnie|wewnątrz|problem|stół|gotów|słychać|ksiądz|póki|szczerze|pójść|trzeci|rzadko|przyznać|umysł|historia|patrzeć|przyjaciel|poprzez|podróż|przykro|zarazem|potrzeba|przekonać|udział|tom|otóż|duży|córka|pięćdziesiąt|siedem|nóż|jechać|czyżby|wpół|sytuacja|powstrzymać|dotychczas|krzyk|wierzyć|pośród|zachód|uwierzyć|lekarz|pułkownik|poczucie|północ|osiem|powrót|klucz|ukryć|żal|zatrzymać|przejść|głąb|tysiąc|przyszłość|uczynić|głównie|prócz|absolutnie|brzeg|centrum|zachować|względem|niedługo|punkt|równocześnie|wóz|trzymać|aha|wschód|księżyc|zająć|przestrzeń|głupi|dotrzeć|ucha|niewątpliwie|możliwość|słuchać|spojrzeć|ubranie|śmiech|błąd|korytarz|związek|nazajutrz|utrzymać|przeciwnie|żołnierz|kochanie|chodzić|wuj|system|naprzeciw|uczuć|drzewo|grupa|hrabia|pośrodku|zacząć|duch|przypomnieć|wystarczająco|przyjąć|początkowo|przyjemność|spośród|usłyszeć|wyjątkowo|początek|miesiąc|rząd|hej|łódź|otworzyć|niepokój|umrzeć|kupić|pociąg|porucznik|gorąco|niechętnie|powód|łóżko|dowód|nieruchomo|opuścić|ażeby|odkąd|któryś|krzesło|któż|starzec|przyjść|muzyka|nieustannie|potrzebny|słusznie|dusza|kapelusz|cichy|charakter|czuć|uprzejmie|schody|chory|ponuro|wszakże|dowódca|komuś|lud|lód|zachowanie|pusty|niebawem|udać|imperium|wygląd|krótki|przypadek|ciężki|spróbować|nauczyć|rzucić|rozumieć|trzej|strażnik|mistrz|towarzystwo|mózg|chleb|sierżant|dach|uciekać|potężny|ciężar|okrzyk|niezależnie|skóra|zauważyć|wódz|służyć|przeważnie|gospodarz|uważać|mur|nawzajem|zwrócić|ucho|wykorzystać|brzuch|gruby|przedmiot|przeżyć|sprzed|kochać|obejrzeć|dwór|kula|wytłumaczyć|uwolnić|autor|sztuka|nastrój|budynek|ruszyć|skutek|szum|świeżo|tytuł".Split('|').ToList();
        }

        public void PickNewText()
        {
            while (words.Count < 50)
            {
                words.Add(GetWord());
            }
            label1.Text = string.Join(" ", words);
            label3.Text = words[0];
        }

        public string GetWord()
        {
            return texts[rnd.Next(texts.Count)];
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            timer = timer - 250;
            if(timer <= 0)
            {
                EndGame();
            }

            TimeSpan ts = TimeSpan.FromMilliseconds(timer);
            label6.Text = ts.ToString(@"mm\:ss");
        }

        public string getSubStr(string str, int N)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }

            return str.Substring(0, Math.Min(str.Length, N));
        }

        public void StartGame()
        {
            tmrTime.Start();
            gameStart = DateTime.Now;
            timer1.Start();
            typingSpeeds.Clear();
            spelledWords = 0;
            timer = GetDefaultTime();
            RefreshTexts();
            PickNewText();
            GoToGame();
        }

        public void EndGame()
        {
            tmrTime.Stop();
            timer1.Stop();
            GoToMenu();

            long avgTypingSpeed = 0;
            foreach(long z in typingSpeeds)
            {
                avgTypingSpeed = avgTypingSpeed + z;
            }
            if(typingSpeeds.Count != 0) avgTypingSpeed = avgTypingSpeed / typingSpeeds.Count;

            TimeSpan ts = DateTime.Now - gameStart;
            MessageBox.Show("- " + "Koniec gry" + "! -" + "\n\nNapisane znaki: " + characters + "\nNapisane słowa: " + spelledWords + "\nŚrednia szybkość pisania: " + avgTypingSpeed + " WPM" + "\nNajwyższa szybkość pisania: " + topTypingSpeed + " WPM\nData: " + string.Format("{0}.{1}.{2}", DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year) + "\nCzas gry: " + ts.ToString(@"mm\:ss"), "fireFun", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void GoToGame()
        {
            Utils.AdaptSize(new Size(590, 389), this);
            textBox1.Select();
            pnlGame.Show();
            pnlGame.BringToFront();
        }
        public void GoToMenu()
        {
            Utils.AdaptSize(new Size(415, 438), this);
            pnlGame.Hide();
            pnlMenu.BringToFront();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text == " ")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == words[0])
            {
                win();
            }
            if(getSubStr(label1.Text, textBox1.TextLength) == getSubStr(textBox1.Text, textBox1.TextLength))
            {
                characters++;
                charsPerSec++;
            }
        }

        public long GetTimeDifference()
        {
            return (DateTime.Now - appStart).Milliseconds;
        }

        public void win()
        {
            words.RemoveAt(0);
            spelledWords++;
            label1.Text = string.Join(" ", words);
            PickNewText();
            textBox1.Text = "";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lastSec = (charsPerSec + lastSec) / 2;
            charsPerSec = 0;
            label4.Text = (lastSec * 60 / 5).ToString();
            if ((lastSec * 60 / 5) != 0) typingSpeeds.Add((lastSec * 60 / 5));
            if ((lastSec * 60 / 5) > topTypingSpeed) topTypingSpeed = (lastSec * 60 / 5);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
