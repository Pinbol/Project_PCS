
namespace Project
{
    partial class FormGantiPassword
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
            this.tb_passwordLama = new System.Windows.Forms.TextBox();
            this.tb_passwordBaru = new System.Windows.Forms.TextBox();
            this.btn_gantiPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Lama :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password Baru :";
            // 
            // tb_passwordLama
            // 
            this.tb_passwordLama.Location = new System.Drawing.Point(121, 16);
            this.tb_passwordLama.Name = "tb_passwordLama";
            this.tb_passwordLama.PasswordChar = '*';
            this.tb_passwordLama.Size = new System.Drawing.Size(158, 20);
            this.tb_passwordLama.TabIndex = 2;
            // 
            // tb_passwordBaru
            // 
            this.tb_passwordBaru.Location = new System.Drawing.Point(121, 45);
            this.tb_passwordBaru.Name = "tb_passwordBaru";
            this.tb_passwordBaru.PasswordChar = '*';
            this.tb_passwordBaru.Size = new System.Drawing.Size(158, 20);
            this.tb_passwordBaru.TabIndex = 3;
            // 
            // btn_gantiPassword
            // 
            this.btn_gantiPassword.Location = new System.Drawing.Point(79, 85);
            this.btn_gantiPassword.Name = "btn_gantiPassword";
            this.btn_gantiPassword.Size = new System.Drawing.Size(142, 23);
            this.btn_gantiPassword.TabIndex = 4;
            this.btn_gantiPassword.Text = "Ganti Password";
            this.btn_gantiPassword.UseVisualStyleBackColor = true;
            this.btn_gantiPassword.Click += new System.EventHandler(this.btn_gantiPassword_Click);
            // 
            // FormGantiPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 142);
            this.Controls.Add(this.btn_gantiPassword);
            this.Controls.Add(this.tb_passwordBaru);
            this.Controls.Add(this.tb_passwordLama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGantiPassword";
            this.Text = "FormGantiPassword";
            this.Load += new System.EventHandler(this.FormGantiPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_passwordLama;
        private System.Windows.Forms.TextBox tb_passwordBaru;
        private System.Windows.Forms.Button btn_gantiPassword;
    }
}