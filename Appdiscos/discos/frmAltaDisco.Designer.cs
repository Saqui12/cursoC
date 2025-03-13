namespace discos
{
    partial class frmAltaDisco
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtCanciones = new System.Windows.Forms.TextBox();
            this.txtImagen = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cbxEstilo = new System.Windows.Forms.ComboBox();
            this.cbxEdicion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de Canciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "UrlImagen";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(222, 61);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(143, 22);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtCanciones
            // 
            this.txtCanciones.Location = new System.Drawing.Point(222, 92);
            this.txtCanciones.Name = "txtCanciones";
            this.txtCanciones.Size = new System.Drawing.Size(143, 22);
            this.txtCanciones.TabIndex = 4;
            // 
            // txtImagen
            // 
            this.txtImagen.Location = new System.Drawing.Point(222, 120);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(143, 22);
            this.txtImagen.TabIndex = 5;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(86, 230);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(199, 230);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cbxEstilo
            // 
            this.cbxEstilo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEstilo.FormattingEnabled = true;
            this.cbxEstilo.Location = new System.Drawing.Point(222, 148);
            this.cbxEstilo.Name = "cbxEstilo";
            this.cbxEstilo.Size = new System.Drawing.Size(143, 24);
            this.cbxEstilo.TabIndex = 8;
            // 
            // cbxEdicion
            // 
            this.cbxEdicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEdicion.FormattingEnabled = true;
            this.cbxEdicion.Location = new System.Drawing.Point(222, 178);
            this.cbxEdicion.Name = "cbxEdicion";
            this.cbxEdicion.Size = new System.Drawing.Size(143, 24);
            this.cbxEdicion.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Estilo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Tipo de Edicion";
            // 
            // frmAltaDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 274);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxEdicion);
            this.Controls.Add(this.cbxEstilo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.txtCanciones);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAltaDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Disco";
            this.Load += new System.EventHandler(this.frmAltaDisco_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtCanciones;
        private System.Windows.Forms.TextBox txtImagen;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxEstilo;
        private System.Windows.Forms.ComboBox cbxEdicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}