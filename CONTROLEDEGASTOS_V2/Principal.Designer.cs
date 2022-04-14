namespace CONTROLEDEGASTOS_V2
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.lblTotalSaidas = new System.Windows.Forms.Label();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgSaidas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadAno = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadLancamento = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelMensal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelAnual = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.dgEntrada = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaltoTotal = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrada)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalSaidas
            // 
            this.lblTotalSaidas.AutoSize = true;
            this.lblTotalSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaidas.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSaidas.Location = new System.Drawing.Point(472, 467);
            this.lblTotalSaidas.Name = "lblTotalSaidas";
            this.lblTotalSaidas.Size = new System.Drawing.Size(18, 20);
            this.lblTotalSaidas.TabIndex = 21;
            this.lblTotalSaidas.Text = "0";
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.AutoSize = true;
            this.lblTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeral.Location = new System.Drawing.Point(669, 552);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(18, 20);
            this.lblTotalGeral.TabIndex = 19;
            this.lblTotalGeral.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 557);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "Saldo Total";
            // 
            // dgSaidas
            // 
            this.dgSaidas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaidas.Location = new System.Drawing.Point(358, 114);
            this.dgSaidas.Name = "dgSaidas";
            this.dgSaidas.Size = new System.Drawing.Size(326, 340);
            this.dgSaidas.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.lançamentosToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(702, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadAno,
            this.btnCadLancamento});
            this.cadastroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastroToolStripMenuItem.Image")));
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // btnCadAno
            // 
            this.btnCadAno.Name = "btnCadAno";
            this.btnCadAno.Size = new System.Drawing.Size(140, 22);
            this.btnCadAno.Text = "Ano";
            this.btnCadAno.Click += new System.EventHandler(this.btnCadAno_Click);
            // 
            // btnCadLancamento
            // 
            this.btnCadLancamento.Name = "btnCadLancamento";
            this.btnCadLancamento.Size = new System.Drawing.Size(140, 22);
            this.btnCadLancamento.Text = "Lançamento";
            this.btnCadLancamento.Click += new System.EventHandler(this.btnCadLancamento_Click);
            // 
            // lançamentosToolStripMenuItem
            // 
            this.lançamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRelMensal,
            this.btnRelAnual});
            this.lançamentosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lançamentosToolStripMenuItem.Image")));
            this.lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            this.lançamentosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.lançamentosToolStripMenuItem.Text = "Relatórios";
            // 
            // btnRelMensal
            // 
            this.btnRelMensal.Name = "btnRelMensal";
            this.btnRelMensal.Size = new System.Drawing.Size(180, 22);
            this.btnRelMensal.Text = "Mensal";
            this.btnRelMensal.Click += new System.EventHandler(this.btnRelMensal_Click);
            // 
            // btnRelAnual
            // 
            this.btnRelAnual.Name = "btnRelAnual";
            this.btnRelAnual.Size = new System.Drawing.Size(180, 22);
            this.btnRelAnual.Text = "Anual";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSair});
            this.sairToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sairToolStripMenuItem.Image")));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // btnSair
            // 
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblTotalEntradas.Location = new System.Drawing.Point(128, 465);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(18, 20);
            this.lblTotalEntradas.TabIndex = 20;
            this.lblTotalEntradas.Text = "0";
            // 
            // dgEntrada
            // 
            this.dgEntrada.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgEntrada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntrada.Location = new System.Drawing.Point(16, 114);
            this.dgEntrada.Name = "dgEntrada";
            this.dgEntrada.Size = new System.Drawing.Size(326, 340);
            this.dgEntrada.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 470);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total das Saídas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total das Entradas";
            // 
            // dt
            // 
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt.Location = new System.Drawing.Point(16, 52);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(116, 20);
            this.dt.TabIndex = 13;
            this.dt.Value = new System.DateTime(2020, 3, 3, 17, 49, 8, 0);
            this.dt.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            this.dt.Enter += new System.EventHandler(this.dt_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lançamentos do dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Entradas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(357, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Saidas";
            // 
            // lblSaltoTotal
            // 
            this.lblSaltoTotal.AutoSize = true;
            this.lblSaltoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaltoTotal.ForeColor = System.Drawing.Color.Black;
            this.lblSaltoTotal.Location = new System.Drawing.Point(665, 504);
            this.lblSaltoTotal.Name = "lblSaltoTotal";
            this.lblSaltoTotal.Size = new System.Drawing.Size(19, 20);
            this.lblSaltoTotal.TabIndex = 25;
            this.lblSaltoTotal.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 506);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Saldo Total:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 533);
            this.Controls.Add(this.lblSaltoTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTotalSaidas);
            this.Controls.Add(this.lblTotalGeral);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgSaidas);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblTotalEntradas);
            this.Controls.Add(this.dgEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Principal";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROLE DE GASTOS";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Click += new System.EventHandler(this.Principal_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotalSaidas;
        private System.Windows.Forms.Label lblTotalGeral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgSaidas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCadAno;
        private System.Windows.Forms.ToolStripMenuItem btnCadLancamento;
        private System.Windows.Forms.ToolStripMenuItem lançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRelMensal;
        private System.Windows.Forms.ToolStripMenuItem btnRelAnual;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.DataGridView dgEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSaltoTotal;
        private System.Windows.Forms.Label label8;
    }
}

