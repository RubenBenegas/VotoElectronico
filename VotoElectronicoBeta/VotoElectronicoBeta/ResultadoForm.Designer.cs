namespace VotoElectronicoBeta
{
    partial class ResultadoForm
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
            this.resultadoJornadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultadoJornadaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultadoJornadaBindingSource
            // 
            this.resultadoJornadaBindingSource.DataSource = typeof(Entidades.ResultadoJornada);
            // 
            // resultadoJornadaDataGridView
            // 
            this.resultadoJornadaDataGridView.AllowUserToAddRows = false;
            this.resultadoJornadaDataGridView.AllowUserToDeleteRows = false;
            this.resultadoJornadaDataGridView.AutoGenerateColumns = false;
            this.resultadoJornadaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadoJornadaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.resultadoJornadaDataGridView.DataSource = this.resultadoJornadaBindingSource;
            this.resultadoJornadaDataGridView.Location = new System.Drawing.Point(12, 12);
            this.resultadoJornadaDataGridView.Name = "resultadoJornadaDataGridView";
            this.resultadoJornadaDataGridView.ReadOnly = true;
            this.resultadoJornadaDataGridView.Size = new System.Drawing.Size(295, 220);
            this.resultadoJornadaDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Candidato";
            this.dataGridViewTextBoxColumn1.HeaderText = "Candidato";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CantidadDeVotos";
            this.dataGridViewTextBoxColumn2.HeaderText = "CantidadDeVotos";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // salirButton
            // 
            this.salirButton.Location = new System.Drawing.Point(232, 238);
            this.salirButton.Name = "salirButton";
            this.salirButton.Size = new System.Drawing.Size(75, 23);
            this.salirButton.TabIndex = 2;
            this.salirButton.Text = "Salir";
            this.salirButton.UseVisualStyleBackColor = true;
            this.salirButton.Click += new System.EventHandler(this.salirButton_Click);
            // 
            // ResultadoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 272);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.resultadoJornadaDataGridView);
            this.Name = "ResultadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadoForm";
            this.Load += new System.EventHandler(this.ResultadoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource resultadoJornadaBindingSource;
        private System.Windows.Forms.DataGridView resultadoJornadaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button salirButton;
    }
}