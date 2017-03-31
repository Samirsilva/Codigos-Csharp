using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class logicaPro : Form
    {
        public logicaPro()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int[] vet = new int[10];
            int i, j, aux;

            for (i = 0; i <= 9; i++)
            {
                vet[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("prompt", "Informe o numero:", "0", 0, 0));
            }

            for (i = 0; i <= 9; i++)
            {
                for (j = i + 1; j <= 9; j++)
                {
                    if (vet[i] > vet[j])
                    {
                        aux = vet[i];
                        vet[i] = vet[j];
                        vet[j] = aux;
                    }
                }
            }
            for (i = 0; i <= 9; i++)
            {
                //lblResposta.Text = Convert.ToString("Vetor de index "+i+ " :" + vet[i]);
                MessageBox.Show("Vetor de index " + i + " :" + vet[i]);
            }
        }
    }
}
