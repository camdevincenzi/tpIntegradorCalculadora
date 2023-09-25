using Entidades;
using System;
using static Entidades.Numeracion;

namespace MiCalculadora
{
    public partial class FrmCalculadora : Form
    {
        private ESistema sistema;
        private Numeracion primerOperando;
        private Numeracion segundoOperando;
        private Numeracion resultado;
        private Operacion calculadora;

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void setResultado(Numeracion resultado)
        {
            if (this.resultado is not null)
            {
                string res = resultado.ConvertirA(this.sistema);
                lblResFinal.Text = res;
            }
        }

        private void FrmCalculadora_Load(object sender, EventArgs e)
        {
            this.cmbOperacion.Items.Add("+");
            this.cmbOperacion.Items.Add("-");
            this.cmbOperacion.Items.Add("*");
            this.cmbOperacion.Items.Add("/");
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void grpSistema_Enter(object sender, EventArgs e)
        {

        }

        private void rdbDecimal_CheckedChanged(object sender, EventArgs e)
        {
            if (this.resultado is not null)
            {
                this.sistema = ESistema.Decimal;
                setResultado(this.resultado);
            }
        }

        private void rdbBinario_CheckedChanged(object sender, EventArgs e)
        {
            this.sistema = ESistema.Binario;
            setResultado(this.resultado);
        }

        private void lblPrimerOperador_Click(object sender, EventArgs e)
        {

        }

        private void txtPrimerOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblOperacion_Click(object sender, EventArgs e)
        {

        }

        private void cmbOperacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSegundoOperador_Click(object sender, EventArgs e)
        {

        }

        private void txtSegundoOperador_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrimerOperador.Text) || string.IsNullOrWhiteSpace(txtSegundoOperador.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            if (double.TryParse(txtPrimerOperador.Text, out double valorUno) && double.TryParse(txtSegundoOperador.Text, out double valorDos))
            {
                this.primerOperando = new Numeracion(this.sistema, valorUno);
                this.segundoOperando = new Numeracion(this.sistema, valorDos);

                char signo = cmbOperacion.Text.FirstOrDefault();

                this.calculadora = new Operacion(this.primerOperando, this.segundoOperando);

                this.resultado = this.calculadora.Operar(signo);
                setResultado(new Numeracion(this.sistema, this.resultado.ConvertirA(this.sistema)));
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerOperador.Clear();
            txtSegundoOperador.Clear();
            this.resultado = null;
            lblResFinal.Text = string.Empty;
            rdbDecimal.Checked = true;
            this.sistema = ESistema.Decimal;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Desea cerrar la calculadora?","Cerrar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}