
namespace BT00_KetNoi
{
    partial class Form1
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
            this.btnAcc2003 = new System.Windows.Forms.Button();
            this.btnAcc2019 = new System.Windows.Forms.Button();
            this.btnSQLWin = new System.Windows.Forms.Button();
            this.btnSQLsa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAcc2003
            // 
            this.btnAcc2003.Location = new System.Drawing.Point(39, 28);
            this.btnAcc2003.Name = "btnAcc2003";
            this.btnAcc2003.Size = new System.Drawing.Size(88, 37);
            this.btnAcc2003.TabIndex = 0;
            this.btnAcc2003.Text = "Access2003";
            this.btnAcc2003.UseVisualStyleBackColor = true;
            this.btnAcc2003.Click += new System.EventHandler(this.btnAcc2003_Click);
            // 
            // btnAcc2019
            // 
            this.btnAcc2019.Location = new System.Drawing.Point(133, 28);
            this.btnAcc2019.Name = "btnAcc2019";
            this.btnAcc2019.Size = new System.Drawing.Size(88, 37);
            this.btnAcc2019.TabIndex = 0;
            this.btnAcc2019.Text = "Access2019";
            this.btnAcc2019.UseVisualStyleBackColor = true;
            this.btnAcc2019.Click += new System.EventHandler(this.btnAcc2019_Click);
            // 
            // btnSQLWin
            // 
            this.btnSQLWin.Location = new System.Drawing.Point(227, 28);
            this.btnSQLWin.Name = "btnSQLWin";
            this.btnSQLWin.Size = new System.Drawing.Size(88, 37);
            this.btnSQLWin.TabIndex = 0;
            this.btnSQLWin.Text = "SQL Windown";
            this.btnSQLWin.UseVisualStyleBackColor = true;
            this.btnSQLWin.Click += new System.EventHandler(this.btnSQLWin_Click);
            // 
            // btnSQLsa
            // 
            this.btnSQLsa.Location = new System.Drawing.Point(321, 28);
            this.btnSQLsa.Name = "btnSQLsa";
            this.btnSQLsa.Size = new System.Drawing.Size(88, 37);
            this.btnSQLsa.TabIndex = 0;
            this.btnSQLsa.Text = "SQL sa";
            this.btnSQLsa.UseVisualStyleBackColor = true;
            this.btnSQLsa.Click += new System.EventHandler(this.btnSQLsa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 94);
            this.Controls.Add(this.btnSQLsa);
            this.Controls.Add(this.btnSQLWin);
            this.Controls.Add(this.btnAcc2019);
            this.Controls.Add(this.btnAcc2003);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết nối";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAcc2003;
        private System.Windows.Forms.Button btnAcc2019;
        private System.Windows.Forms.Button btnSQLWin;
        private System.Windows.Forms.Button btnSQLsa;
    }
}

