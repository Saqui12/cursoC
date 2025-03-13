namespace discos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgbDiscos = new System.Windows.Forms.DataGridView();
            this.pbxDisco = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisico = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgbDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbDiscos
            // 
            this.dgbDiscos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbDiscos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgbDiscos.Location = new System.Drawing.Point(12, 45);
            this.dgbDiscos.MultiSelect = false;
            this.dgbDiscos.Name = "dgbDiscos";
            this.dgbDiscos.ReadOnly = true;
            this.dgbDiscos.RowHeadersWidth = 51;
            this.dgbDiscos.RowTemplate.Height = 24;
            this.dgbDiscos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbDiscos.Size = new System.Drawing.Size(625, 304);
            this.dgbDiscos.TabIndex = 0;
            this.dgbDiscos.SelectionChanged += new System.EventHandler(this.dgbDiscos_SelectionChanged);
            // 
            // pbxDisco
            // 
            this.pbxDisco.Location = new System.Drawing.Point(643, 45);
            this.pbxDisco.Name = "pbxDisco";
            this.pbxDisco.Size = new System.Drawing.Size(320, 304);
            this.pbxDisco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDisco.TabIndex = 1;
            this.pbxDisco.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 372);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(89, 35);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(144, 372);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(89, 35);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisico
            // 
            this.btnEliminarFisico.Location = new System.Drawing.Point(267, 372);
            this.btnEliminarFisico.Name = "btnEliminarFisico";
            this.btnEliminarFisico.Size = new System.Drawing.Size(87, 35);
            this.btnEliminarFisico.TabIndex = 4;
            this.btnEliminarFisico.Text = "Eliminar";
            this.btnEliminarFisico.UseVisualStyleBackColor = true;
            this.btnEliminarFisico.Click += new System.EventHandler(this.btnEliminarFisico_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(58, 17);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(199, 22);
            this.txtFiltro.TabIndex = 5;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.btnEliminarFisico);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxDisco);
            this.Controls.Add(this.dgbDiscos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDisco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbDiscos;
        private System.Windows.Forms.PictureBox pbxDisco;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisico;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label1;
    }
}

