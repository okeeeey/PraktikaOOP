/*************************************************************************
*                       МАИ Каф 302 2 курс ООП                           *
**************************************************************************
*Project Type     : WindowsFormsApplication                              *
*Project Name     : baseform                                             *
*Language         : MS Visual Studio 2013 C#                             *
*File Name        : Logic.cs                                             *
*Programmer(s)    : Плотникова А.В.                                      *
*Modified by      : Плотникова А.В.                                      *
*Created          : 14/06/2016                                           *
*Last Revision    : 17/06/2016                                           *
*Comment          : ООП практика                                         *
**************************************************************************/


using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace LevelBase
{
    public class Logic
    {
        bool IsFalling = false;

        SoundPlayer player;

        public Timer timer_main = new Timer(); //таймер уровня, меняет всю ситуацию игры
        public Timer timer_left = new Timer();
        public Timer timer_right = new Timer();
        public Timer timer_up = new Timer();

        /// <summary>
        /// Интервал всех таймеров
        /// </summary>
        public const int timer_interval = 1;
        /// <summary>
        /// Максимальная скорость движения вверх
        /// </summary>
        public const int vert_speed_max = 0;
        /// <summary>
        /// Смещение смайла при нажатии стрелки
        /// </summary>
        public int move_step = 2;
        /// <summary>
        /// Крайняя верхняя точка для смайла
        /// </summary>
        public int form_border_up { get; set; }
        /// <summary>
        /// Крайняя нижняя точка для смайла
        /// </summary>
        public int form_border_down { get; set; }
        /// <summary>
        /// Крайняя левая точка для смайла
        /// </summary>
        public int form_border_left { get; set; }
        /// <summary>
        /// Крайняя правая точка для смайла
        /// </summary>
        public int form_border_right { get; set; }
        /// <summary>
        /// Скорость движения смайла по вертикали
        /// </summary>
        public int vert_speed { get; set; }
        /// <summary>
        /// Изменение положения смайла по вертикали
        /// </summary>
        public int inc_hor { get; set; }
        /// <summary>
        /// Изменение положения смайла по горизонтали
        /// </summary>
        public int inc_vert { get; set; }
        /// <summary>
        /// Текущая координата смайлика по X
        /// </summary>
        public int X_Smile_Current { get; set; }
        /// <summary>
        /// Текущая координата смайлика по Y
        /// </summary>
        public int Y_Smile_Current { get; set; }
        /// <summary>
        /// Флаг для отображения направления движения - вверх или вниз
        /// </summary>
        public bool Is_Moving_Up;
        /// <summary>
        /// Сообщение для лога
        /// </summary>
        public string LogMessage { get; set; }
        /// <summary>
        /// :)
        /// </summary>
        public PictureBox Smile { get; set; }
        /// <summary>
        /// Платформы на игровом поле
        /// </summary> 
        public PictureBox[] Platforms;
        /// <summary>
        /// Координата ключа по Х
        /// </summary>
        public int X_Key { get; set; }
        /// <summary>
        /// Флаг наличия ключа
        /// </summary>
        bool has_key = false;
        /// <summary>
        /// Ключ
        /// </summary>
        public PictureBox Key { get; set; }
        /// <summary>
        /// Звук
        /// </summary>
        public CheckBox checkBox_sound { get; set; }
        /// <summary>
        /// Следующая форма
        /// </summary>
        public Form NextForm { get; set; }
        /// <summary>
        /// Базовая форма
        /// </summary>
        private LevelBase Form;
        /// <summary>
        /// Шипы на игровом поле
        /// </summary> 
        public PictureBox[] Spikes;


        /// <summary>
        /// Движение смайлика влево
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        public void Move_left(Object myObject, EventArgs myEventArgs)
        {
            int border_distance = Math.Abs(X_Smile_Current - form_border_left);

            if (!(On_Ground())) //Если не на платформе или земле
            {
                if (!(IsFalling)) //Если ещё не падаем
                {
                    vert_speed = 0;
                    IsFalling = true;
                    timer_up.Start();
                }
            }

            if (border_distance > move_step) //Движемся влево, место есть
            {
                inc_hor -= move_step;
            }
            else //Упираемся в препятствие слева
            {
                inc_hor -= border_distance;
            }
        }

        /// <summary>
        /// Движение смайлика вправо
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        public void Move_right(Object myObject, EventArgs myEventArgs)
        {
            int border_distance = Math.Abs(X_Smile_Current - form_border_right);

            if (!(On_Ground())) //Если не на платформе или земле
            {
                if (!(IsFalling)) //Если ещё не падаем
                {
                    vert_speed = 0;
                    IsFalling = true;
                    timer_up.Start();
                }
            }

            if (border_distance > move_step) //Движемся вправо, место есть
            {
                inc_hor += move_step;
            }
            else //Упираемся в препятствие справа
            {
                inc_hor += border_distance;
            }
        }

        /// <summary>
        /// Движение смайлика по вертикали
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        public void Move_up(Object myObject, EventArgs myEventArgs)
        {
            // Скорость отрицательная
            if (vert_speed < vert_speed_max)
            {
                // Если при следующем смещении не упираемся в потолок (препятствие)
                if (Y_Smile_Current + vert_speed > form_border_up)
                {
                    vert_speed++;
                }
                else //Не хватает места, максимально сдвигаемся и начинаем падать
                {
                    vert_speed = form_border_up - Y_Smile_Current;
                }
            }
            // Достигли максимальной скорости - движение вниз
            else if (vert_speed == vert_speed_max) //Застыли наверху, начинаем падать
            {
                vert_speed++;
            }

            else
            {
                Falling();
            }


            // Изменяем положение по вертикали
            inc_vert += vert_speed;
        }

        /// <summary>
        /// Проверка нахождения смайлика на платформе
        /// </summary>
        /// <returns></returns>
        public bool On_Ground()
        {
            foreach (var p in Platforms)
            {
                // Y - координата совпадает с платформой
                if (Y_Smile_Current == p.Location.Y - Smile.Height)
                {
                    // X - не выходит за края платформы больше, чем на длину смайлика - 1
                    if (X_Smile_Current > (p.Location.X - Smile.Width * 0.5) && X_Smile_Current < (p.Location.X + p.Width - Smile.Width * 0.5))
                    {
                        IsFalling = false;
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Проверка необходимости падения
        /// </summary>
        /// <returns></returns>
        public bool ShouldFalling()
        {
            foreach (var p in Platforms)
            {
                // Y - координата совпадает с платформой
                if (Y_Smile_Current == p.Location.Y - Smile.Height)
                {
                    // X - не выходит за края платформы больше, чем на длину смайлика - 1
                    if (X_Smile_Current < (p.Location.X - Smile.Width * 0.5) && X_Smile_Current > (p.Location.X + p.Width - Smile.Width * 0.5))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Метод для тика таймера, он вносит изменения в положение смайлика
        /// </summary>
        /// <param name="myObject"></param>
        /// <param name="myEventArgs"></param>
        public void Change_situation(Object myObject, EventArgs myEventArgs)
        {
            X_Smile_Current += inc_hor;
            Y_Smile_Current += inc_vert;

            if (On_Ground())
            {
                //Упали на землю, остановили таймер up
                timer_up.Stop(); 
                vert_speed = -15;
            }
            else if (ShouldFalling())
            {
                // Если вышел за границы платформы по Х - падай
                vert_speed = 0;
                Falling();
            }

            Smile.Location = new Point(X_Smile_Current, Y_Smile_Current);
            inc_hor = 0; //откатываем инкременты в ноль
            inc_vert = 0;

            GetKey();
            HoDoor();
            HitSpikes();
        }


        /// <summary>
        /// Падение смайлика
        /// </summary>
        private void Falling()
        {
            //Если при следующем смещении не падаем ниже ближайшей платформы
            foreach (var p in Platforms)
            {
                if (X_Smile_Current > (p.Location.X - Smile.Width * 0.5) && X_Smile_Current < (p.Location.X + p.Width - Smile.Width * 0.5) && Y_Smile_Current < p.Location.Y)
                {
                    if (Y_Smile_Current + vert_speed < p.Location.Y - Smile.Height)
                    {
                        vert_speed++;
                        break;
                    }
                    else if (Y_Smile_Current + vert_speed >= p.Location.Y - Smile.Height)
                    {
                        timer_up.Stop();
                        vert_speed = p.Location.Y - Smile.Height - Y_Smile_Current;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Переносит смайлик в стартовую позицию
        /// </summary>
        public void ReSpawn()
        {
            X_Smile_Current = 0;
            Y_Smile_Current = 371;
        }

        /// <summary>
        /// Подготовка игровой логики при запуске игры
        /// </summary>
        private void InitializeLogic()
        {
            timer_main.Tick += Change_situation;
            timer_main.Interval = timer_interval;
            timer_main.Start();

            timer_left.Tick += Move_left;
            timer_left.Interval = timer_interval;

            timer_right.Tick += Move_right;
            timer_right.Interval = timer_interval;

            timer_up.Tick += Move_up;
            timer_up.Interval = timer_interval;
        }

        /// <summary>
        /// Конструктор логики
        /// </summary>
        /// <param name="form"></param>
        public Logic(ref LevelBase form)
        {
            this.Form = form;
            this.Smile = Form.pictureBox_smile;
            this.Platforms = Form.Platforms.ToArray();
            this.Spikes = Form.Spikes.ToArray();
            this.Form.pictureBox_key_ico.BackColor = Color.PaleVioletRed;
            InitializeLogic();
            player = new SoundPlayer(Properties.Resources.music);
            player.Play();
        }

        /// <summary>
        /// Взаимодействие с ключом
        /// </summary>
        public void GetKey()
        {
            if (!has_key)
            {
                if (X_Smile_Current > (Form.pictureBox_key.Location.X - Smile.Width * 0.1)
                    && X_Smile_Current < (Form.pictureBox_key.Location.X + Form.pictureBox_key.Width - Smile.Width * 0.1)
                    && (Y_Smile_Current < Form.pictureBox_key.Location.Y)
                    && (Y_Smile_Current > (Form.pictureBox_key.Location.Y - Form.pictureBox_key.Height)))
                {
                    has_key = true;
                    Form.pictureBox_key.Visible = false;
                    Form.pictureBox_key_ico.BackColor = Color.PaleGreen;
                }
            }
        }

        /// <summary>
        /// Взаимодействие с дверью
        /// </summary>
        public void HoDoor()
        {
            // Проверка положения двери и смайлика
            if (X_Smile_Current > (Form.pictureBox_door.Location.X - Smile.Width * 0.1)
                && X_Smile_Current < (Form.pictureBox_door.Location.X + Form.pictureBox_door.Width - Smile.Width * 0.1)
                && (Y_Smile_Current > Form.pictureBox_door.Location.Y)
                && (Y_Smile_Current < (Form.pictureBox_door.Location.Y + Form.pictureBox_door.Height)))
            {

                // Открытие двери
                if (has_key)
                {
                    timer_main.Stop();
                    timer_left.Stop();
                    timer_right.Stop();
                    timer_up.Stop();
                    has_key = !has_key;

                    if (DialogResult.Yes == MessageBox.Show("Вы прошли уровень!\nПродолжить?", "Caption", MessageBoxButtons.YesNo))
                    {
                        NextLevel();
                    }
                    else
                    {
                        timer_main.Start();
                        Form.pictureBox_key.Visible = true;
                        Form.pictureBox_key_ico.BackColor = Color.PaleVioletRed;
                        ReSpawn();
                    }
                }
            }
        }

        /// <summary>
        /// Переход на следующий уровень либо выход из приложения
        /// </summary>
        public void NextLevel()
        {
            if (NextForm != null)
            {
                timer_main.Stop();
                NextForm.Show();
            }
            else
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Взаимодействие с шипами
        /// </summary>
        public void HitSpikes()
        {
            foreach (var s in Spikes)
            {
                if (X_Smile_Current > (s.Location.X - Smile.Width)
                    && X_Smile_Current < (s.Location.X + s.Width)
                    && (Y_Smile_Current >= s.Location.Y - Smile.Height)
                    && (Y_Smile_Current <= (s.Location.Y + s.Height)))
                {
                    if (has_key)
                    {
                        has_key = !has_key;
                        Form.pictureBox_key.Visible = true;
                        Form.pictureBox_key_ico.BackColor = Color.PaleVioletRed;
                    }
                    ReSpawn();
                }
            }
        }
    }
}
