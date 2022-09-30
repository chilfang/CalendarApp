
namespace CapstoneProjectQ1.UserControls {
    partial class Date {
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.noteDisplayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Location = new System.Drawing.Point(0, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(31, 15);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Date";
            // 
            // noteDisplayButton
            // 
            this.noteDisplayButton.BackColor = System.Drawing.Color.Red;
            this.noteDisplayButton.FlatAppearance.BorderSize = 0;
            this.noteDisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noteDisplayButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.noteDisplayButton.Location = new System.Drawing.Point(3, 18);
            this.noteDisplayButton.Name = "noteDisplayButton";
            this.noteDisplayButton.Size = new System.Drawing.Size(95, 38);
            this.noteDisplayButton.TabIndex = 1;
            this.noteDisplayButton.UseVisualStyleBackColor = false;
            this.noteDisplayButton.Click += new System.EventHandler(this.noteDisplayButton_Click);
            this.noteDisplayButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.noteDisplayButton_MouseDown);
            // 
            // Date
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.noteDisplayButton);
            this.Controls.Add(this.dateLabel);
            this.Name = "Date";
            this.Size = new System.Drawing.Size(101, 84);
            this.Click += new System.EventHandler(this.Date_Click);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Date_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Date_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        public System.Windows.Forms.Button noteDisplayButton;
    }
}
