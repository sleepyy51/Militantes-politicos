using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Militantes_politicos
{
    public partial class frmMilitantes : Form
    {
        List<string> columnas;
        HashSet<string> munis;
        int afiliados = 1;
        DataTable dt;
        public frmMilitantes()
        {
            InitializeComponent();
            columnas = new List<string> { "ID", "Entidad", "Municipio", "Nombre", "Fecha de afiliacion", "Estatus" };
            munis = new HashSet<string>();
            dt = new DataTable();
            foreach (var col in columnas)
            {
                dt.Columns.Add(col);
            }
        }

        private void CargarExcel(String path)
        {
            afiliados = 1;
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
                    for (int i = 2; i < worksheet.Dimension.End.Row; i++)
                    {
                        rowCount = rowCount + 1;
                        afiliados++;
                    }
                    rowCount = rowCount + 3;
                    for (int i = 2; i < rowCount; i++)
                    {
                        DataRow row = dt.NewRow();
                        munis.Add("TODOS");
                        string muni = worksheet.Cells[i, 3].Text;
                        if (!string.IsNullOrEmpty(muni))
                        {
                            munis.Add(muni);
                        }
                        else
                        {
                            munis.Add("NINGUNO");
                        }

                        for (int j = 1; j < dt.Columns.Count + 1; j++)
                        {
                            row[j - 1] = worksheet.Cells[i, j].Text;
                        }
                        dt.Rows.Add(row);
                    }

                    cmbMunicipio.Invoke((MethodInvoker)delegate
                    {
                        cmbMunicipio.DataSource = munis.ToList();
                    });

                    dgvInformacion.Invoke((MethodInvoker)delegate
                    {
                        dgvInformacion.DataSource = null;
                        dgvInformacion.Columns.Clear();
                        dgvInformacion.AutoGenerateColumns = true;
                        dgvInformacion.DataSource = dt;
                        dgvInformacion.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofdCargar.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string archivo = ofdCargar.FileName;
                    Thread t1 = new Thread(() => CargarExcel(archivo));
                    t1.Start();
                }catch(Exception ex)
                {
                    MessageBox.Show("Error "+ex.Message, "Error cargando el archivo");
                }
                
            }
        }

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvInformacion.DataSource = null;
            dgvInformacion.Rows.Clear();
            dgvInformacion.DataSource = dt;
            dgvInformacion.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cmbMunicipio.DataSource = new List<string>(){"Seleccionar"};
            labNombreEstado.Text = "No se ha cargado ningún archivo";
            tsslAfiliados.Text = "Afiliados: ";
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataView dv = new DataView(dt);
            
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
    }
}
