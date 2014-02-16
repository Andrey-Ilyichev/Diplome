using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace ExpertSystem
{
    public partial class ES_form : Form
    {
        private DBWorker dbWorker;
        private DataTable dtRule;
        public ES_form(DBWorker dbW)
        {
            InitializeComponent();

            #region получение таблицы правил и отражение на dgv
                this.dbWorker = dbW;
                DataSet dSet = dbWorker.getDataSet();
                dtRule = dSet.Tables[0];
                dgv_rule.DataSource = dtRule;
                int ruleCount = dgv_rule.RowCount -1;            
            

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

                for (int i = 0; i < dgv_rule.RowCount; i++)
                {
                    for (int j = 1; j < dgv_rule.ColumnCount; j++)
                    {
                        string ruleAntVal = deleteSpaces(dgv_rule[j,i].Value.ToString());
                        dgv_rule[j,i].Value = ruleAntVal;
                    }

                }
            #endregion
            #region создание таблицы фактов и привязка к dataGridView
                DataTable dtFact = new DataTable("fact");

                DataColumn idFactCol = new DataColumn("id_fact", typeof(int));
                idFactCol.Caption = "Rule №";
                idFactCol.AutoIncrementSeed = 1;
                idFactCol.AutoIncrementStep = 1;

                DataColumn factVarCol = new DataColumn("fact_var", typeof(string));
                factVarCol.Caption = "fact_var";

                DataColumn factValCol = new DataColumn("fact_val", typeof(string));
                factValCol.Caption = "fact_val";


                dtFact.Columns.AddRange(new DataColumn[] { idFactCol, factVarCol, factValCol });
                dgv_fact.DataSource = dtFact;
               dgv_fact.ColumnHeadersVisible = false;



               //DataRow dRow = dtFact.NewRow();
               //dRow["fact_var"] = "намеренье"; dRow["fact_val"] = "отдых";
               //dtFact.Rows.Add(dRow);

               //dRow = dtFact.NewRow();
               //dRow["fact_var"] = "место отдыха"; dRow["fact_val"] = "горы";
               //dtFact.Rows.Add(dRow);




              // DataRow dRow = dtFact.NewRow();
               //dRow["fact_var"] = "двигатель"; dRow["fact_val"] = "не заводится";
               //dtFact.Rows.Add(dRow);

               //dRow = dtFact.NewRow();
               //dRow["fact_var"] = "искра"; dRow["fact_val"] = "отсутствует";
               //dtFact.Rows.Add(dRow);

                dgv_fact.Columns[0].Visible = false;
                #endregion
        }
        enum continueAnswer { yes,no,na}
        enum entering { was,wasnot}
        private void btn_getFact_Click(object sender, EventArgs e)
        {
            //int dgv_fact_count = dgv_fact.RowCount - 1;
            //for (int i = 0; i < dgv_fact_count; i++)
            //{
            //    DataRow dRow = dTableFact.NewRow();
            //    dRow[1] = dgv_fact.Rows[i].Cells[1].Value.ToString();
            //    dRow[2] = dgv_fact.Rows[i].Cells[2].Value.ToString();
            //    dTableFact.Rows.Add(dRow);
            //}
        }

        private void btn_begin_Click(object sender, EventArgs e)
        {

            #region создаем таблицу переменных условий и связываем с dgv

                DataTable dtVarCon = new DataTable("varCon");

                DataColumn colIdVarConCol = new DataColumn("id_var_con", typeof(int));
                colIdVarConCol.Caption = "Var con №";
                colIdVarConCol.AutoIncrementSeed = 1;
                colIdVarConCol.AutoIncrementStep = 1;

                DataColumn colIdentVar = new DataColumn("ident_var", typeof(string));
                colIdentVar.Caption = "ident var";

                DataColumn colMarkInit = new DataColumn("mark_init", typeof(bool));
                colMarkInit.Caption = "mark init";

                DataColumn colValVar = new DataColumn("val_var", typeof(string));
                colValVar.Caption = "val var";

                dtVarCon.Columns.AddRange(new DataColumn[] { colIdVarConCol, colIdentVar, colMarkInit, colValVar });
                dgv_varCon.DataSource = dtVarCon;

                dgv_varCon.Columns[0].Visible = false;
                dgv_varCon.Columns[1].HeaderText = "Идентификатор переменной";
                dgv_varCon.Columns[2].HeaderText = "Отметка инициализации";
                dgv_varCon.Columns[3].HeaderText = "Значение переменной";
            #endregion
            #region создание таблицы очереди фактов
                DataTable dtQueue = new DataTable("queue");

                DataColumn colIdQFact = new DataColumn("id_q_fact", typeof(int));
                colIdQFact.Caption = "QFact №";
                colIdQFact.AutoIncrementSeed = 1;
                colIdQFact.AutoIncrementStep = 1;

                DataColumn colQFactVar = new DataColumn("q_fact_var", typeof(string));
                colQFactVar.Caption = "q_fact_var";

                DataColumn colQFactVal = new DataColumn("q_fact_val", typeof(string));
                colQFactVal.Caption = "q_fact_val";


                dtQueue.Columns.AddRange(new DataColumn[] { colIdQFact, colQFactVar, colQFactVal });
                dgv_queue.DataSource = dtQueue;

                dgv_queue.Columns[0].Visible = false;
                dgv_queue.Columns[1].HeaderText = "Название факта";
                dgv_queue.Columns[2].HeaderText = "Значение факта";
            #endregion
            #region заполнение столбца идентификаторов таблицы переменных условий
                int ruleCount = dgv_rule.RowCount;
                SortedSet<string> setInd = new SortedSet<string>();

                for (int curRow = 0; curRow < ruleCount; curRow++)
                {
                    for (int curCell = 1; curCell < 7; curCell += 2)
                    {
                        string str = dgv_rule.Rows[curRow].Cells[curCell].Value.ToString();
                        setInd.Add(str);
                    }
                }

                int setIndCount = setInd.Count;
                for (int curIndVar = 0; curIndVar < setIndCount; curIndVar++)
                {
                    string curIndVarCon = setInd.Min;
                    setInd.Remove(setInd.Min);
                    if (curIndVarCon == "") continue;

                    DataRow dRow = dtVarCon.NewRow();
                    dRow["ident_var"] = curIndVarCon;
                    dtVarCon.Rows.Add(dRow);
                }
                setInd.Clear(); setInd = null;
            #endregion
            #region первичная инициализация таблицы переменных условия и формирование очереди
                for (int curFact = 0; curFact < dgv_fact.Rows.Count - 1; curFact++)
                {
                    string identFact = dgv_fact["fact_var", curFact].Value.ToString();
                    string valFact = dgv_fact["fact_val", curFact].Value.ToString();
                    DataRow[] foundRows = dtVarCon.Select("ident_var = " + "'" + identFact + "'");
                    if (foundRows.Length != 0)
                    {
                        foundRows[0][2] = true;
                        foundRows[0][3] = valFact;
                    }

                    DataRow dRow = dtQueue.NewRow();
                    dRow["q_fact_var"] = identFact;
                    dRow["q_fact_val"] = valFact;
                    dtQueue.Rows.Add(dRow);

                    dgv_queue.ReadOnly = false;
                    dgv_queue.Rows[0].Cells[0].Style.BackColor = Color.Red;
                    dgv_queue.ReadOnly = true;
                }
           #endregion


           #region работа основная

                continueAnswer continueAns = continueAnswer.na;
                bool firstStep = true;
                string q_fact_var = "";
                string q_fact_val = "";

                do
                {
                        //берем факт из очереди
                    if (firstStep == false) { MessageBox.Show("Закончили работать с фактом из очереди (" + q_fact_var + " - " + q_fact_val + ")"); }
                    firstStep = false;
                    ///////////////////////////////////
                    for (int i = 0; i < dgv_rule.Rows.Count; i++)
                        dgv_rule.Rows[i].DefaultCellStyle.BackColor = Color.White;
                    //////////////////////
                    q_fact_var = dtQueue.Rows[0]["q_fact_var"].ToString();
                    q_fact_val = dtQueue.Rows[0]["q_fact_val"].ToString();
                    MessageBox.Show("Берем новый факт из очереди (" + q_fact_var + " - " + q_fact_val +")");
                    lb_result.Items.Add("Работаем с фактом (" + q_fact_var + " - " + q_fact_val+ ")");
                    entering ent = entering.wasnot;
                    //ищем вхождение в правило
                    for (int curRule = 0; curRule < dgv_rule.RowCount; curRule++)
                    {
                        dgv_rule.Rows[curRule].DefaultCellStyle.BackColor = Color.Gray;

                        string[] ruleAnt = new string[8];
                        for (int curCell = 1; curCell < 9; curCell++)
                        {
                            ruleAnt[curCell-1] = dgv_rule[curCell, curRule].Value.ToString();
                        }
                        //пробегаем по текущему правилу
                        for (int curAnt = 0; curAnt <= 4; curAnt += 2)
                        {
                            //если есть вхождение в правило
                            if (ruleAnt[curAnt].Equals(q_fact_var, StringComparison.OrdinalIgnoreCase))
                            {
                                //и вхождение с совпало с фактом
                                if (ruleAnt[curAnt + 1].Equals(q_fact_val, StringComparison.OrdinalIgnoreCase))
                                {
                                    ent = entering.was;
                                    bool allTrue = true;
                                    dgv_rule.Rows[curRule].DefaultCellStyle.BackColor = Color.LightYellow;
                                    //проверяем всё правило на факты
                                    for (int curAntInRule = 0; curAntInRule <= 4 ; curAntInRule += 2)
                                    {
                                        if (ruleAnt[curAntInRule] == "") break;
                                        DataRow[] foundRows = dtQueue.Select("q_fact_var = " + "'" + ruleAnt[curAntInRule] + "'");//ищем в очереди
                                        if (foundRows.Length != 0)//нашли в очереди
                                        {
                                            string curValQ = foundRows[0]["q_fact_val"].ToString();
                                            string curVal = ruleAnt[curAntInRule + 1];
                                            allTrue &= curValQ.Equals(curVal, StringComparison.OrdinalIgnoreCase);
                                        }
                                        else
                                        { //нет в очереди-проверим переменные
                                            ///////////////////////////////////////////////////////////////////
                                            DataRow[] foundRowsV = dtVarCon.Select("ident_var = " + "'" + ruleAnt[curAntInRule] + "'");
                                            if (foundRowsV.Length == 0)
                                            { allTrue = false; break; }
                                            else
                                            {
                                                string curValV = foundRowsV[0]["val_var"].ToString();
                                                string curVal = ruleAnt[curAntInRule + 1];

                                                allTrue &= curValV.Equals(curVal, StringComparison.OrdinalIgnoreCase);
                                            }
                                            //////////////////////////////////////////////////////////////////////
                                        }  
                                         //   allTrue = false; break; }
                                    }
                                    //все антценденты нашлись в очереди
                                    if (allTrue == true)
                                    {
                                        // =>правило сработало
                                        dgv_rule.Rows[curRule].DefaultCellStyle.BackColor = Color.Green;
                                        int inc = curRule + 1;

                                        string ruleStr = "Сработало правило Если ";
                                            for (int i = 0; i<=4;i+=2)
                                            {
                                                if (ruleAnt[i]=="")
                                                {break;}
                                                string curAntStr = "(" + ruleAnt[i] + "-" + ruleAnt[i + 1] + ") и";
                                                ruleStr += curAntStr;
                                            }
                                            ruleStr = ruleStr.Remove(ruleStr.Length - 2);
                                            ruleStr += ",то";

                                            string curConStr = "(" + ruleAnt[6] + "-" + ruleAnt[7] + ")";
                                            MessageBox.Show(ruleStr+=curConStr);
                                        lb_result.Items.Add("Сработало правило " + ruleStr);
                                        ///////////////////////////////////////////
                                        //dtRule.Rows[curRule].Delete();
                                        ///////////////////////////////////////////
                                        // ищем консеквент в таблице условий
                                        string curConVar = ruleAnt[6].ToString();
                                        string curConVal = ruleAnt[7].ToString();
                                        DataRow[] foundRowsSV = dtVarCon.Select("ident_var = " + "'" + curConVar + "'");
                                        if (foundRowsSV.Length != 0)//уже есть в таблице переменных условий
                                        {
                                            //помещаем новый факт в очередь если до этого не поместили
                                            DataRow[] foundRowsExistInQueue = dtQueue.Select("q_fact_var = " + "'" + curConVar + "'");
                                            if (foundRowsExistInQueue.Length == 0)
                                            {
                                                DataRow dRow = dtQueue.NewRow();
                                                dRow["q_fact_var"] = curConVar;
                                                dRow["q_fact_val"] = curConVal;
                                                dtQueue.Rows.Add(dRow);
                                            }
                                            //правим значения в таблице переменных условий
                                            foundRowsSV[0]["mark_init"] = true;
                                            foundRowsSV[0]["val_var"] = curConVal;
                                            //старый факт-в конец очереди
                                //            dtQueue.Rows[0].Delete();
                                            //DataRow dRowQ = dtQueue.NewRow();
                                            //dRowQ["q_fact_var"] = q_fact_var;
                                            //dRowQ["q_fact_val"] = q_fact_val;
                                            //dtQueue.Rows.Add(dRowQ);

                                        }
                                        else//новый факт, не присутствует в антецендентах 
                                        {
                                            string res = "Получили, что (" + curConVar + " - " + curConVal + ")";
                                            lb_result.Items.Add(res);
                                            DialogResult result = MessageBox.Show(res+"\nПродолжить вычисления?", "Вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                            if (result == DialogResult.No) //Если нажал нет
                                            {
                                                continueAns = continueAnswer.no;
                                                break;
                                            }
                                            if (result == DialogResult.Yes) //Если нажал Да
                                            {
                                                continueAns = continueAnswer.yes;
                                                //break;
                                                continue;
                                            }
                                        }
                                    }
                                    else//не всё нашлось в очереди
                                    {
                                        //dtQueue.Rows[0].Delete();
                                        //DataRow dRowQ = dtQueue.NewRow();
                                        //dRowQ["q_fact_var"] = q_fact_var;
                                        //dRowQ["q_fact_val"] = q_fact_val;
                                        //dtQueue.Rows.Add(dRowQ);
                                        break;
                                    }
                                }
                            }
                        }
                        if (continueAns != continueAnswer.na) break;
                    }
                    if (continueAns == continueAnswer.no) break;
                    //////////////////////////////////////////////////
                    if (ent == entering.was)
                    {
                        dtQueue.Rows[0].Delete();
                        //DataRow dRowQM = dtQueue.NewRow();
                        //dRowQM["q_fact_var"] = q_fact_var;
                        //dRowQM["q_fact_val"] = q_fact_val;
                        //dtQueue.Rows.Add(dRowQM);
                        //ent = entering.wasnot;
                        continue;
                    }
                    ///////////////////////////////////////////////////
                    if (continueAns == continueAnswer.yes)
                    {
                        continueAns = continueAnswer.na;
                        continue;
                    }
                    else
                        if (continueAns == continueAnswer.no)
                        {
                            continueAns = continueAnswer.na;
                            break;
                        }
                        else//вхождение не было найдено
                        {
                            dtQueue.Rows[0].Delete();
                        }
                } while (dtQueue.Rows.Count != 0);
                MessageBox.Show("Работа завершена");
            #endregion

                DataSet dSet = dbWorker.getDataSet();
                dtRule = dSet.Tables[0];
                dgv_rule.DataSource = dtRule;
                for (int i = 0; i < dgv_rule.RowCount; i++)
                {
                    for (int j = 1; j < dgv_rule.ColumnCount; j++)
                    {
                        string ruleAntVal = deleteSpaces(dgv_rule[j, i].Value.ToString());
                        dgv_rule[j, i].Value = ruleAntVal;
                    }

                }
                lb_result.Items.Clear();

        }

        private string deleteSpaces(string inStr)
        {
            return inStr.Trim();
        }

    }
}
