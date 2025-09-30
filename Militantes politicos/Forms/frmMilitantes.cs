using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Militantes_politicos
{
    public partial class frmMilitantes : Form
    {
        List<string> columnas; //Crear encabezados del dt
        HashSet<string> munis; //Almacenar los municipios del excel
        DataTable dt;
        int afiliados;
        public frmMilitantes()
        {
            InitializeComponent();
            columnas = new List<string> { "ID", "Entidad", "Municipio", "Nombre", "Fecha de afiliacion", "Estatus" };
            munis = new HashSet<string>() {"Seleccionar"};
            crearDt(); //inicializar el datatable
        }

        private void crearDt() //Metodo para crear el datatable con las columnas necesarias
        {
            dt = new DataTable();
            foreach (var col in columnas)
            {
                //Daba error que no se aceptaba el formato al buscar pq no era datetime la columna
                if (col == "Fecha de afiliacion")
                {
                    dt.Columns.Add("Fecha de afiliacion", typeof(DateTime));
                }
                else
                {
                    dt.Columns.Add(col);
                }
            }
        }

        private void CargarExcel(String path) //Metodo para cargar el excel original de clase
        {
            ExcelPackage.License.SetNonCommercialPersonal("Josue Guzman");
            try
            {
                using (var package = new ExcelPackage(new System.IO.FileInfo(path)))
                {
                    if (package.Workbook.Worksheets.Count == 0)
                    {
                        MessageBox.Show("El archivo de Excel no contiene hojas de trabajo.");
                        return;
                    }

                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = 0;
                    afiliados = 1;
                    for (int i = 2; i < worksheet.Dimension.End.Row; i++)
                    {
                        rowCount = rowCount + 1;
                        afiliados++;
                    }
                    rowCount = rowCount + 3;
                    for (int i = 2; i < rowCount; i++)
                    {
                        DataRow row = dt.NewRow();
                        munis.Add("TODOS"); //Agregar la opcion de todos los municipios
                        string muni = worksheet.Cells[i, 3].Text;
                        if (!string.IsNullOrEmpty(muni))
                        {
                            munis.Add(muni);
                        }
                        else
                        {
                            munis.Add("NINGUNO"); //Agregar la opcion de ningun municipio (Cuando la columna no tiene ningun dato)
                        }

                        for (int j = 1; j < dt.Columns.Count + 1; j++)
                        {
                            row[j - 1] = worksheet.Cells[i, j].Text;
                        }
                        dt.Rows.Add(row);
                    }

                    cmbMunicipio.Invoke((MethodInvoker)delegate
                    {
                        cmbMunicipio.DataSource = munis.ToList(); //Actualizar el datasource del combobox con los municipios encontrados
                    });

                    dgvInformacion.Invoke((MethodInvoker)delegate
                    {
                        dgvInformacion.DataSource = null;
                        dgvInformacion.Columns.Clear();
                        dgvInformacion.AutoGenerateColumns = true; //Sin esto se generaba una tabla vacia y la nueva a la derecha
                        dgvInformacion.DataSource = dt;
                        dgvInformacion.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //Ajustar la columna de nombre (pq si no se veo feo)
                    });

                    this.Invoke((MethodInvoker)delegate
                    {
                        tsslAfiliados.Text = "Afiliados: " + afiliados.ToString();
                        labNombreEstado.Text = "Estado: " + dgvInformacion.Rows[0].Cells[1].Value.ToString();
                    });
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error "+ex.Message, "Error al cargar el Excel");
            }
        }

        private void limpiarDatos()
        {
            dgvInformacion.DataSource = null; //Para poder modificar el dgv manualmente
            dgvInformacion.Rows.Clear();
            crearDt(); //Vuelve a crear el datatable con valores default
            dgvInformacion.DataSource = dt;
            dgvInformacion.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; //Ajustar la columna de nombre (pq si no se veo feo)
            munis = new HashSet<string>(); //Reiniciar el hashset de municipios
            cmbMunicipio.DataSource = new List<string>() { "Seleccionar" };
            labNombreEstado.Text = "No se ha cargado ningún archivo";
            tsslAfiliados.Text = "Afiliados: ";
            labDir.Text = "No se ha cargado ningún archivo";
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofdCargar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    limpiarDatos(); //Limpiar los datos antes de cargar uno nuevo
                    string archivo = ofdCargar.FileName;
                    labDir.Text = archivo;
                    Thread t1 = new Thread(() => CargarExcel(archivo)); //Crear un hilo para no congelar la interfaz
                    t1.Start();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error "+ex.Message, "Error cargando el archivo");
                }
                
            }
        }

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            limpiarDatos();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt); //filtrar el datatable con dataview segun la seleccion del combobox

            if (cmbMunicipio.SelectedItem.ToString() == "TODOS")
            {
                dv.RowFilter = "";
            }
            else if (cmbMunicipio.SelectedItem.ToString() == "NINGUNO")
            {
                dv.RowFilter = $"Municipio = ''";
            }
            else
            {
                string selec = cmbMunicipio.SelectedItem.ToString();
                dv.RowFilter = $"Municipio = '{selec}'";
            }
            dgvInformacion.DataSource = dv;
        }

        private void chbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(chbFecha.Checked == true) //Habilitar o deshabilitar los datetimepicker segun el checkbox
            {
                dtpInicio.Enabled = true;
                dtpTermino.Enabled = true;
            }
            else
            {
                dtpInicio.Enabled = false;
                dtpTermino.Enabled = false;
            }
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            cmbMunicipio.SelectedIndex = 0; //Resetear el combobox al seleccionar buscar por fecha
            try //Filtrar por fechas si el checkbox esta seleccionado
            {
                DataView dv = new DataView(dt);
                DateTime ini = dtpInicio.Value.Date;
                DateTime fin = dtpTermino.Value.Date;
                dv.RowFilter = $"[Fecha de afiliacion] >= #{ini:MM-dd-yyyy}# AND [Fecha de afiliacion] <= #{fin:MM-dd-yyyy}#"; //Query tipo sql para filtrar por fechas salida de stackoverflow
                dgvInformacion.DataSource = dv;
            }
            catch (Exception ex) {
                MessageBox.Show("Error " + ex.Message, "Error al buscar por fecha");
            }
        }
    }
}
