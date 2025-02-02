namespace WinAppEnITma
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
            this.dgv_catalogo = new System.Windows.Forms.DataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_catalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_catalogo
            // 
            this.dgv_catalogo.AllowUserToAddRows = false;
            this.dgv_catalogo.AllowUserToDeleteRows = false;
            this.dgv_catalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_catalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_catalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto});
            this.dgv_catalogo.Location = new System.Drawing.Point(13, 13);
            this.dgv_catalogo.Name = "dgv_catalogo";
            this.dgv_catalogo.ReadOnly = true;
            this.dgv_catalogo.Size = new System.Drawing.Size(600, 291);
            this.dgv_catalogo.TabIndex = 0;
            // 
            // IdProducto
            // 
            this.IdProducto.DataPropertyName = "IdProducto";
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(458, 310);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(75, 23);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(538, 310);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_actualizar.TabIndex = 3;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 339);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.dgv_catalogo);
            this.Name = "Form1";
            this.Text = "Catalogo de productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_catalogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_catalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_actualizar;
    }
}

