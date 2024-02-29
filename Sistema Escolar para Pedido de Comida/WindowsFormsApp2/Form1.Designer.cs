namespace WindowsFormsApp2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnmodificar2 = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.btnlistacompras = new System.Windows.Forms.Button();
            this.btncompras = new System.Windows.Forms.Button();
            this.recetasDBDataSet = new WindowsFormsApp2.RecetasDBDataSet();
            this.recetasDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdato4 = new System.Windows.Forms.TextBox();
            this.txtdato5 = new System.Windows.Forms.TextBox();
            this.txtdato6 = new System.Windows.Forms.TextBox();
            this.txtdato7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtidentificador = new System.Windows.Forms.TextBox();
            this.txtdato1 = new System.Windows.Forms.TextBox();
            this.txtdato2 = new System.Windows.Forms.TextBox();
            this.txtdato3 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recetasDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(8, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1400, 900);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.Controls.Add(this.txtdato3);
            this.tabPage1.Controls.Add(this.txtdato2);
            this.tabPage1.Controls.Add(this.txtdato1);
            this.tabPage1.Controls.Add(this.txtidentificador);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btneliminar);
            this.tabPage1.Controls.Add(this.btnmodificar);
            this.tabPage1.Controls.Add(this.btninsert);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(772, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Padres";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Khaki;
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtdato7);
            this.tabPage2.Controls.Add(this.txtdato6);
            this.tabPage2.Controls.Add(this.txtdato5);
            this.tabPage2.Controls.Add(this.txtdato4);
            this.tabPage2.Controls.Add(this.txtid);
            this.tabPage2.Controls.Add(this.btnmodificar2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1392, 871);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Niños";
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.btncompras);
            this.tabPage3.Controls.Add(this.btnlistacompras);
            this.tabPage3.Controls.Add(this.btnmostrar);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1392, 871);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lista de Compras";
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(110, 165);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(88, 38);
            this.btninsert.TabIndex = 0;
            this.btninsert.Text = "Insertar";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(284, 165);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(101, 37);
            this.btnmodificar.TabIndex = 1;
            this.btnmodificar.Text = "Modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(529, 165);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(89, 41);
            this.btneliminar.TabIndex = 2;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnmodificar2
            // 
            this.btnmodificar2.BackColor = System.Drawing.Color.Transparent;
            this.btnmodificar2.Location = new System.Drawing.Point(260, 131);
            this.btnmodificar2.Name = "btnmodificar2";
            this.btnmodificar2.Size = new System.Drawing.Size(135, 30);
            this.btnmodificar2.TabIndex = 0;
            this.btnmodificar2.Text = "Modificar";
            this.btnmodificar2.UseVisualStyleBackColor = false;
            this.btnmodificar2.Click += new System.EventHandler(this.btnmodificar2_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(466, 14);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(75, 23);
            this.btnmostrar.TabIndex = 1;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btnlistacompras
            // 
            this.btnlistacompras.Location = new System.Drawing.Point(28, 14);
            this.btnlistacompras.Name = "btnlistacompras";
            this.btnlistacompras.Size = new System.Drawing.Size(75, 23);
            this.btnlistacompras.TabIndex = 2;
            this.btnlistacompras.Text = "Lista";
            this.btnlistacompras.UseVisualStyleBackColor = true;
            this.btnlistacompras.Click += new System.EventHandler(this.btnlistacompras_Click);
            // 
            // btncompras
            // 
            this.btncompras.Location = new System.Drawing.Point(171, 14);
            this.btncompras.Name = "btncompras";
            this.btncompras.Size = new System.Drawing.Size(127, 23);
            this.btncompras.TabIndex = 3;
            this.btncompras.Text = "Hacer compras";
            this.btncompras.UseVisualStyleBackColor = true;
            this.btncompras.Click += new System.EventHandler(this.btncompras_Click);
            // 
            // recetasDBDataSet
            // 
            this.recetasDBDataSet.DataSetName = "RecetasDBDataSet";
            this.recetasDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // recetasDBDataSetBindingSource
            // 
            this.recetasDBDataSetBindingSource.DataSource = this.recetasDBDataSet;
            this.recetasDBDataSetBindingSource.Position = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(24, 85);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 22);
            this.txtid.TabIndex = 1;
            // 
            // txtdato4
            // 
            this.txtdato4.Location = new System.Drawing.Point(165, 85);
            this.txtdato4.Name = "txtdato4";
            this.txtdato4.Size = new System.Drawing.Size(100, 22);
            this.txtdato4.TabIndex = 2;
            // 
            // txtdato5
            // 
            this.txtdato5.Location = new System.Drawing.Point(308, 85);
            this.txtdato5.Name = "txtdato5";
            this.txtdato5.Size = new System.Drawing.Size(100, 22);
            this.txtdato5.TabIndex = 3;
            // 
            // txtdato6
            // 
            this.txtdato6.Location = new System.Drawing.Point(455, 84);
            this.txtdato6.Name = "txtdato6";
            this.txtdato6.Size = new System.Drawing.Size(100, 22);
            this.txtdato6.TabIndex = 4;
            // 
            // txtdato7
            // 
            this.txtdato7.Location = new System.Drawing.Point(594, 84);
            this.txtdato7.Name = "txtdato7";
            this.txtdato7.Size = new System.Drawing.Size(100, 22);
            this.txtdato7.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(198, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(336, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "EDAD";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(485, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "NIVEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(619, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "GRADO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(58, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(220, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "NOMBRE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(395, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "TELEFONO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(560, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "LUGAR DE TRABAJO";
            // 
            // txtidentificador
            // 
            this.txtidentificador.Location = new System.Drawing.Point(37, 103);
            this.txtidentificador.Name = "txtidentificador";
            this.txtidentificador.Size = new System.Drawing.Size(100, 22);
            this.txtidentificador.TabIndex = 7;
            // 
            // txtdato1
            // 
            this.txtdato1.Location = new System.Drawing.Point(207, 103);
            this.txtdato1.Name = "txtdato1";
            this.txtdato1.Size = new System.Drawing.Size(100, 22);
            this.txtdato1.TabIndex = 8;
            // 
            // txtdato2
            // 
            this.txtdato2.Location = new System.Drawing.Point(398, 103);
            this.txtdato2.Name = "txtdato2";
            this.txtdato2.Size = new System.Drawing.Size(100, 22);
            this.txtdato2.TabIndex = 9;
            // 
            // txtdato3
            // 
            this.txtdato3.Location = new System.Drawing.Point(580, 103);
            this.txtdato3.Name = "txtdato3";
            this.txtdato3.Size = new System.Drawing.Size(100, 22);
            this.txtdato3.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 364);
            this.dataGridView1.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Padres",
            "Niños",
            "Alimentos",
            "Ingrediente",
            "Compras",
            "Recetas",
            "PedidosMenu",
            "DetallePedido",
            "VistaDetalleReceta"});
            this.comboBox1.Location = new System.Drawing.Point(339, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Comedor Pink Flor";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recetasDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recetasDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnmodificar2;
        private System.Windows.Forms.Button btncompras;
        private System.Windows.Forms.Button btnlistacompras;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.BindingSource recetasDBDataSetBindingSource;
        private RecetasDBDataSet recetasDBDataSet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdato7;
        private System.Windows.Forms.TextBox txtdato6;
        private System.Windows.Forms.TextBox txtdato5;
        private System.Windows.Forms.TextBox txtdato4;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdato3;
        private System.Windows.Forms.TextBox txtdato2;
        private System.Windows.Forms.TextBox txtdato1;
        private System.Windows.Forms.TextBox txtidentificador;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

