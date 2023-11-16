namespace WinFormsApp4
{
    partial class Home
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
            label1 = new Label();
            button_Comecar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(588, 214);
            label1.Name = "label1";
            label1.Size = new Size(354, 32);
            label1.TabIndex = 0;
            label1.Text = "Bem-vindo ao nosso Aplicativo de Amigo Secreto!\r\n\r\n";
            // 
            // button_Comecar
            // 
            button_Comecar.BackColor = Color.Moccasin;
            button_Comecar.FlatAppearance.BorderSize = 0;
            button_Comecar.FlatStyle = FlatStyle.Flat;
            button_Comecar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Comecar.ForeColor = Color.Black;
            button_Comecar.Location = new Point(725, 249);
            button_Comecar.Name = "button_Comecar";
            button_Comecar.Size = new Size(85, 34);
            button_Comecar.TabIndex = 1;
            button_Comecar.Text = "Começar";
            button_Comecar.UseVisualStyleBackColor = false;
            button_Comecar.Click += button_Comecar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.amigo;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(979, 492);
            Controls.Add(button_Comecar);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_Comecar;
    }
}