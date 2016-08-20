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
            System.Windows.Forms.Label nroDeJornadaLabel;
            System.Windows.Forms.Label organizadorLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JornadaForm));
            this.jornadaElectoralBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.jornadaElectoralBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaComienzoTextBox = new System.Windows.Forms.TextBox();
            this.horaFinTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.nroDeJornadaTextBox = new System.Windows.Forms.TextBox();
            this.organizadorTextBox = new System.Windows.Forms.TextBox();
            this.aceptarBbutton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.jornadaElectoralBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fechaLabel = new System.Windows.Forms.Label();
            horaComienzoLabel = new System.Windows.Forms.Label();
            horaFinLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            nroDeJornadaLabel = new System.Windows.Forms.Label();
            organizadorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jornadaElectoralBindingNavigator)).BeginInit();
            this.jornadaElectoralBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jornadaElectoralBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(24, 97);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 1;
            fechaLabel.Text = "Fecha:";
            // 
            // horaComienzoLabel
            // 
            horaComienzoLabel.AutoSize = true;
            horaComienzoLabel.Location = new System.Drawing.Point(24, 122);
            horaComienzoLabel.Name = "horaComienzoLabel";
            horaComienzoLabel.Size = new System.Drawing.Size(82, 13);
            horaComienzoLabel.TabIndex = 3;
            horaComienzoLabel.Text = "Hora Comienzo:";
            // 
            // horaFinLabel
            // 
            horaFinLabel.AutoSize = true;
            horaFinLabel.Location = new System.Drawing.Point(24, 148);
            horaFinLabel.Name = "horaFinLabel";
            horaFinLabel.Size = new System.Drawing.Size(50, 13);
            horaFinLabel.TabIndex = 5;
            horaFinLabel.Text = "Hora Fin:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(24, 70);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // nroDeJornadaLabel
            // 
            nroDeJornadaLabel.AutoSize = true;
            nroDeJornadaLabel.Location = new System.Drawing.Point(24, 44);
            nroDeJornadaLabel.Name = "nroDeJornadaLabel";
            nroDeJornadaLabel.Size = new System.Drawing.Size(85, 13);
            nroDeJornadaLabel.TabIndex = 9;
            nroDeJornadaLabel.Text = "Nro De Jornada:";
            // 
            // organizadorLabel
            // 
            organizadorLabel.AutoSize = true;
            organizadorLabel.Location = new System.Drawing.Point(24, 175);
            organizadorLabel.Name = "organizadorLabel";
            organizadorLabel.Size = new System.Drawing.Size(67, 13);
            organizadorLabel.TabIndex = 11;
            organizadorLabel.Text = "Organizador:";
            // 
            // jornadaElectoralBindingNavigator
            // 
            this.jornadaElectoralBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jornadaElectoralBindingNavigator.BindingSource = this.jornadaElectoralBindingSource;
            this.jornadaElectoralBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jornadaElectoralBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jornadaElectoralBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.jornadaElectoralBindingNavigatorSaveItem});
            this.jornadaElectoralBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jornadaElectoralBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jornadaElectoralBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jornadaElectoralBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jornadaElectoralBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jornadaElectoralBindingNavigator.Name = "jornadaElectoralBindingNavigator";
            this.jornadaElectoralBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jornadaElectoralBindingNavigator.Size = new System.Drawing.Size(351, 25);
            this.jornadaElectoralBindingNavigator.TabIndex = 0;
            this.jornadaElectoralBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // jornadaElectoralBindingNavigatorSaveItem
            // 
            this.jornadaElectoralBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jornadaElectoralBindingNavigatorSaveItem.Enabled = false;
            this.jornadaElectoralBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jornadaElectoralBindingNavigatorSaveItem.Image")));
            this.jornadaElectoralBindingNavigatorSaveItem.Name = "jornadaElectoralBindingNavigatorSaveItem";
            this.jornadaElectoralBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.jornadaElectoralBindingNavigatorSaveItem.Text = "Guardar datos";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.jornadaElectoralBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(115, 93);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 2;
            // 
            // horaComienzoTextBox
            // 
            this.horaComienzoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "HoraComienzo", true));
            this.horaComienzoTextBox.Location = new System.Drawing.Point(115, 119);
            this.horaComienzoTextBox.Name = "horaComienzoTextBox";
            this.horaComienzoTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaComienzoTextBox.TabIndex = 4;
            // 
            // horaFinTextBox
            // 
            this.horaFinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "HoraFin", true));
            this.horaFinTextBox.Location = new System.Drawing.Point(115, 145);
            this.horaFinTextBox.Name = "horaFinTextBox";
            this.horaFinTextBox.Size = new System.Drawing.Size(200, 20);
            this.horaFinTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(115, 67);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // nroDeJornadaTextBox
            // 
            this.nroDeJornadaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "NroDeJornada", true));
            this.nroDeJornadaTextBox.Location = new System.Drawing.Point(115, 41);
            this.nroDeJornadaTextBox.Name = "nroDeJornadaTextBox";
            this.nroDeJornadaTextBox.Size = new System.Drawing.Size(200, 20);
            this.nroDeJornadaTextBox.TabIndex = 10;
            // 
            // organizadorTextBox
            // 
            this.organizadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jornadaElectoralBindingSource, "Organizador", true));
            this.organizadorTextBox.Location = new System.Drawing.Point(115, 172);
            this.organizadorTextBox.Name = "organizadorTextBox";
            this.organizadorTextBox.Size = new System.Drawing.Size(200, 20);
            this.organizadorTextBox.TabIndex = 12;
            // 
            // aceptarBbutton
            // 
            this.aceptarBbutton.Location = new System.Drawing.Point(138, 278);
            this.aceptarBbutton.Name = "aceptarBbutton";
            this.aceptarBbutton.Size = new System.Drawing.Size(75, 23);
            this.aceptarBbutton.TabIndex = 13;
            this.aceptarBbutton.Text = "Aceptar";
            this.aceptarBbutton.UseVisualStyleBackColor = true;
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(253, 278);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 23);
            this.cancelarButton.TabIndex = 14;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Agregar candidatos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // jornadaElectoralBindingSource
            // 
            this.jornadaElectoralBindingSource.DataSource = typeof(Entidades.JornadaElectoral);
            // 
            // JornadaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 319);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarBbutton);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(horaComienzoLabel);
            this.Controls.Add(this.horaComienzoTextBox);
            this.Controls.Add(horaFinLabel);
            this.Controls.Add(this.horaFinTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(nroDeJornadaLabel);
            this.Controls.Add(this.nroDeJornadaTextBox);
            this.Controls.Add(organizadorLabel);
            this.Controls.Add(this.organizadorTextBox);
            this.Controls.Add(this.jornadaElectoralBindingNavigator);
            this.Name = "JornadaForm";
            this.Text = "JornadaFormForm";
            ((System.ComponentModel.ISupportInitialize)(this.jornadaElectoralBindingNavigator)).EndInit();
            this.jornadaElectoralBindingNavigator.ResumeLayout(false);
            this.jornadaElectoralBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jornadaElectoralBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource jornadaElectoralBindingSource;
        private System.Windows.Forms.BindingNavigator jornadaElectoralBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton jornadaElectoralBindingNavigatorSaveItem;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox horaComienzoTextBox;
        private System.Windows.Forms.TextBox horaFinTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox nroDeJornadaTextBox;
        private System.Windows.Forms.TextBox organizadorTextBox;
        private System.Windows.Forms.Button aceptarBbutton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.Button button1;
    }
}