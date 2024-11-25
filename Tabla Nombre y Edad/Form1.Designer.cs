namespace Tabla_Nombre_y_Edad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Nombre = new Label();
            Edad = new Label();
            txtnombre = new TextBox();
            txtedad = new TextBox();
            btnguardar = new Button();
            btnlimpiar = new Button();
            grilla = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.BackColor = Color.LightGray;
            Nombre.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Nombre.ForeColor = Color.FromArgb(128, 64, 64);
            Nombre.Location = new Point(24, 20);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(94, 21);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre: ";
            // 
            // Edad
            // 
            Edad.AutoSize = true;
            Edad.BackColor = Color.LightGray;
            Edad.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Edad.ForeColor = Color.FromArgb(128, 64, 64);
            Edad.Location = new Point(24, 69);
            Edad.Name = "Edad";
            Edad.Size = new Size(67, 21);
            Edad.TabIndex = 1;
            Edad.Text = "Edad: ";
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.FromArgb(192, 192, 255);
            txtnombre.Location = new Point(135, 19);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(447, 31);
            txtnombre.TabIndex = 2;
            txtnombre.TextChanged += textBox1_TextChanged;
            // 
            // txtedad
            // 
            txtedad.BackColor = Color.FromArgb(192, 192, 255);
            txtedad.Location = new Point(134, 63);
            txtedad.Name = "txtedad";
            txtedad.Size = new Size(150, 31);
            txtedad.TabIndex = 3;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.FromArgb(192, 255, 255);
            btnguardar.Font = new Font("SimSun", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnguardar.ForeColor = SystemColors.HotTrack;
            btnguardar.Location = new Point(673, 605);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(127, 86);
            btnguardar.TabIndex = 4;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // btnlimpiar
            // 
            btnlimpiar.BackColor = Color.FromArgb(192, 255, 255);
            btnlimpiar.Font = new Font("SimSun", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnlimpiar.ForeColor = SystemColors.Highlight;
            btnlimpiar.Location = new Point(802, 24);
            btnlimpiar.Name = "btnlimpiar";
            btnlimpiar.Size = new Size(113, 90);
            btnlimpiar.TabIndex = 5;
            btnlimpiar.Text = "Limpiar";
            btnlimpiar.UseVisualStyleBackColor = false;
            btnlimpiar.Click += btnlimpiar_Click;
            // 
            // grilla
            // 
            grilla.BackgroundColor = SystemColors.ButtonHighlight;
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Location = new Point(67, 173);
            grilla.Name = "grilla";
            grilla.RowHeadersWidth = 62;
            grilla.RowTemplate.Height = 33;
            grilla.Size = new Size(851, 318);
            grilla.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("SimSun", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(177, 734);
            label3.Name = "label3";
            label3.Size = new Size(432, 28);
            label3.TabIndex = 7;
            label3.Text = "Dulce Mariana Andrade Olvera";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1077, 771);
            Controls.Add(label3);
            Controls.Add(grilla);
            Controls.Add(btnlimpiar);
            Controls.Add(btnguardar);
            Controls.Add(txtedad);
            Controls.Add(txtnombre);
            Controls.Add(Edad);
            Controls.Add(Nombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private Label Edad;
        private TextBox txtnombre;
        private TextBox txtedad;
        private Button btnguardar;
        private Button btnlimpiar;
        private DataGridView grilla;
        private Label label3;
    }
}
