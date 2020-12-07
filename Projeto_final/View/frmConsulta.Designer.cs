namespace Projeto_final.View
{
    partial class frmConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsulta));
            this.txtidconsulta = new System.Windows.Forms.TextBox();
            this.lblidconsulta = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lbldata = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblExame = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExame = new System.Windows.Forms.TextBox();
            this.txtDiagnostico = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cbmedico = new System.Windows.Forms.ComboBox();
            this.cbpaciente = new System.Windows.Forms.ComboBox();
            this.bntinserir = new System.Windows.Forms.Button();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtidmedico = new System.Windows.Forms.TextBox();
            this.txtpaci = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtidconsulta
            // 
            this.txtidconsulta.Location = new System.Drawing.Point(140, 20);
            this.txtidconsulta.Name = "txtidconsulta";
            this.txtidconsulta.Size = new System.Drawing.Size(33, 20);
            this.txtidconsulta.TabIndex = 0;
            // 
            // lblidconsulta
            // 
            this.lblidconsulta.AutoSize = true;
            this.lblidconsulta.Location = new System.Drawing.Point(69, 20);
            this.lblidconsulta.Name = "lblidconsulta";
            this.lblidconsulta.Size = new System.Drawing.Size(65, 13);
            this.lblidconsulta.TabIndex = 1;
            this.lblidconsulta.Text = "ID Consulta:";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(101, 80);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(45, 13);
            this.lblMedico.TabIndex = 2;
            this.lblMedico.Text = "Medico:";
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Location = new System.Drawing.Point(315, 81);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(33, 13);
            this.lbldata.TabIndex = 4;
            this.lbldata.Text = "Data:";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(101, 131);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(52, 13);
            this.lblPaciente.TabIndex = 8;
            this.lblPaciente.Text = "Paciente:";
            // 
            // lblExame
            // 
            this.lblExame.AutoSize = true;
            this.lblExame.Location = new System.Drawing.Point(36, 171);
            this.lblExame.Name = "lblExame";
            this.lblExame.Size = new System.Drawing.Size(42, 13);
            this.lblExame.TabIndex = 10;
            this.lblExame.Text = "Exame:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Diagnostico:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtExame
            // 
            this.txtExame.Location = new System.Drawing.Point(84, 168);
            this.txtExame.Multiline = true;
            this.txtExame.Name = "txtExame";
            this.txtExame.Size = new System.Drawing.Size(391, 84);
            this.txtExame.TabIndex = 12;
            this.txtExame.TextChanged += new System.EventHandler(this.txtExame_TextChanged);
            // 
            // txtDiagnostico
            // 
            this.txtDiagnostico.Location = new System.Drawing.Point(86, 262);
            this.txtDiagnostico.Multiline = true;
            this.txtDiagnostico.Name = "txtDiagnostico";
            this.txtDiagnostico.Size = new System.Drawing.Size(389, 93);
            this.txtDiagnostico.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(84, 371);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 150);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // cbmedico
            // 
            this.cbmedico.FormattingEnabled = true;
            this.cbmedico.Location = new System.Drawing.Point(152, 78);
            this.cbmedico.Name = "cbmedico";
            this.cbmedico.Size = new System.Drawing.Size(121, 21);
            this.cbmedico.TabIndex = 15;
            this.cbmedico.SelectedIndexChanged += new System.EventHandler(this.cbmedico_SelectedIndexChanged);
            // 
            // cbpaciente
            // 
            this.cbpaciente.FormattingEnabled = true;
            this.cbpaciente.Location = new System.Drawing.Point(162, 128);
            this.cbpaciente.Name = "cbpaciente";
            this.cbpaciente.Size = new System.Drawing.Size(121, 21);
            this.cbpaciente.TabIndex = 16;
            // 
            // bntinserir
            // 
            this.bntinserir.FlatAppearance.BorderSize = 3;
            this.bntinserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntinserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntinserir.Image = ((System.Drawing.Image)(resources.GetObject("bntinserir.Image")));
            this.bntinserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntinserir.Location = new System.Drawing.Point(86, 540);
            this.bntinserir.Name = "bntinserir";
            this.bntinserir.Size = new System.Drawing.Size(102, 44);
            this.bntinserir.TabIndex = 17;
            this.bntinserir.Text = "Inserir";
            this.bntinserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntinserir.UseVisualStyleBackColor = true;
            this.bntinserir.Click += new System.EventHandler(this.bntinserir_Click);
            // 
            // btnalterar
            // 
            this.btnalterar.FlatAppearance.BorderSize = 3;
            this.btnalterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnalterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnalterar.Image = ((System.Drawing.Image)(resources.GetObject("btnalterar.Image")));
            this.btnalterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnalterar.Location = new System.Drawing.Point(225, 540);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(107, 44);
            this.btnalterar.TabIndex = 18;
            this.btnalterar.Text = "Alterar";
            this.btnalterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.FlatAppearance.BorderSize = 3;
            this.btnexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnexcluir.Image")));
            this.btnexcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcluir.Location = new System.Drawing.Point(367, 540);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(108, 44);
            this.btnexcluir.TabIndex = 19;
            this.btnexcluir.Text = "Excluir";
            this.btnexcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // dateTime
            // 
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime.Location = new System.Drawing.Point(354, 77);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(96, 20);
            this.dateTime.TabIndex = 20;
            // 
            // txtidmedico
            // 
            this.txtidmedico.Location = new System.Drawing.Point(60, 79);
            this.txtidmedico.Name = "txtidmedico";
            this.txtidmedico.Size = new System.Drawing.Size(35, 20);
            this.txtidmedico.TabIndex = 21;
            // 
            // txtpaci
            // 
            this.txtpaci.Location = new System.Drawing.Point(60, 129);
            this.txtpaci.Name = "txtpaci";
            this.txtpaci.Size = new System.Drawing.Size(35, 20);
            this.txtpaci.TabIndex = 22;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(523, 596);
            this.Controls.Add(this.txtpaci);
            this.Controls.Add(this.txtidmedico);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.bntinserir);
            this.Controls.Add(this.cbpaciente);
            this.Controls.Add(this.cbmedico);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDiagnostico);
            this.Controls.Add(this.txtExame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblExame);
            this.Controls.Add(this.lblPaciente);
            this.Controls.Add(this.lbldata);
            this.Controls.Add(this.lblMedico);
            this.Controls.Add(this.lblidconsulta);
            this.Controls.Add(this.txtidconsulta);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frmConsulta";
            this.Text = "Consultas ";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtidconsulta;
        private System.Windows.Forms.Label lblidconsulta;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblExame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExame;
        private System.Windows.Forms.TextBox txtDiagnostico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbmedico;
        private System.Windows.Forms.ComboBox cbpaciente;
        private System.Windows.Forms.Button bntinserir;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox txtidmedico;
        private System.Windows.Forms.TextBox txtpaci;
    }
}