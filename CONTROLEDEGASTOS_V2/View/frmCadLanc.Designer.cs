namespace CONTROLEDEGASTOS_V2.View
{
    partial class frmCadLanc
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cbBuscarTipo = new System.Windows.Forms.ComboBox();
            this.rdBuscarPorTipo = new System.Windows.Forms.RadioButton();
            this.rrBuscarData = new System.Windows.Forms.RadioButton();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtBuscar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dg = new System.Windows.Forms.DataGridView();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(664, 389);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(13, 13);
            this.lblTotal.TabIndex = 57;
            this.lblTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 389);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Total:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(621, 183);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(57, 20);
            this.txtId.TabIndex = 55;
            this.txtId.Visible = false;
            // 
            // cbBuscarTipo
            // 
            this.cbBuscarTipo.FormattingEnabled = true;
            this.cbBuscarTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saida"});
            this.cbBuscarTipo.Location = new System.Drawing.Point(556, 64);
            this.cbBuscarTipo.Name = "cbBuscarTipo";
            this.cbBuscarTipo.Size = new System.Drawing.Size(121, 21);
            this.cbBuscarTipo.TabIndex = 54;
            this.cbBuscarTipo.Visible = false;
            this.cbBuscarTipo.SelectedIndexChanged += new System.EventHandler(this.cbBuscarTipo_SelectedIndexChanged);
            this.cbBuscarTipo.SelectionChangeCommitted += new System.EventHandler(this.cbBuscarTipo_SelectionChangeCommitted);
            // 
            // rdBuscarPorTipo
            // 
            this.rdBuscarPorTipo.AutoSize = true;
            this.rdBuscarPorTipo.Location = new System.Drawing.Point(385, 41);
            this.rdBuscarPorTipo.Name = "rdBuscarPorTipo";
            this.rdBuscarPorTipo.Size = new System.Drawing.Size(100, 17);
            this.rdBuscarPorTipo.TabIndex = 53;
            this.rdBuscarPorTipo.Text = "Buscar por Tipo";
            this.rdBuscarPorTipo.UseVisualStyleBackColor = true;
            this.rdBuscarPorTipo.CheckedChanged += new System.EventHandler(this.rdBuscarPorTipo_CheckedChanged);
            // 
            // rrBuscarData
            // 
            this.rrBuscarData.AutoSize = true;
            this.rrBuscarData.Location = new System.Drawing.Point(227, 39);
            this.rrBuscarData.Name = "rrBuscarData";
            this.rrBuscarData.Size = new System.Drawing.Size(102, 17);
            this.rrBuscarData.TabIndex = 52;
            this.rrBuscarData.Text = "Buscar por Data";
            this.rrBuscarData.UseVisualStyleBackColor = true;
            this.rrBuscarData.CheckedChanged += new System.EventHandler(this.rrBuscarData_CheckedChanged);
            // 
            // dt
            // 
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(185, 190);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(116, 20);
            this.dt.TabIndex = 51;
            this.dt.Value = new System.DateTime(2020, 3, 3, 17, 49, 8, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 50;
            this.label7.Text = "Data:";
            // 
            // dtBuscar
            // 
            this.dtBuscar.Enabled = false;
            this.dtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBuscar.Location = new System.Drawing.Point(556, 38);
            this.dtBuscar.Name = "dtBuscar";
            this.dtBuscar.Size = new System.Drawing.Size(121, 20);
            this.dtBuscar.TabIndex = 49;
            this.dtBuscar.Value = new System.DateTime(2020, 3, 3, 17, 49, 8, 0);
            this.dtBuscar.Visible = false;
            this.dtBuscar.ValueChanged += new System.EventHandler(this.rdBuscarPorTipo_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(500, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Buscar:";
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
            this.cbMes.Location = new System.Drawing.Point(365, 103);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(120, 21);
            this.cbMes.TabIndex = 47;
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(557, 103);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(121, 21);
            this.cbAno.TabIndex = 46;
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Entrada",
            "Saída"});
            this.cbTipo.Location = new System.Drawing.Point(185, 103);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(121, 21);
            this.cbTipo.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Ano:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(329, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Mês:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tipo:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(558, 141);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(120, 20);
            this.txtValor.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(518, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Valor:";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(376, 389);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(477, 389);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 38;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(284, 389);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 37;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(185, 389);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 36;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Location = new System.Drawing.Point(126, 223);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(552, 150);
            this.dg.TabIndex = 35;
            this.dg.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellClick);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(185, 141);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(212, 20);
            this.txtDescricao.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Descrição:";
            // 
            // frmCadLanc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbBuscarTipo);
            this.Controls.Add(this.rdBuscarPorTipo);
            this.Controls.Add(this.rrBuscarData);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dg);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label1);
            this.Name = "frmCadLanc";
            this.Text = "Lançamentos";
            this.Load += new System.EventHandler(this.frmCadLanc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cbBuscarTipo;
        private System.Windows.Forms.RadioButton rdBuscarPorTipo;
        private System.Windows.Forms.RadioButton rrBuscarData;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
    }
}