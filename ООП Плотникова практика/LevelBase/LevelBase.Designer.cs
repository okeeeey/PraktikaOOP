namespace LevelBase
{
    partial class LevelBase
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxGround = new System.Windows.Forms.PictureBox();
            this.pictureBox_smile = new System.Windows.Forms.PictureBox();
            this.pictureBox_key = new System.Windows.Forms.PictureBox();
            this.pictureBox_key_ico = new System.Windows.Forms.PictureBox();
            this.pictureBox_door = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_smile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_key)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_key_ico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_door)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGround
            // 
            this.pictureBoxGround.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureBoxGround.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxGround.BackgroundImage = global::LevelBase.Properties.Resources.grass;
            this.pictureBoxGround.Enabled = false;
            this.pictureBoxGround.Image = global::LevelBase.Properties.Resources.grass;
            this.pictureBoxGround.Location = new System.Drawing.Point(-5, 411);
            this.pictureBoxGround.Name = "pictureBoxGround";
            this.pictureBoxGround.Size = new System.Drawing.Size(800, 50);
            this.pictureBoxGround.TabIndex = 0;
            this.pictureBoxGround.TabStop = false;
            // 
            // pictureBox_smile
            // 
            this.pictureBox_smile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox_smile.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_smile.BackgroundImage = global::LevelBase.Properties.Resources.smile;
            this.pictureBox_smile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_smile.Location = new System.Drawing.Point(0, 371);
            this.pictureBox_smile.Name = "pictureBox_smile";
            this.pictureBox_smile.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_smile.TabIndex = 2;
            this.pictureBox_smile.TabStop = false;
            // 
            // pictureBox_key
            // 
            this.pictureBox_key.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_key.BackgroundImage = global::LevelBase.Properties.Resources.key;
            this.pictureBox_key.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_key.Location = new System.Drawing.Point(344, 375);
            this.pictureBox_key.Name = "pictureBox_key";
            this.pictureBox_key.Size = new System.Drawing.Size(30, 30);
            this.pictureBox_key.TabIndex = 11;
            this.pictureBox_key.TabStop = false;
            // 
            // pictureBox_key_ico
            // 
            this.pictureBox_key_ico.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_key_ico.BackgroundImage = global::LevelBase.Properties.Resources.key;
            this.pictureBox_key_ico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_key_ico.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_key_ico.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_key_ico.Name = "pictureBox_key_ico";
            this.pictureBox_key_ico.Size = new System.Drawing.Size(40, 40);
            this.pictureBox_key_ico.TabIndex = 12;
            this.pictureBox_key_ico.TabStop = false;
            // 
            // pictureBox_door
            // 
            this.pictureBox_door.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_door.BackgroundImage = global::LevelBase.Properties.Resources.door;
            this.pictureBox_door.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_door.Location = new System.Drawing.Point(740, 346);
            this.pictureBox_door.Name = "pictureBox_door";
            this.pictureBox_door.Size = new System.Drawing.Size(45, 65);
            this.pictureBox_door.TabIndex = 13;
            this.pictureBox_door.TabStop = false;
            // 
            // LevelBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::LevelBase.Properties.Resources.background_landscape;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pictureBox_smile);
            this.Controls.Add(this.pictureBox_door);
            this.Controls.Add(this.pictureBox_key_ico);
            this.Controls.Add(this.pictureBoxGround);
            this.Controls.Add(this.pictureBox_key);
            this.DoubleBuffered = true;
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LevelBase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LevelBase_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.LevelBase_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_smile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_key)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_key_ico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_door)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBoxGround;
        public System.Windows.Forms.PictureBox pictureBox_smile;
        public System.Windows.Forms.PictureBox pictureBox_key;
        public System.Windows.Forms.PictureBox pictureBox_key_ico;
        public System.Windows.Forms.PictureBox pictureBox_door;
        public System.Windows.Forms.CheckBox checheckBox_sound;

    }
}

