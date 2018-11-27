namespace ProyectoFinal.UI.Registros
{
    partial class RegistroJuegoscs
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
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.nuevobutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PlataformatextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.TitulotextBox = new System.Windows.Forms.TextBox();
            this.VideoJuegoIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.LanzamientodateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GenerotextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DesarrolladorestextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EjemplaresnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.videoJuegoserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Buscarbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VideoJuegoIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EjemplaresnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoJuegoserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Location = new System.Drawing.Point(308, 359);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(75, 57);
            this.Eliminarbutton.TabIndex = 36;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(170, 359);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 57);
            this.Guardarbutton.TabIndex = 35;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // nuevobutton
            // 
            this.nuevobutton.Location = new System.Drawing.Point(26, 359);
            this.nuevobutton.Name = "nuevobutton";
            this.nuevobutton.Size = new System.Drawing.Size(75, 57);
            this.nuevobutton.TabIndex = 34;
            this.nuevobutton.Text = "nuevo";
            this.nuevobutton.UseVisualStyleBackColor = true;
            this.nuevobutton.Click += new System.EventHandler(this.nuevobutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Plataforma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Id";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(286, 25);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(102, 20);
            this.FechadateTimePicker.TabIndex = 27;
            // 
            // PlataformatextBox
            // 
            this.PlataformatextBox.Location = new System.Drawing.Point(125, 189);
            this.PlataformatextBox.Name = "PlataformatextBox";
            this.PlataformatextBox.Size = new System.Drawing.Size(181, 20);
            this.PlataformatextBox.TabIndex = 26;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(125, 110);
            this.DescripciontextBox.Multiline = true;
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(262, 37);
            this.DescripciontextBox.TabIndex = 25;
            // 
            // TitulotextBox
            // 
            this.TitulotextBox.Location = new System.Drawing.Point(125, 73);
            this.TitulotextBox.Name = "TitulotextBox";
            this.TitulotextBox.Size = new System.Drawing.Size(262, 20);
            this.TitulotextBox.TabIndex = 23;
            // 
            // VideoJuegoIdnumericUpDown
            // 
            this.VideoJuegoIdnumericUpDown.Location = new System.Drawing.Point(63, 25);
            this.VideoJuegoIdnumericUpDown.Name = "VideoJuegoIdnumericUpDown";
            this.VideoJuegoIdnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.VideoJuegoIdnumericUpDown.TabIndex = 22;
            // 
            // LanzamientodateTimePicker
            // 
            this.LanzamientodateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.LanzamientodateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.LanzamientodateTimePicker.Location = new System.Drawing.Point(125, 153);
            this.LanzamientodateTimePicker.Name = "LanzamientodateTimePicker";
            this.LanzamientodateTimePicker.Size = new System.Drawing.Size(120, 20);
            this.LanzamientodateTimePicker.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Lanzamiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Genero";
            // 
            // GenerotextBox
            // 
            this.GenerotextBox.Location = new System.Drawing.Point(125, 224);
            this.GenerotextBox.Name = "GenerotextBox";
            this.GenerotextBox.Size = new System.Drawing.Size(181, 20);
            this.GenerotextBox.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Desarrolladores";
            // 
            // DesarrolladorestextBox
            // 
            this.DesarrolladorestextBox.Location = new System.Drawing.Point(125, 264);
            this.DesarrolladorestextBox.Name = "DesarrolladorestextBox";
            this.DesarrolladorestextBox.Size = new System.Drawing.Size(181, 20);
            this.DesarrolladorestextBox.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Ejemplares";
            // 
            // EjemplaresnumericUpDown
            // 
            this.EjemplaresnumericUpDown.Location = new System.Drawing.Point(125, 299);
            this.EjemplaresnumericUpDown.Name = "EjemplaresnumericUpDown";
            this.EjemplaresnumericUpDown.Size = new System.Drawing.Size(181, 20);
            this.EjemplaresnumericUpDown.TabIndex = 45;
            // 
            // videoJuegoserrorProvider
            // 
            this.videoJuegoserrorProvider.ContainerControl = this;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(189, 9);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 49);
            this.Buscarbutton.TabIndex = 47;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // RegistroJuegoscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 445);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.EjemplaresnumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DesarrolladorestextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GenerotextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LanzamientodateTimePicker);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.nuevobutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.PlataformatextBox);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.TitulotextBox);
            this.Controls.Add(this.VideoJuegoIdnumericUpDown);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistroJuegoscs";
            this.Text = "Registro de video juegos";
            ((System.ComponentModel.ISupportInitialize)(this.VideoJuegoIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EjemplaresnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoJuegoserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button nuevobutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.TextBox PlataformatextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.TextBox TitulotextBox;
        private System.Windows.Forms.NumericUpDown VideoJuegoIdnumericUpDown;
        private System.Windows.Forms.DateTimePicker LanzamientodateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox GenerotextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DesarrolladorestextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown EjemplaresnumericUpDown;
        private System.Windows.Forms.ErrorProvider videoJuegoserrorProvider;
        private System.Windows.Forms.Button Buscarbutton;
    }
}