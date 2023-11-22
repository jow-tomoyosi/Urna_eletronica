using System.Windows.Forms;

namespace Urna
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.tela = new System.Windows.Forms.Panel();
            this.partido = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.Label();
            this.digit2 = new System.Windows.Forms.TextBox();
            this.digit1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tlFim = new System.Windows.Forms.Label();
            this.branco = new System.Windows.Forms.Button();
            this.corrige = new System.Windows.Forms.Button();
            this.confirma = new System.Windows.Forms.Button();
            this.relogio = new System.Windows.Forms.Timer(this.components);
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tela.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(513, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tela
            // 
            this.tela.Controls.Add(this.panel1);
            this.tela.Controls.Add(this.partido);
            this.tela.Controls.Add(this.nome);
            this.tela.Controls.Add(this.digit2);
            this.tela.Controls.Add(this.digit1);
            this.tela.Controls.Add(this.label9);
            this.tela.Controls.Add(this.label8);
            this.tela.Controls.Add(this.pictureBox1);
            this.tela.Controls.Add(this.label7);
            this.tela.Controls.Add(this.label6);
            this.tela.Location = new System.Drawing.Point(88, 98);
            this.tela.Name = "tela";
            this.tela.Size = new System.Drawing.Size(341, 262);
            this.tela.TabIndex = 10;
            // 
            // partido
            // 
            this.partido.AutoSize = true;
            this.partido.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partido.Location = new System.Drawing.Point(76, 196);
            this.partido.Name = "partido";
            this.partido.Size = new System.Drawing.Size(0, 16);
            this.partido.TabIndex = 16;
            // 
            // nome
            // 
            this.nome.AutoSize = true;
            this.nome.Location = new System.Drawing.Point(73, 168);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(0, 16);
            this.nome.TabIndex = 15;
            // 
            // digit2
            // 
            this.digit2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit2.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit2.Location = new System.Drawing.Point(126, 90);
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(41, 50);
            this.digit2.TabIndex = 14;
            this.digit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // digit1
            // 
            this.digit1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.digit1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1.Location = new System.Drawing.Point(79, 91);
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(41, 50);
            this.digit1.TabIndex = 5;
            this.digit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "Partido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nome:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pictureBox1.Location = new System.Drawing.Point(211, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Número:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "PRESIDENTE";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tlFim);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 262);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            // 
            // tlFim
            // 
            this.tlFim.AutoSize = true;
            this.tlFim.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlFim.Location = new System.Drawing.Point(129, 106);
            this.tlFim.Name = "tlFim";
            this.tlFim.Size = new System.Drawing.Size(73, 38);
            this.tlFim.TabIndex = 0;
            this.tlFim.Text = "FIM";
            // 
            // branco
            // 
            this.branco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.branco.Font = new System.Drawing.Font("Arial", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branco.Location = new System.Drawing.Point(489, 324);
            this.branco.Name = "branco";
            this.branco.Size = new System.Drawing.Size(54, 30);
            this.branco.TabIndex = 11;
            this.branco.Text = "BRANCO";
            this.branco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.branco.UseVisualStyleBackColor = true;
            this.branco.Click += new System.EventHandler(this.branco_Click);
            // 
            // corrige
            // 
            this.corrige.BackColor = System.Drawing.Color.Salmon;
            this.corrige.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.corrige.Font = new System.Drawing.Font("Arial", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.corrige.Location = new System.Drawing.Point(549, 324);
            this.corrige.Name = "corrige";
            this.corrige.Size = new System.Drawing.Size(62, 30);
            this.corrige.TabIndex = 12;
            this.corrige.Text = "CORRIGE";
            this.corrige.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.corrige.UseVisualStyleBackColor = false;
            this.corrige.Click += new System.EventHandler(this.corrige_Click);
            // 
            // confirma
            // 
            this.confirma.BackColor = System.Drawing.Color.LimeGreen;
            this.confirma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirma.Font = new System.Drawing.Font("Arial", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirma.Location = new System.Drawing.Point(618, 315);
            this.confirma.Name = "confirma";
            this.confirma.Size = new System.Drawing.Size(57, 38);
            this.confirma.TabIndex = 13;
            this.confirma.Text = "CONFIRMA";
            this.confirma.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.confirma.UseVisualStyleBackColor = false;
            this.confirma.Click += new System.EventHandler(this.confirma_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.Control;
            this.button10.Location = new System.Drawing.Point(560, 279);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(42, 28);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.SystemColors.Control;
            this.button9.Location = new System.Drawing.Point(608, 243);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(42, 28);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.SystemColors.Control;
            this.button8.Location = new System.Drawing.Point(560, 243);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 28);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.Control;
            this.button7.Location = new System.Drawing.Point(513, 243);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(42, 28);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(513, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Control;
            this.button5.Location = new System.Drawing.Point(560, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 28);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(608, 202);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(42, 28);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(608, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(560, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Urna.Properties.Resources.urna1;
            this.ClientSize = new System.Drawing.Size(802, 503);
            this.Controls.Add(this.confirma);
            this.Controls.Add(this.corrige);
            this.Controls.Add(this.branco);
            this.Controls.Add(this.tela);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tela.ResumeLayout(false);
            this.tela.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Panel tela;
        private Button branco;
        private Button corrige;
        private Button confirma;
        private Label label6;
        private Label label7;
        private TextBox digit1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Label nome;
        private TextBox digit2;
        private Panel panel1;
        private Label partido;
        private Label tlFim;
        private Timer relogio;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
    }
}

