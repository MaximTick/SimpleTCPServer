namespace Server
{
    partial class Form1
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
            this.AcceptConnection = new System.Windows.Forms.Button();
            this.ReceiveImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(51, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(592, 354);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // AcceptConnection
            // 
            this.AcceptConnection.Location = new System.Drawing.Point(51, 373);
            this.AcceptConnection.Name = "AcceptConnection";
            this.AcceptConnection.Size = new System.Drawing.Size(130, 65);
            this.AcceptConnection.TabIndex = 2;
            this.AcceptConnection.Text = "Accept connection";
            this.AcceptConnection.UseVisualStyleBackColor = true;
            this.AcceptConnection.Click += new System.EventHandler(this.AcceptConnection_Click);
            // 
            // ReceiveImage
            // 
            this.ReceiveImage.Location = new System.Drawing.Point(513, 382);
            this.ReceiveImage.Name = "ReceiveImage";
            this.ReceiveImage.Size = new System.Drawing.Size(130, 65);
            this.ReceiveImage.TabIndex = 3;
            this.ReceiveImage.Text = "Receive image";
            this.ReceiveImage.UseVisualStyleBackColor = true;
            this.ReceiveImage.Click += new System.EventHandler(this.ReceiveImage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReceiveImage);
            this.Controls.Add(this.AcceptConnection);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button AcceptConnection;
        private System.Windows.Forms.Button ReceiveImage;
    }
}

