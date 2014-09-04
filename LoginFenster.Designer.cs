namespace WindowsFormsApplication3
{
    partial class LoginFenster
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trusted = new System.Windows.Forms.CheckBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_db = new System.Windows.Forms.TextBox();
            this.tb_usr = new System.Windows.Forms.TextBox();
            this.tb_srv = new System.Windows.Forms.TextBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trusted);
            this.panel1.Controls.Add(this.tb_pw);
            this.panel1.Controls.Add(this.tb_db);
            this.panel1.Controls.Add(this.tb_usr);
            this.panel1.Controls.Add(this.tb_srv);
            this.panel1.Controls.Add(this.loginbtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 144);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Passwort:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Benutzer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Datenbank:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Server:";
            // 
            // trusted
            // 
            this.trusted.AutoSize = true;
            this.trusted.Location = new System.Drawing.Point(12, 120);
            this.trusted.Name = "trusted";
            this.trusted.Size = new System.Drawing.Size(97, 17);
            this.trusted.TabIndex = 1;
            this.trusted.Text = "NT Anmeldung";
            this.trusted.UseVisualStyleBackColor = true;
            this.trusted.CheckedChanged += new System.EventHandler(this.trusted_CheckedChanged);
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(91, 90);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(345, 20);
            this.tb_pw.TabIndex = 4;
            this.tb_pw.Text = "iwm";
            // 
            // tb_db
            // 
            this.tb_db.Location = new System.Drawing.Point(91, 38);
            this.tb_db.Name = "tb_db";
            this.tb_db.Size = new System.Drawing.Size(345, 20);
            this.tb_db.TabIndex = 3;
            this.tb_db.Text = "kunden";
            // 
            // tb_usr
            // 
            this.tb_usr.Location = new System.Drawing.Point(91, 64);
            this.tb_usr.Name = "tb_usr";
            this.tb_usr.Size = new System.Drawing.Size(345, 20);
            this.tb_usr.TabIndex = 2;
            this.tb_usr.Text = "sa";
            // 
            // tb_srv
            // 
            this.tb_srv.Location = new System.Drawing.Point(91, 12);
            this.tb_srv.Name = "tb_srv";
            this.tb_srv.Size = new System.Drawing.Size(345, 20);
            this.tb_srv.TabIndex = 1;
            this.tb_srv.Text = "LBW7\\SAGE";
            // 
            // loginbtn
            // 
            this.loginbtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loginbtn.Location = new System.Drawing.Point(361, 116);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Anmelden";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // LoginFenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 150);
            this.Controls.Add(this.panel1);
            this.Name = "LoginFenster";
            this.Text = "Anmeldung";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox trusted;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_db;
        private System.Windows.Forms.TextBox tb_usr;
        private System.Windows.Forms.TextBox tb_srv;
        private System.Windows.Forms.Button loginbtn;
    }
}