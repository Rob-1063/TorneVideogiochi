using System.IO;
using System.Text;
namespace progettoTorneoVideogiochi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Lista sulla quale ogni informazione della struct Giocatore
        List<Giocatore> Partecipante = new List<Giocatore>();

        string Percorsofile = "StampaPartecipanti.txt";
        //dichiarazione struct Videogioco
        struct Videogioco
        {
            public string titolo;
            public string tipologia;
        }
        //dichiarazione struct Giocatore
        struct Giocatore
        {
            public string nome;
            public string cognome;
            public string nickname;
            public int punteggio;
            public Videogioco gioco;

            public string Scrivi()
            {
                return "N: " + nome + " |" + "C: " + cognome + " |" + "Nick: " + nickname + " |" + "Score: " + punteggio + " |" + "Titolo: " + gioco.titolo + " |" + "Tipo: " + gioco.tipologia;
            }

        }

        //funzione per l'assenazione random della variabile punteggio
        int punteggiorandom()
        {
            Random r = new Random();
            int punteggio = r.Next(2000, 200000);
            return punteggio;
        }

        void caricamentolista(Giocatore giocatore, ListBox lst)
        {
            lst.Items.Add("N: " + giocatore.nome + " |" + "C: " + giocatore.cognome + " |" + "Nick: " + giocatore.nickname + " |" + "Score: " + giocatore.punteggio + " |" + "Titolo: " + giocatore.gioco.titolo + " |" + "Tipo: " + giocatore.gioco.tipologia);
            txtnome.Clear();
            txtcognome.Clear();
            txtnickname.Clear();
            txtnomegioco.Clear();
            txttipologiagioco.Clear();
        }
        //Funzione per l'assegnazione dalle text box alle variabili sulla struct Giocatore
        Giocatore salvaP()
        {
            Giocatore informazioneG = new Giocatore();
            informazioneG.nome = txtnome.Text;
            informazioneG.cognome = txtcognome.Text;
            informazioneG.nickname = txtnickname.Text;
            informazioneG.punteggio = punteggiorandom();
            informazioneG.gioco.titolo = txtnomegioco.Text;
            informazioneG.gioco.tipologia = txttipologiagioco.Text;
            return informazioneG;
        }

        //Procedura che stampa tutto quello che c'è scritto nella lista dentro il file
        void SalvaFile()
        {
            if(Partecipante.Count == 0)
            {
                MessageBox.Show("Lista Vuota");
                return;
            }
            try
            {
                using (StreamWriter sw = new StreamWriter(Percorsofile, false))
                {
                    foreach (Giocatore c in Partecipante)
                    {
                        sw.WriteLine(c.Scrivi());
                    }
                }

                MessageBox.Show("Dati salvati con successo nel file");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nel salvataggio dati");
            }
        }

        //Bottone sul quale si salva la lista e la si stampa nella list box 
        private void btncarica_Click(object sender, EventArgs e)
        {
            Giocatore informazioneG = salvaP();
            Partecipante.Add(informazioneG);
            caricamentolista(informazioneG, lstregistrazioneutenti);
        }

        private void btnsalvafile_Click(object sender, EventArgs e)
        {
            SalvaFile();
        }
    }

}
