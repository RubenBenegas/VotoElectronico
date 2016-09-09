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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultadoForm));
            this.resultadoJornadaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.resultadoJornadaBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.resultadoJornadaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.resultadoJornadaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaBindingNavigator)).BeginInit();
            this.resultadoJornadaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultadoJornadaBindingNavigator
            // 
            this.resultadoJornadaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.resultadoJornadaBindingNavigator.BindingSource = this.resultadoJornadaBindingSource;
            this.resultadoJornadaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.resultadoJornadaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.resultadoJornadaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.resultadoJornadaBindingNavigatorSaveItem});
            this.resultadoJornadaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.resultadoJornadaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.resultadoJornadaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.resultadoJornadaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.resultadoJornadaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.resultadoJornadaBindingNavigator.Name = "resultadoJornadaBindingNavigator";
            this.resultadoJornadaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.resultadoJornadaBindingNavigator.Size = new System.Drawing.Size(526, 25);
            this.resultadoJornadaBindingNavigator.TabIndex = 0;
            this.resultadoJornadaBindingNavigator.Text = "bindingNavigator1";
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
            // resultadoJornadaBindingSource
            // 
            this.resultadoJornadaBindingSource.DataSource = typeof(Entidades.ResultadoJornada);
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
            // resultadoJornadaBindingNavigatorSaveItem
            // 
            this.resultadoJornadaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.resultadoJornadaBindingNavigatorSaveItem.Enabled = false;
            this.resultadoJornadaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("resultadoJornadaBindingNavigatorSaveItem.Image")));
            this.resultadoJornadaBindingNavigatorSaveItem.Name = "resultadoJornadaBindingNavigatorSaveItem";
            this.resultadoJornadaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.resultadoJornadaBindingNavigatorSaveItem.Text = "Guardar datos";
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
            this.resultadoJornadaDataGridView.Location = new System.Drawing.Point(46, 63);
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
            this.salirButton.Location = new System.Drawing.Point(276, 306);
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
            this.ClientSize = new System.Drawing.Size(526, 341);
            this.Controls.Add(this.salirButton);
            this.Controls.Add(this.resultadoJornadaDataGridView);
            this.Controls.Add(this.resultadoJornadaBindingNavigator);
            this.Name = "ResultadoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultadoForm";
            this.Load += new System.EventHandler(this.ResultadoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaBindingNavigator)).EndInit();
            this.resultadoJornadaBindingNavigator.ResumeLayout(false);
            this.resultadoJornadaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoJornadaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource resultadoJornadaBindingSource;
        private System.Windows.Forms.BindingNavigator resultadoJornadaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton resultadoJornadaBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView resultadoJornadaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button salirButton;
    }
}