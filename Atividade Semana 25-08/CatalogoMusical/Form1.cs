using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CatalogoMusical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection dbConnection = connectDB();
                MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                sqlSyntax.CommandText = "INSERT INTO `musical`.`musicos` (`nome`, `nomeReal`, `instrumento`) VALUES ('"+ txtName.Text +"', '"+ txtRealName.Text +"', '"+ txtInstrument.Text +"');"; 
                sqlSyntax.ExecuteNonQuery();

                dbConnection.Close();
                MessageBox.Show("Inserido com sucesso");

                txtName.Text = "";
                txtRealName.Text = "";
                txtInstrument.Text = "";
                updateTable();

            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("conexão falhou");
            }
        }

        public void updateTable()
        {
            try
            {
                MySqlConnection dbConnection = connectDB();
                MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                sqlSyntax.CommandText = "SELECT * from musical.musicos;";

                MySqlDataReader reader = sqlSyntax.ExecuteReader();
                tblMusicos.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)tblMusicos.Rows[0].Clone();

                    row.Cells[0].Value = reader.GetString(1);
                    row.Cells[1].Value = reader.GetString(2);
                    row.Cells[2].Value = reader.GetString(3);

                    tblMusicos.Rows.Add(row);

                }
                dbConnection.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("falha ao carregar tabela");
            }

        }

        public MySqlConnection connectDB()
        {
            MySqlConnectionStringBuilder dbAccess = new MySqlConnectionStringBuilder();
            dbAccess.Server = "localhost";
            dbAccess.Database = "musical";
            dbAccess.UserID = "root";
            dbAccess.Password = "afaca12345";
            MySqlConnection dbConnection = new MySqlConnection(dbAccess.ToString());
            dbConnection.Open();
            return dbConnection;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateTable();
        }
    }
}
