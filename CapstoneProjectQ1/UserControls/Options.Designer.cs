
namespace CapstoneProjectQ1 {
    partial class Options {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ExportCalendarButton = new System.Windows.Forms.Button();
            this.ImportCalendarButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.PathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExportCalendarButton
            // 
            this.ExportCalendarButton.AutoSize = true;
            this.ExportCalendarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ExportCalendarButton.FlatAppearance.BorderSize = 0;
            this.ExportCalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportCalendarButton.Location = new System.Drawing.Point(109, 51);
            this.ExportCalendarButton.Name = "ExportCalendarButton";
            this.ExportCalendarButton.Size = new System.Drawing.Size(101, 27);
            this.ExportCalendarButton.TabIndex = 8;
            this.ExportCalendarButton.Text = "Export Calendar";
            this.ExportCalendarButton.UseVisualStyleBackColor = false;
            this.ExportCalendarButton.Click += new System.EventHandler(this.ExportCalendarButton_Click);
            // 
            // ImportCalendarButton
            // 
            this.ImportCalendarButton.AutoSize = true;
            this.ImportCalendarButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ImportCalendarButton.FlatAppearance.BorderSize = 0;
            this.ImportCalendarButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportCalendarButton.Location = new System.Drawing.Point(216, 51);
            this.ImportCalendarButton.Name = "ImportCalendarButton";
            this.ImportCalendarButton.Size = new System.Drawing.Size(103, 27);
            this.ImportCalendarButton.TabIndex = 9;
            this.ImportCalendarButton.Text = "Import Calendar";
            this.ImportCalendarButton.UseVisualStyleBackColor = false;
            this.ImportCalendarButton.Click += new System.EventHandler(this.ImportCalendarButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Database Files (*.db)|*.db|All Files (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "database";
            this.saveFileDialog1.Filter = "Database Files (*.db)|*.db";
            this.saveFileDialog1.Title = "Export";
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(109, 33);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(31, 15);
            this.PathLabel.TabIndex = 10;
            this.PathLabel.Text = "Path";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.ImportCalendarButton);
            this.Controls.Add(this.ExportCalendarButton);
            this.Name = "Options";
            this.Size = new System.Drawing.Size(755, 557);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportCalendarButton;
        private System.Windows.Forms.Button ImportCalendarButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label PathLabel;
    }
}
