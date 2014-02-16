using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ExpertSystem
{
    public class DBWorker
    {
        OleDbConnection connection;
        OleDbDataAdapter dataAdapter;
        public DBWorker(string filePath)
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source= "+  filePath;
            connection = new OleDbConnection(connectionString);
        }

        ~DBWorker() {connection = null; }


        public void formStructureKB()
        {
            connection.Open();
            string sql = @"CREATE TABLE KB ("+
                                            "id    integer IDENTITY(1,1), " +
                                            "ind_ant1 char(100), val_ant1 char(100), " +
                                            "ind_ant2 char(100), val_ant2 char(100), " +
                                            "ind_ant3 char(100), val_ant3 char(100), " +
                                            "ind_con char(100), val_con char(100), " +
                                            "PRIMARY KEY(id)) ";
            OleDbCommand command = new OleDbCommand(sql, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Структура базы знаний создана");
        }

        public DataSet getDataSet()
        {
            DataSet dataSet = new DataSet();
            connection.Open();
            {
                string sql = "select * from KB";
                OleDbCommand command = new OleDbCommand(sql, connection);
                dataAdapter = new OleDbDataAdapter(command);
                //getCommands();
                dataAdapter.Fill(dataSet);
            }
            connection.Close();
            return dataSet;
        }

        public void update(DataSet ds)
        {
            try
            {
                OleDbCommandBuilder commandBuilder = new OleDbCommandBuilder(dataAdapter);
                dataAdapter.UpdateCommand = commandBuilder.GetUpdateCommand();
                dataAdapter.InsertCommand = commandBuilder.GetInsertCommand();
                dataAdapter.DeleteCommand = commandBuilder.GetDeleteCommand();
                dataAdapter.Update(ds);
                MessageBox.Show("Изменения сохранены");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
