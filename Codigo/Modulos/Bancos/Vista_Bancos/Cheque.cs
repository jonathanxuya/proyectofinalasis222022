using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador_Bancos;


namespace Vista_Bancos
{
    public partial class Cheque : Form
    {
        Convertir con = new Convertir();
        private static Cheque instancia = null;
        
        public static Cheque ventana_unica()
        {
            if (instancia == null)
            {
                instancia = new Cheque();
                return instancia;
            }
            return instancia;
        }
        public Cheque()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMontoLetras.Text = con.enletras(txtMonto.Text).ToUpper();
            Imprimir frm_imp = new Imprimir();
            frm_imp.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void navegador2_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "7003";
            TextBox[] Grupotextbox = { txtID, txtIDCuentaBancaria, txtIDConcepto, txtMonto, txtFechaReg, txtFechaAp, txtMontoLetras, txtIDBanco };
            TextBox[] Idtextbox = { txtID, txtIDCuentaBancaria };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "tbl_ctrl_cheques");
        }
    }
}
