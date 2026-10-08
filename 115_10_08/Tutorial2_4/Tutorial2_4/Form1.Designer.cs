namespace Tutorial2_4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.germanyPictureBox = new System.Windows.Forms.PictureBox();
            this.francePictureBox = new System.Windows.Forms.PictureBox();
            this.finlandPictureBox = new System.Windows.Forms.PictureBox();
            this.councry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // germanyPictureBox
            // 
            this.germanyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("germanyPictureBox.Image")));
            this.germanyPictureBox.Location = new System.Drawing.Point(529, 126);
            this.germanyPictureBox.Name = "germanyPictureBox";
            this.germanyPictureBox.Size = new System.Drawing.Size(196, 129);
            this.germanyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanyPictureBox.TabIndex = 2;
            this.germanyPictureBox.TabStop = false;
            this.germanyPictureBox.Click += new System.EventHandler(this.germanyPictureBox_Click);
            // 
            // francePictureBox
            // 
            this.francePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("francePictureBox.Image")));
            this.francePictureBox.Location = new System.Drawing.Point(272, 126);
            this.francePictureBox.Name = "francePictureBox";
            this.francePictureBox.Size = new System.Drawing.Size(196, 129);
            this.francePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.francePictureBox.TabIndex = 1;
            this.francePictureBox.TabStop = false;
            this.francePictureBox.Click += new System.EventHandler(this.francePictureBox_Click);
            // 
            // finlandPictureBox
            // 
            this.finlandPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("finlandPictureBox.Image")));
            this.finlandPictureBox.Location = new System.Drawing.Point(24, 126);
            this.finlandPictureBox.Name = "finlandPictureBox";
            this.finlandPictureBox.Size = new System.Drawing.Size(192, 129);
            this.finlandPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finlandPictureBox.TabIndex = 0;
            this.finlandPictureBox.TabStop = false;
            this.finlandPictureBox.Click += new System.EventHandler(this.finlandPictureBox_Click);
            // 
            // councry
            // 
            this.councry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.councry.Location = new System.Drawing.Point(127, 332);
            this.councry.Name = "councry";
            this.councry.Size = new System.Drawing.Size(185, 84);
            this.councry.TabIndex = 3;
            this.councry.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(67, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(594, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "點選一個國旗，我告訴你是哪個國家";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.councry);
            this.Controls.Add(this.germanyPictureBox);
            this.Controls.Add(this.francePictureBox);
            this.Controls.Add(this.finlandPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.germanyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.francePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finlandPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox finlandPictureBox;
        private System.Windows.Forms.PictureBox francePictureBox;
        private System.Windows.Forms.PictureBox germanyPictureBox;
        private System.Windows.Forms.Label councry;
        private System.Windows.Forms.Label label2;
    }
}

