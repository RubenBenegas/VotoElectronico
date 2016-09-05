namespace VotoElectronicoBeta
{
    partial class CandidatoForm
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label partidoLabel;
            System.Windows.Forms.Label sloganLabel;
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.partidoTextBox = new System.Windows.Forms.TextBox();
            this.sloganTextBox = new System.Windows.Forms.TextBox();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.candidatoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            apellidoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            partidoLabel = new System.Windows.Forms.Label();
            sloganLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(24, 62);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 1;
            apellidoLabel.Text = "Apellido:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(24, 89);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // partidoLabel
            // 
            partidoLabel.AutoSize = true;
            partidoLabel.Location = new System.Drawing.Point(24, 115);
            partidoLabel.Name = "partidoLabel";
            partidoLabel.Size = new System.Drawing.Size(43, 13);
            partidoLabel.TabIndex = 7;
            partidoLabel.Text = "Partido:";
            // 
            // sloganLabel
            // 
            sloganLabel.AutoSize = true;
            sloganLabel.Location = new System.Drawing.Point(24, 141);
            sloganLabel.Name = "sloganLabel";
            sloganLabel.Size = new System.Drawing.Size(43, 13);
            sloganLabel.TabIndex = 9;
            sloganLabel.Text = "Slogan:";
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidatoBindingSource, "Apellido", true));
            this.apellidoTextBox.Location = new System.Drawing.Point(77, 59);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidoTextBox.TabIndex = 0;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidatoBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(77, 86);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // partidoTextBox
            // 
            this.partidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidatoBindingSource, "Partido", true));
            this.partidoTextBox.Location = new System.Drawing.Point(77, 112);
            this.partidoTextBox.Name = "partidoTextBox";
            this.partidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.partidoTextBox.TabIndex = 2;
            // 
            // sloganTextBox
            // 
            this.sloganTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.candidatoBindingSource, "Slogan", true));
            this.sloganTextBox.Location = new System.Drawing.Point(77, 138);
            this.sloganTextBox.Name = "sloganTextBox";
            this.sloganTextBox.Size = new System.Drawing.Size(100, 20);
            this.sloganTextBox.TabIndex = 3;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(229, 59);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 4;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(229, 89);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 5;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // candidatoBindingSource
            // 
            this.candidatoBindingSource.DataSource = typeof(Entidades.Candidato);
            // 
            // CandidatoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 204);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(partidoLabel);
            this.Controls.Add(this.partidoTextBox);
            this.Controls.Add(sloganLabel);
            this.Controls.Add(this.sloganTextBox);
            this.Name = "CandidatoForm";
            this.Text = "CandidatoForm";
            ((System.ComponentModel.ISupportInitialize)(this.candidatoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource candidatoBindingSource;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox partidoTextBox;
        private System.Windows.Forms.TextBox sloganTextBox;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}