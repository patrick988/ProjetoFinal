namespace Projeto_final.View
{
    partial class frmmedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmedico));
            this.lblIDMedico = new System.Windows.Forms.Label();
            this.lblnomeMed = new System.Windows.Forms.Label();
            this.lblIdEspecialidade = new System.Windows.Forms.Label();
            this.txtidmed = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.dgmedico = new System.Windows.Forms.DataGridView();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtendereco = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txttelefone = new System.Windows.Forms.TextBox();
            this.txtcpf = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.btninserir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.cmbespecialidade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgmedico)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIDMedico
            // 
            this.lblIDMedico.AutoSize = true;
            this.lblIDMedico.Location = new System.Drawing.Point(28, 69);
            this.lblIDMedico.Name = "lblIDMedico";
            this.lblIDMedico.Size = new System.Drawing.Size(56, 13);
            this.lblIDMedico.TabIndex = 0;
            this.lblIDMedico.Text = "ID Medico";
            // 
            // lblnomeMed
            // 
            this.lblnomeMed.AutoSize = true;
            this.lblnomeMed.Location = new System.Drawing.Point(28, 101);
            this.lblnomeMed.Name = "lblnomeMed";
            this.lblnomeMed.Size = new System.Drawing.Size(35, 13);
            this.lblnomeMed.TabIndex = 1;
            this.lblnomeMed.Text = "Nome";
            // 
            // lblIdEspecialidade
            // 
            this.lblIdEspecialidade.AutoSize = true;
            this.lblIdEspecialidade.Location = new System.Drawing.Point(272, 73);
            this.lblIdEspecialidade.Name = "lblIdEspecialidade";
            this.lblIdEspecialidade.Size = new System.Drawing.Size(76, 13);
            this.lblIdEspecialidade.TabIndex = 2;
            this.lblIdEspecialidade.Text = " Especialidade";
            // 
            // txtidmed
            // 
            this.txtidmed.Location = new System.Drawing.Point(88, 66);
            this.txtidmed.Name = "txtidmed";
            this.txtidmed.Size = new System.Drawing.Size(100, 20);
            this.txtidmed.TabIndex = 3;
            // 
            // txtnome
            // 
            this.txtnome.Location = new System.Drawing.Point(88, 101);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(406, 20);
            this.txtnome.TabIndex = 5;
            // 
            // dgmedico
            // 
            this.dgmedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmedico.Location = new System.Drawing.Point(68, 205);
            this.dgmedico.Name = "dgmedico";
            this.dgmedico.Size = new System.Drawing.Size(426, 169);
            this.dgmedico.TabIndex = 6;
            this.dgmedico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmedico_CellContentClick);
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(28, 141);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 8;
            this.lblEndereco.Text = "Endereco";
            // 
            // txtendereco
            // 
            this.txtendereco.Location = new System.Drawing.Point(87, 138);
            this.txtendereco.Name = "txtendereco";
            this.txtendereco.Size = new System.Drawing.Size(223, 20);
            this.txtendereco.TabIndex = 10;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(330, 141);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 11;
            this.lblTelefone.Text = "Telefone";
            // 
            // txttelefone
            // 
            this.txttelefone.Location = new System.Drawing.Point(385, 138);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(109, 20);
            this.txttelefone.TabIndex = 12;
            // 
            // txtcpf
            // 
            this.txtcpf.Location = new System.Drawing.Point(87, 170);
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.Size = new System.Drawing.Size(100, 20);
            this.txtcpf.TabIndex = 13;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(28, 177);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 14;
            this.lblCpf.Text = "CPF";
            // 
            // btninserir
            // 
            this.btninserir.BackColor = System.Drawing.Color.Transparent;
            this.btninserir.FlatAppearance.BorderSize = 2;
            this.btninserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btninserir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btninserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninserir.Image = ((System.Drawing.Image)(resources.GetObject("btninserir.Image")));
            this.btninserir.Location = new System.Drawing.Point(68, 381);
            this.btninserir.Name = "btninserir";
            this.btninserir.Size = new System.Drawing.Size(120, 44);
            this.btninserir.TabIndex = 15;
            this.btninserir.Text = "Inserir";
            this.btninserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btninserir.UseVisualStyleBackColor = false;
            this.btninserir.Click += new System.EventHandler(this.btninserir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Transparent;
            this.btnAlterar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAlterar.FlatAppearance.BorderSize = 2;
            this.btnAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(231, 381);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(117, 44);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnexcluir.FlatAppearance.BorderSize = 2;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.Location = new System.Drawing.Point(383, 380);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(111, 44);
            this.btnexcluir.TabIndex = 17;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcluir.UseVisualStyleBackColor = false;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // cmbespecialidade
            // 
            this.cmbespecialidade.FormattingEnabled = true;
            this.cmbespecialidade.Location = new System.Drawing.Point(373, 69);
            this.cmbespecialidade.Name = "cmbespecialidade";
            this.cmbespecialidade.Size = new System.Drawing.Size(121, 21);
            this.cmbespecialidade.TabIndex = 18;
            this.cmbespecialidade.SelectedIndexChanged += new System.EventHandler(this.cbespecialidade_SelectedIndexChanged);
            // 
            // frmmedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnAlterar;
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.cmbespecialidade);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btninserir);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtcpf);
            this.Controls.Add(this.txttelefone);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtendereco);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.dgmedico);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.txtidmed);
            this.Controls.Add(this.lblIdEspecialidade);
            this.Controls.Add(this.lblnomeMed);
            this.Controls.Add(this.lblIDMedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmmedico";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Cadastro medico";
            this.Load += new System.EventHandler(this.frmmedico_Load);
            this.Layout += new System.Windows.Forms.LayoutEventHandler(this.frmmedico_Layout);
            ((System.ComponentModel.ISupportInitialize)(this.dgmedico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDMedico;
        private System.Windows.Forms.Label lblnomeMed;
        private System.Windows.Forms.Label lblIdEspecialidade;
        private System.Windows.Forms.TextBox txtidmed;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.DataGridView dgmedico;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtendereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txttelefone;
        private System.Windows.Forms.TextBox txtcpf;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Button btninserir;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.ComboBox cmbespecialidade;
        private System.Windows.Forms.Button btnAlterar;
    }
}