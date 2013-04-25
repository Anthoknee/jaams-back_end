namespace jaamsbackend1
{
    partial class login
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
            this.serverLab = new System.Windows.Forms.Label();
            this.unLab = new System.Windows.Forms.Label();
            this.pwLab = new System.Windows.Forms.Label();
            this.server = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.connect = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverLab
            // 
            this.serverLab.AutoSize = true;
            this.serverLab.Location = new System.Drawing.Point(12, 43);
            this.serverLab.Name = "serverLab";
            this.serverLab.Size = new System.Drawing.Size(41, 13);
            this.serverLab.TabIndex = 0;
            this.serverLab.Text = "Server:";
            // 
            // unLab
            // 
            this.unLab.AutoSize = true;
            this.unLab.Location = new System.Drawing.Point(12, 69);
            this.unLab.Name = "unLab";
            this.unLab.Size = new System.Drawing.Size(60, 13);
            this.unLab.TabIndex = 1;
            this.unLab.Text = "UserName:";
            // 
            // pwLab
            // 
            this.pwLab.AutoSize = true;
            this.pwLab.Location = new System.Drawing.Point(12, 95);
            this.pwLab.Name = "pwLab";
            this.pwLab.Size = new System.Drawing.Size(56, 13);
            this.pwLab.TabIndex = 2;
            this.pwLab.Text = "Password:";
            // 
            // server
            // 
            this.server.Location = new System.Drawing.Point(111, 40);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(100, 20);
            this.server.TabIndex = 3;
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(111, 66);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 20);
            this.user.TabIndex = 4;
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(111, 92);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(100, 20);
            this.pw.TabIndex = 5;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(15, 136);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 23);
            this.connect.TabIndex = 6;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(136, 136);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 7;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 182);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.user);
            this.Controls.Add(this.server);
            this.Controls.Add(this.pwLab);
            this.Controls.Add(this.unLab);
            this.Controls.Add(this.serverLab);
            this.Name = "login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label serverLab;
        private System.Windows.Forms.Label unLab;
        private System.Windows.Forms.Label pwLab;
        private System.Windows.Forms.TextBox server;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button Cancel;
    }
}