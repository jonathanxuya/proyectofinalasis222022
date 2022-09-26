using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloContabilidadd
{
    public partial class ContenedorCF : MetroFramework.Forms.MetroForm
    {
        public ContenedorCF()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiscales_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }

        private void btn_Fiscales_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cierre_Contable ccontable = new Cierre_Contable();
            ccontable.Show();
        }

        private void btn_Procesos_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Polizas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Polizas_Locales plocales = new Polizas_Locales();
            plocales.Show();
        }

        private void btn_AcivosF_Click(object sender, EventArgs e)
        {
            this.Hide();
            Activos_Fijos Afijos = new Activos_Fijos();
            Afijos.Show();
        }

        private void btn_Presupuestos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Presupuestos presp = new Presupuestos();
            presp.Show();
        }

        private void btn_EstadosD_Click(object sender, EventArgs e)
        {
            this.Hide();
            Estados_Financieros efinancieros = new Estados_Financieros();
            efinancieros.Show();
        }

        private void btn_Mantenimientos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Mantenimientos mant = new Mantenimientos();
            mant.Show();
        }

        private void ContenedorCF_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
