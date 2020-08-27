namespace CatalogoMusical
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRealName = new System.Windows.Forms.Label();
            this.txtRealName = new System.Windows.Forms.TextBox();
            this.lblInstrument = new System.Windows.Forms.Label();
            this.txtInstrument = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tblMusicos = new System.Windows.Forms.DataGridView();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instrumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblMusicos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome";
            // 
            // lblRealName
            // 
            this.lblRealName.AutoSize = true;
            this.lblRealName.Location = new System.Drawing.Point(142, 15);
            this.lblRealName.Name = "lblRealName";
            this.lblRealName.Size = new System.Drawing.Size(60, 13);
            this.lblRealName.TabIndex = 2;
            this.lblRealName.Text = "Nome Real";
            // 
            // txtRealName
            // 
            this.txtRealName.Location = new System.Drawing.Point(145, 34);
            this.txtRealName.Name = "txtRealName";
            this.txtRealName.Size = new System.Drawing.Size(100, 20);
            this.txtRealName.TabIndex = 3;
            // 
            // lblInstrument
            // 
            this.lblInstrument.AutoSize = true;
            this.lblInstrument.Location = new System.Drawing.Point(276, 15);
            this.lblInstrument.Name = "lblInstrument";
            this.lblInstrument.Size = new System.Drawing.Size(62, 13);
            this.lblInstrument.TabIndex = 4;
            this.lblInstrument.Text = "Instrumento";
            // 
            // txtInstrument
            // 
            this.txtInstrument.Location = new System.Drawing.Point(279, 34);
            this.txtInstrument.Name = "txtInstrument";
            this.txtInstrument.Size = new System.Drawing.Size(100, 20);
            this.txtInstrument.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(396, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 20);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tblMusicos
            // 
            this.tblMusicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblMusicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nome,
            this.nomeReal,
            this.instrumento});
            this.tblMusicos.Location = new System.Drawing.Point(13, 70);
            this.tblMusicos.Name = "tblMusicos";
            this.tblMusicos.Size = new System.Drawing.Size(494, 360);
            this.tblMusicos.TabIndex = 7;
            // 
            // nome
            // 
            this.nome.HeaderText = "Nome Artístico";
            this.nome.Name = "nome";
            this.nome.Width = 150;
            // 
            // nomeReal
            // 
            this.nomeReal.HeaderText = "Nome Real";
            this.nomeReal.Name = "nomeReal";
            this.nomeReal.Width = 150;
            // 
            // instrumento
            // 
            this.instrumento.HeaderText = "Instrumento";
            this.instrumento.Name = "instrumento";
            this.instrumento.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 442);
            this.Controls.Add(this.tblMusicos);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtInstrument);
            this.Controls.Add(this.lblInstrument);
            this.Controls.Add(this.txtRealName);
            this.Controls.Add(this.lblRealName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblMusicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRealName;
        private System.Windows.Forms.TextBox txtRealName;
        private System.Windows.Forms.Label lblInstrument;
        private System.Windows.Forms.TextBox txtInstrument;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView tblMusicos;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeReal;
        private System.Windows.Forms.DataGridViewTextBoxColumn instrumento;
    }
}

