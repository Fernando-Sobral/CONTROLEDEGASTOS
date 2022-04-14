using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLEDEGASTOS_V2.Report
{
    public partial class frmMensal : Form
    {
        public frmMensal()
        {
            InitializeComponent();
        }

        private void frmMensal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gERENCIAMENTOGASTOSDataSet.saidaValor' table. You can move, or remove it, as needed.
            this.saidaValorTableAdapter.Fill(this.gERENCIAMENTOGASTOSDataSet.saidaValor);
            // TODO: This line of code loads data into the 'gERENCIAMENTOGASTOSDataSet.entradaValor' table. You can move, or remove it, as needed.
            this.entradaValorTableAdapter.Fill(this.gERENCIAMENTOGASTOSDataSet.entradaValor);
            // TODO: This line of code loads data into the 'gERENCIAMENTOGASTOSDataSet.lancamento_ano' table. You can move, or remove it, as needed.
            this.lancamento_anoTableAdapter.Fill(this.gERENCIAMENTOGASTOSDataSet.lancamento_ano,cbMes.Text);
            // TODO: This line of code loads data into the 'gERENCIAMENTOGASTOSDataSet.lancamento' table. You can move, or remove it, as needed.
            this.lancamentoTableAdapter.Fill(this.gERENCIAMENTOGASTOSDataSet.lancamento);

            this.reportViewer1.RefreshReport();
        }

        private void cbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //this.lancamento_anoTableAdapter.Fill(this.gERENCIAMENTOGASTOSDataSet.lancamento_ano, cbMes.Text);
         

            //this.reportViewer1.RefreshReport();
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lancamento_anoTableAdapter.Fill(this.gERENCIAMENTOGASTOSDataSet.lancamento_ano, cbMes.Text);


            this.reportViewer1.RefreshReport();
        }
    }
}
