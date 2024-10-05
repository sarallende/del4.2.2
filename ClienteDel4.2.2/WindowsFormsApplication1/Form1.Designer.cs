namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.grados = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.A_Fahrenheit = new System.Windows.Forms.RadioButton();
            this.A_Celsius = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Grados :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grados
            // 
            this.grados.Location = new System.Drawing.Point(174, 48);
            this.grados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grados.Name = "grados";
            this.grados.Size = new System.Drawing.Size(244, 26);
            this.grados.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(34, 31);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 181);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.A_Fahrenheit);
            this.groupBox1.Controls.Add(this.A_Celsius);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.grados);
            this.groupBox1.Location = new System.Drawing.Point(34, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(544, 258);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            // 
            // A_Fahrenheit
            // 
            this.A_Fahrenheit.AutoSize = true;
            this.A_Fahrenheit.Location = new System.Drawing.Point(265, 117);
            this.A_Fahrenheit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A_Fahrenheit.Name = "A_Fahrenheit";
            this.A_Fahrenheit.Size = new System.Drawing.Size(257, 24);
            this.A_Fahrenheit.TabIndex = 7;
            this.A_Fahrenheit.TabStop = true;
            this.A_Fahrenheit.Text = "Dame los grados en Fahrenheit";
            this.A_Fahrenheit.UseVisualStyleBackColor = true;
            this.A_Fahrenheit.CheckedChanged += new System.EventHandler(this.Longitud_CheckedChanged);
            // 
            // A_Celsius
            // 
            this.A_Celsius.AutoSize = true;
            this.A_Celsius.Location = new System.Drawing.Point(26, 117);
            this.A_Celsius.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.A_Celsius.Name = "A_Celsius";
            this.A_Celsius.Size = new System.Drawing.Size(231, 24);
            this.A_Celsius.TabIndex = 8;
            this.A_Celsius.TabStop = true;
            this.A_Celsius.Text = "Dame los grados en Celsius";
            this.A_Celsius.UseVisualStyleBackColor = true;
            this.A_Celsius.CheckedChanged += new System.EventHandler(this.Bonito_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(34, 397);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 82);
            this.button3.TabIndex = 10;
            this.button3.Text = "desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 546);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox grados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton A_Fahrenheit;
        private System.Windows.Forms.RadioButton A_Celsius;
        private System.Windows.Forms.Button button3;
    }
}

