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
            lstregistrazioneutenti.Location = new Point(243, 38);
            lstregistrazioneutenti.Name = "lstregistrazioneutenti";
            lstregistrazioneutenti.RightToLeft = RightToLeft.No;
            lstregistrazioneutenti.Size = new Size(498, 199);
            lstregistrazioneutenti.TabIndex = 11;
            // 
            // btnsalvafile
            // 
            btnsalvafile.Location = new Point(243, 243);
            btnsalvafile.Name = "btnsalvafile";
            btnsalvafile.Size = new Size(127, 53);
            btnsalvafile.TabIndex = 12;
            btnsalvafile.Text = "Salva nel file";
            btnsalvafile.UseVisualStyleBackColor = true;
            btnsalvafile.Click += btnsalvafile_Click;
            // 
            // btnimportafile
            // 
            btnimportafile.Location = new Point(376, 243);
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
            txtcercagioco.Location = new Point(52, 385);
            txtcercagioco.Name = "txtcercagioco";
            txtcercagioco.Size = new Size(239, 23);
            txtcercagioco.TabIndex = 15;
            // 
            // lblcercagioco
            // 
            lblcercagioco.AutoSize = true;
            lblcercagioco.Location = new Point(52, 367);
            lblcercagioco.Name = "lblcercagioco";
            lblcercagioco.Size = new Size(204, 15);
            lblcercagioco.TabIndex = 16;
            lblcercagioco.Text = "Inserisci il nome del gioco da cercare:";
            // 
            // btncercavideogioco
            // 
            btncercavideogioco.Location = new Point(307, 367);
            btncercavideogioco.Name = "btncercavideogioco";
            btncercavideogioco.Size = new Size(108, 41);
            btncercavideogioco.TabIndex = 17;
            btncercavideogioco.Text = "CERCA";
            btncercavideogioco.UseVisualStyleBackColor = true;
            btncercavideogioco.Click += btncercavideogioco_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 752);
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
    }
}
