namespace progettoTorneoVideogiochi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btncarica = new Button();
            txtnome = new TextBox();
            txtcognome = new TextBox();
            txtnickname = new TextBox();
            txttipologiagioco = new TextBox();
            txtnomegioco = new TextBox();
            lblnome = new Label();
            lblcognome = new Label();
            label3 = new Label();
            lbltipgioco = new Label();
            lblnomegioco = new Label();
            lstregistrazioneutenti = new ListBox();
            btnsalvafile = new Button();
            btnimportafile = new Button();
            btnripulirefile = new Button();
            txtcercagioco = new TextBox();
            lblcercagioco = new Label();
            btncercavideogioco = new Button();
            lblprofiligiocatori = new Label();
            txtnomegiocatore = new TextBox();
            picboxprofilogiocatore = new PictureBox();
            lblnomeG = new Label();
            lblcognomeG = new Label();
            label1 = new Label();
            label2 = new Label();
            picboxavatarG = new PictureBox();
            lblnickname = new Label();
            lblinfogioco = new Label();
            lbltipologiaG = new Label();
            lblpunteggioG = new Label();
            btncercaG = new Button();
            lblvideogioconome = new Label();
            lstclassifica = new ListBox();
            lblclassificagioco = new Label();
            txtclassifica = new TextBox();
            label4 = new Label();
            btncreaclassifica = new Button();
            ((System.ComponentModel.ISupportInitialize)picboxprofilogiocatore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxavatarG).BeginInit();
            SuspendLayout();
            // 
            // btncarica
            // 
            btncarica.BackColor = Color.Yellow;
            btncarica.Location = new Point(59, 194);
            btncarica.Name = "btncarica";
            btncarica.Size = new Size(160, 43);
            btncarica.TabIndex = 0;
            btncarica.Text = "CARICA";
            btncarica.UseVisualStyleBackColor = false;
            btncarica.Click += btncarica_Click;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(141, 38);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 1;
            // 
            // txtcognome
            // 
            txtcognome.Location = new Point(141, 67);
            txtcognome.Name = "txtcognome";
            txtcognome.Size = new Size(100, 23);
            txtcognome.TabIndex = 2;
            // 
            // txtnickname
            // 
            txtnickname.Location = new Point(141, 96);
            txtnickname.Name = "txtnickname";
            txtnickname.Size = new Size(100, 23);
            txtnickname.TabIndex = 3;
            // 
            // txttipologiagioco
            // 
            txttipologiagioco.Location = new Point(141, 154);
            txttipologiagioco.Name = "txttipologiagioco";
            txttipologiagioco.Size = new Size(100, 23);
            txttipologiagioco.TabIndex = 4;
            // 
            // txtnomegioco
            // 
            txtnomegioco.Location = new Point(141, 125);
            txtnomegioco.Name = "txtnomegioco";
            txtnomegioco.Size = new Size(100, 23);
            txtnomegioco.TabIndex = 5;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnome.Location = new Point(88, 39);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(47, 17);
            lblnome.TabIndex = 6;
            lblnome.Text = "NOME";
            // 
            // lblcognome
            // 
            lblcognome.AutoSize = true;
            lblcognome.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblcognome.Location = new Point(61, 68);
            lblcognome.Name = "lblcognome";
            lblcognome.Size = new Size(74, 17);
            lblcognome.TabIndex = 7;
            lblcognome.Text = "COGNOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(59, 97);
            label3.Name = "label3";
            label3.Size = new Size(76, 17);
            label3.TabIndex = 8;
            label3.Text = "NICKNAME";
            // 
            // lbltipgioco
            // 
            lbltipgioco.AutoSize = true;
            lbltipgioco.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltipgioco.Location = new Point(13, 160);
            lbltipgioco.Name = "lbltipgioco";
            lbltipgioco.Size = new Size(122, 17);
            lbltipgioco.TabIndex = 9;
            lbltipgioco.Text = "TIPOLOGIA GIOCO";
            // 
            // lblnomegioco
            // 
            lblnomegioco.AutoSize = true;
            lblnomegioco.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblnomegioco.Location = new Point(47, 126);
            lblnomegioco.Name = "lblnomegioco";
            lblnomegioco.Size = new Size(88, 17);
            lblnomegioco.TabIndex = 10;
            lblnomegioco.Text = "NOMEGIOCO";
            // 
            // lstregistrazioneutenti
            // 
            lstregistrazioneutenti.FormattingEnabled = true;
            lstregistrazioneutenti.HorizontalScrollbar = true;
            lstregistrazioneutenti.ItemHeight = 15;
            lstregistrazioneutenti.Location = new Point(260, 29);
            lstregistrazioneutenti.Name = "lstregistrazioneutenti";
            lstregistrazioneutenti.RightToLeft = RightToLeft.No;
            lstregistrazioneutenti.Size = new Size(498, 229);
            lstregistrazioneutenti.TabIndex = 11;
            // 
            // btnsalvafile
            // 
            btnsalvafile.BackColor = Color.LawnGreen;
            btnsalvafile.Location = new Point(260, 264);
            btnsalvafile.Name = "btnsalvafile";
            btnsalvafile.Size = new Size(230, 62);
            btnsalvafile.TabIndex = 12;
            btnsalvafile.Text = "Salva nel file";
            btnsalvafile.UseVisualStyleBackColor = false;
            btnsalvafile.Click += btnsalvafile_Click;
            // 
            // btnimportafile
            // 
            btnimportafile.BackColor = Color.Cyan;
            btnimportafile.Location = new Point(538, 264);
            btnimportafile.Name = "btnimportafile";
            btnimportafile.Size = new Size(220, 62);
            btnimportafile.TabIndex = 13;
            btnimportafile.Text = "Importa nel file";
            btnimportafile.UseVisualStyleBackColor = false;
            btnimportafile.Click += btnimportafile_Click;
            // 
            // btnripulirefile
            // 
            btnripulirefile.Location = new Point(1198, 798);
            btnripulirefile.Name = "btnripulirefile";
            btnripulirefile.Size = new Size(159, 52);
            btnripulirefile.TabIndex = 14;
            btnripulirefile.Text = "RIPULIRE FILE";
            btnripulirefile.UseVisualStyleBackColor = true;
            btnripulirefile.Click += btnripulirefile_Click;
            // 
            // txtcercagioco
            // 
            txtcercagioco.Location = new Point(37, 361);
            txtcercagioco.Name = "txtcercagioco";
            txtcercagioco.Size = new Size(239, 23);
            txtcercagioco.TabIndex = 15;
            // 
            // lblcercagioco
            // 
            lblcercagioco.AutoSize = true;
            lblcercagioco.Location = new Point(37, 343);
            lblcercagioco.Name = "lblcercagioco";
            lblcercagioco.Size = new Size(204, 15);
            lblcercagioco.TabIndex = 16;
            lblcercagioco.Text = "Inserisci il nome del gioco da cercare:";
            // 
            // btncercavideogioco
            // 
            btncercavideogioco.Location = new Point(292, 343);
            btncercavideogioco.Name = "btncercavideogioco";
            btncercavideogioco.Size = new Size(108, 41);
            btncercavideogioco.TabIndex = 17;
            btncercavideogioco.Text = "CERCA";
            btncercavideogioco.UseVisualStyleBackColor = true;
            btncercavideogioco.Click += btncercavideogioco_Click;
            // 
            // lblprofiligiocatori
            // 
            lblprofiligiocatori.AutoSize = true;
            lblprofiligiocatori.Location = new Point(861, 80);
            lblprofiligiocatori.Name = "lblprofiligiocatori";
            lblprofiligiocatori.Size = new Size(246, 15);
            lblprofiligiocatori.TabIndex = 18;
            lblprofiligiocatori.Text = "Ricerca profilo giocatore attraverso nickname";
            // 
            // txtnomegiocatore
            // 
            txtnomegiocatore.Location = new Point(895, 98);
            txtnomegiocatore.Name = "txtnomegiocatore";
            txtnomegiocatore.Size = new Size(177, 23);
            txtnomegiocatore.TabIndex = 19;
            // 
            // picboxprofilogiocatore
            // 
            picboxprofilogiocatore.Image = (Image)resources.GetObject("picboxprofilogiocatore.Image");
            picboxprofilogiocatore.Location = new Point(839, 127);
            picboxprofilogiocatore.Name = "picboxprofilogiocatore";
            picboxprofilogiocatore.Size = new Size(319, 291);
            picboxprofilogiocatore.TabIndex = 20;
            picboxprofilogiocatore.TabStop = false;
            // 
            // lblnomeG
            // 
            lblnomeG.AutoSize = true;
            lblnomeG.BackColor = Color.Black;
            lblnomeG.ForeColor = Color.AliceBlue;
            lblnomeG.Location = new Point(853, 179);
            lblnomeG.Name = "lblnomeG";
            lblnomeG.Size = new Size(12, 15);
            lblnomeG.TabIndex = 21;
            lblnomeG.Text = "-";
            // 
            // lblcognomeG
            // 
            lblcognomeG.AutoSize = true;
            lblcognomeG.BackColor = Color.Black;
            lblcognomeG.ForeColor = Color.AliceBlue;
            lblcognomeG.Location = new Point(853, 208);
            lblcognomeG.Name = "lblcognomeG";
            lblcognomeG.Size = new Size(12, 15);
            lblcognomeG.TabIndex = 22;
            lblcognomeG.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(853, 151);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 23;
            label1.Text = "DATI PERSONALI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(852, 235);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 24;
            label2.Text = "NOME IN GIOCO:";
            // 
            // picboxavatarG
            // 
            picboxavatarG.BackColor = Color.Transparent;
            picboxavatarG.BackgroundImageLayout = ImageLayout.None;
            picboxavatarG.Image = (Image)resources.GetObject("picboxavatarG.Image");
            picboxavatarG.Location = new Point(1042, 141);
            picboxavatarG.Name = "picboxavatarG";
            picboxavatarG.Size = new Size(98, 96);
            picboxavatarG.SizeMode = PictureBoxSizeMode.CenterImage;
            picboxavatarG.TabIndex = 25;
            picboxavatarG.TabStop = false;
            // 
            // lblnickname
            // 
            lblnickname.AutoSize = true;
            lblnickname.BackColor = Color.Black;
            lblnickname.ForeColor = Color.AliceBlue;
            lblnickname.Location = new Point(853, 264);
            lblnickname.Name = "lblnickname";
            lblnickname.Size = new Size(12, 15);
            lblnickname.TabIndex = 26;
            lblnickname.Text = "-";
            // 
            // lblinfogioco
            // 
            lblinfogioco.AutoSize = true;
            lblinfogioco.BackColor = Color.Black;
            lblinfogioco.Font = new Font("Sitka Heading", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblinfogioco.ForeColor = Color.AliceBlue;
            lblinfogioco.Location = new Point(853, 303);
            lblinfogioco.Name = "lblinfogioco";
            lblinfogioco.Size = new Size(181, 23);
            lblinfogioco.TabIndex = 27;
            lblinfogioco.Text = "INFORMAZIONI GIOCO:";
            // 
            // lbltipologiaG
            // 
            lbltipologiaG.AutoSize = true;
            lbltipologiaG.BackColor = Color.Black;
            lbltipologiaG.ForeColor = Color.AliceBlue;
            lbltipologiaG.Location = new Point(853, 386);
            lbltipologiaG.Name = "lbltipologiaG";
            lbltipologiaG.Size = new Size(12, 15);
            lbltipologiaG.TabIndex = 28;
            lbltipologiaG.Text = "-";
            // 
            // lblpunteggioG
            // 
            lblpunteggioG.AutoSize = true;
            lblpunteggioG.BackColor = Color.Black;
            lblpunteggioG.ForeColor = Color.AliceBlue;
            lblpunteggioG.Location = new Point(853, 356);
            lblpunteggioG.Name = "lblpunteggioG";
            lblpunteggioG.Size = new Size(12, 15);
            lblpunteggioG.TabIndex = 29;
            lblpunteggioG.Text = "-";
            // 
            // btncercaG
            // 
            btncercaG.Location = new Point(1114, 80);
            btncercaG.Name = "btncercaG";
            btncercaG.Size = new Size(105, 41);
            btncercaG.TabIndex = 30;
            btncercaG.Text = "CERCA GIOCATORE";
            btncercaG.UseVisualStyleBackColor = true;
            btncercaG.Click += btncercaG_Click;
            // 
            // lblvideogioconome
            // 
            lblvideogioconome.AutoSize = true;
            lblvideogioconome.BackColor = Color.Black;
            lblvideogioconome.ForeColor = Color.AliceBlue;
            lblvideogioconome.Location = new Point(853, 326);
            lblvideogioconome.Name = "lblvideogioconome";
            lblvideogioconome.Size = new Size(12, 15);
            lblvideogioconome.TabIndex = 31;
            lblvideogioconome.Text = "-";
            // 
            // lstclassifica
            // 
            lstclassifica.FormattingEnabled = true;
            lstclassifica.ItemHeight = 15;
            lstclassifica.Location = new Point(51, 456);
            lstclassifica.Name = "lstclassifica";
            lstclassifica.Size = new Size(333, 229);
            lstclassifica.TabIndex = 33;
            // 
            // lblclassificagioco
            // 
            lblclassificagioco.AutoSize = true;
            lblclassificagioco.Location = new Point(54, 438);
            lblclassificagioco.Name = "lblclassificagioco";
            lblclassificagioco.Size = new Size(183, 15);
            lblclassificagioco.TabIndex = 34;
            lblclassificagioco.Text = "CLASSIFICA DI UN CERTO GIOCO:";
            // 
            // txtclassifica
            // 
            txtclassifica.Location = new Point(401, 533);
            txtclassifica.Name = "txtclassifica";
            txtclassifica.Size = new Size(329, 23);
            txtclassifica.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 515);
            label4.Name = "label4";
            label4.Size = new Size(329, 15);
            label4.TabIndex = 36;
            label4.Text = "INSERIRE IL NOME DEL GIOCO PER FORMARE LA CLASSIFICA";
            // 
            // btncreaclassifica
            // 
            btncreaclassifica.Location = new Point(464, 562);
            btncreaclassifica.Name = "btncreaclassifica";
            btncreaclassifica.Size = new Size(205, 58);
            btncreaclassifica.TabIndex = 37;
            btncreaclassifica.Text = "CREA CLASSIFICA";
            btncreaclassifica.UseVisualStyleBackColor = true;
            btncreaclassifica.Click += btncreaclassifica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1369, 862);
            Controls.Add(btncreaclassifica);
            Controls.Add(label4);
            Controls.Add(txtclassifica);
            Controls.Add(lblclassificagioco);
            Controls.Add(lstclassifica);
            Controls.Add(lblvideogioconome);
            Controls.Add(btncercaG);
            Controls.Add(lblpunteggioG);
            Controls.Add(lbltipologiaG);
            Controls.Add(lblinfogioco);
            Controls.Add(lblnickname);
            Controls.Add(picboxavatarG);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblcognomeG);
            Controls.Add(lblnomeG);
            Controls.Add(picboxprofilogiocatore);
            Controls.Add(txtnomegiocatore);
            Controls.Add(lblprofiligiocatori);
            Controls.Add(btncercavideogioco);
            Controls.Add(lblcercagioco);
            Controls.Add(txtcercagioco);
            Controls.Add(btnripulirefile);
            Controls.Add(btnimportafile);
            Controls.Add(btnsalvafile);
            Controls.Add(lstregistrazioneutenti);
            Controls.Add(lblnomegioco);
            Controls.Add(lbltipgioco);
            Controls.Add(label3);
            Controls.Add(lblcognome);
            Controls.Add(lblnome);
            Controls.Add(txtnomegioco);
            Controls.Add(txttipologiagioco);
            Controls.Add(txtnickname);
            Controls.Add(txtcognome);
            Controls.Add(txtnome);
            Controls.Add(btncarica);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)picboxprofilogiocatore).EndInit();
            ((System.ComponentModel.ISupportInitialize)picboxavatarG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncarica;
        private TextBox txtnome;
        private TextBox txtcognome;
        private TextBox txtnickname;
        private TextBox txttipologiagioco;
        private TextBox txtnomegioco;
        private Label lblnome;
        private Label lblcognome;
        private Label label3;
        private Label lbltipgioco;
        private Label lblnomegioco;
        private ListBox lstregistrazioneutenti;
        private Button btnsalvafile;
        private Button btnimportafile;
        private Button btnripulirefile;
        private TextBox txtcercagioco;
        private Label lblcercagioco;
        private Button btncercavideogioco;
        private Label lblprofiligiocatori;
        private TextBox txtnomegiocatore;
        private PictureBox picboxprofilogiocatore;
        private Label lblnomeG;
        private Label lblcognomeG;
        private Label label1;
        private Label label2;
        private PictureBox picboxavatarG;
        private Label lblnickname;
        private Label lblinfogioco;
        private Label lbltipologiaG;
        private Label lblpunteggioG;
        private Button btncercaG;
        private Label lblvideogioconome;
        private ListBox lstclassifica;
        private Label lblclassificagioco;
        private TextBox txtclassifica;
        private Label label4;
        private Button btncreaclassifica;
    }
}
