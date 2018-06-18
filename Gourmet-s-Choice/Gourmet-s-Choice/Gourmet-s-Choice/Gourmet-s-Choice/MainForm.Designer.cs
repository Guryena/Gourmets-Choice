namespace Gourmet_s_Choice
{
    partial class MainForm
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
            this.ptbLeft = new System.Windows.Forms.PictureBox();
            this.ptbRight = new System.Windows.Forms.PictureBox();
            this.pctbRound = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbLeft
            // 
            this.ptbLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbLeft.Location = new System.Drawing.Point(0, 0);
            this.ptbLeft.Name = "ptbLeft";
            this.ptbLeft.Size = new System.Drawing.Size(357, 318);
            this.ptbLeft.TabIndex = 0;
            this.ptbLeft.TabStop = false;
            this.ptbLeft.Click += new System.EventHandler(this.ptbLeft_Click);
            // 
            // ptbRight
            // 
            this.ptbRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbRight.Location = new System.Drawing.Point(0, 0);
            this.ptbRight.Name = "ptbRight";
            this.ptbRight.Size = new System.Drawing.Size(354, 318);
            this.ptbRight.TabIndex = 1;
            this.ptbRight.TabStop = false;
            this.ptbRight.Click += new System.EventHandler(this.ptbRight_Click);
            // 
            // pctbRound
            // 
            this.pctbRound.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pctbRound.Location = new System.Drawing.Point(312, 10);
            this.pctbRound.Margin = new System.Windows.Forms.Padding(1);
            this.pctbRound.Name = "pctbRound";
            this.pctbRound.Size = new System.Drawing.Size(92, 90);
            this.pctbRound.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbRound.TabIndex = 6;
            this.pctbRound.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.Location = new System.Drawing.Point(0, 104);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ptbLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ptbRight);
            this.splitContainer1.Size = new System.Drawing.Size(715, 318);
            this.splitContainer1.SplitterDistance = 357;
            this.splitContainer1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(715, 422);
            this.Controls.Add(this.pctbRound);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbRound)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbLeft;
        private System.Windows.Forms.PictureBox ptbRight;
        private System.Windows.Forms.PictureBox pctbRound;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

