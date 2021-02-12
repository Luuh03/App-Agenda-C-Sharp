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
    public partial class frmUsuarios : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPesId.Text = "";
            txtUsrNome.Text = "";
            txtUsrSenha.Text = "";
            lblRetorno.Text = "";
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtPesId.Text != "")
            {
                if (txtUsrNome.Text != "")
                {
                    if(txtUsrSenha.Text != "")
                    {
                        lblRetorno.Text = "";
                        try
                        {
                            string strSql = "Select * from tblusuarios Where pesid = " + txtPesId.Text;
                            objCmd.Connection = objCnx;
                            objCmd.CommandText = strSql;
                            objDados = objCmd.ExecuteReader();
                            if (objDados.HasRows)
                            {
                                MessageBox.Show("Id existente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtPesId.Focus();
                            }
                            else
                            {
                                if (!objDados.IsClosed) { objDados.Close(); }
                                strSql = "Insert into tblusuarios (pesid, usrnome, usrsenha) values (";
                                strSql += txtPesId.Text + ",";
                                strSql += "'" + txtUsrNome.Text + "',";
                                strSql += "'" + txtUsrSenha.Text + "')";

                                objCmd.Connection = objCnx;
                                objCmd.CommandText = strSql;
                                objCmd.ExecuteNonQuery();
                                MessageBox.Show("Usuário incluído com sucesso!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        lblRetorno.Text = "Senha inválida!";
                    }
                }
                else
                {
                    lblRetorno.Text = "Nome inválido!";
                }
            }
            else
            {
                lblRetorno.Text = "Id da pessoa inválido!";
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if(txtPesId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tblusuarios Where pesid = " + txtPesId.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Id inexistente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPesId.Focus();
                    }
                    else
                    {
                        objDados.Read();
                        txtUsrNome.Text = objDados["usrnome"].ToString();
                        txtUsrSenha.Text = objDados["usrsenha"].ToString();
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
                lblRetorno.Text = "Id inválido!";
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtPesId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tblusuarios Where pesid = " + txtPesId.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Id inexistente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPesId.Focus();
                    }
                    else
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }

                        if (MessageBox.Show("Deseja excluir ?", "ADO.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            objCmd.Connection = objCnx;
                            objCmd.CommandText = strSql;
                            objCmd.ExecuteNonQuery();
                            MessageBox.Show("Usuário Eliminado com sucesso!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
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
                lblRetorno.Text = "Id inválido!";
            }
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if(txtPesId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tblusuarios Where pesid = " + txtPesId.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Id inexistente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPesId.Focus();
                    }
                    else
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                        strSql = "Update tblusuarios set ";
                        strSql += "usrnome = '" + txtUsrNome.Text + "',";
                        strSql += "usrsenha = '" + txtUsrSenha.Text + "' ";
                        strSql += "Where pesid = " + txtPesId.Text;

                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objCmd.ExecuteNonQuery();
                        MessageBox.Show("Alteração realizada com sucesso!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                lblRetorno.Text = "Id inválido!";
            }
            
        }
    }
}
