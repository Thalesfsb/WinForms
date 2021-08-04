namespace Thales
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btIncluir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mtbData = new System.Windows.Forms.MaskedTextBox();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.tbNivel = new System.Windows.Forms.TextBox();
            this.tbDistancia = new System.Windows.Forms.TextBox();
            this.tbCusto = new System.Windows.Forms.TextBox();
            this.lbNivelDor = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbCaptura = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.lbDistancia = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.lbCusto = new System.Windows.Forms.Label();
            this.lvwVOO = new System.Windows.Forms.ListView();
            this.col_ID_VOO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_DATA_VOO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_CAPTURA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_NIVEL_DOR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btExcluir);
            this.panel1.Controls.Add(this.btIncluir);
            this.panel1.Location = new System.Drawing.Point(332, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 30);
            this.panel1.TabIndex = 1;
            // 
            // btExcluir
            // 
            this.btExcluir.Location = new System.Drawing.Point(84, 3);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 23);
            this.btExcluir.TabIndex = 7;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btIncluir
            // 
            this.btIncluir.Location = new System.Drawing.Point(3, 3);
            this.btIncluir.Name = "btIncluir";
            this.btIncluir.Size = new System.Drawing.Size(75, 23);
            this.btIncluir.TabIndex = 6;
            this.btIncluir.Text = "Incluir";
            this.btIncluir.UseVisualStyleBackColor = true;
            this.btIncluir.Click += new System.EventHandler(this.btIncluir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mtbData);
            this.panel2.Controls.Add(this.rbSim);
            this.panel2.Controls.Add(this.rbNao);
            this.panel2.Controls.Add(this.tbNivel);
            this.panel2.Controls.Add(this.tbDistancia);
            this.panel2.Controls.Add(this.tbCusto);
            this.panel2.Controls.Add(this.lbNivelDor);
            this.panel2.Controls.Add(this.lbData);
            this.panel2.Controls.Add(this.lbCaptura);
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.lbDistancia);
            this.panel2.Controls.Add(this.btSalvar);
            this.panel2.Controls.Add(this.lbCusto);
            this.panel2.Location = new System.Drawing.Point(332, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(203, 240);
            this.panel2.TabIndex = 2;
            // 
            // mtbData
            // 
            this.mtbData.Location = new System.Drawing.Point(60, 23);
            this.mtbData.Mask = "00/00/0000";
            this.mtbData.Name = "mtbData";
            this.mtbData.Size = new System.Drawing.Size(137, 20);
            this.mtbData.TabIndex = 0;
            this.mtbData.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtbData.ValidatingType = typeof(System.DateTime);
            this.mtbData.TextChanged += new System.EventHandler(this.mtbData_TextChanged);
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(115, 101);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(42, 17);
            this.rbSim.TabIndex = 4;
            this.rbSim.Text = "Sim";
            this.rbSim.UseVisualStyleBackColor = true;
            this.rbSim.CheckedChanged += new System.EventHandler(this.rbSim_CheckedChanged);
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(60, 99);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(45, 17);
            this.rbNao.TabIndex = 3;
            this.rbNao.Text = "Não";
            this.rbNao.UseVisualStyleBackColor = true;
            this.rbNao.CheckedChanged += new System.EventHandler(this.rbNao_CheckedChanged);
            // 
            // tbNivel
            // 
            this.tbNivel.Location = new System.Drawing.Point(60, 122);
            this.tbNivel.Name = "tbNivel";
            this.tbNivel.Size = new System.Drawing.Size(137, 20);
            this.tbNivel.TabIndex = 5;
            this.tbNivel.TextChanged += new System.EventHandler(this.tbNivel_TextChanged);
            // 
            // tbDistancia
            // 
            this.tbDistancia.Location = new System.Drawing.Point(60, 73);
            this.tbDistancia.Name = "tbDistancia";
            this.tbDistancia.Size = new System.Drawing.Size(137, 20);
            this.tbDistancia.TabIndex = 2;
            this.tbDistancia.TextChanged += new System.EventHandler(this.tbDistancia_TextChanged);
            // 
            // tbCusto
            // 
            this.tbCusto.Location = new System.Drawing.Point(60, 48);
            this.tbCusto.Name = "tbCusto";
            this.tbCusto.Size = new System.Drawing.Size(137, 20);
            this.tbCusto.TabIndex = 1;
            this.tbCusto.TextChanged += new System.EventHandler(this.tbCusto_TextChanged);
            // 
            // lbNivelDor
            // 
            this.lbNivelDor.AutoSize = true;
            this.lbNivelDor.Location = new System.Drawing.Point(3, 125);
            this.lbNivelDor.Name = "lbNivelDor";
            this.lbNivelDor.Size = new System.Drawing.Size(51, 13);
            this.lbNivelDor.TabIndex = 6;
            this.lbNivelDor.Text = "Nível dor";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(4, 26);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(30, 13);
            this.lbData.TabIndex = 2;
            this.lbData.Text = "Data";
            // 
            // lbCaptura
            // 
            this.lbCaptura.AutoSize = true;
            this.lbCaptura.Location = new System.Drawing.Point(4, 103);
            this.lbCaptura.Name = "lbCaptura";
            this.lbCaptura.Size = new System.Drawing.Size(44, 13);
            this.lbCaptura.TabIndex = 5;
            this.lbCaptura.Text = "Captura";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(115, 190);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // lbDistancia
            // 
            this.lbDistancia.AutoSize = true;
            this.lbDistancia.Location = new System.Drawing.Point(4, 77);
            this.lbDistancia.Name = "lbDistancia";
            this.lbDistancia.Size = new System.Drawing.Size(51, 13);
            this.lbDistancia.TabIndex = 4;
            this.lbDistancia.Text = "Distancia";
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(34, 190);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 8;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // lbCusto
            // 
            this.lbCusto.AutoSize = true;
            this.lbCusto.Location = new System.Drawing.Point(4, 51);
            this.lbCusto.Name = "lbCusto";
            this.lbCusto.Size = new System.Drawing.Size(34, 13);
            this.lbCusto.TabIndex = 3;
            this.lbCusto.Text = "Custo";
            // 
            // lvwVOO
            // 
            this.lvwVOO.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_ID_VOO,
            this.col_DATA_VOO,
            this.col_CAPTURA,
            this.col_NIVEL_DOR});
            this.lvwVOO.FullRowSelect = true;
            this.lvwVOO.HideSelection = false;
            this.lvwVOO.Location = new System.Drawing.Point(12, 19);
            this.lvwVOO.MultiSelect = false;
            this.lvwVOO.Name = "lvwVOO";
            this.lvwVOO.ShowItemToolTips = true;
            this.lvwVOO.Size = new System.Drawing.Size(304, 259);
            this.lvwVOO.TabIndex = 10;
            this.lvwVOO.UseCompatibleStateImageBehavior = false;
            this.lvwVOO.View = System.Windows.Forms.View.Details;
            this.lvwVOO.Click += new System.EventHandler(this.lvwVOO_Click);
            // 
            // col_ID_VOO
            // 
            this.col_ID_VOO.Text = "Id";
            this.col_ID_VOO.Width = 0;
            // 
            // col_DATA_VOO
            // 
            this.col_DATA_VOO.Text = "Data";
            this.col_DATA_VOO.Width = 70;
            // 
            // col_CAPTURA
            // 
            this.col_CAPTURA.Text = "Captura";
            // 
            // col_NIVEL_DOR
            // 
            this.col_NIVEL_DOR.Text = "Nível de dor";
            this.col_NIVEL_DOR.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 307);
            this.Controls.Add(this.lvwVOO);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ECME FLIGHT MANAGER";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btIncluir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNivelDor;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbCaptura;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label lbDistancia;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Label lbCusto;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.TextBox tbNivel;
        private System.Windows.Forms.TextBox tbDistancia;
        private System.Windows.Forms.TextBox tbCusto;
        private System.Windows.Forms.MaskedTextBox mtbData;
        private System.Windows.Forms.ListView lvwVOO;
        private System.Windows.Forms.ColumnHeader col_ID_VOO;
        private System.Windows.Forms.ColumnHeader col_DATA_VOO;
        private System.Windows.Forms.ColumnHeader col_CAPTURA;
        private System.Windows.Forms.ColumnHeader col_NIVEL_DOR;
    }
}

