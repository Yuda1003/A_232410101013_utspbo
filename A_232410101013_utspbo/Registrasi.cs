using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_232410101013_utspbo
{
    public partial class Registrasi : Form
    {
        public Registrasi()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.buttonAdd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(340, 48);
            label1.Name = "label1";
            label1.Size = new Size(156, 45);
            label1.TabIndex = 0;
            label1.Text = "Registrasi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(251, 126);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 1;
            label2.Text = "username";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(251, 181);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 2;
            label3.Text = "password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new Point(347, 126);
            this.textBox1.Margin = new Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(201, 31);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new Point(347, 181);
            this.textBox2.Margin = new Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(201, 31);
            this.textBox2.TabIndex = 7;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new Point(441, 257);
            this.buttonAdd.Margin = new Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new Size(107, 38);
            this.buttonAdd.TabIndex = 11;
            this.buttonAdd.Text = "Daftar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // Registrasi
            // 
            ClientSize = new Size(899, 366);
            Controls.Add(this.buttonAdd);
            Controls.Add(this.textBox2);
            Controls.Add(this.textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrasi";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
