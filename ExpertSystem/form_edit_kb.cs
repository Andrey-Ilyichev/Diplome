using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpertSystem
{
    public partial class form_edit_kb : Form
    {
        private DBWorker dbWorker;
        private DataSet dSet;
        public form_edit_kb(DBWorker dbW)
        {

            InitializeComponent();

            this.dbWorker = dbW;
            dSet = dbWorker.getDataSet();
            dgv_rule.DataSource = dSet.Tables[0];
            dgv_rule.Columns[0].Visible = false;

            int ruleCount = dgv_rule.RowCount - 1;
            for (int i = 0; i < ruleCount; i++)
            {
                dgv_rule.Rows[i].Cells[0].Value = i + 1;
            }
            dgv_rule.Columns[0].HeaderText = "#";
            dgv_rule.Columns[1].HeaderText = "Переменная антецендента 1";
            dgv_rule.Columns[2].HeaderText = "Значение антецендента 1";
            dgv_rule.Columns[3].HeaderText = "Переменная антецендента 2";
            dgv_rule.Columns[4].HeaderText = "Значение антецендента 2";
            dgv_rule.Columns[5].HeaderText = "Переменная антецендента 3";
            dgv_rule.Columns[6].HeaderText = "Значение антецендента 3";

            dgv_rule.Columns[7].HeaderText = "Переменная консеквента";
            dgv_rule.Columns[8].HeaderText = "Значение консеквента";

            dgv_rule.Columns[0].Visible = false;
        }

        private void btn_addRules_Click(object sender, EventArgs e)
        {

            this.dbWorker.update(this.dSet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ES_form form = new ES_form(this.dbWorker);
            form.Show();
            this.Close();
        }
    }
}
