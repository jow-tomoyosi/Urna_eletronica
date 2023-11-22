using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urna
{
    public partial class Form1 : Form
    {

        private Dictionary<string, Candidato> _dicCandidato;
        public Form1()
        {
            InitializeComponent();
            _dicCandidato = new Dictionary<string, Candidato>();
            _dicCandidato.Add("56", new Candidato() { Id = 56, Nome = "Jair Bolsonaro", Partido = "Partido Liberal", Foto = Properties.Resources.cad_mito });
            _dicCandidato.Add("10", new Candidato() { Id = 10, Nome = "Enéias Carneiro", Partido = "Partido de Reedificação da Ordem Nacional", Foto = Properties.Resources.cad_eneias });
            _dicCandidato.Add("11", new Candidato() { Id = 11, Nome = "Lula", Partido = "Partido Trabalhista", Foto = Properties.Resources.cad_lula });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrarDigito("1");
            SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistrarDigito("2");
            SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrarDigito("3");
            SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegistrarDigito("4");
            SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistrarDigito("5");
            SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegistrarDigito("6");
            SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegistrarDigito("7");
            SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegistrarDigito("8");
            SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RegistrarDigito("9");
            SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RegistrarDigito("0"); SoundPlayer s = new SoundPlayer(Properties.Resources.clique);
            s.Play();
        }

        private void branco_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Limpar();

            SoundPlayer s = new SoundPlayer(Properties.Resources.urna); 
            s.Play();

            relogio.Tick += new EventHandler(AcaoFinal);
            relogio.Interval = 3000;
            relogio.Enabled = true;
            relogio.Start();
        }

        private void corrige_Click(object sender, EventArgs e)
        {
            Limpar();
            relogio.Stop();
            relogio.Enabled = false;
        }

        private void confirma_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(digit1.Text))
            {
                MessageBox.Show("Favor informar o candidato.");
                    return;
            }

            panel1.Visible=true;
            Limpar();
            SoundPlayer s = new SoundPlayer(Properties.Resources.urna);
            s.Play();

            relogio.Tick += new EventHandler(AcaoFinal);
            relogio.Interval = 3000;
            relogio.Enabled = true;
            relogio.Start();
        }

        private void AcaoFinal(object myObject, EventArgs myEventArgs)
        {
            relogio.Stop();
            relogio.Enabled = false;
            panel1.Visible = false;
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarDigito(string digito)
        {
            if (string.IsNullOrEmpty(digit1.Text)) { digit1.Text = digito; }
            else { digit2.Text = digito;
                PreencherCandidato(digit1.Text, digit2.Text);
            }
        }

        private void PreencherCandidato(string d1, string d2)
        {
            if (_dicCandidato.ContainsKey(d1 + d2))
            {
                nome.Text = _dicCandidato[d1 + d2].Nome;
                partido.Text = _dicCandidato[d1 + d2].Partido;
                pictureBox1.Image = _dicCandidato[d1 + d2].Foto;
            }
            else
            {
                MessageBox.Show("Candidato não encontrado");
            }
        }

        private void Limpar()
        {
            digit1.Text = "";
            digit2.Text = "";
            nome.Text = String.Empty;
            partido.Text = String.Empty;
            pictureBox1.Image = null;
        }
    }

    public class Candidato
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Partido { get; set; }
        public Image Foto { get; set; }
    }
}
