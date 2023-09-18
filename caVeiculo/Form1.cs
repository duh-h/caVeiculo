using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caVeiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GerarGradelistView();
        }

        private void GerarGradelistView()
        {
            listView1.Columns.Add("Placa", 70).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Ano", 60).TextAlign = HorizontalAlignment.Center;
            listView1.Columns.Add("Qtd", 60).TextAlign = HorizontalAlignment.Center;
            listView1.View = View.Details;
        }

        private void RBOnibus_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.onibusPOO;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            maskedTextBox1.Mask = "000-0000";

        }

        private void RBCaminhao_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.CaminhaoPOO;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            maskedTextBox1.Mask = "000-0000";

            labelQTD.Text = "Qtd Eixos";

        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (RBCaminhao.Checked == true)
            {
                Veiculo caminhao = new Caminhao(Convert.ToInt32(textBox2.Text), maskedTextBox1.Text, Convert.ToInt32(textBox1.Text));


                InserirAreaListView(caminhao);
            }
            if (RBOnibus.Checked == true)
            {
                Veiculo onibus = new Onibus(Convert.ToInt32(textBox2.Text), maskedTextBox1.Text, Convert.ToInt32(textBox1.Text));


                InserirAreaListView(onibus);
            }
            
        }
        private void InserirAreaListView(Veiculo itens)
            {
                string[] formasGeos = new string[3];

                formasGeos[0] = maskedTextBox1.Text;
                formasGeos[1] = textBox1.Text;
                formasGeos[2] = textBox2.Text;
                listView1.Items.Add(new ListViewItem(formasGeos));
            }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
