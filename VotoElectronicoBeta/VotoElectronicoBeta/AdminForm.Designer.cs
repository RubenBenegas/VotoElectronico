﻿namespace VotoElectronicoBeta
{
    partial class AdminForm
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
            System.Windows.Forms.Label contraseñaLabel;
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.administradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            contraseñaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Location = new System.Drawing.Point(12, 35);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(64, 13);
            contraseñaLabel.TabIndex = 1;
            contraseñaLabel.Text = "Contraseña:";
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administradorBindingSource, "Contraseña", true));
            this.contraseñaTextBox.Location = new System.Drawing.Point(82, 32);
            this.contraseñaTextBox.MaxLength = 8;
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.PasswordChar = '•';
            this.contraseñaTextBox.Size = new System.Drawing.Size(83, 20);
            this.contraseñaTextBox.TabIndex = 2;
            // 
            // administradorBindingSource
            // 
            this.administradorBindingSource.DataSource = typeof(Entidades.Administrador);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(171, 30);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 3;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(171, 59);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            this.cancelarButton.Click += new System.EventHandler(this.cancelarButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cancelarButton);
            this.groupBox1.Controls.Add(this.contraseñaTextBox);
            this.groupBox1.Controls.Add(this.aceptarButton);
            this.groupBox1.Controls.Add(contraseñaLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 99);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 120);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.administradorBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource administradorBindingSource;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}