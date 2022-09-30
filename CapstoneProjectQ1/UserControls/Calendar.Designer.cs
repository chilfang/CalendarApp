
namespace CapstoneProjectQ1 {
    partial class Calendar {
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
            this.CurrentMonthLabel = new System.Windows.Forms.Label();
            this.ArrowRightPicture = new System.Windows.Forms.PictureBox();
            this.ArrowLeftPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowRightPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowLeftPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CurrentMonthLabel
            // 
            this.CurrentMonthLabel.BackColor = System.Drawing.Color.Transparent;
            this.CurrentMonthLabel.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentMonthLabel.Location = new System.Drawing.Point(136, 0);
            this.CurrentMonthLabel.Name = "CurrentMonthLabel";
            this.CurrentMonthLabel.Size = new System.Drawing.Size(483, 89);
            this.CurrentMonthLabel.TabIndex = 1;
            this.CurrentMonthLabel.Text = "September 2022";
            this.CurrentMonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArrowRightPicture
            // 
            this.ArrowRightPicture.BackColor = System.Drawing.Color.Transparent;
            this.ArrowRightPicture.Image = global::CapstoneProjectQ1.Properties.Resources.ArrowRight;
            this.ArrowRightPicture.Location = new System.Drawing.Point(622, 17);
            this.ArrowRightPicture.Name = "ArrowRightPicture";
            this.ArrowRightPicture.Size = new System.Drawing.Size(130, 84);
            this.ArrowRightPicture.TabIndex = 2;
            this.ArrowRightPicture.TabStop = false;
            this.ArrowRightPicture.Click += new System.EventHandler(this.ArrowRightPicture_Click);
            // 
            // ArrowLeftPicture
            // 
            this.ArrowLeftPicture.BackColor = System.Drawing.Color.Transparent;
            this.ArrowLeftPicture.Image = global::CapstoneProjectQ1.Properties.Resources.ArrowLeft;
            this.ArrowLeftPicture.Location = new System.Drawing.Point(3, 17);
            this.ArrowLeftPicture.Name = "ArrowLeftPicture";
            this.ArrowLeftPicture.Size = new System.Drawing.Size(130, 84);
            this.ArrowLeftPicture.TabIndex = 3;
            this.ArrowLeftPicture.TabStop = false;
            this.ArrowLeftPicture.Click += new System.EventHandler(this.ArrowLeftPicture_Click);
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.CurrentMonthLabel);
            this.Controls.Add(this.ArrowLeftPicture);
            this.Controls.Add(this.ArrowRightPicture);
            this.Name = "Calendar";
            this.Size = new System.Drawing.Size(755, 653);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Calendar_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.ArrowRightPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowLeftPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CurrentMonthLabel;
        private System.Windows.Forms.PictureBox ArrowRightPicture;
        private System.Windows.Forms.PictureBox ArrowLeftPicture;
    }
}
