using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AplWinFormAgenda
{
    public partial class frmPessoas : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        public frmPessoas()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtPesId.Text = "";
            txtPesNome.Text = "";
            txtPesEmail.Text = "";
            txtPesFixo.Text = "";
            txtPesCelular.Text = "";
            lblRetorno.Text = "";
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtPesId.Text != "")
            {
                if (txtPesNome.Text != "")
                {
                    if (txtPesEmail.Text != "")
                    {
                        if (txtPesFixo.Text != "")
                        {
                            if (txtPesCelular.Text != "")
                            {
                                lblRetorno.Text = "";
                                try
                                {
                                    string strSql = "Select * from tblpessoas Where pesid = " + txtPesId.Text;
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
                                        if(!objDados.IsClosed) { objDados.Close(); }
                                        strSql = "Insert into tblpessoas (pesid, pesnome, pesemail, pestelefonefixo, pestelefonecelular) values (";
                                        strSql += txtPesId.Text + ",";
                                        strSql += "'" + txtPesNome.Text + "',";
                                        strSql += "'" + txtPesEmail.Text + "',";
                                        strSql += "'" + txtPesFixo.Text + "',";
                                        strSql += "'" + txtPesCelular.Text + "')";

                                        objCmd.Connection = objCnx;
                                        objCmd.CommandText = strSql;
                                        objCmd.ExecuteNonQuery();
                                        MessageBox.Show("Registro incluído com sucesso!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    if(!objDados.IsClosed) { objDados.Close(); }
                                }
                                catch (Exception Erro)
                                {
                                    MessageBox.Show("Erro ==> " + Erro.Message, "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                            else
                            {
                                lblRetorno.Text = "Campo celular inválido!";
                            }
                        }
                        else
                        {
                            lblRetorno.Text = "Campo telefone fixo inválido!";
                        }
                    }
                    else
                    {
                        lblRetorno.Text = "Campo e-mail inválido!";
                    }
                }
                else
                {
                    lblRetorno.Text = "Campo nome inválido!";
                }
            }
            else
            {
                lblRetorno.Text = "Campo id inválido!";
            }
        }

        private void frmPessoas_Load(object sender, EventArgs e)
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
                    string strSql = "Select * from tblpessoas Where pesid = " + txtPesId.Text;
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
                        txtPesNome.Text = objDados["pesnome"].ToString();
                        txtPesEmail.Text = objDados["pesemail"].ToString();
                        txtPesFixo.Text = objDados["pestelefonefixo"].ToString();
                        txtPesCelular.Text = objDados["pestelefonecelular"].ToString();
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
                    string strSql = "Select * from tblpessoas Where pesid = " + txtPesId.Text;
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
                        strSql = "Update tblpessoas set ";
                        strSql += "pesnome = '" + txtPesNome.Text + "',";
                        strSql += "pesemail = '" + txtPesEmail.Text + "',";
                        strSql += "pestelefonefixo = '" + txtPesFixo.Text + "',";
                        strSql += "pestelefonecelular = '" + txtPesCelular.Text + "' ";
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if(txtPesId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tblpessoas Where pesid = " + txtPesId.Text;
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
                            MessageBox.Show("Registro Eliminado com sucesso!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
