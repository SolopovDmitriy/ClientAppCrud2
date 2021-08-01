using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientApp
{
    public partial class Form1 : Form
    {
        private string _dp;
        private string _connectionString;

        private DbProviderFactory _dbProviderFactory;
        private DbConnection _dbConn;
        private DataTable _dataTable;
        private DbDataAdapter _dataAdapter;
        private DataSet _dataSet;

        string filePath;

        //[System.ComponentModel.Browsable(false)]
        public override bool AutoSize { get; set; }

        public Form1()
        {
            InitializeComponent();
            _dp = ConfigurationManager.AppSettings["MSSQLProvider"];
            _connectionString = ConfigurationManager.ConnectionStrings["MSSQLProvider"].ConnectionString;
            _dbProviderFactory = DbProviderFactories.GetFactory(_dp);
            _dbConn = _dbProviderFactory.CreateConnection();
            _dbConn.ConnectionString = _connectionString;
            _dataAdapter = _dbProviderFactory.CreateDataAdapter();
            _dataSet = new DataSet();
            textBox_Query.Text = "select * from users_info";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //_dataTable = new DataTable(); //пустая таблица
            ///*Определяю столбцы*/
            //_dataTable.Columns.Add("Id");
            //_dataTable.Columns.Add("Login");
            //_dataTable.Columns.Add("Email");
            //_dataTable.Columns.Add("Password");

            ///*создаю строку данных*/
            //DataRow dataRow = _dataTable.NewRow();
            //dataRow[0] = 1;
            //dataRow[1] = "Test user";
            //dataRow[2] = "testemail.om";
            //dataRow[3] = "qwerty";

            //_dataTable.Rows.Add(dataRow);
            ///*привязываю DataTable к DataGridView*/
            //dataGridView_Results.DataSource = _dataTable;
        }

        private void button_Execute_Click(object sender, EventArgs e)
        {
            DbDataReader resultReader = null;
            try
            {
                if (textBox_Query.Text.Length >= 5)
                {
                    _dataTable = new DataTable();

                    DbCommand dbSelectAllUsersCommand = _dbProviderFactory.CreateCommand();
                    dbSelectAllUsersCommand.Connection = _dbConn;
                    dbSelectAllUsersCommand.CommandText = textBox_Query.Text;
                    _dbConn.Open();
                    resultReader = dbSelectAllUsersCommand.ExecuteReader();
                    //toolStripStatusLabel_Info.Text = resultReader.
                    int line = 0;
                    do
                    {
                        while (resultReader.Read())
                        {
                            if (line == 0)
                            {
                                for (int i = 0; i < resultReader.FieldCount; i++)
                                {
                                    _dataTable.Columns.Add(resultReader.GetName(i));
                                }
                                line++;
                            }
                                DataRow currentRow = _dataTable.NewRow();
                                for (int i = 0; i < resultReader.FieldCount; i++)
                                {
                                    currentRow[i] = resultReader[i];
                                }
                                _dataTable.Rows.Add(currentRow);
                        }
                    } while (resultReader.NextResult());
                    dataGridView_Results.DataSource = _dataTable;
                }
                else
                {
                    toolStripStatusLabel_Info.ForeColor = Color.Red;
                    toolStripStatusLabel_Info.Text = "Тело  запроса не межет быть пустым";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _dbConn.Close();
                if(resultReader != null) resultReader.Close();
            }
        }

        private void button_Exexute_set_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Query.Text.Length >= 5)
                {
                    //_dataAdapter.SelectCommand
                    //_dataAdapter.InsertCommand
                    //_dataAdapter.UpdateCommand
                    //_dataAdapter.DeleteCommand


                    //_dataAdapter.Fill() //select
                    //_dataAdapter.Update(); //insert-delete-update

                    _dataSet.Clear();
                    DbCommand command = _dbProviderFactory.CreateCommand();
                    command.Connection = _dbConn;
                    command.CommandText = textBox_Query.Text;
                    _dataAdapter.SelectCommand = command;
                    _dataAdapter.Fill(_dataSet);
                    dataGridView_Results.DataSource = _dataSet.Tables[0];

                    Debug.WriteLine(_dataAdapter.UpdateCommand);
                    Debug.WriteLine(_dataAdapter.InsertCommand);
                    Debug.WriteLine(_dataAdapter.DeleteCommand);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                _dbConn.Close();
            }
        }

        private void button_ExecUpdate_Click(object sender, EventArgs e)
        {
            //Пользовательская логика синхронизации GridView <=> dataAdapter <=> DB
            //_dataAdapter.SelectCommand
            //_dataAdapter.InsertCommand
            //_dataAdapter.UpdateCommand
            //_dataAdapter.DeleteCommand
            DbCommand dbSelectCommand = _dbProviderFactory.CreateCommand();
            dbSelectCommand.Connection = _dbConn;
            dbSelectCommand.CommandText = "select * from users_info";
            _dataAdapter.SelectCommand = dbSelectCommand;

            _dataAdapter.Fill(_dataSet);

            /*DbCommandBuilder dbCommandBuilder = _dbProviderFactory.CreateCommandBuilder();
            dbCommandBuilder.DataAdapter = _dataAdapter;
            dbCommandBuilder.GetDeleteCommand();
            dbCommandBuilder.GetInsertCommand();
            dbCommandBuilder.GetUpdateCommand();*/


            /*Пользовательская логика - UpdateCommand -----------------------------------------------------start*/
            //DbCommand dbCommandUpdate = _dbProviderFactory.CreateCommand();
            //dbCommandUpdate.Connection = _dbConn;
            //dbCommandUpdate.CommandText = "UPDATE users SET password = @pPassword WHERE Id = @iId";

            //DbParameter dbPasswordParameter = dbCommandUpdate.CreateParameter();
            //dbPasswordParameter.DbType = DbType.String;
            //dbPasswordParameter.ParameterName = "@pPassword";
            //dbPasswordParameter.SourceVersion = DataRowVersion.Current;
            //dbPasswordParameter.SourceColumn = "password";
            //dbCommandUpdate.Parameters.Add(dbPasswordParameter);

            //DbParameter dbIdParameter = dbCommandUpdate.CreateParameter();
            //dbIdParameter.DbType = DbType.Int32;
            //dbIdParameter.ParameterName = "@iId";
            //dbIdParameter.SourceColumn = "Id";
            //dbIdParameter.SourceVersion = DataRowVersion.Original;
            //dbCommandUpdate.Parameters.Add(dbIdParameter);

            //_dataAdapter.UpdateCommand = dbCommandUpdate;
            /*Пользовательская логика - UpdateCommand ------------------------------------------------------------end*/






            /*Пользовательская логика - InsertCommand ----------start*/
            // TODO change size
            byte[] file;
            //filePath = @"D:\Новая папка (4)\Screenshots\Снимок экрана (1).png";
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    file = reader.ReadBytes((int)stream.Length);
                    DbCommand dbCommandInsert = _dbProviderFactory.CreateCommand();
                    dbCommandInsert.Connection = _dbConn;
                    dbCommandInsert.CommandText = "insert into users_info (user_id, email, avatar) Values(@user_id2, @email2, @avatar2)";

                    DbParameter user_idParam = dbCommandInsert.CreateParameter();
                    user_idParam.DbType = DbType.Int32;
                    user_idParam.ParameterName = "@user_id2";
                    user_idParam.SourceVersion = DataRowVersion.Current;
                    user_idParam.SourceColumn = "user_id";
                    dbCommandInsert.Parameters.Add(user_idParam);

                    DbParameter emailParam = dbCommandInsert.CreateParameter();
                    emailParam.DbType = DbType.String;
                    emailParam.ParameterName = "@email2";
                    emailParam.SourceColumn = "email";
                    emailParam.SourceVersion = DataRowVersion.Original;
                    dbCommandInsert.Parameters.Add(emailParam);

                    
                    DbParameter avatarParam = dbCommandInsert.CreateParameter();
                    avatarParam.DbType = DbType.Binary;
                    avatarParam.ParameterName = "@avatar2";
                    avatarParam.Value = file;
                    avatarParam.Size = file.Length;
                    Debug.WriteLine(filePath);
                    dbCommandInsert.Parameters.Add(avatarParam);

                    //dbCommandInsert.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
                   
                    _dataAdapter.InsertCommand = dbCommandInsert;
                }
            }
            /*Пользовательская логика - InsertCommand ----------end*/





            _dataAdapter.Update(_dataSet);

            _dataSet.Clear();
            _dataAdapter.Fill(_dataSet);
            dataGridView_Results.DataSource = _dataSet.Tables[0];
        }

        private void dataGridView_Results_CellLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_FilterExec_Click(object sender, EventArgs e)
        {
            if(textBox_RowFilter.Text.Length >= 5)
            {
                DataViewManager dataViewManager = new DataViewManager(_dataSet);
                dataViewManager.DataViewSettings[0].RowFilter = textBox_RowFilter.Text;

                DataView dataViewFiltered = dataViewManager.CreateDataView(_dataSet.Tables[0]);
                dataGridView_Results.DataSource = dataViewFiltered;
            }
        }

        private void button_SortExec_Click(object sender, EventArgs e)
        {

            if (textBox_SortFilter.Text.Length >= 3)
            { 
                DataViewManager dataViewManager = new DataViewManager(_dataSet);
                dataViewManager.DataViewSettings[0].Sort = textBox_SortFilter.Text;

                DataView dataViewSorted = dataViewManager.CreateDataView(_dataSet.Tables[0]);
                dataGridView_Results.DataSource = dataViewSorted;
            }
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {               
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {                    
                    filePath = openFileDialog.FileName;
                }
            }
            this.textBox_RowFilter.AutoSize = false;
            this.textBox_RowFilter.Text = "Hello world!";
            this.textBox_RowFilter.Font = new System.Drawing.Font("ArialBlack", 8, FontStyle.Regular);


        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            Process.Start("mspaint.exe");
        }
    }
}
