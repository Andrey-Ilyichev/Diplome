using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ADOX;
namespace ExpertSystem
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }

        private void btn_createNewDB_Click(object sender, EventArgs e)
        {
            SaveFileDialog createNewDBDialog = new SaveFileDialog();
            createNewDBDialog.InitialDirectory = @"../";
            createNewDBDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;


            createNewDBDialog.Filter = @"DBfiles|*.mdb";
            if (createNewDBDialog.ShowDialog() == DialogResult.OK && createNewDBDialog.FileName.Length > 0)
            {
                try
                {
                    ADOX.CatalogClass cat = new CatalogClass();
                    string str = "provider=Microsoft.Jet.OleDb.4.0;Data Source=" + createNewDBDialog.FileName;
                    cat.Create(str);
                    cat = null;
                    DBWorker dbWorker = new DBWorker(createNewDBDialog.FileName);
                    dbWorker.formStructureKB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            createNewDBDialog = null;
        }

        private void btn_openDBfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"../";
            openFileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
            openFileDialog.Filter = @"DBfiles|*.mdb";
            if (openFileDialog.ShowDialog() == DialogResult.OK && openFileDialog.FileName.Length > 0)
            {
                DBWorker dbWorker = new DBWorker(openFileDialog.FileName);
                form_edit_kb formEdit = new form_edit_kb(dbWorker);
                formEdit.Show();
            }
            openFileDialog = null;
        }
    }
}
