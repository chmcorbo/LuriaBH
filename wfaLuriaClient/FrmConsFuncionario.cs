using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clBasePOO.DAL;
using clBasePOO.Model;

namespace wfaNotifierBHClient
{
    public partial class FrmConsFuncionario : Form
    {
        private DALFuncionario _dalFuncionario;
        private List<Funcionario> _lista;
        private FrmCadFuncionario _frmCadFuncionario;
        private Funcionario _funcionario;
        public FrmConsFuncionario()
        {
            InitializeComponent();
            _dalFuncionario = new DALFuncionario();
        }

        private void FrmConsFuncionario_Load(object sender, EventArgs e)
        {
            cbCampo.SelectedIndex = 1;
            // lista = _dalFuncionario.ListForAll();
            // dataGridView1.DataSource = lista;
            // dataGridView1.DataMember = "clNotifierBalanceHours.Model.Funcionario";
            // dataGridView1.DataMember = "Funcionario";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string msg = String.Format("Row: {0}, Column: {1} Value: {2}",
                dataGridView1.CurrentCell.RowIndex,
                dataGridView1.CurrentCell.ColumnIndex,
                dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());

            MessageBox.Show(msg, "Current Cell");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Obtendo a matrícula do funcionário selecionado. 
            Int32 _matricula = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);

            if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString() == "Alterar")
            {
                _frmCadFuncionario = new FrmCadFuncionario(_matricula);
                _frmCadFuncionario.Show();
            }
            else if (dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[dataGridView1.CurrentCell.ColumnIndex].Value.ToString() == "Excluir")
            {
                _funcionario = _dalFuncionario.FindByMatricula(_matricula);
                if (_funcionario!=null)
                { 
                    if (MessageBox.Show("Confirma a exclusão deste funcionário?","Confirmação", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                    {
                        _funcionario.Delete(); 
                        _dalFuncionario.PostObject(_funcionario);
                        btnBuscar_Click(sender, e);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbCampo.SelectedIndex==1)
            {
                _lista = _dalFuncionario.FindByName(txtFindText.Text.ToUpper());
            }
            
            dataGridView1.DataSource = _lista;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            _frmCadFuncionario = new FrmCadFuncionario();
            _frmCadFuncionario.Show();
        }
    }
}
