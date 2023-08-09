
namespace Veri_tabanı__Personel_Kayıt_projesi_
{
    partial class girişpnl
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtkuladı = new System.Windows.Forms.TextBox();
            this.grşbtn = new System.Windows.Forms.Button();
            this.txtşifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(89, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(155, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Tan;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(211, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 57);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sisteme Giriş";
            // 
            // txtkuladı
            // 
            this.txtkuladı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkuladı.Location = new System.Drawing.Point(243, 119);
            this.txtkuladı.Multiline = true;
            this.txtkuladı.Name = "txtkuladı";
            this.txtkuladı.Size = new System.Drawing.Size(123, 22);
            this.txtkuladı.TabIndex = 3;
            this.txtkuladı.Text = "Fatih12";
            // 
            // grşbtn
            // 
            this.grşbtn.Location = new System.Drawing.Point(273, 254);
            this.grşbtn.Name = "grşbtn";
            this.grşbtn.Size = new System.Drawing.Size(111, 27);
            this.grşbtn.TabIndex = 5;
            this.grşbtn.Text = "Giriş";
            this.grşbtn.UseVisualStyleBackColor = true;
            this.grşbtn.Click += new System.EventHandler(this.grşbtn_Click);
            // 
            // txtşifre
            // 
            this.txtşifre.Location = new System.Drawing.Point(243, 189);
            this.txtşifre.Name = "txtşifre";
            this.txtşifre.Size = new System.Drawing.Size(123, 22);
            this.txtşifre.TabIndex = 4;
            this.txtşifre.Text = "12345";
            this.txtşifre.UseSystemPasswordChar = true;
            // 
            // girişpnl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(740, 404);
            this.Controls.Add(this.txtşifre);
            this.Controls.Add(this.grşbtn);
            this.Controls.Add(this.txtkuladı);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "girişpnl";
            this.Text = "Girişpnl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkuladı;
        private System.Windows.Forms.Button grşbtn;
        private System.Windows.Forms.TextBox txtşifre;
    }
}