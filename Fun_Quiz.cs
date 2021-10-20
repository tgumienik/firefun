using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FireFun
{
    public partial class Fun_Quiz : Form
    {
        List<QuizQuestion> questions = new List<QuizQuestion>();

        List<QuizQuestion> mathQuestions = new List<QuizQuestion>();
        List<QuizQuestion> ortoQuestions = new List<QuizQuestion>();
        List<QuizQuestion> geoQuestions = new List<QuizQuestion>();
        List<string> orto = new List<string>();

        Random rnd = new Random();
        string correctAnswer;
        int currentQuestion = 0;
        int questionsInRound = 10;
        int result = 0;
        int index = 0;

        DateTime gameStart;

        Color correctColor = Color.Lime;
        Color incorrectColor = Color.Red;
        Color defaultColor = Color.FromArgb(94, 148, 255);

        ToolTip toolTip = new ToolTip();

        bool inGame = false;

        public Fun_Quiz()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            pnlGame.Location = new Point(0, 0);
            GoMenu();

            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 0;
            toolTip.ReshowDelay = 500;
            toolTip.ShowAlways = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!inGame)
            {
                index = comboBox1.SelectedIndex;
                guna2Button1.Text = "Ładowanie";
                guna2Button1.Enabled = false;
                RefreshQuestions();
                guna2Button1.Text = "Zacznij";
                guna2Button1.Enabled = true;
            }
        }

        public void GoGame()
        {
            Utils.AdaptSize(new Size(419, 699), this);
            pnlGame.BringToFront();
        }

        public void GoMenu()
        {
            Utils.AdaptSize(new Size(414, 394), this);
            pnlMenu.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            inGame = true;
            gameStart = DateTime.Now;

            pnlGame.Location = new Point(0, 0);
            GoGame();
            NextQuestion();
            guna2Button1.Enabled = false;
        }

        private void tmrNextQuestion_Tick(object sender, EventArgs e)
        {
            NextQuestion();
            tmrNextQuestion.Stop();
        }

        public void NextQuestion()
        {
            if (questionsInRound >= currentQuestion + 1)
            {
                currentQuestion++;

                btnAnswer1.FillColor = defaultColor;
                btnAnswer2.FillColor = defaultColor;
                btnAnswer3.FillColor = defaultColor;
                btnAnswer4.FillColor = defaultColor;

                QuizQuestion pytanie = questions[rnd.Next(0, questions.Count)];

                lblPytanieIndex.Text = "Pytanie " + currentQuestion;
                lblPytanie.Text = pytanie.Question;
                imgPytanie.Image = pytanie.Image;
                if (!string.IsNullOrEmpty(pytanie.ImageURL)) imgPytanie.LoadAsync(pytanie.ImageURL);

                string[] allAnswers = pytanie.Answers;
                correctAnswer = pytanie.CorrectAnswer;

                if(!pytanie.DontSort) allAnswers = allAnswers.OrderBy(x => rnd.Next()).ToArray();

                if (pytanie.IncorrectAnswers.Length < 1) { btnAnswer2.Hide(); } else { btnAnswer2.Show(); }
                if (pytanie.IncorrectAnswers.Length < 2) { btnAnswer3.Hide(); } else { btnAnswer3.Show(); }
                if (pytanie.IncorrectAnswers.Length < 3) { btnAnswer4.Hide(); } else { btnAnswer4.Show(); }

                if (btnAnswer1.Visible) btnAnswer1.Text = allAnswers[0];
                if (btnAnswer2.Visible) btnAnswer2.Text = allAnswers[1];
                if (btnAnswer3.Visible) btnAnswer3.Text = allAnswers[2];
                if (btnAnswer4.Visible) btnAnswer4.Text = allAnswers[3];

                if (btnAnswer1.Visible && btnAnswer2.Visible && btnAnswer3.Visible && btnAnswer4.Visible)
                {
                    btnAnswer3.Text = allAnswers[0];
                    btnAnswer4.Text = allAnswers[1];
                    btnAnswer1.Text = allAnswers[2];
                    btnAnswer2.Text = allAnswers[3];
                }

                questions.Remove(pytanie);

                toolTip.RemoveAll();
                if(!string.IsNullOrEmpty(pytanie.Attribution)) toolTip.SetToolTip(imgPytanie, pytanie.Attribution);

                if (questions.Count == 0) RefreshQuestions();

            }
            else
            {
                GoToMenu();
            }
        }

        public void GoToMenu()
        {
            inGame = false;
            tmrNextQuestion.Stop();
            pnlMenu.Location = new Point(0, 0);
            GoMenu();
            guna2Button1.Enabled = true;
            string text = "Mógłbyś trochę potrenować.";
            float calc = ((float)result / (float)questionsInRound) * 100f;
            if (calc >= 40) text = "Coraz lepiej! Ćwicz dalej!";
            if (calc >= 60) text = "No.. Jesteś blisko!";
            if (calc >= 80) text = "Możesz być z siebie dumny!";
            if (calc >= 85) text = "Jesteś mistrzem!";
            if (calc == 100) text = "Wszystko dobrze! Gratulacje!";
            TimeSpan ts = DateTime.Now - gameStart;
            MessageBox.Show("- " + "Koniec gry" + "! -" + "\n\nWynik: " + result + "/" + questionsInRound + "\n" + text + "\nData: " + string.Format("{0}.{1}.{2}", DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year) + "\nCzas gry: " + ts.ToString(@"mm\:ss"), "fireFun", MessageBoxButtons.OK, MessageBoxIcon.Information);
            currentQuestion = 0;
            result = 0;
        }

        private void answerQuestion(object sender, EventArgs e)
        {
            if (btnAnswer1.FillColor == correctColor || btnAnswer2.FillColor == correctColor || btnAnswer3.FillColor == correctColor || btnAnswer4.FillColor == correctColor) return;

            if (btnAnswer1.Visible && btnAnswer1.Text == correctAnswer) btnAnswer1.FillColor = correctColor;
            if (btnAnswer2.Visible && btnAnswer2.Text == correctAnswer) btnAnswer2.FillColor = correctColor;
            if (btnAnswer3.Visible && btnAnswer3.Text == correctAnswer) btnAnswer3.FillColor = correctColor;
            if (btnAnswer4.Visible && btnAnswer4.Text == correctAnswer) btnAnswer4.FillColor = correctColor;
            if (((Guna2Button)sender).Text != correctAnswer) { ((Guna2Button)sender).FillColor = incorrectColor; }
            else { result++; }
            tmrNextQuestion.Start();
        }

        public bool NextBoolean(Random random)
        {
            return random.Next() > (Int32.MaxValue / 2);
        }

        public void RefreshQuestions()
        {
            if (index == 0) {
                mathQuestions.Clear();
                for (int i = 0; i <= Math.Round((decimal)questionsInRound / 2); i++)
                {
                    int a = rnd.Next(50, 500);
                    int b = rnd.Next(25, 250);
                    mathQuestions.Add(new QuizQuestion("Ile to " + a + " + " + b + "?", Properties.Resources.quiz_pic1, (a + b).ToString(), new string[] { ((a - 3) + (b + 7)).ToString(), ((a - 5) + (b + 2)).ToString(), ((a) + (b - 2)).ToString() }, "Web vectors by Vecteezy: https://www.vecteezy.com/free-vector/web", true));
                    a = rnd.Next(50, 500);
                    b = rnd.Next(25, 250);
                    mathQuestions.Add(new QuizQuestion("Ile to " + a + " - " + b + "?", Properties.Resources.quiz_pic1, (a - b).ToString(), new string[] { ((a - 3) - (b + 7)).ToString(), ((a - 5) - (b + 2)).ToString(), ((a) - (b - 2)).ToString() }, "Web vectors by Vecteezy: https://www.vecteezy.com/free-vector/web", true));
                    a = rnd.Next(50, 500);
                    b = rnd.Next(10, 15);
                    mathQuestions.Add(new QuizQuestion("Ile to " + a + " : " + b + "?", Properties.Resources.quiz_pic1, (a / b).ToString(), new string[] { ((a - 3) / (b + 7)).ToString(), ((a - 5) / (b + 2)).ToString(), ((a) / (b - 2)).ToString() }, "Web vectors by Vecteezy: https://www.vecteezy.com/free-vector/web", true));
                }
                questions = mathQuestions;
            } else if (index == 1)
            {
                orto = "że|już|przez|może|ich|który|przed|tu|przy|żeby|potem|też|dobrze|niż|aż|przecież|drzwi|chyba|sposób|razem|także|mój|choć|lub|trzeba|niech|ku|twarz|którego|znowu|tutaj|również|życie|znów|zupełnie|iż|wciąż|jeżeli|trzy|ponieważ|długo|natychmiast|cóż|każdy|wśród|zresztą|chociaż|gdyż|swój|wokół|wrażenie|skąd|dużo|drugi|bowiem|przynajmniej|mężczyzna|mówić|cicho|rzecz|czasem|stąd|wkrótce|dół|pół|całkiem|wówczas|dom|trudno|rzeczywiście|tuż|usta|równie|ciągle|tymczasem|przykład|przede|żaden|twój|powietrze|och|jutro|zatem|ach|czemu|możliwe|mąż|dopóki|wieczorem|dotąd|żona|przedtem|ów|według|zewnątrz|bądź|choćby|król|ostrożnie|spojrzenie|spokój|pokój|chłopiec|wzdłuż|przeciwko|ależ|ból|ciężko|żyć|owszem|dokąd|szczególnie|ruch|jakże|wieczór|uśmiech|długi|chwila|uważnie|chłopak|wyłącznie|zrozumieć|akurat|samochód|naprzód|numer|wrócić|krótko|strach|zapach|wziąć|tłum|toteż|trzydzieści|jednakże|oddech|późno|przeciw|oprócz|zarówno|czyż|chętnie|szukać|mnóstwo|uczucie|południe|poważnie|stamtąd|morze (woda)|może (prawdopodobieństwo)|naturalnie|wewnątrz|problem|stół|gotów|słychać|ksiądz|póki|szczerze|pójść|trzeci|rzadko|przyznać|umysł|historia|patrzeć|przyjaciel|poprzez|podróż|przykro|zarazem|potrzeba|przekonać|udział|otóż|duży|córka|pięćdziesiąt|siedem|nóż|jechać|czyżby|wpół|sytuacja|powstrzymać|dotychczas|krzyk|wierzyć|pośród|zachód|uwierzyć|lekarz|pułkownik|poczucie|północ|osiem|powrót|klucz|ukryć|żal|zatrzymać|przejść|głąb|tysiąc|przyszłość|uczynić|głównie|prócz|absolutnie|brzeg|centrum|zachować|względem|niedługo|punkt|równocześnie|wóz|trzymać|aha|wschód|księżyc|zająć|przestrzeń|głupi|dotrzeć|ucha|niewątpliwie|możliwość|słuchać|spojrzeć|ubranie|śmiech|błąd|korytarz|związek|nazajutrz|utrzymać|przeciwnie|żołnierz|kochanie|chodzić|wuj|system|naprzeciw|uczuć|drzewo|grupa|hrabia|pośrodku|zacząć|duch|przypomnieć|wystarczająco|przyjąć|początkowo|przyjemność|spośród|usłyszeć|wyjątkowo|początek|miesiąc|rząd|hej|łódź|otworzyć|niepokój|umrzeć|kupić|pociąg|porucznik|gorąco|niechętnie|powód|łóżko|dowód|nieruchomo|opuścić|ażeby|odkąd|któryś|krzesło|któż|starzec|przyjść|muzyka|nieustannie|potrzebny|słusznie|dusza|kapelusz|cichy|charakter|czuć|uprzejmie|schody|chory|ponuro|wszakże|dowódca|komuś|lud (osoby)|lód (zimny)|zachowanie|pusty|niebawem|udać|imperium|wygląd|krótki|przypadek|ciężki|spróbować|nauczyć|rzucić|rozumieć|trzej|strażnik|mistrz|towarzystwo|mózg|chleb|sierżant|dach|uciekać|potężny|ciężar|okrzyk|niezależnie|skóra|zauważyć|wódz|służyć|przeważnie|gospodarz|uważać|mur|nawzajem|zwrócić|ucho|wykorzystać|brzuch|gruby|przedmiot|przeżyć|sprzed|kochać|obejrzeć|dwór|kula|wytłumaczyć|uwolnić|autor|sztuka|nastrój|budynek|ruszyć|skutek|szum|świeżo|tytuł".Split('|').ToList();
                ortoQuestions.Clear();
                for (int i = 0; i <= Math.Round((decimal)questionsInRound / 2); i++)
                {
                    string what = "";
                    string item = orto[rnd.Next(orto.Count)];
                    orto.Remove(item);

                    if (item.Length < 3) continue;

                    if (item.Split(' ')[0].Contains("ż") || item.Split(' ')[0].Contains("rz")) what = "rz/ż";
                    else if (item.Split(' ')[0].Contains("h")) what = "ch/h";
                    else if (item.Split(' ')[0].Contains("u") || item.Split(' ')[0].Contains("ó")) what = "u/ó";
                    else if (item.Split(' ')[0].EndsWith("em") || item.Split(' ')[0].EndsWith("ę")) what = "em/ę";
                    else if (item.Split(' ')[0].EndsWith("om") || item.Split(' ')[0].EndsWith("ą")) what = "om/ą";
                    else continue;

                    string itemCensored = item;
                    string correct = "";
                    string[] incorrect = new string[] { "" };

                    if (what == "rz/ż")
                    {
                        if (item.Contains("rz")) { itemCensored = ReplaceFirst(item, "rz", "_"); correct = "rz"; incorrect = new string[] { "ż" }; }
                        else if (item.Contains("ż")) { itemCensored = ReplaceFirst(item, "ż", "_"); correct = "ż"; incorrect = new string[] { "rz" }; }
                    }
                    else if (what == "ch/h")
                    {
                        if (item.Contains("ch")) { itemCensored = ReplaceFirst(item, "ch", "_"); correct = "ch"; incorrect = new string[] { "h" }; }
                        else if (item.Contains("h")) { itemCensored = ReplaceFirst(item, "h", "_"); correct = "h"; incorrect = new string[] { "ch" }; }
                    }
                    else if (what == "u/ó")
                    {
                        if (item.Contains("u")) { itemCensored = ReplaceFirst(item, "u", "_"); correct = "u"; incorrect = new string[] { "ó" }; }
                        else if (item.Contains("ó")) { itemCensored = ReplaceFirst(item, "ó", "_"); correct = "ó"; incorrect = new string[] { "u" }; }
                    }
                    else if (what == "em/ę")
                    {
                        if (item.EndsWith("em")) { itemCensored = ReplaceLast(item, "em", "_"); correct = "em"; incorrect = new string[] { "ę" }; }
                        else if (item.EndsWith("ę")) { itemCensored = ReplaceLast(item, "ę", "_"); correct = "ę"; incorrect = new string[] { "em" }; }
                    }
                    else if (what == "om/ą")
                    {
                        if (item.EndsWith("om")) { itemCensored = ReplaceLast(item, "om", "_"); correct = "om"; incorrect = new string[] { "ą" }; }
                        else if (item.EndsWith("ą")) { itemCensored = ReplaceLast(item, "ą", "_"); correct = "ą"; incorrect = new string[] { "om" }; }
                    }
                    ortoQuestions.Add(new QuizQuestion("Uzupełnij: " + itemCensored, Properties.Resources.quiz_pic2, correct, incorrect, "https://www.zss101.pl/wp-content/uploads/2019/10/z_ortografia_za_pan_brat-1.png"));
                }
                questions = ortoQuestions;
            } else if (index == 2)
            {
                geoQuestions.Clear();
                geoQuestions.Add(new QuizQuestion("W którym stanie USA znajduje się Chimney Rock, jeden z symboli Dzikiego Zachodu?", "https://globalquiz.org/media/pic/300/16215.jpg", "Nebraska", new string[] { "Nevada", "Arizona", "Montana" }));
                geoQuestions.Add(new QuizQuestion("W ilu krajach język włoski jest językiem urzędowym?", "https://globalquiz.org/media/pic/300/4985.jpg", "4", new string[] { "3", "2", "1" }, "", true));
                geoQuestions.Add(new QuizQuestion("Jakie miasto w Unii Europejskiej ma najwięcej mieszkańców?", "https://globalquiz.org/media/pic/300/22090.jpg", "Berlin", new string[] { "Londyn", "Paryż", "Rzym" }));
                geoQuestions.Add(new QuizQuestion("Z iloma krajami Hiszpania dzieli granicę lądową?", "https://globalquiz.org/media/pic/300/1377.jpg", "5", new string[] { "2", "3", "4" }, "", true));
                geoQuestions.Add(new QuizQuestion("Jaka jest największa pustynia w USA, obejmująca prawie 500 000 km²?", "https://www.worldatlas.com/r/w960-q80/upload/3e/c7/d0/shutterstock-143955328.jpg", "Pustynia Great Basin", new string[] { "Pustynia Chihuahuan", "Pustynia Sonoran", "Pustynia Mojave" }));
                geoQuestions.Add(new QuizQuestion("Ile stref czasowych obejmują Indie?", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.downloadclipart.net%2Flarge%2Findia-map-png-photos.png&f=1&nofb=1", "2", new string[] { "1", "3", "4" }, "", true));
                geoQuestions.Add(new QuizQuestion("Który stan w Stanach Zjednoczona zawiera najmniej hrabstw?", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2Ff%2Ff1%2FFlag-map_of_the_United_States.svg%2F1280px-Flag-map_of_the_United_States.svg.png&f=1&nofb=1", "Delaware", new string[] { "Nevada", "Arizona", "Colorado" }));
                geoQuestions.Add(new QuizQuestion("Jaka jest najdłuższa rzeka w Etiopii?", "https://brilliant-ethiopia.imgix.net/blue-nile-falls-1.JPG?auto=format,enhance,compress&fit=crop&crop=faces,edges&w=1200&h=0&q=30", "Nil Błękitny", new string[] { "Takaze", "Auasz", "Nil" }));
                geoQuestions.Add(new QuizQuestion("Jak długi jest Most Brookliński?", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdn.photographylife.com%2Fwp-content%2Fuploads%2F2015%2F08%2FBrook-1-of-1.jpg&f=1&nofb=1", "1,834 m", new string[] { "976 m", "872 m", "1,994 m" }));
                geoQuestions.Add(new QuizQuestion("Który kraj był w przeszłości znany jako Rodezja?", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.clipartbest.com%2Fcliparts%2F4Tb%2FpKE%2F4TbpKEkLc.png&f=1&nofb=1", "Zimbabwe", new string[] { "Sudan", "Nigeria", "Angola" }));
                geoQuestions.Add(new QuizQuestion("Który szkocki loch o długości ok. 24 mil podobno zawiera potwora?", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Loch_Morar.jpg", "Loch Ness", new string[] { "Loch Lomond", "Loch Morar", "Loch Tay" }, "By Lynne Kirton, CC BY-SA 2.0, https://commons.wikimedia.org/w/index.php?curid=447317"));
                geoQuestions.Add(new QuizQuestion("Gdzie odnotowano największą różnicę między rocznymi wysokimi a niskimi temperaturami?", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Feliteptmiami.com%2Fwp-content%2Fuploads%2F2017%2F07%2FHot-Cold.png&f=1&nofb=1", "Rosja", new string[] { "Islandia", "Antarktyka", "Grenlandia" }));
                geoQuestions.Add(new QuizQuestion("W jakim kraju jako pierwsze wyrosły banany?", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.pngpix.com%2Fwp-content%2Fuploads%2F2016%2F03%2FOpen-Banana-PNG-image.png&f=1&nofb=1", "Indie", new string[] { "Norwegia", "Japonia", "Paragwaj" }));
                geoQuestions.Add(new QuizQuestion("Gdzie są największe średnie roczne opady na świecie?", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmassago.ca%2Fwp-content%2Fuploads%2F2018%2F06%2Fblog-post_rain.jpg&f=1&nofb=1", "Hawaje", new string[] { "Indie", "Kostaryka", "Paragwaj" }));
                geoQuestions.Add(new QuizQuestion("Gdzie, z danych w 2009 roku spadły rekordowe roczne opady deszczu na świecie?", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmassago.ca%2Fwp-content%2Fuploads%2F2018%2F06%2Fblog-post_rain.jpg&f=1&nofb=1", "Indie", new string[] { "Peru", "Hawaje", "Kamerun" }));
                geoQuestions.Add(new QuizQuestion("Z jakiego kontynentu wywodzili się nasi wyprostowani przodkowie?", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fpixfeeds.com%2Fimages%2Ftopic%2F3471%2F1200-3471-human-evolution-photo1.jpg&f=1&nofb=1", "Afryka", new string[] { "Europa", "Azja", "Ameryka Północna" }));
                geoQuestions.Add(new QuizQuestion("Nauka tworzenia map nazywa się:", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.newdesignfile.com%2Fpostpic%2F2015%2F01%2Fmap-icons-markers_20960.png&f=1&nofb=1", "Kartografia", new string[] { "Geocaching", "Geologia", "Topografia" }));
                geoQuestions.Add(new QuizQuestion("Które z poniższych jest używane do zbierania, przechowywania i analizowania danych oraz wyświetlania ich na mapie?", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.newdesignfile.com%2Fpostpic%2F2015%2F01%2Fmap-icons-markers_20960.png&f=1&nofb=1", "GIS", new string[] { "GPS", "Teledetekcja", "Fotografia satelitarna" }));
                geoQuestions.Add(new QuizQuestion("Szerokość i długość geograficzna oraz adres są przykładami:", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fmagoosh.com%2Fmath%2Ffiles%2F2018%2F10%2Fshutterstock_1149181886-300x300.jpg&f=1&nofb=1", "Lokalizacji bezwzględna", new string[] { "Względnego położenia", "Miejsca", "Regionu" }));
                geoQuestions.Add(new QuizQuestion("W jakim kraju znajduje się ten niebieski kościół z kopułą?", "https://i.imgur.com/gG2kBZG.png", "Grecja", new string[] { "Wielka Brytania", "Indie", "Chiny" }));
                geoQuestions.Add(new QuizQuestion("Jaka jest stolica Australii?", "https://www.pngall.com/wp-content/uploads/2016/05/Australia-Flag-PNG-File.png", "Canberra", new string[] { "Sydney", "Brisbane", "Perth" }));
                geoQuestions.Add(new QuizQuestion("Jaka jest największa subtropikalna pustynia na świecie?", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fnews.cgtn.com%2Fnews%2F2020-08-27%2FStunning-view-of-China-s-fourth-largest-desert-Ti47kmG9Es%2Fimg%2F0595fd4e2a2e4044bedab8e8287f6ca4%2F0595fd4e2a2e4044bedab8e8287f6ca4.jpeg&f=1&nofb=1", "Sahara", new string[] { "Wielka Pustynia Piaszczysta", "Kalahari", "Kara-Kum" }));
                geoQuestions.Add(new QuizQuestion("Jaka jest stolica Brazylii?", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.tapetus.pl%2Fobrazki%2Fn%2F143854_rio-de-janeiro-brazylia-miasto.jpg&f=1&nofb=1", "Brasília", new string[] { "Rio de Janeiro", "São Paulo", "Belo Horizonte" }));

                questions = geoQuestions;
            }
        }

        public string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }

        public string ReplaceLast(string Source, string Find, string Replace)
        {
            int place = Source.LastIndexOf(Find);

            if (place == -1)
                return Source;

            string result = Source.Remove(place, Find.Length).Insert(place, Replace);
            return result;
        }
    }
}
