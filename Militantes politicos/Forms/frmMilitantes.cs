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
        int afiliados = 1;
        public frmMilitantes()
        {
            InitializeComponent();
            columnas = new List<string> { "ID", "Entidad", "Municipio", "Nombre", "Fecha de afiliacion", "Estatus" };
        }

        private void CargarExcel(String path)
        {
            afiliados = 1;
            DataTable dt = new DataTable();
            ExcelPackage.License.SetNonCommercialPersonal("Josue Guzman");
            using (var package = new ExcelPackage(new System.IO.FileInfo(path)))
            {
                if (package.Workbook.Worksheets.Count == 0)
                {
                    MessageBox.Show("El archivo de Excel no contiene hojas de trabajo.");
                    return;
                }

                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                foreach (var col in columnas)
                {
                    dt.Columns.Add(col);
                }

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
                    for (int j = 1; j < dt.Columns.Count + 1; j++)
                    {
                        row[j - 1] = worksheet.Cells[i, j].Text;
                    }
                    dt.Rows.Add(row);
                }


                dgvInformacion.Invoke((MethodInvoker)delegate
                {
                    dgvInformacion.Rows.Clear();
                    dgvInformacion.Rows.Add(dt.Rows.Count);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            dgvInformacion.Rows[i].Cells[j].Value = dt.Rows[i][j].ToString();
                        }

                    }
                });
            }
        }

        private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ofdCargar.ShowDialog() == DialogResult.OK)
            {
                string archivo = ofdCargar.FileName;
                Thread t1 = new Thread(() => CargarExcel(archivo));
                t1.Start();
                tsslAfiliados.Text = "Afiliados: " + afiliados.ToString();
                labNombreEstado.Text = "Estado: " + dgvInformacion.Rows[0].Cells[1].Value.ToString();
            }
        }

        private void limpiarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvInformacion.Rows.Clear();
            labNombreEstado.Text = "No se ha cargado ningún archivo";
            tsslAfiliados.Text = "Afiliados: ";
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
