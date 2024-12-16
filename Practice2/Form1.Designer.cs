namespace Practice2
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
			this.roomPictureBox = new System.Windows.Forms.PictureBox();
			this.questNameLabel = new System.Windows.Forms.Label();
			this.questDescriptionLabel = new System.Windows.Forms.Label();
			this.guiPictureBox = new System.Windows.Forms.PictureBox();
			this.decoyPicture1 = new System.Windows.Forms.PictureBox();
			this.decoyPicture2 = new System.Windows.Forms.PictureBox();
			this.decoyPicture3 = new System.Windows.Forms.PictureBox();
			this.questItemPicture = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.guiPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.decoyPicture1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.decoyPicture2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.decoyPicture3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.questItemPicture)).BeginInit();
			this.SuspendLayout();
			// 
			// roomPictureBox
			// 
			this.roomPictureBox.BackColor = System.Drawing.SystemColors.Control;
			this.roomPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.roomPictureBox.Location = new System.Drawing.Point(0, 0);
			this.roomPictureBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.roomPictureBox.Name = "roomPictureBox";
			this.roomPictureBox.Size = new System.Drawing.Size(960, 540);
			this.roomPictureBox.TabIndex = 0;
			this.roomPictureBox.TabStop = false;
			// 
			// questNameLabel
			// 
			this.questNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.questNameLabel.ForeColor = System.Drawing.Color.White;
			this.questNameLabel.Location = new System.Drawing.Point(65, 92);
			this.questNameLabel.Name = "questNameLabel";
			this.questNameLabel.Size = new System.Drawing.Size(212, 53);
			this.questNameLabel.TabIndex = 1;
			this.questNameLabel.Text = "label1";
			// 
			// questDescriptionLabel
			// 
			this.questDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
			this.questDescriptionLabel.ForeColor = System.Drawing.Color.White;
			this.questDescriptionLabel.Location = new System.Drawing.Point(65, 145);
			this.questDescriptionLabel.Name = "questDescriptionLabel";
			this.questDescriptionLabel.Size = new System.Drawing.Size(212, 71);
			this.questDescriptionLabel.TabIndex = 2;
			this.questDescriptionLabel.Text = "label1";
			// 
			// guiPictureBox
			// 
			this.guiPictureBox.BackColor = System.Drawing.Color.Transparent;
			this.guiPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.guiPictureBox.Location = new System.Drawing.Point(0, 0);
			this.guiPictureBox.Name = "guiPictureBox";
			this.guiPictureBox.Size = new System.Drawing.Size(355, 300);
			this.guiPictureBox.TabIndex = 3;
			this.guiPictureBox.TabStop = false;
			// 
			// decoyPicture1
			// 
			this.decoyPicture1.BackColor = System.Drawing.Color.Transparent;
			this.decoyPicture1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.decoyPicture1.Location = new System.Drawing.Point(402, 28);
			this.decoyPicture1.Name = "decoyPicture1";
			this.decoyPicture1.Size = new System.Drawing.Size(63, 62);
			this.decoyPicture1.TabIndex = 4;
			this.decoyPicture1.TabStop = false;
			this.decoyPicture1.Click += new System.EventHandler(this.decoyPictureClick);
			// 
			// decoyPicture2
			// 
			this.decoyPicture2.BackColor = System.Drawing.Color.Transparent;
			this.decoyPicture2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.decoyPicture2.Location = new System.Drawing.Point(471, 28);
			this.decoyPicture2.Name = "decoyPicture2";
			this.decoyPicture2.Size = new System.Drawing.Size(63, 62);
			this.decoyPicture2.TabIndex = 5;
			this.decoyPicture2.TabStop = false;
			this.decoyPicture2.Click += new System.EventHandler(this.decoyPictureClick);
			// 
			// decoyPicture3
			// 
			this.decoyPicture3.BackColor = System.Drawing.Color.Transparent;
			this.decoyPicture3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.decoyPicture3.Location = new System.Drawing.Point(540, 28);
			this.decoyPicture3.Name = "decoyPicture3";
			this.decoyPicture3.Size = new System.Drawing.Size(63, 62);
			this.decoyPicture3.TabIndex = 6;
			this.decoyPicture3.TabStop = false;
			this.decoyPicture3.Click += new System.EventHandler(this.decoyPictureClick);
			// 
			// questItemPicture
			// 
			this.questItemPicture.BackColor = System.Drawing.Color.Transparent;
			this.questItemPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.questItemPicture.Location = new System.Drawing.Point(634, 28);
			this.questItemPicture.Name = "questItemPicture";
			this.questItemPicture.Size = new System.Drawing.Size(63, 62);
			this.questItemPicture.TabIndex = 7;
			this.questItemPicture.TabStop = false;
			this.questItemPicture.Click += new System.EventHandler(this.questItemPictureClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(961, 541);
			this.Controls.Add(this.questItemPicture);
			this.Controls.Add(this.decoyPicture3);
			this.Controls.Add(this.decoyPicture2);
			this.Controls.Add(this.decoyPicture1);
			this.Controls.Add(this.questDescriptionLabel);
			this.Controls.Add(this.questNameLabel);
			this.Controls.Add(this.guiPictureBox);
			this.Controls.Add(this.roomPictureBox);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.roomPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.guiPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.decoyPicture1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.decoyPicture2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.decoyPicture3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.questItemPicture)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.PictureBox roomPictureBox;
		private System.Windows.Forms.Label questNameLabel;
		private System.Windows.Forms.Label questDescriptionLabel;
		private System.Windows.Forms.PictureBox guiPictureBox;
		private System.Windows.Forms.PictureBox decoyPicture1;
		private System.Windows.Forms.PictureBox decoyPicture2;
		private System.Windows.Forms.PictureBox decoyPicture3;
		private System.Windows.Forms.PictureBox questItemPicture;
	}
}

