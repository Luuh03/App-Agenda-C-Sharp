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
    public partial class frmPrincipal : Form
    {
        private MySqlConnection objCnx = new MySqlConnection();
        private MySqlCommand objCmd = new MySqlCommand();
        private MySqlDataReader objDados;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void fecharProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            objCnx.Close();
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
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
            tsslblMensagem.Text = "Bem vindo a Agenda Eletrônica";
        }

        private void tmrTempo_Tick(object sender, EventArgs e)
        {
            tsslblData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            tsslblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void microsoftWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecutor.StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\root\\Office16\\WinWord.exe";
            prcExecutor.Start();
        }

        private void microsoftExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecutor.StartInfo.FileName = "C:\\Program Files\\Microsoft Office\\root\\Office16\\Excel.exe";
            prcExecutor.Start();
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prcExecutor.StartInfo.FileName = "Calc.exe";
            prcExecutor.Start();
        }

        private void pessoasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPessoas objPessoas = new frmPessoas();
            objPessoas.ShowDialog();
        }

        private void compromissosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompromisso objCompromisso = new frmCompromisso();
            objCompromisso.ShowDialog();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios objUsuarios = new frmUsuarios();
            objUsuarios.ShowDialog();
        }

        private void tiposDeCompromissosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoComp objTipoComp = new frmTipoComp();
            objTipoComp.ShowDialog();
        }

        private void fazerLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
