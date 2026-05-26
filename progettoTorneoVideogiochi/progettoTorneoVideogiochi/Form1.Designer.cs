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
            ((System.ComponentModel.ISupportInitialize)picboxprofilogiocatore).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picboxavatarG).BeginInit();
            SuspendLayout();
            // 
            // btncarica
            // 
            btncarica.Location = new Point(51, 194);
            btncarica.Name = "btncarica";
            btncarica.Size = new Size(160, 43);
            btncarica.TabIndex = 0;
            btncarica.Text = "CARICA";
            btncarica.UseVisualStyleBackColor = true;
            btncarica.Click += btncarica_Click;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(125, 40);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 1;
            // 
            // txtcognome
            // 
            txtcognome.Location = new Point(125, 69);
            txtcognome.Name = "txtcognome";
            txtcognome.Size = new Size(100, 23);
            txtcognome.TabIndex = 2;
            // 
            // txtnickname
            // 
            txtnickname.Location = new Point(125, 98);
            txtnickname.Name = "txtnickname";
            txtnickname.Size = new Size(100, 23);
            txtnickname.TabIndex = 3;
            // 
            // txttipologiagioco
            // 
            txttipologiagioco.Location = new Point(125, 156);
            txttipologiagioco.Name = "txttipologiagioco";
            txttipologiagioco.Size = new Size(100, 23);
            txttipologiagioco.TabIndex = 4;
            // 
            // txtnomegioco
            // 
            txtnomegioco.Location = new Point(125, 127);
            txtnomegioco.Name = "txtnomegioco";
            txtnomegioco.Size = new Size(100, 23);
            txtnomegioco.TabIndex = 5;
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Location = new Point(77, 43);
            lblnome.Name = "lblnome";
            lblnome.Size = new Size(42, 15);
            lblnome.TabIndex = 6;
            lblnome.Text = "NOME";
            // 
            // lblcognome
            // 
            lblcognome.AutoSize = true;
            lblcognome.Location = new Point(52, 72);
            lblcognome.Name = "lblcognome";
            lblcognome.Size = new Size(67, 15);
            lblcognome.TabIndex = 7;
            lblcognome.Text = "COGNOME";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 101);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 8;
            label3.Text = "NICKNAME";
            // 
            // lbltipgioco
            // 
            lbltipgioco.AutoSize = true;
            lbltipgioco.Location = new Point(13, 159);
            lbltipgioco.Name = "lbltipgioco";
            lbltipgioco.Size = new Size(107, 15);
            lbltipgioco.TabIndex = 9;
            lbltipgioco.Text = "TIPOLOGIA GIOCO";
            // 
            // lblnomegioco
            // 
            lblnomegioco.AutoSize = true;
            lblnomegioco.Location = new Point(40, 130);
            lblnomegioco.Name = "lblnomegioco";
            lblnomegioco.Size = new Size(79, 15);
            lblnomegioco.TabIndex = 10;
            lblnomegioco.Text = "NOMEGIOCO";
            // 
            // lstregistrazioneutenti
            // 
            lstregistrazioneutenti.FormattingEnabled = true;
            lstregistrazioneutenti.HorizontalScrollbar = true;
            lstregistrazioneutenti.ItemHeight = 15;
            lstregistrazioneutenti.Location = new Point(241, 29);
            lstregistrazioneutenti.Name = "lstregistrazioneutenti";
            lstregistrazioneutenti.RightToLeft = RightToLeft.No;
            lstregistrazioneutenti.Size = new Size(498, 229);
            lstregistrazioneutenti.TabIndex = 11;
            // 
            // btnsalvafile
            // 
            btnsalvafile.Location = new Point(241, 264);
            btnsalvafile.Name = "btnsalvafile";
            btnsalvafile.Size = new Size(127, 53);
            btnsalvafile.TabIndex = 12;
            btnsalvafile.Text = "Salva nel file";
            btnsalvafile.UseVisualStyleBackColor = true;
            btnsalvafile.Click += btnsalvafile_Click;
            // 
            // btnimportafile
            // 
            btnimportafile.Location = new Point(374, 264);
            btnimportafile.Name = "btnimportafile";
            btnimportafile.Size = new Size(127, 53);
            btnimportafile.TabIndex = 13;
            btnimportafile.Text = "Importa nel file";
            btnimportafile.UseVisualStyleBackColor = true;
            btnimportafile.Click += btnimportafile_Click;
            // 
            // btnripulirefile
            // 
            btnripulirefile.Location = new Point(1198, 688);
            btnripulirefile.Name = "btnripulirefile";
            btnripulirefile.Size = new Size(159, 52);
            btnripulirefile.TabIndex = 14;
            btnripulirefile.Text = "RIPULIRE FILE";
            btnripulirefile.UseVisualStyleBackColor = true;
            btnripulirefile.Click += btnripulirefile_Click;
            // 
            // txtcercagioco
            // 
            txtcercagioco.Location = new Point(35, 361);
            txtcercagioco.Name = "txtcercagioco";
            txtcercagioco.Size = new Size(239, 23);
            txtcercagioco.TabIndex = 15;
            // 
            // lblcercagioco
            // 
            lblcercagioco.AutoSize = true;
            lblcercagioco.Location = new Point(35, 343);
            lblcercagioco.Name = "lblcercagioco";
            lblcercagioco.Size = new Size(204, 15);
            lblcercagioco.TabIndex = 16;
            lblcercagioco.Text = "Inserisci il nome del gioco da cercare:";
            // 
            // btncercavideogioco
            // 
            btncercavideogioco.Location = new Point(290, 343);
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
            lblprofiligiocatori.Location = new Point(913, 77);
            lblprofiligiocatori.Name = "lblprofiligiocatori";
            lblprofiligiocatori.Size = new Size(246, 15);
            lblprofiligiocatori.TabIndex = 18;
            lblprofiligiocatori.Text = "Ricerca profilo giocatore attraverso nickname";
            // 
            // txtnomegiocatore
            // 
            txtnomegiocatore.Location = new Point(947, 95);
            txtnomegiocatore.Name = "txtnomegiocatore";
            txtnomegiocatore.Size = new Size(177, 23);
            txtnomegiocatore.TabIndex = 19;
            // 
            // picboxprofilogiocatore
            // 
            picboxprofilogiocatore.Image = (Image)resources.GetObject("picboxprofilogiocatore.Image");
            picboxprofilogiocatore.Location = new Point(839, 127);
            picboxprofilogiocatore.Name = "picboxprofilogiocatore";
            picboxprofilogiocatore.Size = new Size(388, 401);
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
            label1.Font = new Font("Sitka Heading", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(853, 156);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 23;
            label1.Text = "DATI PERSONALI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Sitka Heading", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(853, 240);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 24;
            label2.Text = "NOME IN GIOCO:";
            // 
            // picboxavatarG
            // 
            picboxavatarG.BackColor = Color.Transparent;
            picboxavatarG.BackgroundImageLayout = ImageLayout.None;
            picboxavatarG.Image = (Image)resources.GetObject("picboxavatarG.Image");
            picboxavatarG.Location = new Point(1114, 141);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 752);
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
    }
}
