namespace gifSplitter
{
    partial class GifGrater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GifGrater));
            this.openGif = new System.Windows.Forms.Button();
            this.gifInBox = new System.Windows.Forms.TextBox();
            this.gifOutBox = new System.Windows.Forms.TextBox();
            this.run = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.display = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.display)).BeginInit();
            this.SuspendLayout();
            // 
            // openGif
            // 
            this.openGif.Location = new System.Drawing.Point(294, 12);
            this.openGif.Name = "openGif";
            this.openGif.Size = new System.Drawing.Size(75, 23);
            this.openGif.TabIndex = 0;
            this.openGif.Text = "Browse...";
            this.openGif.UseVisualStyleBackColor = true;
            this.openGif.Click += new System.EventHandler(this.openGif_Click);
            // 
            // gifInBox
            // 
            this.gifInBox.Location = new System.Drawing.Point(62, 13);
            this.gifInBox.Name = "gifInBox";
            this.gifInBox.Size = new System.Drawing.Size(215, 20);
            this.gifInBox.TabIndex = 2;
            // 
            // gifOutBox
            // 
            this.gifOutBox.Location = new System.Drawing.Point(62, 51);
            this.gifOutBox.Name = "gifOutBox";
            this.gifOutBox.Size = new System.Drawing.Size(215, 20);
            this.gifOutBox.TabIndex = 3;
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(294, 51);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(75, 23);
            this.run.TabIndex = 4;
            this.run.Text = "punch it";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "GIF In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "GIF Out";
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(387, 12);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(66, 62);
            this.display.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display.TabIndex = 8;
            this.display.TabStop = false;
            this.display.Visible = false;
            // 
            // GifGrater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 86);
            this.Controls.Add(this.display);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.run);
            this.Controls.Add(this.gifOutBox);
            this.Controls.Add(this.gifInBox);
            this.Controls.Add(this.openGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GifGrater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GifGrater";
            ((System.ComponentModel.ISupportInitialize)(this.display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button openGif;
        private System.Windows.Forms.TextBox gifInBox;
        private System.Windows.Forms.TextBox gifOutBox;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox display;
    }
}

