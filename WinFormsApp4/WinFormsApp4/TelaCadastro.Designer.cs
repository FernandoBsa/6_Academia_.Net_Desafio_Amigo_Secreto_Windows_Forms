namespace WinFormsApp4
{
    partial class TelaCadastro
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
            listView1 = new ListView();
            columnHeader_Nome = new ColumnHeader();
            columnHeader_Email = new ColumnHeader();
            label1 = new Label();
            label2 = new Label();
            textBox_Nome = new TextBox();
            textBox_Email = new TextBox();
            button_Cadastro = new Button();
            button_Sorteio = new Button();
            button_Limpar = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader_Nome, columnHeader_Email });
            listView1.Location = new Point(12, 115);
            listView1.Name = "listView1";
            listView1.Size = new Size(450, 370);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader_Nome
            // 
            columnHeader_Nome.Text = "Nome";
            columnHeader_Nome.Width = 225;
            // 
            // columnHeader_Email
            // 
            columnHeader_Email.Text = "Email";
            columnHeader_Email.Width = 225;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(72, 63);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // textBox_Nome
            // 
            textBox_Nome.Location = new Point(117, 23);
            textBox_Nome.Name = "textBox_Nome";
            textBox_Nome.Size = new Size(345, 23);
            textBox_Nome.TabIndex = 3;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(117, 55);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(345, 23);
            textBox_Email.TabIndex = 4;
            // 
            // button_Cadastro
            // 
            button_Cadastro.BackColor = Color.Moccasin;
            button_Cadastro.FlatAppearance.BorderSize = 0;
            button_Cadastro.FlatStyle = FlatStyle.Flat;
            button_Cadastro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Cadastro.ForeColor = Color.Black;
            button_Cadastro.Location = new Point(481, 12);
            button_Cadastro.Name = "button_Cadastro";
            button_Cadastro.Size = new Size(87, 71);
            button_Cadastro.TabIndex = 5;
            button_Cadastro.Text = "CADASTRAR";
            button_Cadastro.UseVisualStyleBackColor = false;
            button_Cadastro.Click += button_Cadastro_Click;
            // 
            // button_Sorteio
            // 
            button_Sorteio.BackColor = Color.Moccasin;
            button_Sorteio.FlatAppearance.BorderSize = 0;
            button_Sorteio.FlatStyle = FlatStyle.Flat;
            button_Sorteio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Sorteio.ForeColor = Color.Black;
            button_Sorteio.Location = new Point(586, 12);
            button_Sorteio.Name = "button_Sorteio";
            button_Sorteio.Size = new Size(87, 71);
            button_Sorteio.TabIndex = 6;
            button_Sorteio.Text = "SORTEAR";
            button_Sorteio.UseVisualStyleBackColor = false;
            button_Sorteio.Click += button_Sorteio_Click;
            // 
            // button_Limpar
            // 
            button_Limpar.BackColor = Color.Moccasin;
            button_Limpar.FlatAppearance.BorderSize = 0;
            button_Limpar.FlatStyle = FlatStyle.Flat;
            button_Limpar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button_Limpar.ForeColor = Color.Black;
            button_Limpar.Location = new Point(468, 414);
            button_Limpar.Name = "button_Limpar";
            button_Limpar.Size = new Size(87, 71);
            button_Limpar.TabIndex = 8;
            button_Limpar.Text = "LIMPAR";
            button_Limpar.UseVisualStyleBackColor = false;
            button_Limpar.Click += button_Limpar_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Moccasin;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(468, 328);
            button2.Name = "button2";
            button2.Size = new Size(87, 71);
            button2.TabIndex = 9;
            button2.Text = "REMOVER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TelaCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Moccasin;
            BackgroundImage = Properties.Resources.amigo;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(746, 497);
            Controls.Add(button2);
            Controls.Add(button_Limpar);
            Controls.Add(button_Sorteio);
            Controls.Add(button_Cadastro);
            Controls.Add(textBox_Email);
            Controls.Add(textBox_Nome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listView1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "TelaCadastro";
            Text = "Cadastro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader columnHeader_Nome;
        private ColumnHeader columnHeader_Email;
        private Label label1;
        private Label label2;
        private TextBox textBox_Nome;
        private TextBox textBox_Email;
        private Button button_Cadastro;
        private Button button_Sorteio;
        private Button button_Limpar;
        private Button button2;
    }
}