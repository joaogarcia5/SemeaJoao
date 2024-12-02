using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemeaJoao
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Entrada exibir mais detalhes planos
        private void label2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Botao_Detalhes = "saude";
            form3.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Botao_Detalhes = "odonto";
            form3.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Botao_Detalhes = "farmaceutico";
            form3.Show();
        }

        private void label9_Click(object sender, EventArgs e)
        {

            Form3 form3 = new Form3();
            form3.Botao_Detalhes = "seguro_de_vida";
            form3.Show();
        }

        //Entrada editar planos
        private void label6_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "farmaceutico";
            form4.Show();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "saude";
            form4.Show();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "saude";
            form4.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "odonto";
            form4.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "odonto";
            form4.Show();
        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "saude";
            form4.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "farmaceutico";
            form4.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "saude";
            form4.Show();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "saude";
            form4.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "seguro_de_vida";
            form4.Show();
        }

        private void label9_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Botao_Editar_Beneficios = "seguro_de_vida";
            form4.Show();
        }


        private void lbl_editar1_MouseEnter_1(object sender, EventArgs e)
        {
            lbl_editar1.Font = lbl_editarsublinhado.Font;
        }
        private void lbl_editar2_MouseEnter(object sender, EventArgs e)
        {
            lbl_editar2.Font = lbl_editarsublinhado.Font;
        }
        private void lbl_editar3_MouseEnter(object sender, EventArgs e)
        {
            lbl_editar3.Font = lbl_editarsublinhado.Font;
        }
        private void lbl_editar4_MouseEnter(object sender, EventArgs e)
        {
            lbl_editar4.Font = lbl_editarsublinhado.Font;
        }


        private void lbl_editar1_MouseLeave(object sender, EventArgs e)
        {
            lbl_editar1.Font = lbl_editsave.Font;
        }
        private void lbl_editar2_MouseLeave_1(object sender, EventArgs e)
        {
            lbl_editar2.Font = lbl_editsave.Font;
        }
        private void lbl_editar3_MouseLeave_2(object sender, EventArgs e)
        {
            lbl_editar3.Font = lbl_editsave.Font;
        }
        private void lbl_editar4_MouseLeave_3(object sender, EventArgs e)
        {
            lbl_editar4.Font = lbl_editsave.Font;
        }
    }
}
