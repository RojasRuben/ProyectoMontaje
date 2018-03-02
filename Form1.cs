
using PlancharLibrary.Controller.DAOArchivos;
using PlancharLibrary.Controller.DAOExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlancharExcel
{
    public partial class frmPlanchar : Form
    {
        private OpenFileDialog open = new OpenFileDialog();

        public frmPlanchar()
        {
            InitializeComponent();
        }

        private void buttonExaminar_Click(object sender, EventArgs e)
        {
            
            open.Filter = "Excel  (*.xlsx)|*.xlsx|Excel (*.xls)|*.xls";
            open.Title = "Selecciona un archivo Excel(.xlsx,.xls)";

            if (open.ShowDialog() == DialogResult.OK)
            {
                labelExaminar.Text = open.SafeFileName;
                ActualizarArchivos(true, true, false);
                MessageBox.Show("Favor de presionar el boton Validar información");
            }

        }

        private void frmPlanchar_Load(object sender, EventArgs e)
        {
            comboBoxSeleccionaArchivos.DataSource=  DAOArchivos.Instance.CargarArchivosSeleccionables();
            ActualizarArchivos(false,false,false);
        }


        private void ActualizarArchivos(bool examinarButton,bool validarButton,bool guardarButton)
        {
            buttonExaminar.Enabled = examinarButton;
            buttonCargar.Enabled = validarButton;
            buttonGuardarActualizar.Enabled = guardarButton;
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            string mensaje;
            DataTable dtHoja = DAOExcel.Instance.LeerArchivoExcel(comboBoxSeleccionaArchivos.SelectedItem, open.FileName,open.OpenFile(),out mensaje);
            ActualizarArchivos(true, true, true);
            if (mensaje == "")
            {
                DataTable dtValidar= DAOExcel.Instance.ValidarInformacion(comboBoxSeleccionaArchivos.SelectedItem, dtHoja, out mensaje);
                if (mensaje=="")
                {
                    mensaje = "no se han encontrado datos repetidos, para continuar presione el boton Planchar informacion";
                }
                else
                {
                    dataGridViewValidar.DataSource = dtValidar;
                    MessageBox.Show(mensaje);
                }
            }
            else
                MessageBox.Show(mensaje);
        }

        private void buttonGuardarActualizar_Click(object sender, EventArgs e)
        {
            string mensaje;
            DataTable dtHoja = DAOExcel.Instance.LeerArchivoExcel(comboBoxSeleccionaArchivos.SelectedItem, open.FileName, open.OpenFile(), out mensaje);
            ActualizarArchivos(false, false, false);
            if (mensaje == "")
            {
                bool respuesta = DAOExcel.Instance.PlacharInserarInformacion(comboBoxSeleccionaArchivos.SelectedItem, dtHoja, out mensaje);
                MessageBox.Show(mensaje);
                if (respuesta)
                {
                    this.dataGridViewValidar.DataSource = null;
                    this.comboBoxSeleccionaArchivos.SelectedIndex = 0;
                }
            }
            else
                MessageBox.Show(mensaje);
        }

        private void comboBoxSeleccionaArchivos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarArchivos(true, false, false);
        }
    }
}
