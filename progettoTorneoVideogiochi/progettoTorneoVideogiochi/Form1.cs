using System.Collections.Generic;
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
        string PercorsoFilePartecGioco = "StampaPartecipantiAdUnGioco.txt";
        string PercorsoFileGiocatore = "StampaInfoGiocatore.txt";
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

            File.WriteAllText(Percorsofile, String.Empty);
            if (Partecipante.Count == 0)
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
        //Procedura che permette di importate tutte le informazioni nel file dei partecipanti dentro la lista
        void importafile()
        {
            string percorsoFile = "StampaPartecipanti.txt";
            if (!File.Exists(percorsoFile))
            {
                MessageBox.Show("File non trovato!");
            }
            try
            {
                Partecipante.Clear();
                lstregistrazioneutenti.Items.Clear();

                using (StreamReader sr = new StreamReader(percorsoFile))
                {
                    string riga;

                    while ((riga = sr.ReadLine()) != null)
                    {

                        if (!string.IsNullOrWhiteSpace(riga))
                        {
                            string[] pezzi = riga.Split('|');
                            if (pezzi.Length == 6)
                            {
                                Giocatore giocatore = new Giocatore();
                                //solo in questa parte abbiamo usato l'IA
                                giocatore.nome = pezzi[0].Replace("N:", "").Trim();
                                giocatore.cognome = pezzi[1].Replace("C:", "").Trim();
                                giocatore.nickname = pezzi[2].Replace("Nick:", "").Trim();
                                giocatore.punteggio = int.Parse(pezzi[3].Replace("Score:", "").Trim());
                                giocatore.gioco.titolo = pezzi[4].Replace("Titolo:", "").Trim();
                                giocatore.gioco.tipologia = pezzi[5].Replace("Tipo:", "").Trim();
                                //--------------------------------------------------------------
                                Partecipante.Add(giocatore);
                                lstregistrazioneutenti.Items.Add("N: " + giocatore.nome + " |" + "C: " + giocatore.cognome + " |" + "Nick: " + giocatore.nickname + " |" + "Score: " + giocatore.punteggio + " |" + "Titolo: " + giocatore.gioco.titolo + " |" + "Tipo: " + giocatore.gioco.tipologia);
                            }
                        }
                    }
                }
                MessageBox.Show("Dati caricati nella lista concatenata!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante la lettura!" + ex.Message);
            }
        }

        void cercaVideogioco()
        {
            lstregistrazioneutenti.Items.Clear();
            foreach (Giocatore g in Partecipante)
            {
                if (g.gioco.titolo == txtcercagioco.Text)
                {

                    lstregistrazioneutenti.Items.Add(g.Scrivi());
                    File.WriteAllText(PercorsoFilePartecGioco, String.Empty);
                    if (Partecipante.Count == 0)
                    {
                        MessageBox.Show("Lista Vuota");
                        return;
                    }
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(PercorsoFilePartecGioco, false))
                        {
                            sw.WriteLine(g.Scrivi());
                        }

                        MessageBox.Show("Dati salvati con successo nel file");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore nel salvataggio dati");
                    }
                }
            }
        }

        void CercaGiocatore()
        {
            foreach(Giocatore g in Partecipante)
            {
                if (g.nickname == txtnomegiocatore.Text)
                {
                    lblnomeG.Text = g.nome;
                    lblcognomeG.Text = g.cognome;
                    lblnickname.Text= g.nickname;
                    lblpunteggioG.Text = Convert.ToString(g.punteggio);
                    lbltipologiaG.Text = g.gioco.tipologia;
                    lblvideogioconome.Text = g.gioco.titolo;

                    File.WriteAllText(PercorsoFileGiocatore, String.Empty);
                    if (Partecipante.Count == 0)
                    {
                        MessageBox.Show("Lista Vuota");
                        return;
                    }
                    try
                    {
                        using (StreamWriter sw = new StreamWriter(PercorsoFileGiocatore, false))
                        {
                            sw.WriteLine(g.Scrivi());
                        }

                        MessageBox.Show("Dati salvati con successo nel file");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Errore nel salvataggio dati");
                    }
                }
            }
        }

        void PulisciLabel()
        {

            lblnomeG.Text = string.Empty;
            lblcognomeG.Text = string.Empty;
            lblnickname.Text = string.Empty;
            lblpunteggioG.Text = string.Empty;
            lbltipologiaG.Text = string.Empty;
            lblvideogioconome.Text = string.Empty;
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
            lstregistrazioneutenti.Items.Clear();
            SalvaFile();
        }

        private void btnimportafile_Click(object sender, EventArgs e)
        {
            lstregistrazioneutenti.Items.Clear();
            importafile();
        }

        private void btncercavideogioco_Click(object sender, EventArgs e)
        {
            cercaVideogioco();
        }

        private void btnripulirefile_Click(object sender, EventArgs e)
        {
            File.WriteAllText(Percorsofile, String.Empty);
        }

        private void btncercaG_Click(object sender, EventArgs e)
        {
            PulisciLabel();
            CercaGiocatore();
        }
    }

}
