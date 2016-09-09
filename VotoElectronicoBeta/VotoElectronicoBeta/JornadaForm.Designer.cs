namespace VotoElectronicoBeta
{
    partial class JornadaForm
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
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label horaComienzoLabel;
            System.Windows.Forms.Label horaFinLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label organizadorLabel;
            this.jornadaElectoralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aceptarButton = new System.Windows.Forms.Button();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.horaComienzoTextBox = new System.Windows.Forms.TextBox();
            this.horaFinTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.organizadorTextBox = new System.Windows.Forms.TextBox();
            fechaLabel = new System.Windows.Forms.Label();
            horaComienzoLabel = new System.Windows.Forms.Label();
            horaFinLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            organizadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jornadaElectoralBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(24, 58);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "Fecha:";
            // 
            // horaComienzoLabel
            // 
            horaComienzoLabel.AutoSize = true;
            horaComienzoLabel.Location = new System.Drawing.Point(24, 84);
            horaComienzoLabel.Name = "horaComienzoLabel";
            horaComienzoLabel.Size = new System.Drawing.Size(82, 13);
            horaComienzoLabel.TabIndex = 9;
            horaComienzoLabel.Text = "Hora Comienzo:";
            // 
            // horaFinLabel
            // 
            horaFinLabel.AutoSize = true;
            horaFinLabel.Location = new System.Drawing.Point(183, 84);
            horaFinLabel.Name = "horaFinLabel";
            horaFinLabel.Size = new System.Drawing.Size(50, 13);
            horaFinLabel.TabIndex = 11;
            horaFinLabel.Text = "Hora Fin:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(24, 32);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 15;
            nombreLabel.Text = "Nombre:";
            // 
            // organizadorLabel
            // 
            organizadorLabel.AutoSize = true;
            organizadorLabel.Location = new System.Drawing.Point(24, 116);
            organizadorLabel.Name = "organizadorLabel";
            organizadorLabel.Size = new System.Drawing.Size(67, 13);
            organizadorLabel.TabIndex = 17;
            organizadorLabel.Text = "Organizador:";
            // 
            // jornadaElectoralBindingSource
            // 
            this.jornadaElectoralBindingSource.DataSource = typeof(Entidades.JornadaElectoral);
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(112, 155);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 6;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(208, 155);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 7;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "CREAR JORNADA ELECTORAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(fechaLabel);
            this.groupBox1.Controls.Add(this.fechaTextBox);
            this.groupBox1.Controls.Add(horaComienzoLabel);
            this.groupBox1.Controls.Add(this.horaComienzoTextBox);
            this.groupBox1.Controls.Add(horaFinLabel);
            this.groupBox1.Controls.Add(this.horaFinTextBox);
            this.groupBox1.Controls.Add(nombreLabel);
            this.groupBox1.Controls.Add(this.nombreTextBox);
            this.groupBox1.Controls.Add(organizadorLabel);
            this.groupBox1.Controls.Add(this.organizadorTextBox);
            this.groupBox1.Controls.Add(this.Cancelar);
            this.groupBox1.Controls.Add(this.aceptarButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 193);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Jornada";
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "Fecha", true));
            this.fechaTextBox.Location = new System.Drawing.Point(112, 55);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.Size = new System.Drawing.Size(79, 20);
            this.fechaTextBox.TabIndex = 8;
            // 
            // horaComienzoTextBox
            // 
            this.horaComienzoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "HoraComienzo", true));
            this.horaComienzoTextBox.Location = new System.Drawing.Point(112, 81);
            this.horaComienzoTextBox.Name = "horaComienzoTextBox";
            this.horaComienzoTextBox.Size = new System.Drawing.Size(41, 20);
            this.horaComienzoTextBox.TabIndex = 10;
            // 
            // horaFinTextBox
            // 
            this.horaFinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "HoraFin", true));
            this.horaFinTextBox.Location = new System.Drawing.Point(239, 81);
            this.horaFinTextBox.Name = "horaFinTextBox";
            this.horaFinTextBox.Size = new System.Drawing.Size(41, 20);
            this.horaFinTextBox.TabIndex = 12;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(112, 29);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(201, 20);
            this.nombreTextBox.TabIndex = 16;
            // 
            // organizadorTextBox
            // 
            this.organizadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "Organizador", true));
            this.organizadorTextBox.Location = new System.Drawing.Point(112, 113);
            this.organizadorTextBox.Name = "organizadorTextBox";
            this.organizadorTextBox.Size = new System.Drawing.Size(100, 20);
            this.organizadorTextBox.TabIndex = 18;
            // 
            // JornadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 251);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "JornadaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JornadaForm";
            this.Load += new System.EventHandler(this.JornadaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jornadaElectoralBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.BindingSource jornadaElectoralBindingSource;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.TextBox horaComienzoTextBox;
        private System.Windows.Forms.TextBox horaFinTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox organizadorTextBox;
    }
}