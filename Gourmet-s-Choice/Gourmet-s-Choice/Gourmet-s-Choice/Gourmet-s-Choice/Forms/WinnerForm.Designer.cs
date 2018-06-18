namespace Gourmet_s_Choice.Forms
{
    partial class WinnerForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bttnRetry = new System.Windows.Forms.Button();
            this.btnLink = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pctbWinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bttnRetry);
            this.splitContainer1.Panel1.Controls.Add(this.btnLink);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pctbWinner);
            this.splitContainer1.Size = new System.Drawing.Size(764, 450);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 4;
            // 
            // bttnRetry
            // 
            this.bttnRetry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnRetry.Location = new System.Drawing.Point(24, 201);
            this.bttnRetry.Name = "bttnRetry";
            this.bttnRetry.Size = new System.Drawing.Size(173, 46);
            this.bttnRetry.TabIndex = 3;
            this.bttnRetry.Text = "다시 하기";
            this.bttnRetry.UseVisualStyleBackColor = true;
            this.bttnRetry.Click += new System.EventHandler(this.bttnRetry_Click);
            // 
            // btnLink
            // 
            this.btnLink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLink.Location = new System.Drawing.Point(24, 253);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(173, 46);
            this.btnLink.TabIndex = 2;
            this.btnLink.Text = "button1";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Thistle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Gourmet_s_Choice.Properties.Resources.YourFood;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pctbWinner
            // 
            this.pctbWinner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctbWinner.Location = new System.Drawing.Point(0, 0);
            this.pctbWinner.Name = "pctbWinner";
            this.pctbWinner.Size = new System.Drawing.Size(539, 450);
            this.pctbWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbWinner.TabIndex = 1;
            this.pctbWinner.TabStop = false;
            // 
            // WinnerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "WinnerForm";
            this.Text = "WinnerForm";
            this.Load += new System.EventHandler(this.WinnerForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbWinner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctbWinner;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Button bttnRetry;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}