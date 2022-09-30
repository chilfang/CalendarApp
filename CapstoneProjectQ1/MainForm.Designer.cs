
namespace CapstoneProjectQ1 {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PersonalizeButton = new System.Windows.Forms.Button();
            this.ScheduleButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.CalendarButton = new System.Windows.Forms.Button();
            this.userControlsPanel = new System.Windows.Forms.Panel();
            this.NavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.NavigationPanel.Controls.Add(this.pictureBox1);
            this.NavigationPanel.Controls.Add(this.label1);
            this.NavigationPanel.Controls.Add(this.PersonalizeButton);
            this.NavigationPanel.Controls.Add(this.ScheduleButton);
            this.NavigationPanel.Controls.Add(this.OptionsButton);
            this.NavigationPanel.Controls.Add(this.CalendarButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.NavigationPanel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(200, 653);
            this.NavigationPanel.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapstoneProjectQ1.Properties.Resources.CalendarIcon30_;
            this.pictureBox1.Location = new System.Drawing.Point(27, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 56);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(75, 25);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(125, 64);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calendar\r\nApp";
            // 
            // PersonalizeButton
            // 
            this.PersonalizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.PersonalizeButton.FlatAppearance.BorderSize = 0;
            this.PersonalizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonalizeButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PersonalizeButton.Image = global::CapstoneProjectQ1.Properties.Resources.PaintbrushIcon;
            this.PersonalizeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PersonalizeButton.Location = new System.Drawing.Point(0, 287);
            this.PersonalizeButton.Name = "PersonalizeButton";
            this.PersonalizeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PersonalizeButton.Size = new System.Drawing.Size(200, 66);
            this.PersonalizeButton.TabIndex = 3;
            this.PersonalizeButton.Text = "Personalize";
            this.PersonalizeButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PersonalizeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PersonalizeButton.UseVisualStyleBackColor = false;
            this.PersonalizeButton.Click += new System.EventHandler(this.PersonalizeButton_Click);
            // 
            // ScheduleButton
            // 
            this.ScheduleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ScheduleButton.FlatAppearance.BorderSize = 0;
            this.ScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScheduleButton.Image = ((System.Drawing.Image)(resources.GetObject("ScheduleButton.Image")));
            this.ScheduleButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ScheduleButton.Location = new System.Drawing.Point(0, 203);
            this.ScheduleButton.Name = "ScheduleButton";
            this.ScheduleButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ScheduleButton.Size = new System.Drawing.Size(200, 66);
            this.ScheduleButton.TabIndex = 2;
            this.ScheduleButton.Text = " Schedule";
            this.ScheduleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ScheduleButton.UseVisualStyleBackColor = false;
            this.ScheduleButton.Click += new System.EventHandler(this.ScheduleButton_Click);
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OptionsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.OptionsButton.FlatAppearance.BorderSize = 0;
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OptionsButton.Image = global::CapstoneProjectQ1.Properties.Resources.GearIcon;
            this.OptionsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OptionsButton.Location = new System.Drawing.Point(0, 469);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OptionsButton.Size = new System.Drawing.Size(200, 66);
            this.OptionsButton.TabIndex = 1;
            this.OptionsButton.Text = " Options";
            this.OptionsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OptionsButton.UseVisualStyleBackColor = false;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // CalendarButton
            // 
            this.CalendarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CalendarButton.FlatAppearance.BorderSize = 0;
            this.CalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CalendarButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalendarButton.Image = global::CapstoneProjectQ1.Properties.Resources.CalendarIcon30_;
            this.CalendarButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.CalendarButton.Location = new System.Drawing.Point(0, 119);
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CalendarButton.Size = new System.Drawing.Size(200, 66);
            this.CalendarButton.TabIndex = 0;
            this.CalendarButton.Text = " Calendar";
            this.CalendarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CalendarButton.UseVisualStyleBackColor = false;
            this.CalendarButton.Click += new System.EventHandler(this.CalendarButton_Click);
            // 
            // userControlsPanel
            // 
            this.userControlsPanel.Location = new System.Drawing.Point(218, 0);
            this.userControlsPanel.Name = "userControlsPanel";
            this.userControlsPanel.Size = new System.Drawing.Size(755, 653);
            this.userControlsPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(985, 653);
            this.Controls.Add(this.userControlsPanel);
            this.Controls.Add(this.NavigationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "Calendar App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.NavigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel NavigationPanel;
        private System.Windows.Forms.Button CalendarButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button ScheduleButton;
        private System.Windows.Forms.Button PersonalizeButton;
        private System.Windows.Forms.Panel userControlsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

