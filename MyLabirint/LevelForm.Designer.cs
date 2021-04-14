
namespace MyLabirint
{
    partial class LevelForm
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
            this.wall1 = new System.Windows.Forms.Button();
            this.wall3 = new System.Windows.Forms.Button();
            this.wall4 = new System.Windows.Forms.Button();
            this.wall2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-282, -114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Black;
            this.wall1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall1.Location = new System.Drawing.Point(0, 0);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(799, 23);
            this.wall1.TabIndex = 3;
            this.wall1.Text = " ";
            this.wall1.UseVisualStyleBackColor = false;
            this.wall1.MouseEnter += new System.EventHandler(this.wall2_MouseEnter);
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.Black;
            this.wall3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall3.Location = new System.Drawing.Point(0, 422);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(799, 29);
            this.wall3.TabIndex = 3;
            this.wall3.Text = " ";
            this.wall3.UseVisualStyleBackColor = false;
            this.wall3.MouseEnter += new System.EventHandler(this.wall2_MouseEnter);
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.Black;
            this.wall4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall4.Location = new System.Drawing.Point(0, 0);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(31, 451);
            this.wall4.TabIndex = 4;
            this.wall4.Text = " ";
            this.wall4.UseVisualStyleBackColor = false;
            this.wall4.MouseEnter += new System.EventHandler(this.wall2_MouseEnter);
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Black;
            this.wall2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall2.Location = new System.Drawing.Point(768, 0);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(49, 451);
            this.wall2.TabIndex = 5;
            this.wall2.UseVisualStyleBackColor = false;
            this.wall2.MouseEnter += new System.EventHandler(this.wall2_MouseEnter);
            // 
            // LevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LevelForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wall1;
        private System.Windows.Forms.Button wall3;
        private System.Windows.Forms.Button wall4;
        private System.Windows.Forms.Button wall2;
    }
}