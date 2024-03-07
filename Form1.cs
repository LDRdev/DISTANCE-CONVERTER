using System.Globalization;

namespace Conversor_de_Km_e_milhas
{
    public partial class lbConversor : Form
    {
        public lbConversor()
        {
            InitializeComponent();
            txtValorConvertido.BackColor = Color.White;
        }


        private void btnConverter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtValor.Text))
            {
                MessageBox.Show("Digite um valor.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!float.TryParse(txtValor.Text, out _))
            {
                MessageBox.Show("Valor deve ser um número.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Clear();
                rbK.Checked = false;
                rbM.Checked = false;
                return;

            }

            if (!rbM.Checked & !rbK.Checked)
            {
                MessageBox.Show("Seleção obrigatória.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string valor = txtValor.Text.Replace('.', ',');


            var converter = new Conversor() { valor = float.Parse(valor) };


            if (rbM.Checked)
            {
                double resultadoMilhas = converter.converteMilhas();
                txtValorConvertido.Text = resultadoMilhas.ToString("N2");
            }
            if (rbK.Checked)
            {
                txtValorConvertido.Text = converter.converteKm().ToString("N2");
            }

            txtValor.Clear();
            rbK.Checked = false;
            rbM.Checked = false;
            txtValor.Focus();
        }

        private void txtValorConvertido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}