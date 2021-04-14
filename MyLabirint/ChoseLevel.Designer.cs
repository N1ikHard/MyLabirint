
namespace MyLabirint
{
    partial class ChoseLevel
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
            this.level1 = new System.Windows.Forms.Label();
            this.level2 = new System.Windows.Forms.Label();
            this.level3 = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.level1.Location = new System.Drawing.Point(61, 41);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(61, 25);
            this.level1.TabIndex = 0;
            this.level1.Text = "Level1";
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // level2
            // 
            this.level2.AutoSize = true;
            this.level2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.level2.Location = new System.Drawing.Point(61, 73);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(61, 25);
            this.level2.TabIndex = 1;
            this.level2.Text = "Level2";
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // level3
            // 
            this.level3.AutoSize = true;
            this.level3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.level3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.level3.Location = new System.Drawing.Point(61, 108);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(61, 25);
            this.level3.TabIndex = 2;
            this.level3.Text = "Level3";
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(156, 14);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(25, 24);
            this.CloseLabel.TabIndex = 3;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseLabel);
            this.panel1.Location = new System.Drawing.Point(0, -16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 44);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Уровни";
            // 
            // ChoseLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(183, 142);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.level3);
            this.Controls.Add(this.level2);
            this.Controls.Add(this.level1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChoseLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoseLevel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label level1;
        private System.Windows.Forms.Label level2;
        private System.Windows.Forms.Label level3;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}