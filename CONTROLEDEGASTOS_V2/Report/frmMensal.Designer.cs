
namespace CONTROLEDEGASTOS_V2.Report
{
    partial class frmMensal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lancamentoanoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.entradaValorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gERENCIAMENTOGASTOSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gERENCIAMENTOGASTOSDataSet = new CONTROLEDEGASTOS_V2.GERENCIAMENTOGASTOSDataSet();
            this.lancamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentoTableAdapter = new CONTROLEDEGASTOS_V2.GERENCIAMENTOGASTOSDataSetTableAdapters.lancamentoTableAdapter();
            this.lancamento_anoTableAdapter = new CONTROLEDEGASTOS_V2.GERENCIAMENTOGASTOSDataSetTableAdapters.lancamento_anoTableAdapter();
            this.entradaValorTableAdapter = new CONTROLEDEGASTOS_V2.GERENCIAMENTOGASTOSDataSetTableAdapters.entradaValorTableAdapter();
            this.saidaValorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saidaValorTableAdapter = new CONTROLEDEGASTOS_V2.GERENCIAMENTOGASTOSDataSetTableAdapters.saidaValorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoanoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gERENCIAMENTOGASTOSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gERENCIAMENTOGASTOSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaValorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lancamentoanoBindingSource
            // 
            this.lancamentoanoBindingSource.DataMember = "lancamento_ano";
            this.lancamentoanoBindingSource.DataSource = this.gERENCIAMENTOGASTOSDataSetBindingSource;
            // 
            // entradaValorBindingSource
            // 
            this.entradaValorBindingSource.DataMember = "entradaValor";
            this.entradaValorBindingSource.DataSource = this.gERENCIAMENTOGASTOSDataSetBindingSource;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lancamentoanoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.entradaValorBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.saidaValorBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CONTROLEDEGASTOS_V2.Report.RelMensal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(26, 55);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(742, 348);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbMes.Location = new System.Drawing.Point(95, 17);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(120, 21);
            this.cbMes.TabIndex = 49;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            this.cbMes.SelectionChangeCommitted += new System.EventHandler(this.cbMes_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Mês:";
            // 
            // gERENCIAMENTOGASTOSDataSetBindingSource
            // 
            this.gERENCIAMENTOGASTOSDataSetBindingSource.DataSource = this.gERENCIAMENTOGASTOSDataSet;
            this.gERENCIAMENTOGASTOSDataSetBindingSource.Position = 0;
            // 
            // gERENCIAMENTOGASTOSDataSet
            // 
            this.gERENCIAMENTOGASTOSDataSet.DataSetName = "GERENCIAMENTOGASTOSDataSet";
            this.gERENCIAMENTOGASTOSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lancamentoBindingSource
            // 
            this.lancamentoBindingSource.DataMember = "lancamento";
            this.lancamentoBindingSource.DataSource = this.gERENCIAMENTOGASTOSDataSet;
            // 
            // lancamentoTableAdapter
            // 
            this.lancamentoTableAdapter.ClearBeforeFill = true;
            // 
            // lancamento_anoTableAdapter
            // 
            this.lancamento_anoTableAdapter.ClearBeforeFill = true;
            // 
            // entradaValorTableAdapter
            // 
            this.entradaValorTableAdapter.ClearBeforeFill = true;
            // 
            // saidaValorBindingSource
            // 
            this.saidaValorBindingSource.DataMember = "saidaValor";
            this.saidaValorBindingSource.DataSource = this.gERENCIAMENTOGASTOSDataSetBindingSource;
            // 
            // saidaValorTableAdapter
            // 
            this.saidaValorTableAdapter.ClearBeforeFill = true;
            // 
            // frmMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmMensal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMensal";
            this.Load += new System.EventHandler(this.frmMensal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoanoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entradaValorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gERENCIAMENTOGASTOSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gERENCIAMENTOGASTOSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saidaValorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private GERENCIAMENTOGASTOSDataSet gERENCIAMENTOGASTOSDataSet;
        private System.Windows.Forms.BindingSource gERENCIAMENTOGASTOSDataSetBindingSource;
        private System.Windows.Forms.BindingSource lancamentoBindingSource;
        private GERENCIAMENTOGASTOSDataSetTableAdapters.lancamentoTableAdapter lancamentoTableAdapter;
        private System.Windows.Forms.BindingSource lancamentoanoBindingSource;
        private GERENCIAMENTOGASTOSDataSetTableAdapters.lancamento_anoTableAdapter lancamento_anoTableAdapter;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource entradaValorBindingSource;
        private GERENCIAMENTOGASTOSDataSetTableAdapters.entradaValorTableAdapter entradaValorTableAdapter;
        private System.Windows.Forms.BindingSource saidaValorBindingSource;
        private GERENCIAMENTOGASTOSDataSetTableAdapters.saidaValorTableAdapter saidaValorTableAdapter;
    }
}