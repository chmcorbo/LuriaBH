using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using clLuriaBH.Dominio.Model;
using clLuriaBH.DAL.MongoDB;
using wfaLuriaBHClient.Enums;


namespace wfaLuriaBHClient
{
    public partial class FrmCadFuncionario : Form
    {
        private Int32 _matricula;
        private Funcionario _funcionario;
        private DALFuncionario _dalFuncionario;
        private StatusForm _statusForm;
        public FrmCadFuncionario()
        {
            Initializer();
            _matricula = 0;
            SetStatusForm();
        }

        public FrmCadFuncionario(Int32 pMatricula)
        {
            Initializer();
            _matricula = pMatricula;
            SetStatusForm();
        }

        private void SetStatusForm(StatusForm pStatusForm)
        {
            _statusForm = pStatusForm;
        }

        private void SetStatusForm()
        {
            if (_matricula == 0)
            {
                _statusForm = StatusForm.stfNew;
                _funcionario = new Funcionario();
            }
            else
            {
                _statusForm = StatusForm.stfEdit;
                _funcionario = _dalFuncionario.BuscarPorMatricula(_matricula);
            }

            btnExcluir.Enabled = (_statusForm != StatusForm.stfNew);
            SetStatusObject();
        }

        private void SetStatusObject()
        {
            if (_statusForm == StatusForm.stfNew)
            {
               _funcionario.Insert();
            }
            else if (_statusForm == StatusForm.stfEdit)
            {
                _funcionario.Edit();
            }
            FillForm();
        }

        private void Initializer()
        {
            InitializeComponent();
            _funcionario = new Funcionario();
            _dalFuncionario = new DALFuncionario();
        }

        private void FillForm()
        {
            txtMatricula.Text = _funcionario.Matricula.ToString();
            txtNome.Text = _funcionario.Nome;
            txtEmail.Text = _funcionario.Email;
        }

        private void UpdateObject()
        {
            _funcionario.Matricula = Convert.ToInt32(txtMatricula.Text);
            _funcionario.Nome = txtNome.Text;
            _funcionario.Email = txtEmail.Text;
        }


        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateObject();
                _dalFuncionario.Post(_funcionario);
                MessageBox.Show("Registro gravado com sucesso.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro durante a inserção do funcionário. " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).Text = (sender as MaskedTextBox).Text.ToUpper();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            (sender as MaskedTextBox).Text = (sender as MaskedTextBox).Text.ToLower();
        }

        private void FrmCadFuncionario_Load(object sender, EventArgs e)
        {
         
        }
    }
}
