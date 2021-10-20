using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FireFun
{
    public partial class Fun_Hangman : Form
    {
        string word;
        Random rnd = new Random();
        int hanglevel = 1;
        DateTime gameStart;

        List<string> foodWords = new List<string>();
        List<string> animalWords = new List<string>();
        List<string> jobWords = new List<string>();
        List<string> countryWords = new List<string>();
        List<string> nameWords = new List<string>();
        List<string> computerWords = new List<string>();

        List<string> words = new List<string>() { "1", "2", "3" };
        List<string> letters = new List<string>();

        public Fun_Hangman()
        {
            InitializeComponent();
            guna2ComboBox1.SelectedIndex = 0;
            foreach(Control c in pnlGame.Controls)
            {
                if (c.Tag == null) continue;
                if(c is Guna2CircleButton && c.Tag.ToString().StartsWith("answer"))
                {
                    letters.Add(c.Text.ToLower());
                }
            }
        }

        public void PickNewWord()
        {
            label1.Text = string.Empty;
            if (words.Count == 0) RefreshWords(); 
            word = words[rnd.Next(words.Count)];
            words.Remove(word);

            gameStart = DateTime.Now;
            hanglevel = 1;
            pictureBox1.Image = Properties.Resources._1;
            foreach (char z in word)
            {
                if (z == ' ') label1.Text = label1.Text + "  ";
                else label1.Text = label1.Text + "_ ";
            }
            letters.Clear();
            foreach (Control c in pnlGame.Controls)
            {
                if (c.Tag == null) continue;
                if (c is Guna2CircleButton && c.Tag.ToString().StartsWith("answer"))
                {
                    ((Guna2CircleButton)c).Enabled = true;
                    ((Guna2CircleButton)c).Tag = "answer";
                    ((Guna2CircleButton)c).FillColor = Color.FromArgb(94, 148, 255);
                }
            }
            label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            PickNewWord();
        }

        private void ClickLetter(object sender, EventArgs e)
        {
            if (((Guna2CircleButton)sender).Tag.ToString() != "answer") return;
            ((Guna2CircleButton)sender).Tag = "answer-off";
            label1.Text = label1.Text.Replace("_ ", "_");
            label1.Text = label1.Text.Replace("  ", " ");
            int i = -1;
            bool correct = false;
            foreach (char z in word)
            {
                i++;
                if (z.ToString().ToLower() == ((Guna2CircleButton)sender).Text.ToString().ToLower())
                {
                    label1.Text = label1.Text.Remove(i, 1).Insert(i, z.ToString().ToLower());
                    correct = true;
                }
            }

            label1.Text = label1.Text.Replace(" ", "  ");
            label1.Text = label1.Text.Replace("_", "_ ");
            if (label1.Text.Substring(0, label1.Text.Length - 1) == " ") label1.Text = label1.Text.Substring(0, label1.Text.Length - 1);

            if (!correct)
            {
                ((Guna2CircleButton)sender).FillColor = Color.Red;
                wrongGuess();
                return;
            }
            else
            {
                ((Guna2CircleButton)sender).FillColor = Color.Lime;
            }

            if (label1.Text.Replace("  ", " ") == word)
            {
                //GoToMenu();
                GameEnd(true);
            }
        }

        public void GoToGame()
        {
            Utils.AdaptSize(new Size(506, 292), this);
            pnlMenu.Hide();
            pnlGame.Show();
            pnlGame.BringToFront();
        }

        public void GoToMenu()
        {
            Utils.AdaptSize(new Size(350, 350), this);
            pnlMenu.Show();
            pnlGame.Hide();
            pnlMenu.BringToFront();
        }

        public void wrongGuess()
        {
            if (hanglevel == 1) pictureBox1.Image = Properties.Resources._2;
            else if (hanglevel == 2) pictureBox1.Image = Properties.Resources._3;
            else if (hanglevel == 3) pictureBox1.Image = Properties.Resources._4;
            else if (hanglevel == 4) pictureBox1.Image = Properties.Resources._5;
            else if (hanglevel == 5) pictureBox1.Image = Properties.Resources._6;
            else if (hanglevel == 6) 
            {
                pictureBox1.Image = Properties.Resources._7;
                hanglevel = 7;
                GameEnd(false); GoToMenu();
            }
            hanglevel++;
        }

        public void GameEnd(bool win)
        {
            TimeSpan ts = DateTime.Now - gameStart;
            MessageBox.Show("- " + (win ? "Zwycięstwo" : "Porażka") + "! -" + "\n\nZłe odpowiedzi: " + (hanglevel - 1) + "/6\nKategoria gry: " + guna2ComboBox1.SelectedItem.ToString() + "\nHasło: " + word + "\nData: " + string.Format("{0}.{1}.{2}", DateTime.Now.Day.ToString("00"), DateTime.Now.Month.ToString("00"), DateTime.Now.Year) + "\nCzas gry: " + ts.ToString(@"mm\:ss"), "fireFun", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToMenu();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PickNewWord();
            GoToGame();
        }

        public void RefreshWords()
        {
            foodWords = "anyż|algi|ananas|andrut|anyżki|adżika|bezy|bigos|burrito|barszcz|babka|boczek|babeczki|budyń|bułka|czekolada|cannelloni|chaczapuri|chir|czulent|chłodnik|cielęcina|ciastko|ciasto|dorsz|dżem|diablotki|dorada|ekler|empanada|eskalopki|egg-nog|frytki|faworki|fasolka po bretońsku|flaki|frykadele|faszerowane pomidory|gofry|gazpacho|gulasz|gyros|grochówka|garus|gołąbki|gzik|galaretka|golonka|gicz|gęś|hamburger|herbata|herbatniki|hot dog|hummus|hekele|homar|indyk|jabłecznik|jajecznica|jajko|jogurt|jagnięcina|julep|karkówka|kwaśnica|kabanos|kalmar|kasza|kawior|kebab|kimbap|krab|krewetki|kutia|kwas chlebowy|kaczka|kiełbasa|kapuśniak|karp|keks|kompot|kefir|knedel|lablabi|langusta|lazania|legumina|lody|lutenica|leszcz|leczo|langosze|landrynki|lizak|makaron|miód|mititei|mleko|mortadela|muffin|marmolada|mazurek|marcepan|makowiec|majonez|musztarda|mizeria|mule|masło|małż|mortadela|nachosy|naleśniki|natka pietruszki|nerkowiec|nugat|nuggetsy|naleśnik|napoleonka|nóżka z kurczaka|nóżki w galarecie|nigiri sushi|nasiona chia|nać|oscypek|oliebol|ostryga|owsianka|omlet|obwarzanek|owsianka|ocet|oliwa|oponka|na cotta|paprykarz|parmezan|pierogi|pumpernikiel|przepiórka|pstrąg|pita|precel|purée|popcorn|pączek|piernik|ptyś|ratatuj|ragoût|rogal|romesco|risotto|racuch|ravioli|rumtopf|salami|sandacz|sardynka|ser|smalec|szynka|salceson|schab|słonina|szprotka|sznycel|sałatka|salsa|sernik|szarlotka|tiramisu|taco|tatar|tortilla|tost|tuńczyk|twaróg|tortellini|trufla|tabasco|toffi|tort|tarta|uszka|udko|udziec|wanilia|wasabi|wątróbka|wodzionka|wieprzowina|wołowina|węgorz|wata cukrowa|wafelek|zupa|zrazy|zapiekanka|zapiekanka warzywna|ząbek czosnku|ziarno|zupka chińska|zacierka|zalewajka|zasmażka|zielenina|zakwas|zboże|zabajone|zioła prowansalskie|żeberka|żelki|żołędzie jadalne|żółtko|żabie udka|żyto|żurek|żelatyna".Split('|').ToList();
            animalWords = "amur|anakonda zielona|aligator|alpaka|bóbr|byk|biedronka|bocian|bąk|bażant|boa|bizon|baran|czapla siwa|chrząszcz|chomik|czajka|czarna wdowa|czyż|dorsz atlantycki|daniel|delfin|dzik|dziobak|dingo|dikdik|diabeł tasmański|dront dodo|emu|eland|edredon|eskulapa|fenek pustynny|flądra|flaming różowy|foka pospolita|fretka|gołąb miejski|guziec|gepard|goryl|grizly|gęś domowa|gil|gronostaj europejski|hiena cętkowana|hipopotam|homar|halibut|iguana|indyk|ibis|irbis śnieżny|impala|jaguar|jeleń|jastrząb|jeż|jaskółka dymówka|jedwabnik|jeżozwierz|jednorożec|jesiotr ostronosy|jenot|jaszczurka|koala|krowa|koń|kura|kapibara|kaczka|kanczyl srebrzystogrzbiety|kangur|królik|kruk|kalmar|kajman|karaluch|koza domowa|karaś|kormoran|koczkodan|kondor|kaszalot|kret|kot|leszcz|likaon|lama andyjska|legwan zielony|leming|leniwiec|lew|lis|leopard|łabędź|łania|łasica|łęczak|łoś|łosoś|mrówkojad|małpa|mysz|manta|mors|morświn|murena|motyl|małż|mol|makrela|nietoperz|nosorożec|nartnik|narwal|niedźwiedź|norka europejska|nornica ruda|nosacz sundajski|orangutan|okapi|okoń|ocelot|orka oceaniczna|orzeł|ostryga|osa|osioł|ośmiornica|owca domowa|pająk|panda|pantera|papuga|pawian|pelikan|pies|pingwin|puma|pyton tygrysi|rak|rekin|renifer|ropucha|rosomak|rozgwiazda|ryba|rybik|ryś|surykatka|struś|szczur|sęp|sikorka|sarna|sowa|salamandra|szympans|słoń|sokół|szczupak|śledź|śmieszka|świerszcz|świetlik|świnia|świstak|traszka|tygrys|tarantula|truteń|tapir|trzmiel|ukwiał|uszatka|uchatka|ukleja|wombat|wieloryb|wilk|wielbłąd|wąż|wieprz|wół|ważka|wiewiórka|waran|wrona|zebra|zając|zaskroniec|zięba|zimorodek|żyrafa|żuk|żółw|żuraw|żmija|żubroń|żbik|żubr".Split('|').ToList();
            jobWords = "aktor|architekt|aptekarz|anestezjolog|astronauta|arbiter|barista|bibliotekarz|blacharz|barman|brukarz|bramkarz|cieśla|cukiernik|celnik|choreograf|chemik|cyrkowiec|dekarz|dentysta|dermatolog|dietetyk|drwal|dyrygent|elektryk|ekspedient|etnograf|ekonomista|edytor|elektromechanik|fryzjer|farmaceuta|fotograf|farmer|filozof|fizyk|garncarz|górnik|ginekolog|geodeta|geograf|hydraulik|handlowiec|hostessa|hotelarz|higienistka|himalaista|informatyk|ilustrator|inżynier|introligator|iluzjonista|influencer|jubiler|jeździec konny|językoznawca|japonista|jazzman|juror|kasjer|kierowca|kolejarz|kucharz|kominiarz|księgowy|łyżwiarz|ławnik|łucznik|lakiernik|lekarz|lektor|listonosz|lekkoatleta|laryngolog|malarz|marynarz|maszynista|mechanik|murarz|nauczyciel|nurek|neurolog|notariusz|niania|okulista|ogrodnik|ochroniarz|ortopeda|ortodonta|pediatra|piekarz|pielęgniarka|policjant|piłkarz|reżyser|rolnik|rybak|ratownik|rzeźnik|spawacz|sekretarka|strażak|stolarz|sprzątaczka|taksówkarz|tancerz|tynkarz|trener|tapicer|urolog|urbanista|ubezpieczyciel|urzędnik|ulotkarz|weterynarz|wojskowy|woźny|wizażysta|wodzirej|zegarmistrz|złotnik|zdun|zoolog|zecer|żołnierz|żigolak|żeglarz|żużlowiec|żurnalista".Split('|').ToList();
            countryWords = "afganistan|albania|algieria|andora|angola|antigua i barbuda|arabia saudyjska|argentyna|armenia|australia|austria|azerbejdżan|bahamy|bahrajn|bangladesz|barbados|belgia|belize|benin|bhutan|białoruś|boliwia|bośnia i hercegowina|botswana|brazylia|brunei|bułgaria|burkina faso|burundi|chile|chiny|chorwacja|cypr|czad|czarnogóra|czechy|dania|demokratyczna republika konga|dominika|dominikana|dżibuti|egipt|ekwador|erytrea|estonia|eswatini|etiopia|fidżi|filipiny|finlandia|francja|gabon|gambia|ghana|grecja|grenada|gruzja|gujana|gwatemala|gwinea|gwinea bissau|gwinea równikowa|haiti|hiszpania|holandia|honduras|indie|indonezja|irak|iran|irlandia|islandia|izrael|jamajka|japonia|jemen|jordania|kambodża|kamerun|kanada|katar|kazachstan|kenia|kirgistan|kiribati|kolumbia|komory|kongo|korea południowa|korea północna|kostaryka|kuba|kuwejt|laos|lesotho|liban|liberia|libia|liechtenstein|litwa|luksemburg|łotwa|macedonia północna|madagaskar|malawi|malediwy|malezja|mali|malta|maroko|mauretania|mauritius|meksyk|mikronezja|mjanma|mołdawia|monako|mongolia|mozambik|namibia|nauru|nepal|niemcy|niger|nigeria|nikaragua|norwegia|nowa zelandia|oman|pakistan|palau|panama|papua-nowa gwinea|paragwaj|peru|polska|południowa afryka|portugalia|republika środkowoafrykańska|republika zielonego przylądka|rosja|rumunia|rwanda|saint kitts i nevis|saint lucia|saint vincent i grenadyny|salwador|samoa|san marino|senegal|serbia|seszele|sierra leone|singapur|słowacja|słowenia|somalia|sri lanka|stany zjednoczone|sudan|sudan południowy|surinam|syria|szwajcaria|szwecja|tadżykistan|tajlandia|tanzania|timor wschodni|togo|tonga|trynidad i tobago|tunezja|turcja|turkmenistan|tuvalu|uganda|ukraina|urugwaj|uzbekistan|vanuatu|watykan|wenezuela|węgry|wielka brytania|wietnam|włochy|wybrzeże kości słoniowej|wyspy marshalla|wyspy salomona|wyspy świętego tomasza i książęca|zambia|zimbabwe|zjednoczone emiraty arabskie".Split('|').ToList();
            nameWords = "abdon|abel|abelard|abraham|achilles|adam|adelard|adnan|adrian|agapit|agaton|agrypin|ajdin|albert|alan aluś|albin|albrecht|aleks|aleksander|aleksy|alfons|alfred|alojzy|alwin|amadeusz|ambroży|anastazy|ananiasz|anatol|andrzej|anioł|annasz|antoni|antonin|antonius|anzelm|apollo|apoloniusz|ariel|arkadiusz|arkady|arnold|artur|august|augustyn|aurelian|baldwin|baltazar|barabasz|barnim|bartłomiej|bartosz|bazyli|beat|benedykt|beniamin|benon|bernard|bert|błażej|bodosław|bogdał|bogdan|boguchwał|bogumił|bogumir|bogusław|bogusz|bolebor|bolelut|bolesław|bonawentura|bonifacy|borys|borysław|borzywoj|bożan|bożidar|bożydar|bożimir|bromir|bronisław|bruno|brunon|budzisław|cecyl|cecylian|celestyn|cezar|cezary|chociemir|chrystian|chwalibóg|chwalimir|chwalisław|cichosław|ciechosław|cyprian|cyryl|czesław|dajmir|dal|dalbor|damazy|damian|daniel|danisław|danko|dargomir|dargosław|dariusz|darwit|dawid|denis|derwit|dionizy|dobiesław|dobrogost|dobrosław|domasław|dominik|donald|donat|dorian|duszan|dymitr|dyter|dzwonimierz|dżamil|dżan|dżem|dżemil|edgar|edmund|edward|edwin|efraim|efrem|eliasz|eligiusz|eliot|emanuel|emil|emir|erazm|ernest|erwin|eugeniusz|eryk|ewald|ewaryst|ezaw|ezechiel|fabian|farid|faris|faustyn|felicjan|feliks|ferdynand|filip|florentyn|florian|fortunat|franciszek|fryc|fryderyk|gabriel|gabor|gaj|gardomir|gaweł|gerard|gerwazy|gilbert|ginter|gniewomir|gniewosz|godfryg|godfryd|godzisław|gościsław|gracjan|grodzisław|grzegorz|grzymisław|gustaw|gwalbert|gwido|gwidon|hadrian|hamza|hanusz|hasan|hektor|heliodor|henryk|herakles|herbert|herman|hermes|hiacynt|hieronim|hilary|hipolit|honorat|horacy|hubert|hugo|hugon|husajn|idzi|ignacy|igor|ildefons|inocenty|ireneusz|iwan|iwo|iwon|izajasz|izydor|jacek|jacenty|jakub|jan|january|janusz|jarad|jaromir|jaropełk|jarosław|jarowit|jeremiasz|jerzy|jędrzej|joachim|jona|jonasz|jonatan|jozafat|józef|józefat|julian|juliusz|jur|juri|justyn|justynian|jasuf|kacper|kain|kajetan|kajfasz|kajusz|kamil|kanimir|karol|kasjusz|kasper|kastor|kazimierz|kemal|kilian|klaudiusz|klemens|kochan|kondrat|konrad|konradyn|konstancjusz|konstanty|konstantyn|kordian|kornel|korneli|korneliusz|kosma|kryspin|krystian|krystyn|krzesimir|krzesisław|krzysztof|ksawery|kwiatosław|kwietosław|lambert|laurencjusz|lech|lechosław|lenart|leo|leon|leokadiusz|leonard|leopold|lesław|leszek|lew|longin|lubisław|lubogost|lubomił|lubomir|luborad|lubosław|lucjan|ludmił|ludomił|ludolf|ludomir|ludowit|ludwik|ładysław|łazarz|łucjan|łukasz|maciej|magnus|makary|maksymilian|malachiasz|mamert|manfred|manuel|marcel|marceli|marcin|marcjan|marek|marian|marin|mariusz|maryn|mateusz|maurycjusz|maurycy|maurycjusz|medard|melchior|metody|michał|mieszko|mieczysław|mikołaj|milan|miłobąd|miłogost|miłomir|miłorad|miłosław|miłosz|miłowan|miłowit|mirod|miroład|miron|mirosław|mirosz|modest|mojmierz|mojmir|mojżesz|mściwoj|murat|myślimir|napoleon|narcyz|nasif|natan|natanael|nataniel|nestor|nicefor|niecisław|nikodem|norbert|norman|odo|odon|oktawian|oktawiusz|olaf|oleg|olgierd|omar|onufry|oskar|orian|otniel|oswald|otokar|otto|otton|owidiusz|pabian|pafnucy|pakosław|pankracy|paskal|patrycjusz|patryk|paweł|pelagiusz|petroniusz|piotr|placyd|polikarp|prokop|prot|protazy|przemysł|przemysław|przedpełk|przybysław|radogost|radomił|radomir|radosław|radowit|radzimir|rafał|rajmund|rajner|remigiusz|renat|robert|roch|roderyk|roger|roland|roman|romeo|romuald|ronald|rosłan|rudolf|rufus|ryszard|rezi|salomon|samir|sambor|samson|samuel|sebastian|serafin|sergiusz|serwacy|seweryn|sędomir|sędzisław|siemowit|sław|sławek|sławomierz|sławomir|sobiesław|sofroniusz|stanisław|starwit|stefan|stoigniew|stoisław|stojan|strzeżymir|subisław|sulibor|sulisław|sykstus|sylwan|sylwester|sylwiusz|symeon|syriusz|szczepan|szymon|ścibor|świętibor|świętomir|świętopełk|świętosław|tadeusz|tarik|telesfor|teobald|teodor|teodozjusz|teofil|tęgomir|tobiasz|tomasz|tomisław|tristan|tulimir|tulimierz|tymon|tymoteusz|tytus|urban|ursyn|wacław|wahid|waldemar|walenty|walentyn|walerian|walery|walid|walter|wandelin|wawrzyniec|więcesław|wenancjusz|wendelin|wespazjan|wielisław|wiesław|wiktor|wilhelm|wincenty|wirgiliusz|wirginiusz|wisław|wit|witold|witołd|witosław|władysław|włodzimierz|włodzisław|wojciech|wolimir|wojsław|wrocisław|wszebor|zachariasz|zbigniew|zdzisław|zenobiusz|zefir|zefiryn|zenon|ziemowit|zwinisław|zygfryd|zygmunt|zygmunta|żarek|żarko|żelisław|żytomir|abigail|ada|adamina|adela|adelajda|adriana|adrianna|agata|agnieszka|agrypina|afra|aida|aisza|ajna|alberta|albertyna|albina|aldona|aleksa|aleksandra|aleksja|alfreda|alicja|alida|alina|alojza|amalia|amanda|amber|amelia|amina|amira|ana|anastazja|andrea|andrzeja|andżelika|aneta|angela|angelika|angelina|aniel|anita|anna|antonina|anzelma|apollona|apollina|apolonia|arabella|ariadna|arleta|arnolda|astryda|atena|augusta|augustyna|aurelia|aurora|babeta|balbina|barbara|bartłomieja|beata|beatrycja|beatrycze|beatryksa|benedykta|beniamina|berenika|bernarda|bernadeta|berta|betina|bianka|bibiana|blanka|błażena|bogdana|bogna|boguchwała|bogumiła|bogusława|bojana|bolesława|bona|bożena|bromira|bronisława|brunhilda|brygida|cecylia|celestyna|celina|cezaria|cezaryna|chociemira|chwalisława|ciechosława|ciesława|cinosława|cina|czesława|dajmira|dagna|dagmara|dalia|dalila|dalmira|damroka|dana|daniela|danisława|danuta|dargomira|dargosława|daria|dąbrówka|delfina|delia|diana|dilara|dobiesława|domasława|dominika|donata|dorosława|dorota|dyzma|dżanan|dżamila|dżesika|edeltrauda|edyta|eleonora|eliza|elwira|elżbieta|elmira|emanuela|emilia|emina|emma|ernesta|ernestyna|eryka|estera|eugenia|ewa|ewelina|fabia|fabiana|fabiola|farida|fatima|fatma|faustyna|felicja|felicjana|felicyta|feliksa|ferdynanda|filipa|filipina|flora|florentyna|floriana|franciszka|fryderyka|gabriela|gaja|genowefa|gerarda|gertruda|gizela|gloria|gniewomira|gracja|gracjana|grażyna|greta|gryzelda|grzymisława|gustawa|gwidona|hadriana|halina|halszka|hanna|hedwiga|helena|helga|henrieta|henryka|herma|hermana|hermenegilda|hermina|hestia|hiacynta|hilaria|hildegarda|hipolita|honorata|hortensja|huberta|husaria|ida|idosława|idzia|idalia|idzisława|iga, igusia|ildefonsa|ilia|iliana|ilona|ilza|inga|ingeborga|ingryda|irena|iryda|iwa|iwona|izabela|izolda|izydora|jadwiga|jagoda|jana|janina|jarmiła|jaromiła|jaromira|jarosława|jasława|jaśmina|joachima|joanna|jolanta|jowita|józefa|józefina|judyta|julia|julianna|julisława|julita|justyna|juta|kaja|kalina|kamila|karima|karina|karola|karolina|karyna|katarzyna|kasandra|kazimiera|kiara|kiliana|kinga|kira|klara|klarysa|klaudia|klaudyna|klementyna|kleopatra|klotylda|konstancja|kordula|kornelia|koryna|krystiana|krystyna|krzysztofa|ksawera|ksenia|kunegunda|kwiatosława|kwietosława|laila|lajla|lana|larisa|larysa|latifa|laura|laurenjca|lea|lejla|lena|leokadia|leona|leonarda|leoncja|leonora|leopolda|lidia|ligia|lilia|liliana|linda|liwia|lora|luborada|lucjana|lucjola|lucyna|ludmiła|ludolfa|ludwika|ludwina|luiza|luna|lilianna|ładana|ładysława|łagoda|łucja|macieja|magda|magdalena|maja|maksa|maksyma|malina|malwina|małgorzata|manuela|marcela|marcelina|marcjana|marcjanna|maria|mariam|marianna|marietta|marika|mariola|marlena|marta|martyna|maryja|maryla|maryna|marzena|matylda|melania|michalina|mieczysława|milena|milomira|miłosława|miłowita|minerwa|mina|mira|mirabela|miranda|mirela|miriam|mirka|miroda|mirołada|mirosława|mojmira|monika|morzana|morzena|nadia|nadzieja|najmiła|najsława|narcyza|natalia|natasza|nela|nika|nikodema|nikola|nikita|nikoleta|nina|noemi|nora|norberta|norma|oda|odeta|odyla|ofelia|oksana|oktawia|ola|olga|olimpia|oliwia|oriana|ota|otylia|ożanna|olena|pabiana|pamela|patrycja|paula|paulina|pelagia|petra|petronela|petronia|placyda|pola|polmira|przemysława|przybysława|rachela|ramona|radmiła|radomiła|radomira|radosława|rafaela|rajmunda|rajna|raszyda|rebeka|regina|remigia|renata|rita|roberta|rodzisława|roksana|roma|romana|romualda|rozalia|rozalinda|rozamunda|rozetta|rozwita|róża|rudolfina|ruta|ryszarda|sabina|safira|salma|saloma|salomea|samanta|sandra|sara|sebastiana|selena|selma|serafina|seweryna|sędomira|sędzisława|sława|sławina|sławomira|sobiesława|sonia|stamira|stanisława|stefania|stela|stoisława|stella|sydney|strzeżymira|subisława|sulima|sulisława|sybilla|sylwana|sylwia|szarlota|szarlin|szarlina|szejma|szymona|świetlana|świętomira|świętosława|tabita|tacjana|tadea|tamara|tatiana|tekla|telimena|teodora|teodozja|teresa|tęgomira|tina|tolisława|tomiła|tomisława|tulimira|tessa|ulana|ulryka|uma|una|unima|urszula|uta|wacława|walentyna|waleria|wanda|wanessa|wera|weronika|wesna|wiara|wielina|wiera|wierada|wiesława|wiktoria|wilhelmina|wilma|wincentyna|wioleta|wirgilia|wirginia|wisława|witosława|władysława|włodzimiera|wolimira|wrocisława|zaida|zaira|zdzisława|zefiryna|zenobia|zenona|zofia|zoja|zuzanna|zwinisława|zygfryda|zyta|żaklina|żaneta|żanna|żelisława|żużanna|żywia|żywisława".Split('|').ToList();
            computerWords = "chłodzenie all in one|chłodzenie powietrzne|chłodzenie wodne|obudowa|płyta główna|procesor|karta graficzna|ram|ssd|dysk twardy|system operacyjny|zasilacz|wentylatory|dysk optyczny|pasta termoprzewodząca|thermalpad|termopad|klawiatura|głośniki|mysz|słuchawki|karta dźwiękowa|monitor|kamera internetowa|podkładka pod mysz".Split('|').ToList();

            if (guna2ComboBox1.SelectedIndex == 0) { words.Clear(); words.AddRange(computerWords); words.AddRange(nameWords); words.AddRange(countryWords); words.AddRange(jobWords); words.AddRange(animalWords); words.AddRange(computerWords); }
            else if (guna2ComboBox1.SelectedIndex == 1) { words.Clear(); words = foodWords; }
            else if (guna2ComboBox1.SelectedIndex == 2) { words.Clear(); words = animalWords; }
            else if (guna2ComboBox1.SelectedIndex == 3) { words.Clear(); words = jobWords; }
            else if (guna2ComboBox1.SelectedIndex == 4) { words.Clear(); words = countryWords; }
            else if (guna2ComboBox1.SelectedIndex == 5) { words.Clear(); words = nameWords; }
            else if (guna2ComboBox1.SelectedIndex == 6) { words.Clear(); words = computerWords; }

            label2.Text = "Kategoria: " + guna2ComboBox1.SelectedItem.ToString();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshWords();
        }
    }
}
