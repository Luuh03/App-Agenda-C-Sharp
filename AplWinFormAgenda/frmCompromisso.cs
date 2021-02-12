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
    public partial class frmCompromisso : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        public frmCompromisso()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtComId.Text = "";
            txtPesId.Text = "";
            dtpDataHora.Text = "";
            txtComDesc.Text = "";
            txtTpoId.Text = "";
            txtComStatus.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtComId.Text != "")
            {
                if (txtPesId.Text != "")
                {
                    if (dtpDataHora.Text != "")
                    {
                        if (txtComDesc.Text != "")
                        {
                            if (txtTpoId.Text != "")
                            {
                                if (txtComStatus.Text != "")
                                {
                                    lblRetorno.Text = "";
                                    try
                                    {
                                        string strSql = "Select * from tblcompromissos Where comid = " + txtComId.Text;
                                        objCmd.Connection = objCnx;
                                        objCmd.CommandText = strSql;
                                        objDados = objCmd.ExecuteReader();
                                        if (objDados.HasRows)
                                        {
                                            MessageBox.Show("Id existente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            txtComId.Focus();
                                        }
                                        else
                                        {
                                            if (!objDados.IsClosed) { objDados.Close(); }
                                            strSql = "Insert into tblcompromissos (comid, pesid, comdatahora, comdescricao, tpoid, comstatus) values (";
                                            strSql += txtComId.Text + ",";
                                            strSql += "'" + txtPesId.Text + "',";
                                            strSql += "'" + dtpDataHora.Value.Date.ToString("yyyy-MM-dd HH:mm") + "',";
                                            strSql += "'" + txtComDesc.Text + "',";
                                            strSql += "'" + txtTpoId.Text + "',";
                                            strSql += "'" + txtComStatus.Text + "')";

                                            objCmd.Connection = objCnx;
                                            objCmd.CommandText = strSql;
                                            objCmd.ExecuteNonQuery();
                                            MessageBox.Show("Compromisso incluído com sucesso!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                    lblRetorno.Text = "Campo Status inválido!";
                                }
                            }
                            else
                            {
                                lblRetorno.Text = "Campo id tipo inválido!";
                            }
                        }
                        else
                        {
                            lblRetorno.Text = "Campo descrição inválido!";
                        }
                    }
                    else
                    {
                        lblRetorno.Text = "Campo data inválido!";
                    }
                }
                else
                {
                    lblRetorno.Text = "Campo id da pessoa inválido!";
                }
            }
            else
            {
                lblRetorno.Text = "Campo id inválido!";
            }
        }

        private void frmCompromisso_Load(object sender, EventArgs e)
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
            if (txtComId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tblcompromissos Where comid = " + txtComId.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Id inexistente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtComId.Focus();
                    }
                    else
                    {
                        objDados.Read();
                        txtPesId.Text = objDados["pesid"].ToString();
                        dtpDataHora.Text = objDados["comdatahora"].ToString();
                        txtComDesc.Text = objDados["comdescricao"].ToString();
                        txtTpoId.Text = objDados["tpoid"].ToString();
                        txtComStatus.Text = objDados["comstatus"].ToString();
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
            if (txtComId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tblcompromissos Where comid = " + txtComId.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Id inexistente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtComId.Focus();
                    }
                    else
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                        strSql = "Update tblcompromissos set ";
                        strSql += "pesid = '" + txtPesId.Text + "',";
                        strSql += "comdatahora = '" + dtpDataHora.Value.Date.ToString("yyyy-MM-dd HH:mm") + "',";
                        strSql += "comdescricao = '" + txtComDesc.Text + "',";
                        strSql += "tpoid = '" + txtTpoId.Text + "',";
                        strSql += "comstatus = '" + txtComStatus.Text + "' ";
                        strSql += "Where comid = " + txtComId.Text;

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
            if (txtComId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tblcompromissos Where comid = " + txtComId.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Id inexistente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtComId.Focus();
                    }
                    else
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }

                        if (MessageBox.Show("Deseja excluir ?", "ADO.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            objCmd.Connection = objCnx;
                            objCmd.CommandText = strSql;
                            objCmd.ExecuteNonQuery();
                            MessageBox.Show("Compromisso Eliminado com sucesso!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
