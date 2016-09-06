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
            this.candidatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votarButton = new System.Windows.Forms.Button();
            this.imprimirButton = new System.Windows.Forms.Button();
            this.candidatoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // candidatoBindingSource
            // 
            this.candidatoBindingSource.DataSource = typeof(Entidades.Candidato);
            // 
            // votarButton
            // 
            this.votarButton.Location = new System.Drawing.Point(24, 221);
            this.votarButton.Name = "votarButton";
            this.votarButton.Size = new System.Drawing.Size(143, 150);
            this.votarButton.TabIndex = 1;
            this.votarButton.Text = "Votar";
            this.votarButton.UseVisualStyleBackColor = true;
            this.votarButton.Click += new System.EventHandler(this.votarButton_Click);
            // 
            // imprimirButton
            // 
            this.imprimirButton.Location = new System.Drawing.Point(325, 221);
            this.imprimirButton.Name = "imprimirButton";
            this.imprimirButton.Size = new System.Drawing.Size(143, 150);
            this.imprimirButton.TabIndex = 2;
            this.imprimirButton.Text = "Imprimir tiket";
            this.imprimirButton.UseVisualStyleBackColor = true;
            // 
            // candidatoDataGridView
            // 
            this.candidatoDataGridView.AutoGenerateColumns = false;
            this.candidatoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.candidatoDataGridView.DataSource = this.candidatoBindingSource;
            this.candidatoDataGridView.Location = new System.Drawing.Point(24, 12);
            this.candidatoDataGridView.Name = "candidatoDataGridView";
            this.candidatoDataGridView.Size = new System.Drawing.Size(444, 192);
            this.candidatoDataGridView.TabIndex = 2;

            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Apellido";
            this.dataGridViewTextBoxColumn2.HeaderText = "Apellido";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Partido";
            this.dataGridViewTextBoxColumn3.HeaderText = "Partido";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Slogan";
            this.dataGridViewTextBoxColumn4.HeaderText = "Slogan";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // VotacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 423);
            this.Controls.Add(this.candidatoDataGridView);
            this.Controls.Add(this.imprimirButton);
            this.Controls.Add(this.votarButton);
            this.Name = "VotacionForm";
            this.Text = "VotacionForm";
            this.Load += new System.EventHandler(this.VotacionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource candidatoBindingSource;
        private System.Windows.Forms.Button votarButton;
        private System.Windows.Forms.Button imprimirButton;
        private System.Windows.Forms.DataGridView candidatoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}