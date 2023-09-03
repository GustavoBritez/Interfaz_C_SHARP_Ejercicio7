namespace Ejercicio_7
{
    partial class Ejercicio_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio_7));
            this.Enunciado = new System.Windows.Forms.Label();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.DT_1 = new System.Windows.Forms.DataGridView();
            this.DT_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_Tasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datos = new System.Windows.Forms.GroupBox();
            this.TX_Monto = new System.Windows.Forms.TextBox();
            this.TX_Tasa = new System.Windows.Forms.TextBox();
            this.TX_Dias = new System.Windows.Forms.TextBox();
            this.LB_Monto = new System.Windows.Forms.Label();
            this.LB_Tasa = new System.Windows.Forms.Label();
            this.LB_DIAS = new System.Windows.Forms.Label();
            this.BTN_Salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DT_1)).BeginInit();
            this.Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enunciado
            // 
            this.Enunciado.Location = new System.Drawing.Point(12, 9);
            this.Enunciado.Name = "Enunciado";
            this.Enunciado.Size = new System.Drawing.Size(450, 70);
            this.Enunciado.TabIndex = 0;
            this.Enunciado.Text = resources.GetString("Enunciado.Text");
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.Location = new System.Drawing.Point(189, 137);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Agregar.TabIndex = 1;
            this.BTN_Agregar.Text = "Agregar";
            this.BTN_Agregar.UseVisualStyleBackColor = true;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // DT_1
            // 
            this.DT_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DT_1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DT_Monto,
            this.DT_Tasa,
            this.DT_Dias,
            this.DT_Resultado});
            this.DT_1.Location = new System.Drawing.Point(12, 166);
            this.DT_1.Name = "DT_1";
            this.DT_1.Size = new System.Drawing.Size(443, 122);
            this.DT_1.TabIndex = 2;
            this.DT_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // DT_Monto
            // 
            this.DT_Monto.HeaderText = "Monto";
            this.DT_Monto.Name = "DT_Monto";
            // 
            // DT_Tasa
            // 
            this.DT_Tasa.HeaderText = "Tasa Anual";
            this.DT_Tasa.Name = "DT_Tasa";
            // 
            // DT_Dias
            // 
            this.DT_Dias.HeaderText = "Dias";
            this.DT_Dias.Name = "DT_Dias";
            // 
            // DT_Resultado
            // 
            this.DT_Resultado.HeaderText = "Interes";
            this.DT_Resultado.Name = "DT_Resultado";
            // 
            // Datos
            // 
            this.Datos.Controls.Add(this.LB_DIAS);
            this.Datos.Controls.Add(this.LB_Tasa);
            this.Datos.Controls.Add(this.LB_Monto);
            this.Datos.Controls.Add(this.TX_Dias);
            this.Datos.Controls.Add(this.TX_Tasa);
            this.Datos.Controls.Add(this.TX_Monto);
            this.Datos.Location = new System.Drawing.Point(15, 69);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(447, 51);
            this.Datos.TabIndex = 3;
            this.Datos.TabStop = false;
            this.Datos.Text = "Datos";
            // 
            // TX_Monto
            // 
            this.TX_Monto.Location = new System.Drawing.Point(17, 25);
            this.TX_Monto.Name = "TX_Monto";
            this.TX_Monto.Size = new System.Drawing.Size(86, 20);
            this.TX_Monto.TabIndex = 0;
            // 
            // TX_Tasa
            // 
            this.TX_Tasa.Location = new System.Drawing.Point(163, 25);
            this.TX_Tasa.Name = "TX_Tasa";
            this.TX_Tasa.Size = new System.Drawing.Size(86, 20);
            this.TX_Tasa.TabIndex = 1;
            // 
            // TX_Dias
            // 
            this.TX_Dias.Location = new System.Drawing.Point(323, 25);
            this.TX_Dias.Name = "TX_Dias";
            this.TX_Dias.Size = new System.Drawing.Size(86, 20);
            this.TX_Dias.TabIndex = 2;
            // 
            // LB_Monto
            // 
            this.LB_Monto.AutoSize = true;
            this.LB_Monto.Location = new System.Drawing.Point(38, 10);
            this.LB_Monto.Name = "LB_Monto";
            this.LB_Monto.Size = new System.Drawing.Size(37, 13);
            this.LB_Monto.TabIndex = 3;
            this.LB_Monto.Text = "Monto";
            // 
            // LB_Tasa
            // 
            this.LB_Tasa.AutoSize = true;
            this.LB_Tasa.Location = new System.Drawing.Point(186, 10);
            this.LB_Tasa.Name = "LB_Tasa";
            this.LB_Tasa.Size = new System.Drawing.Size(31, 13);
            this.LB_Tasa.TabIndex = 4;
            this.LB_Tasa.Text = "Tasa";
            // 
            // LB_DIAS
            // 
            this.LB_DIAS.AutoSize = true;
            this.LB_DIAS.Location = new System.Drawing.Point(342, 9);
            this.LB_DIAS.Name = "LB_DIAS";
            this.LB_DIAS.Size = new System.Drawing.Size(28, 13);
            this.LB_DIAS.TabIndex = 5;
            this.LB_DIAS.Text = "Dias";
            // 
            // BTN_Salir
            // 
            this.BTN_Salir.Location = new System.Drawing.Point(178, 294);
            this.BTN_Salir.Name = "BTN_Salir";
            this.BTN_Salir.Size = new System.Drawing.Size(75, 23);
            this.BTN_Salir.TabIndex = 4;
            this.BTN_Salir.Text = "Salir";
            this.BTN_Salir.UseVisualStyleBackColor = true;
            this.BTN_Salir.Click += new System.EventHandler(this.BTN_Salir_Click);
            // 
            // Ejercicio_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 318);
            this.Controls.Add(this.BTN_Salir);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.DT_1);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.Enunciado);
            this.Name = "Ejercicio_7";
            this.Text = "Ejercicio 7";
            this.Load += new System.EventHandler(this.Ejercicio_7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DT_1)).EndInit();
            this.Datos.ResumeLayout(false);
            this.Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Enunciado;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.DataGridView DT_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_Tasa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_Resultado;
        private System.Windows.Forms.GroupBox Datos;
        private System.Windows.Forms.Label LB_DIAS;
        private System.Windows.Forms.Label LB_Tasa;
        private System.Windows.Forms.Label LB_Monto;
        private System.Windows.Forms.TextBox TX_Dias;
        private System.Windows.Forms.TextBox TX_Tasa;
        private System.Windows.Forms.TextBox TX_Monto;
        private System.Windows.Forms.Button BTN_Salir;
    }
}

