using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ClassLibraryUMT;
using ExcelLibrary;

namespace UsefulMethodsAndTools
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        BindingList<ClassAddress> ListaAdresa = new BindingList<ClassAddress>();

        private void BtnImport_Click(object sender, EventArgs e)
        {
            var ds = default(DataSet);
            dgWorkbook.DataSource = ds;
            try
            {
                if (ofdExcel.ShowDialog() == DialogResult.OK)
                {
                    switch (ofdExcel.SafeFileName.Substring(ofdExcel.SafeFileName.IndexOf(".") + 1).ToLower())
                    {
                        case "xls":  //ds = DataSetHelper.CreateDataSet(ofdExcel.FileName); break;
                        case "xlsx": ds = ExcelImportExport.ImportExcelODBC(ofdExcel.FileName); break;
                        default:
                            Stream ss = File.OpenRead(ofdExcel.FileName);
                            ds = ExcelImportExport.ImportExcelXML(ss, true, false); break;
                    }
                    foreach (DataTable tabela in ds.Tables)
                    {
                        foreach (DataRow red in tabela.Rows)
                        {
                            string sred = string.Empty;
                            foreach (object polje in red.ItemArray)
                            {
                                sred = sred + polje.ToString().Trim();                                
                            }
                            foreach(DataColumn kolona in tabela.Columns)
                            {
                                if (red[kolona].ToString() == string.Empty)
                                {
                                    switch (kolona.DataType.Name)
                                    {
                                        case "String":  red[kolona] = ""; break;
                                        case "DateTime": red[kolona] = DateTime.Today; break;
                                        case "Boolean": red[kolona] = false; break;
                                        default: red[kolona] = 0; break;
                                    }
                                    
                                }
                            }
                            if (sred.Trim() == string.Empty) red.Delete();
                        }
                    }
                    ds.AcceptChanges();
                    dgWorkbook.DataSource = ds;
                    ofdExcel.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sd = new SaveFileDialog())
                {
                    var ds = (DataSet)dgWorkbook.DataSource;
                    sd.FileName = ds.DataSetName;
                    sd.Filter = "Excel files|*.xls";
                    if(sd.ShowDialog()==DialogResult.OK)
                    {
                        ds.AcceptChanges();
                        DataSetHelper.CreateWorkbook(sd.FileName, ds);
                    }
                    
                }
                   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BtnExportLO_Click(object sender, EventArgs e)
        {
            try
            {
                using (var sd = new SaveFileDialog())
                {
                    var ds = (DataSet)dgWorkbook.DataSource;
                    sd.FileName = ds.DataSetName;
                    sd.Filter = "Excel files|*.xls";
                    if (sd.ShowDialog() == DialogResult.OK)
                    {                    
                        ExcelImportExport.ExportExcelLO(sd.FileName, ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string orignalText=string.Empty;
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (RbOriginal.Checked)
            {
                orignalText = RichTextBox1.Text;
            }
        }

        private void RbOriginal_CheckedChanged(object sender, EventArgs e)
        {
            if(RbOriginal.Checked)
            {
                RichTextBox1.Text = orignalText;
            }
        }

        private void RbLatin_CheckedChanged(object sender, EventArgs e)
        {
            if(RbLatin.Checked)
            {
               RichTextBox1.Text= ClassUMT.CyrlToLatn(orignalText);
                string ppp = string.Empty;
                
            }
        }

        private void BtnChoose_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var ds = new DataSet();
                    ds.ReadXml(ofd.FileName);
                    rtbPoco.Text = ClassUMT.DtoToPoco(ds);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnSaveData_Click(object sender, EventArgs e)
        {
           dsTest1.WriteXml("Address.xml"); //data
           dsTest1.WriteXmlSchema("Address.xsd"); //shema
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
              
                if (File.Exists("Address.xml"))
                {
                    dsTest1.ReadXml("Address.xml");
                
                    foreach (var red in dsTest1.dtAddresssBook)
                    {
                        ListaAdresa.Add(red.MapirajMe<dsTest.dtAddresssBookRow, ClassAddress>());
                    }
                    dataGrid1.DataSource = ListaAdresa;
                }
                else
                {
                    ListaAdresa.Add(new ClassAddress {
                        Id = 1,
                        Firstname = "Sima",
                        Surname = "Strahota",
                        Address = "Puste barake 1",
                        Birthday = new DateTime(1976, 10, 8),
                        Phone = "064/789"
                    });
                    ListaAdresa.Add(new ClassAddress
                    {
                        Id = 2,
                        Firstname = "Pera",
                        Surname = "Detlic",
                        Address = "Shumatovacka bb",
                        Birthday = new DateTime(1969, 12, 3),
                        Phone = "065/789"
                    });
                    ListaAdresa.Add(new ClassAddress
                    {
                        Id = 3,
                        Firstname = "Dusko",
                        Surname = "Dugousko",
                        Address = "Rupcine 123",
                        Birthday = new DateTime(1967, 2, 20),
                        Phone = "066/789"
                    });
                    
                    foreach(var red in ListaAdresa)
                    {                     
                        dsTest1.dtAddresssBook.Rows.Add(ClassUMT.PocoToDtoData(dsTest1.dtAddresssBook.NewRow(),red));
                    }
                    dsTest1.AcceptChanges();
                    dataGrid1.DataSource = dsTest1.dtAddresssBook;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void testAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new TestForm().ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
