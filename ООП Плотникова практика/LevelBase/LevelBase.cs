/*************************************************************************
*                       МАИ Каф 302 2 курс ООП                           *
**************************************************************************
*Project Type     : WindowsFormsApplication                              *
*Project Name     : baseform                                             *
*Language         : MS Visual Studio 2013 C#                             *
*File Name        : LevelBase.cs                                         *
*Programmer(s)    : Плотникова А.В.                                      *
*Modified by      : Плотникова А.В.                                      *
*Created          : 14/06/2016                                           *
*Last Revision    : 17/06/2016                                           *
*Comment          : ООП практика                                         *
**************************************************************************/


using System.Collections.Generic;
using System.Windows.Forms;

namespace LevelBase
{
    public partial class LevelBase : Form
    {
        public Logic GameLogic;
        public List<PictureBox> Platforms;
        public List<PictureBox> Spikes;
        protected LevelBase form;
        public LevelBase()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Подготовка игровой логики при запуске игры
        /// </summary>
        public virtual void InitializeLevel()
        {
            Platforms = new List<PictureBox>();
            Spikes = new List<PictureBox>();
            foreach (var c in this.Controls)
            {
                if (c is PictureBox)
                {
                    if (c == pictureBox_door || c == pictureBox_key || c == pictureBox_key_ico || c == pictureBox_smile)
                    {
                        continue;
                    }
                        Platforms.Add(c as PictureBox);
                }
            }

            foreach (var p in Platforms)
            {
                if (p.Height == 18)
                {
                    Spikes.Add(p as PictureBox);
                }
            }


            form = this;
            GameLogic = new Logic(ref form);
            GameLogic.X_Smile_Current = pictureBox_smile.Location.X;
            GameLogic.Y_Smile_Current = pictureBox_smile.Location.Y;
            GameLogic.form_border_up = 0;
            GameLogic.form_border_down = 398;
            GameLogic.form_border_left = 0;
            GameLogic.form_border_right = 743;
            GameLogic.vert_speed = -15;
            GameLogic.X_Key = pictureBox_key.Location.X;
        }

        /// <summary>
        /// Отпускание клавиши на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LevelBase_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDownVirtual(e);
        }

        /// <summary>
        /// Нажатие клавиши на форме
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LevelBase_KeyUp(object sender, KeyEventArgs e)
        {
            KeyUpVirtual(e);
        }

        /// <summary>
        /// Клавиша отпущена
        /// </summary>
        /// <param name="e"></param>
        public virtual void KeyUpVirtual(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GameLogic.timer_left.Stop();
            }

            if (e.KeyCode == Keys.Right)
            {
                GameLogic.timer_right.Stop();
            }
            if (e.KeyCode == Keys.R)
            {
                GameLogic.ReSpawn();
            }
        }

        /// <summary>
        /// Клавиша нажата
        /// </summary>
        /// <param name="e"></param>
        public virtual void KeyDownVirtual(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GameLogic.timer_left.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                GameLogic.timer_right.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                if (GameLogic.On_Ground())
                {
                    GameLogic.timer_up.Start();
                }
            }
        }
    }
}