namespace VotoElectronicoBeta
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.agregarCandidatoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear jornada";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(60, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Votar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // agregarCandidatoButton
            // 
            this.agregarCandidatoButton.Location = new System.Drawing.Point(60, 154);
            this.agregarCandidatoButton.Name = "agregarCandidatoButton";
            this.agregarCandidatoButton.Size = new System.Drawing.Size(152, 58);
            this.agregarCandidatoButton.TabIndex = 6;
            this.agregarCandidatoButton.Text = "Altas, bajas y modificaciones de candidatos";
            this.agregarCandidatoButton.UseVisualStyleBackColor = true;
            this.agregarCandidatoButton.Click += new System.EventHandler(this.agregarCandidatoButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 368);
            this.Controls.Add(this.agregarCandidatoButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button agregarCandidatoButton;
    }
}