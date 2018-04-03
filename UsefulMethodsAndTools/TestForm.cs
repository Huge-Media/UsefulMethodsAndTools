using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryUMT;
using Newtonsoft.Json;
using System.IO;

namespace UsefulMethodsAndTools
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private DataSet ds = default(DataSet);

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void brnLoadExcel_Click(object sender, EventArgs e)
        {
            using(var ofd =new OpenFileDialog())
            {
                try
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        ds = ExcelImportExport.ImportExcelODBC(ofd.FileName);
                        ds.DataSetName = ofd.SafeFileName.Split('.')[0];
                        ds = ObradiDataSet(ds);
                        dgImportExcel.DataSource = ds;
                        rtbJSON.Text= JsonConvert.SerializeObject(ds,Formatting.Indented);
                        rtbJSON.Text = rtbJSON.Text.Replace("\\n", "<br/>");
                        rtbJSON.Text ="var "+ ds.DataSetName + "_data=" + rtbJSON.Text + ";";
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        private DataSet ObradiDataSet(DataSet ds)
        {
            var lokDS = ds;
            foreach(DataTable tabela in lokDS.Tables)
            {
                tabela.TableName = tabela.TableName.Replace("$", "");
                object[] oldNiz = new object[tabela.Columns.Count];
                for (var i= 0; i < oldNiz.Length;i++)
                {
                    oldNiz[i] = DBNull.Value;
                }
                foreach(DataRow red in tabela.Rows)
                {
                    if (!PrazanRed(red))
                    {
                        for (var i = 0; i < oldNiz.Length; i++)
                        {
                            if (red[i].ToString() == "")
                            {
                                red[i] = oldNiz[i];
                            }
                            else
                            {
                                oldNiz[i] = red[i];
                            }
                        }
                    }
                }
            }
            lokDS.AcceptChanges();
            return lokDS;
        }
        private bool PrazanRed(DataRow red)
        {
            var prazan = true;
            foreach(var polje in red.ItemArray)
            {
                prazan &= polje.ToString() == "";
            }
            return prazan;
        }
        private void btnSaveJson_Click(object sender, EventArgs e)
        {
            using(var sfd=new SaveFileDialog())
            {
                try
                {
                    sfd.FileName = ds.DataSetName+".json.js";
                    sfd.Filter = "JavaScript JSON files|*.js";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(sfd.FileName, rtbJSON.Text);
                    }
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
    }
}
