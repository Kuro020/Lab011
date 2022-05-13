using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab011.View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            tbxEndereco.Text = string.Empty;

            try
            {
                if(folderBrowserDialog1.ShowDialog() != DialogResult.Cancel)
                {
                    tbxEndereco.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxEndereco.Text.Trim() == string.Empty)
                {
                    throw new Exception("Selecione uma pasta para efetivar a troca de arquivo.");     
                }

                if (tbxDe.Text.Trim() == string.Empty)
                {
                    throw new Exception("Informe o valor procurado para a troca.");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
