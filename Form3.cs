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
    public partial class Form3 : Form
    {
        public string Botao_Detalhes { get; set; }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel_saude.Visible = false;
            panel_odonto.Visible = false;
            panel_farmaceutico.Visible = false;
            panel_segurodevida.Visible = false;

            if (Botao_Detalhes == "saude")
            {
                tabControl1.SelectedTab = tabPage1;
                panel_saude.Enabled = true;
                panel_saude.Visible = true;
            }
            else if (Botao_Detalhes == "odonto")
            {
                tabControl1.SelectedTab = tabPage2;
                panel_odonto.Enabled = true;
                panel_odonto.Visible = true;
            }
            else if (Botao_Detalhes == "farmaceutico")
            {
                tabControl1.SelectedTab = tabPage3;
                panel_farmaceutico.Enabled = true;
                panel_farmaceutico.Visible = true;
            }
            else if (Botao_Detalhes == "seguro_de_vida")
            {
                tabControl1.SelectedTab = tabPage4;
                panel_segurodevida.Enabled = true;
                panel_segurodevida.Visible = true;
            }

        }
    }
}
