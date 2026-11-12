                            namespace Color_Theme
{
    partial class Form1
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
            this.colorGroupBox = new System.Windows.Forms.GroupBox();
            this.normalRadioButton = new System.Windows.Forms.RadioButton();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.yellowRadioButton = new System.Windows.Forms.RadioButton();
            this.exitButton = new System.Windows.Forms.Button();
            this.colorGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // colorGroupBox
            // 
            this.colorGroupBox.Controls.Add(this.normalRadioButton);
            this.colorGroupBox.Controls.Add(this.whiteRadioButton);
            this.colorGroupBox.Controls.Add(this.redRadioButton);
            this.colorGroupBox.Controls.Add(this.yellowRadioButton);
            this.colorGroupBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.colorGroupBox.Location = new System.Drawing.Point(35, 25);
            this.colorGroupBox.Margin = new System.Windows.Forms.Padding(5);
            this.colorGroupBox.Name = "colorGroupBox";
            this.colorGroupBox.Padding = new System.Windows.Forms.Padding(12, 14, 12, 12);
            this.colorGroupBox.Size = new System.Drawing.Size(470, 300);
            this.colorGroupBox.TabIndex = 0;
            this.colorGroupBox.TabStop = false;
            this.colorGroupBox.Text = "選擇背景色彩";
            // 
            // normalRadioButton
            // 
            this.normalRadioButton.AutoSize = false;
            this.normalRadioButton.Checked = true;
            this.normalRadioButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.normalRadioButton.Location = new System.Drawing.Point(35, 235);
            this.normalRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.normalRadioButton.Name = "normalRadioButton";
            this.normalRadioButton.Size = new System.Drawing.Size(390, 42);
            this.normalRadioButton.TabIndex = 3;
            this.normalRadioButton.TabStop = true;
            this.normalRadioButton.Text = "恢復正常";
            this.normalRadioButton.UseVisualStyleBackColor = true;
            this.normalRadioButton.CheckedChanged += new System.EventHandler(this.normalRadioButton_CheckedChanged);
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.AutoSize = false;
            this.whiteRadioButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.whiteRadioButton.Location = new System.Drawing.Point(35, 180);
            this.whiteRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(390, 42);
            this.whiteRadioButton.TabIndex = 2;
            this.whiteRadioButton.Text = "白色";
            this.whiteRadioButton.UseVisualStyleBackColor = true;
            this.whiteRadioButton.CheckedChanged += new System.EventHandler(this.whiteRadioButton_CheckedChanged);
            // 
            // redRadioButton
            // 
            this.redRadioButton.AutoSize = false;
            this.redRadioButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.redRadioButton.Location = new System.Drawing.Point(35, 125);
            this.redRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(390, 42);
            this.redRadioButton.TabIndex = 1;
            this.redRadioButton.Text = "紅色";
            this.redRadioButton.UseVisualStyleBackColor = true;
            this.redRadioButton.CheckedChanged += new System.EventHandler(this.redRadioButton_CheckedChanged);
            // 
            // yellowRadioButton
            // 
            this.yellowRadioButton.AutoSize = false;
            this.yellowRadioButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.yellowRadioButton.Location = new System.Drawing.Point(35, 70);
            this.yellowRadioButton.Margin = new System.Windows.Forms.Padding(5);
            this.yellowRadioButton.Name = "yellowRadioButton";
            this.yellowRadioButton.Size = new System.Drawing.Size(390, 42);
            this.yellowRadioButton.TabIndex = 0;
            this.yellowRadioButton.Text = "黃色";
            this.yellowRadioButton.UseVisualStyleBackColor = true;
            this.yellowRadioButton.CheckedChanged += new System.EventHandler(this.yellowRadioButton_CheckedChanged);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.exitButton.Location = new System.Drawing.Point(185, 345);
            this.exitButton.Margin = new System.Windows.Forms.Padding(5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(170, 55);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 430);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.colorGroupBox);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "色彩主題";
            this.colorGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox colorGroupBox;
        private System.Windows.Forms.RadioButton normalRadioButton;
        private System.Windows.Forms.RadioButton whiteRadioButton;
        private System.Windows.Forms.RadioButton redRadioButton;
        private System.Windows.Forms.RadioButton yellowRadioButton;
        private System.Windows.Forms.Button exitButton;
    }
}

