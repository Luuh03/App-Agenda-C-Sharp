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
    public partial class frmTipoComp : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        public frmTipoComp()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTpoId.Text = "";
            txtTpoNome.Text = "";
        }

        private void frmTipoComp_Load(object sender, EventArgs e)
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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if(txtTpoId.Text != "")
            {
                if(txtTpoNome.Text != "")
                {
                    lblRetorno.Text = "";
                    try
                    {
                        string strSql = "Select * from tbltipocomp Where tpoid = " + txtTpoId.Text;
                        objCmd.Connection = objCnx;
                        objCmd.CommandText = strSql;
                        objDados = objCmd.ExecuteReader();
                        if (objDados.HasRows)
                        {
                            MessageBox.Show("Id existente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtTpoId.Focus();
                        }
                        else
                        {
                            if (!objDados.IsClosed) { objDados.Close(); }
                            strSql = "Insert into tbltipocomp (tpoid, tponome) values (";
                            strSql += txtTpoId.Text + ",";
                            strSql += "'" + txtTpoNome.Text + "')";

                            objCmd.Connection = objCnx;
                            objCmd.CommandText = strSql;
                            objCmd.ExecuteNonQuery();
                            MessageBox.Show("Registro incluído com sucesso!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    lblRetorno.Text = "Campo tipo nome inválido!";
                }
            }
            else
            {
                lblRetorno.Text = "Campo tipo id inválido!";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtTpoId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tbltipocomp Where tpoid = " + txtTpoId.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Id inexistente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTpoId.Focus();
                    }
                    else
                    {
                        objDados.Read();
                        txtTpoNome.Text = objDados["tponome"].ToString();
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
            if (txtTpoId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tbltipocomp Where tpoid = " + txtTpoId.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Id inexistente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTpoId.Focus();
                    }
                    else
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }
                        strSql = "Update tbltipocomp set ";
                        strSql += "tponome = '" + txtTpoNome.Text + "' ";
                        strSql += "Where tpoid = " + txtTpoId.Text;

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
            if (txtTpoId.Text != "")
            {
                lblRetorno.Text = "";
                try
                {
                    string strSql = "Select * from tbltipocomp Where tpoid = " + txtTpoId.Text;
                    objCmd.Connection = objCnx;
                    objCmd.CommandText = strSql;
                    objDados = objCmd.ExecuteReader();
                    if (!objDados.HasRows)
                    {
                        MessageBox.Show("Id inexistente!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTpoId.Focus();
                    }
                    else
                    {
                        if (!objDados.IsClosed) { objDados.Close(); }

                        if (MessageBox.Show("Deseja excluir ?", "ADO.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            objCmd.Connection = objCnx;
                            objCmd.CommandText = strSql;
                            objCmd.ExecuteNonQuery();
                            MessageBox.Show("Tipo Eliminado com sucesso!", "ADO.NET", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
