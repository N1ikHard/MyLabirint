
namespace MyLabirint
{
    partial class MenuForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.StartGame = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.button_level = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.wall1 = new System.Windows.Forms.Button();
            this.wall2 = new System.Windows.Forms.Button();
            this.wall3 = new System.Windows.Forms.Button();
            this.wall4 = new System.Windows.Forms.Button();
            this.wall5 = new System.Windows.Forms.Button();
            this.wall6 = new System.Windows.Forms.Button();
            this.wall7 = new System.Windows.Forms.Button();
            this._point1 = new System.Windows.Forms.Panel();
            this._point2 = new System.Windows.Forms.Panel();
            this._point3 = new System.Windows.Forms.Panel();
            this._point4 = new System.Windows.Forms.Panel();
            this._point5 = new System.Windows.Forms.Panel();
            this.animation_timer_cursor = new System.Windows.Forms.Timer(this.components);
            this.SoundBox = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.White;
            this.StartGame.Location = new System.Drawing.Point(12, 59);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(94, 29);
            this.StartGame.TabIndex = 0;
            this.StartGame.Text = "Begin";
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.White;
            this.button_close.Location = new System.Drawing.Point(12, 129);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(94, 29);
            this.button_close.TabIndex = 1;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = false;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_level
            // 
            this.button_level.BackColor = System.Drawing.Color.White;
            this.button_level.Location = new System.Drawing.Point(12, 94);
            this.button_level.Name = "button_level";
            this.button_level.Size = new System.Drawing.Size(94, 29);
            this.button_level.TabIndex = 2;
            this.button_level.Text = "Chose level";
            this.button_level.UseVisualStyleBackColor = false;
            this.button_level.Click += new System.EventHandler(this.button_level_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 33);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Лабиринт 2D";
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wall1.FlatAppearance.BorderSize = 0;
            this.wall1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall1.Location = new System.Drawing.Point(164, 69);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(194, 24);
            this.wall1.TabIndex = 4;
            this.wall1.Text = "button1";
            this.wall1.UseVisualStyleBackColor = false;
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wall2.FlatAppearance.BorderSize = 0;
            this.wall2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall2.Location = new System.Drawing.Point(164, 119);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(70, 24);
            this.wall2.TabIndex = 5;
            this.wall2.Text = "button1";
            this.wall2.UseVisualStyleBackColor = false;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wall3.FlatAppearance.BorderSize = 0;
            this.wall3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall3.Location = new System.Drawing.Point(264, 119);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(94, 24);
            this.wall3.TabIndex = 6;
            this.wall3.Text = "button1";
            this.wall3.UseVisualStyleBackColor = false;
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wall4.FlatAppearance.BorderSize = 0;
            this.wall4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall4.Location = new System.Drawing.Point(339, 69);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(19, 74);
            this.wall4.TabIndex = 7;
            this.wall4.Text = "button1";
            this.wall4.UseVisualStyleBackColor = false;
            // 
            // wall5
            // 
            this.wall5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wall5.FlatAppearance.BorderSize = 0;
            this.wall5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall5.Location = new System.Drawing.Point(210, 134);
            this.wall5.Name = "wall5";
            this.wall5.Size = new System.Drawing.Size(24, 57);
            this.wall5.TabIndex = 8;
            this.wall5.Text = "button1";
            this.wall5.UseVisualStyleBackColor = false;
            // 
            // wall6
            // 
            this.wall6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wall6.FlatAppearance.BorderSize = 0;
            this.wall6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall6.Location = new System.Drawing.Point(210, 172);
            this.wall6.Name = "wall6";
            this.wall6.Size = new System.Drawing.Size(204, 19);
            this.wall6.TabIndex = 9;
            this.wall6.Text = "button1";
            this.wall6.UseVisualStyleBackColor = false;
            // 
            // wall7
            // 
            this.wall7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wall7.FlatAppearance.BorderSize = 0;
            this.wall7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wall7.Location = new System.Drawing.Point(390, 69);
            this.wall7.Name = "wall7";
            this.wall7.Size = new System.Drawing.Size(24, 107);
            this.wall7.TabIndex = 10;
            this.wall7.Text = "button1";
            this.wall7.UseVisualStyleBackColor = false;
            // 
            // _point1
            // 
            this._point1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_point1.BackgroundImage")));
            this._point1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._point1.Location = new System.Drawing.Point(164, 93);
            this._point1.Name = "_point1";
            this._point1.Size = new System.Drawing.Size(26, 26);
            this._point1.TabIndex = 11;
            this._point1.Visible = false;
            // 
            // _point2
            // 
            this._point2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_point2.BackgroundImage")));
            this._point2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._point2.Location = new System.Drawing.Point(235, 94);
            this._point2.Name = "_point2";
            this._point2.Size = new System.Drawing.Size(26, 26);
            this._point2.TabIndex = 12;
            this._point2.Visible = false;
            // 
            // _point3
            // 
            this._point3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_point3.BackgroundImage")));
            this._point3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._point3.Location = new System.Drawing.Point(236, 144);
            this._point3.Name = "_point3";
            this._point3.Size = new System.Drawing.Size(26, 26);
            this._point3.TabIndex = 13;
            this._point3.Visible = false;
            // 
            // _point4
            // 
            this._point4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_point4.BackgroundImage")));
            this._point4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._point4.Location = new System.Drawing.Point(362, 144);
            this._point4.Name = "_point4";
            this._point4.Size = new System.Drawing.Size(26, 26);
            this._point4.TabIndex = 13;
            this._point4.Visible = false;
            // 
            // _point5
            // 
            this._point5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("_point5.BackgroundImage")));
            this._point5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._point5.Location = new System.Drawing.Point(362, 69);
            this._point5.Name = "_point5";
            this._point5.Size = new System.Drawing.Size(26, 26);
            this._point5.TabIndex = 13;
            this._point5.Visible = false;
            // 
            // animation_timer_cursor
            // 
            this.animation_timer_cursor.Enabled = true;
            this.animation_timer_cursor.Interval = 10;
            this.animation_timer_cursor.Tick += new System.EventHandler(this.animation_timer_cursor_Tick);
            // 
            // SoundBox
            // 
            this.SoundBox.AutoSize = true;
            this.SoundBox.Location = new System.Drawing.Point(12, 172);
            this.SoundBox.Name = "SoundBox";
            this.SoundBox.Size = new System.Drawing.Size(94, 24);
            this.SoundBox.TabIndex = 14;
            this.SoundBox.Text = "Звук есть";
            this.SoundBox.UseVisualStyleBackColor = true;
            this.SoundBox.CheckedChanged += new System.EventHandler(this.SoundBox_CheckedChanged);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 290);
            this.Controls.Add(this.SoundBox);
            this.Controls.Add(this._point5);
            this.Controls.Add(this._point4);
            this.Controls.Add(this._point3);
            this.Controls.Add(this._point2);
            this.Controls.Add(this._point1);
            this.Controls.Add(this.wall7);
            this.Controls.Add(this.wall6);
            this.Controls.Add(this.wall5);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_level);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.StartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_level;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button wall1;
        private System.Windows.Forms.Button wall2;
        private System.Windows.Forms.Button wall3;
        private System.Windows.Forms.Button wall4;
        private System.Windows.Forms.Button wall5;
        private System.Windows.Forms.Button wall6;
        private System.Windows.Forms.Button wall7;
        private System.Windows.Forms.Panel _point1;
        private System.Windows.Forms.Panel _point2;
        private System.Windows.Forms.Panel _point3;
        private System.Windows.Forms.Panel _point4;
        private System.Windows.Forms.Panel _point5;
        private System.Windows.Forms.Timer animation_timer_cursor;
        private System.Windows.Forms.CheckBox SoundBox;
    }
}

