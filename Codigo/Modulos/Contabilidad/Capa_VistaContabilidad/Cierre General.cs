using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_VistaContabilidad
{
    public partial class Cierre_General : Form
    {
        Capa_ControladorContabilidad.controlador cn = new Capa_ControladorContabilidad.controlador();
        public Cierre_General()
        {
            InitializeComponent();
        }

        private void Cierre_General_Load(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            String cuenta, fecha;
            float monto;

            cuenta = txt_boxcta.Text;
            fecha = dtime_act.Text;
            monto = float.Parse(txt_boxmonto.Text);

            bool resultado = cn.cierreGAct(null, cuenta,monto,fecha);
            if (resultado)
            {
                string confirmacion = "Cuenta Agregada Correctamente";
                MessageBox.Show(confirmacion);
            }

            totalAct(txt_boxtotA);
        }

        private void totalAct(TextBox txt_boxtotA)
        {
            throw new NotImplementedException();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            String cuenta, fecha;
            float monto;

            cuenta = txt_boxctaP.Text;
            monto = float.Parse(txt_boxmontoP.Text);
            fecha = dtime_Pas.Text;

            bool resultado = cn.cierreGPas(null,cuenta,monto,fecha);
            if (resultado)
            {
                string confirmacion = "Cuenta Agregada Correctamente";
                MessageBox.Show(confirmacion);
            }

            totalPas(txt_boxtotP);
        }

        private void totalPas(TextBox txt_boxtotP)
        {
            throw new NotImplementedException();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            float totA, totP;
            String cod, name, fecha;

            totA = float.Parse(txt_boxtotA.Text);
            totP = float.Parse(txt_boxtotP.Text);
            cod = txt_boxcod.Text;
            name = txt_boxname.Text;
            fecha = txt_boxfecha.Text;

            bool resultado = cn.CierreGeneral(null,totA,totP,cod,name,fecha);
            if (resultado)
            {
                string confirmacion = "Cierre General con fecha :" +fecha+ " Ha sido realizado y guardado con exito ";
                MessageBox.Show(confirmacion);
                txt_boxtotA.Text = "";
                txt_boxtotP.Text = "";
                txt_boxcod.Text = "";
                txt_boxmontoP.Text = "";
                txt_boxfecha.Text = "";
            }
        }

        private void btn_cancell_Click(object sender, EventArgs e)
        {
            txt_boxtotA.Text = "";
            txt_boxtotP.Text = "";
            txt_boxcod.Text = "";
            txt_boxmontoP.Text = "";
            txt_boxfecha.Text = "";
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
