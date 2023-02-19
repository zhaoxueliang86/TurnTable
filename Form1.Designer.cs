namespace TurnTableDemo
{
    partial class Form1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.BtnStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnReady = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(65, 43);
            this.progressBar1.MarqueeAnimationSpeed = 200;
            this.progressBar1.Maximum = 80;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1320, 91);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 4;
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnStart.Location = new System.Drawing.Point(1391, 43);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(158, 91);
            this.BtnStart.TabIndex = 5;
            this.BtnStart.Text = "开始";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnStart_MouseDown);
            this.BtnStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnStart_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(574, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 951);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(65, 163);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(357, 951);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "曹操\n刘备\n孙权\n郭嘉\n关羽\n周瑜\n吕布\n董卓\n张飞\n鲁肃";
            this.richTextBox1.Validated += new System.EventHandler(this.richTextBox1_Validated);
            // 
            // BtnReady
            // 
            this.BtnReady.Font = new System.Drawing.Font("Microsoft YaHei UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BtnReady.Location = new System.Drawing.Point(448, 480);
            this.BtnReady.Name = "BtnReady";
            this.BtnReady.Size = new System.Drawing.Size(102, 91);
            this.BtnReady.TabIndex = 7;
            this.BtnReady.Text = "准备";
            this.BtnReady.UseVisualStyleBackColor = true;
            this.BtnReady.Click += new System.EventHandler(this.BtnReady_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1589, 1147);
            this.Controls.Add(this.BtnReady);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProgressBar progressBar1;
        private Button BtnStart;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
        private Button BtnReady;
    }
}