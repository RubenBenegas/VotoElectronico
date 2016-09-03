namespace VotoElectronicoBeta
{
    partial class VotacionForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.candidatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sloganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.votarButton = new System.Windows.Forms.Button();
            this.imprimirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.partidoDataGridViewTextBoxColumn,
            this.sloganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.candidatoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // candidatoBindingSource
            // 
            this.candidatoBindingSource.DataSource = typeof(Entidades.Candidato);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // partidoDataGridViewTextBoxColumn
            // 
            this.partidoDataGridViewTextBoxColumn.DataPropertyName = "Partido";
            this.partidoDataGridViewTextBoxColumn.HeaderText = "Partido";
            this.partidoDataGridViewTextBoxColumn.Name = "partidoDataGridViewTextBoxColumn";
            // 
            // sloganDataGridViewTextBoxColumn
            // 
            this.sloganDataGridViewTextBoxColumn.DataPropertyName = "Slogan";
            this.sloganDataGridViewTextBoxColumn.HeaderText = "Slogan";
            this.sloganDataGridViewTextBoxColumn.Name = "sloganDataGridViewTextBoxColumn";
            // 
            // votarButton
            // 
            this.votarButton.Location = new System.Drawing.Point(12, 221);
            this.votarButton.Name = "votarButton";
            this.votarButton.Size = new System.Drawing.Size(143, 150);
            this.votarButton.TabIndex = 1;
            this.votarButton.Text = "Votar";
            this.votarButton.UseVisualStyleBackColor = true;
            // 
            // imprimirButton
            // 
            this.imprimirButton.Location = new System.Drawing.Point(412, 221);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(143, 150);
            this.imprimirButton.TabIndex = 2;
            this.imprimirButton.Text = "Imprimir tiket";
            this.imprimirButton.UseVisualStyleBackColor = true;
            // 
            // VotacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 423);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.votarButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VotacionForm";
            this.Text = "VotacionForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource candidatoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sloganDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button votarButton;
        private System.Windows.Forms.Button imprimirButton;
    }
}