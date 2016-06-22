/*************************************************************************
*                       МАИ Каф 302 2 курс ООП                           *
**************************************************************************
*Project Type     : WindowsFormsApplication                              *
*Project Name     : baseform                                             *
*Language         : MS Visual Studio 2013 C#                             *
*File Name        : Level1.cs                                            *
*Programmer(s)    : Плотникова А.В.                                      *
*Modified by      : Плотникова А.В.                                      *
*Created          : 14/06/2016                                           *
*Last Revision    : 17/06/2016                                           *
*Comment          : ООП практика                                         *
**************************************************************************/


using LevelBase;
using System.Collections.Generic;
using System.Windows.Forms;

namespace baseform
{
    public partial class Level1 : LevelBase.LevelBase
    {
        public Level1()
        {
            InitializeComponent();
            InitializeLevel();
            this.Text = "Уровень 1";
        }

        /// <summary>
        /// Подготовка игровой логики при запуске игры
        /// </summary>
        public override void InitializeLevel()
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
            GameLogic.NextForm = new Level2();
        }

        /// <summary>
        /// Переопределение нажатия клавиши
        /// </summary>
        /// <param name="e"></param>
        public override void KeyDownVirtual(KeyEventArgs e)
        {
            base.KeyDownVirtual(e);
        }

        /// <summary>
        /// Переопределение отпускания клавиши
        /// </summary>
        /// <param name="e"></param>
        public override void KeyUpVirtual(KeyEventArgs e)
        {
            base.KeyUpVirtual(e);
        }

    }
}
