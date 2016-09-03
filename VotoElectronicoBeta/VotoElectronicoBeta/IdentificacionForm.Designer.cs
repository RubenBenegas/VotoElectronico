namespace VotoElectronicoBeta
{
    partial class IdentificacionForm
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
            System.Windows.Forms.Label documentoLabel;
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.votanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            documentoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.votanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.Location = new System.Drawing.Point(52, 66);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 3;
            documentoLabel.Text = "Documento:";
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.votanteBindingSource, "Documento", true));
            this.documentoTextBox.Location = new System.Drawing.Point(123, 63);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoTextBox.TabIndex = 4;
            // 
            // votanteBindingSource
            // 
            this.votanteBindingSource.DataSource = typeof(Entidades.Votante);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(152, 136);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 6;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // IdentificacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 261);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBox);
            this.Name = "IdentificacionForm";
            this.Text = "IdentificacionForm";
            ((System.ComponentModel.ISupportInitialize)(this.votanteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource votanteBindingSource;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cancelarButton;
    }
}