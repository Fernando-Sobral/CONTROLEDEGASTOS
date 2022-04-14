using CONTROLEDEGASTOS_V2.Entidades;
using CONTROLEDEGASTOS_V2.Models;
using CONTROLEDEGASTOS_V2.Report;
using CONTROLEDEGASTOS_V2.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTROLEDEGASTOS_V2
{
    public partial class Principal : Form
    {
        AnoModel modelA = new AnoModel();
        Lancamentos obj = new Lancamentos();
        public Principal()
        {
            InitializeComponent();
           
            Listar();
            totalizar();
        }

        private void totalizar()
        {
            decimal total = valorTotalEntradas() - valorTotalSaidas();
            lblTotalEntradas.Text = valorTotalEntradas().ToString();
            lblTotalSaidas.Text = valorTotalSaidas().ToString();
            lblTotalGeral.Text = Convert.ToString(total);

            if (Convert.ToDecimal(lblTotalGeral.Text) < 0)
            {
                lblTotalGeral.ForeColor = Color.Red;
            }
            else
            {
                lblTotalGeral.ForeColor = Color.Green;
            }
        }

        private void btnCadAno_Click(object sender, EventArgs e)
        {
            frmCadAno frm = new frmCadAno();
            frm.ShowDialog();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void btnCadLancamento_Click(object sender, EventArgs e)
        {
            frmCadLanc frm = new frmCadLanc();
            frm.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            buscar();
        }
        private void buscar()
        {
            obj.Data = Convert.ToDateTime(dt.Text);
            //obj.Tipo = "Entrada";
            List<Lancamentos> lista = new List<Lancamentos>();
            lista = new LancModel().BuscarDataTipoEntrada(obj);
            dgEntrada.AutoGenerateColumns = false;
            dgEntrada.DataSource = lista;

            List<Lancamentos> lista2 = new List<Lancamentos>();
            lista2 = new LancModel().BuscarDataTipoSaida(obj);
            dgSaidas.AutoGenerateColumns = false;
            dgSaidas.DataSource = lista2;

            totalizar();
        }


        private void Listar()
        {
            try
            {
                List<Lancamentos> lista = new List<Lancamentos>();
               

                dgEntrada.DataSource = lista;
                dgEntrada.Columns[0].Visible = false;
                dgEntrada.Columns[4].Visible = false;
                dgEntrada.Columns[5].Visible = false;
                dgEntrada.Columns[1].Visible = false;
               // dgEntrada.Columns[6].Visible = false;
                dgEntrada.Columns[1].HeaderText = "Tipo";
                dgEntrada.Columns[2].HeaderText = "Descricao";
                dgEntrada.Columns[3].HeaderText = "Valor";
                dgEntrada.Columns[6].HeaderText = "Data";

                dgEntrada.Columns[2].Width = 200;


                List<Lancamentos> lista2 = new List<Lancamentos>();


                dgSaidas.DataSource = lista;
                dgSaidas.Columns[0].Visible = false;
                dgSaidas.Columns[4].Visible = false;
                dgSaidas.Columns[5].Visible = false;
                dgSaidas.Columns[1].Visible = false;
                // dgEntrada.Columns[6].Visible = false;
                dgSaidas.Columns[1].HeaderText = "Tipo";
                dgSaidas.Columns[2].HeaderText = "Descricao";
                dgSaidas.Columns[3].HeaderText = "Valor";
                dgSaidas.Columns[6].HeaderText = "Data";

                dgSaidas.Columns[2].Width = 200;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possível listar os dados " + ex);
            }
        }

        private void dt_Enter(object sender, EventArgs e)
        {
            dt.Value = DateTime.Now;
        }

        private decimal valorTotalEntradas()
        {
            decimal total = 0;

            int i = 0;
            for (i = 0; i < dgEntrada.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgEntrada.Rows[i].Cells[3].Value);
            }
            return total;

        }

        private decimal valorTotalSaidas()
        {
            decimal total = 0;

            int i = 0;
            for (i = 0; i < dgSaidas.Rows.Count; i++)
            {
                total = total + Convert.ToDecimal(dgSaidas.Rows[i].Cells[3].Value);
            }
            return total;

        }

        private void Principal_Click(object sender, EventArgs e)
        {
            buscar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRelMensal_Click(object sender, EventArgs e)
        {
            frmMensal frm = new frmMensal();
            frm.ShowDialog();
        }
    }
}
