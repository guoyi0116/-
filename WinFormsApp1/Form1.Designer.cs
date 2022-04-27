
namespace WinFormsApp1
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
            this.btntruegray = new System.Windows.Forms.Button();
            this.btnLord2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.butngray = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnlightup = new System.Windows.Forms.Button();
            this.marcycar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btntruegray
            // 
            this.btntruegray.Location = new System.Drawing.Point(156, 311);
            this.btntruegray.Name = "btntruegray";
            this.btntruegray.Size = new System.Drawing.Size(147, 64);
            this.btntruegray.TabIndex = 0;
            this.btntruegray.Text = "灰階";
            this.btntruegray.UseVisualStyleBackColor = true;
            this.btntruegray.Click += new System.EventHandler(this.buttonlord_Click);
            // 
            // btnLord2
            // 
            this.btnLord2.Location = new System.Drawing.Point(3, 311);
            this.btnLord2.Name = "btnLord2";
            this.btnLord2.Size = new System.Drawing.Size(147, 64);
            this.btnLord2.TabIndex = 2;
            this.btnLord2.Text = "載入圖片";
            this.btnLord2.UseVisualStyleBackColor = true;
            this.btnLord2.Click += new System.EventHandler(this.btnLord2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 264);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // butngray
            // 
            this.butngray.Location = new System.Drawing.Point(309, 311);
            this.butngray.Name = "butngray";
            this.butngray.Size = new System.Drawing.Size(147, 64);
            this.butngray.TabIndex = 4;
            this.butngray.Text = "負片";
            this.butngray.UseVisualStyleBackColor = true;
            this.butngray.Click += new System.EventHandler(this.butngray_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(258, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(218, 264);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // btnlightup
            // 
            this.btnlightup.Location = new System.Drawing.Point(472, 311);
            this.btnlightup.Name = "btnlightup";
            this.btnlightup.Size = new System.Drawing.Size(147, 64);
            this.btnlightup.TabIndex = 6;
            this.btnlightup.Text = "變亮";
            this.btnlightup.UseVisualStyleBackColor = true;
            this.btnlightup.Click += new System.EventHandler(this.btnlightup_Click);
            // 
            // marcycar
            // 
            this.marcycar.Location = new System.Drawing.Point(625, 311);
            this.marcycar.Name = "marcycar";
            this.marcycar.Size = new System.Drawing.Size(147, 64);
            this.marcycar.TabIndex = 7;
            this.marcycar.Text = "馬賽克";
            this.marcycar.UseVisualStyleBackColor = true;
            this.marcycar.Click += new System.EventHandler(this.marcycar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.marcycar);
            this.Controls.Add(this.btnlightup);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.butngray);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnLord2);
            this.Controls.Add(this.btntruegray);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntruegray;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLord2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button butngray;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnlightup;
        private System.Windows.Forms.Button marcycar;
    }
}

