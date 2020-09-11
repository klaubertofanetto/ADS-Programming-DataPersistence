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
        public String idSelected;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateTable();
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

                updateTable();

            } catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("conexão falhou");
            }
        }


        private void tblMusicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tblMusicos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    tblMusicos.CurrentRow.Selected = true;
                    txtName.Text = tblMusicos.Rows[e.RowIndex].Cells["nome"].FormattedValue.ToString();
                    txtRealName.Text = tblMusicos.Rows[e.RowIndex].Cells["nomeReal"].FormattedValue.ToString();
                    txtInstrument.Text = tblMusicos.Rows[e.RowIndex].Cells["instrumento"].FormattedValue.ToString();
                    idSelected = tblMusicos.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();

                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection dbConnection = connectDB();
                MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                sqlSyntax.CommandText = "UPDATE `musical`.`musicos` SET `ativo` = 0 WHERE `id` = '" + idSelected + "';";
                sqlSyntax.ExecuteNonQuery();

                dbConnection.Close();
                MessageBox.Show("Deletado com sucesso");

                updateTable();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("conexão falhou");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection dbConnection = connectDB();
                MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                sqlSyntax.CommandText = "UPDATE `musical`.`musicos` SET `nome` = '" + txtName.Text + "', `nomeReal` = '" + txtRealName.Text + "', `instrumento` = '" + txtInstrument.Text + "' WHERE `id` = '" + idSelected + "';";
                sqlSyntax.ExecuteNonQuery();

                dbConnection.Close();
                MessageBox.Show("Alterado com sucesso");

                updateTable();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("conexão falhou");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtRealName.Clear();
            txtInstrument.Clear();
        }

        public void updateTable()
        {
            txtName.Clear();
            txtRealName.Clear();
            txtInstrument.Clear();
            try
            {
                MySqlConnection dbConnection = connectDB();
                MySqlCommand sqlSyntax = dbConnection.CreateCommand();
                sqlSyntax.CommandText = "SELECT * from musical.musicos WHERE `ativo` = 1;";

                MySqlDataReader reader = sqlSyntax.ExecuteReader();
                tblMusicos.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)tblMusicos.Rows[0].Clone();

                    row.Cells[0].Value = reader.GetString(1);
                    row.Cells[1].Value = reader.GetString(2);
                    row.Cells[2].Value = reader.GetString(3);
                    row.Cells[3].Value = reader.GetString(0);

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
    }
}
