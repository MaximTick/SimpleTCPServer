namespace Client
{
    partial class Client
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.LoadImage = new System.Windows.Forms.Button();
            this.SendImage = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.enterIP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(90, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(592, 354);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // LoadImage
            // 
            this.LoadImage.Location = new System.Drawing.Point(90, 382);
            this.LoadImage.Name = "LoadImage";
            this.LoadImage.Size = new System.Drawing.Size(108, 56);
            this.LoadImage.TabIndex = 1;
            this.LoadImage.Text = "Load Image";
            this.LoadImage.UseVisualStyleBackColor = true;
            this.LoadImage.Click += new System.EventHandler(this.LoadImage_Click);
            // 
            // SendImage
            // 
            this.SendImage.Location = new System.Drawing.Point(575, 382);
            this.SendImage.Name = "SendImage";
            this.SendImage.Size = new System.Drawing.Size(107, 56);
            this.SendImage.TabIndex = 2;
            this.SendImage.Text = "Send image";
            this.SendImage.UseVisualStyleBackColor = true;
            this.SendImage.Click += new System.EventHandler(this.SendImage_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(453, 382);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 13);
            this.label.TabIndex = 3;
            this.label.Text = "Enter server ip";
            // 
            // enterIP
            // 
            this.enterIP.Location = new System.Drawing.Point(430, 401);
            this.enterIP.Name = "enterIP";
            this.enterIP.Size = new System.Drawing.Size(126, 20);
            this.enterIP.TabIndex = 4;
            this.enterIP.Text = "localhost";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.enterIP);
            this.Controls.Add(this.label);
            this.Controls.Add(this.SendImage);
            this.Controls.Add(this.LoadImage);
            this.Controls.Add(this.pictureBox);
            this.Name = "Client";
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button LoadImage;
        private System.Windows.Forms.Button SendImage;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox enterIP;
    }
}

