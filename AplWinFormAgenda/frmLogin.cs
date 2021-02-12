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

namespace AplWinFormAgenda
{
    public partial class frmLogin : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtSenha.Text != "")
                {
                    try
                    {
                        string strSql = "Select * from tblusuarios Where usrnome = '" + txtUsuario.Text + "' and usrsenha = '" + txtSenha.Text + "'";
                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objDados = objCmd.ExecuteReader();
                        if (!objDados.HasRows)
                        {
                            MessageBox.Show("Usuario ou senha incorretos!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            objDados.Close(); 

                            frmPrincipal objPrincipal = new frmPrincipal();
                            objPrincipal.ShowDialog();
                            this.Hide();
                        }
                        if (!objDados.IsClosed) { objDados.Close(); }
                    }
                    catch (Exception Erro)
                    {
                        MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Senha inválida!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Usuário inválido!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            objCnx.Close();
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                objCnx.ConnectionString = "Server=localhost;" +
                                          "Database=bdagenda;" +
                                          "User=root;" +
                                          "Pwd=8ASA76f675Afs5d67fs545";
                objCnx.Open();
            }
            catch (Exception Erro)
            {
                MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
