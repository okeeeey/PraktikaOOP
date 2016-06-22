namespace baseform
{
    partial class Level1
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_smile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_key_ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_key
            // 
            this.pictureBox_key.Location = new System.Drawing.Point(296, 298);
            // 
            // pictureBox_door
            // 
            this.pictureBox_door.Location = new System.Drawing.Point(563, 346);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::baseform.Properties.Resources.block;
            this.pictureBox2.Location = new System.Drawing.Point(263, 332);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 25);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::baseform.Properties.Resources.spikes;
            this.pictureBox1.Location = new System.Drawing.Point(280, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 18);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Level1";
            this.Text = "Level1";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBoxGround, 0);
            this.Controls.SetChildIndex(this.pictureBox_key_ico, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox_key, 0);
            this.Controls.SetChildIndex(this.pictureBox_door, 0);
            this.Controls.SetChildIndex(this.pictureBox_smile, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_smile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_key_ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_door)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}