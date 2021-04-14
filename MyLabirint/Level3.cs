using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLabirint
{
    /// <summary>
    /// Перечесления для перемещения по рандомным  точкам 
    /// </summary>
    enum Position 
    {
    position1 ,
    position2,
    position3,
    position4,
    position5,
    position6
    }
    public partial class Level3 : LevelForm
    {
    public Level3(bool sound):base(sound)       //Конструктор , принимающий состояние звука
    {
        InitializeComponent();
            StartGame();
    }
        bool MoveFairPoint1 = true;                     //Переключатели позиций
        bool MoveFairPoint2 = true;
        bool MoveFairPoint3 = true;
        bool FlagKey;                                   //
        bool Key;                                       //Ключ для прохождения
        byte count;                                     //Счетчик
        Position position;                      
        bool CanChangePositionFlag = true;              //Переключатель для смены рандомных позиций 
        byte side;                                           
        /// <summary>
        /// Метод , для начала уровня
        /// </summary>
        protected override void StartGame()
        {
            Point point = button_start.Location;
            point.Offset(point.X / 10, point.Y / 10);   //Задаем позицию курсора
            Cursor.Position = PointToScreen(point);
            Key = false;                                //Ключ не доступен
            button_key.Visible = true ;                 //Ключ видимый
            place1.Visible = false;                 
            place2.Visible = false;                    
            place3.Visible = false;        
            place4.Visible = false;           
            place5.Visible = false;             
            place6.Visible = false;               
            place7.Visible = false;
            place8.Visible = false;
            position1.Visible = false;
            position2.Visible = false;
            position3.Visible = false;
            position4.Visible = false;
            position5.Visible = false;
            position6.Visible = false;
            count = 0;                          //счетчик обнулен
        }
        /// <summary>
        /// Переход на новый уровень
        /// </summary>
        protected override void NextLevel()
        {
            base.NextLevel();
                level2 level = new level2(this.checkSound);
                this.Hide();
                level.ShowDialog();   
        }
        /// <summary>
        /// Метод , отвечающий за передвижение ключа
        /// </summary>
        private void MoveKey()
        {
            if (button_key.Location.X == 133) FlagKey = false;
            if (button_key.Location.X == 31) FlagKey = true;
                if (button_key.Location.X < 133 & FlagKey == true) button_key.Location = new Point(button_key.Location.X + 1, button_key.Location.Y);
            if (button_key.Location.X > 31 & FlagKey == false) button_key.Location = new Point(button_key.Location.X - 1, button_key.Location.Y);
        }
        /// <summary>
        /// Метод отвчающий за движение блока по определенному маршурту
        /// </summary>
        private void MoveFair()
        {
            if (button_fair.Location.Y == place8.Location.Y & button_fair.Location.X != place1.Location.X & MoveFairPoint1 == true)
                button_fair.Location = new Point(button_fair.Location.X + 1, button_fair.Location.Y);

            if (button_fair.Location.X == place1.Location.X & button_fair.Location.Y != place2.Location.Y & MoveFairPoint2 == true)
            {
                MoveFairPoint1 = false;
                MoveFairPoint3 = false;
                button_fair.Location = new Point(button_fair.Location.X, button_fair.Location.Y - 1);
            }

            if (button_fair.Location.Y == place3.Location.Y & button_fair.Location.X != place3.Location.X)
                button_fair.Location = new Point(button_fair.Location.X + 1, button_fair.Location.Y);

            if (button_fair.Location.X == place4.Location.X & button_fair.Location.Y != place4.Location.Y & MoveFairPoint1 == false)
            {
                button_fair.Location = new Point(button_fair.Location.X, button_fair.Location.Y + 1);
                MoveFairPoint2 = false;
            }

            if (button_fair.Location.Y == place5.Location.Y & button_fair.Location.X != place5.Location.X & MoveFairPoint2 == false)
            {
                MoveFairPoint1 = true;
                button_fair.Location = new Point(button_fair.Location.X - 1, button_fair.Location.Y);
            }

            if (button_fair.Location.X == place6.Location.X & button_fair.Location.Y != place6.Location.Y & MoveFairPoint3 == false)
            {
                MoveFairPoint2 = true;
                button_fair.Location = new Point(button_fair.Location.X, button_fair.Location.Y + 1);
            }
            if (button_fair.Location.Y == place7.Location.Y & button_fair.Location.X != place7.Location.X)
            {
                MoveFairPoint2 = true;
                MoveFairPoint3 = true;
                button_fair.Location = new Point(button_fair.Location.X - 1, button_fair.Location.Y);
            }

            if (button_fair.Location.X == place8.Location.X & button_fair.Location.Y != place8.Location.Y)
            {

                button_fair.Location = new Point(button_fair.Location.X, button_fair.Location.Y - 1);
            }
        }
        /// <summary>
        /// Метод , отвечающий за перемещение в рандомную позицию
        /// </summary>
        /// <param name="position"></param>
        /// <param name="side"></param>
        private void Jump(ref Position position ,ref byte side)
        {
            if (CanChangePositionFlag) 
            { 
                Random rnd = new Random();
            byte NumPosition = (byte)rnd.Next(0, 6);
            side = (byte)rnd.Next(0, 2);


                switch (NumPosition)
                {
                    case 0:
                        Jumper.Location = position1.Location;
                        CanChangePositionFlag = false;
                        position = Position.position1;
                        break;
                    case 1:
                        Jumper.Location = position2.Location;
                        CanChangePositionFlag = false;
                        position = Position.position2;
                        break;
                    case 2:
                        Jumper.Location = position3.Location;
                        CanChangePositionFlag = false;
                        position = Position.position3;
                        break;
                    case 3:
                        CanChangePositionFlag = false;
                        Jumper.Location = position4.Location;
                        position = Position.position4;
                        break;
                    case 4:
                        CanChangePositionFlag = false;
                        position = Position.position5;
                        Jumper.Location = position5.Location;
                        break;
                    case 5:
                        CanChangePositionFlag = false;
                        position = Position.position6;
                        Jumper.Location = position6.Location;
                        break;
                }
            }
        }
        /// <summary>
        /// Метод , отвечающий за двжение из рандомной позиции
        /// </summary>
        private void MoveJumper()
        {
            Jump(ref position, ref side);
        
            if (position == Position.position1 & side % 2 == 0)
            {
                if (Jumper.Location.X < position2.Location.X)
                    JumperGoRight();              
                else CanChangePositionFlag = true;
            }
            if (position == Position.position1 & side % 2 != 0)
            {
                if (Jumper.Location.Y < position6.Location.Y)
                    JumperGoDown();
                else CanChangePositionFlag = true;
            }
            //
            if (position == Position.position2 & side % 2 == 0)
            {
                if (Jumper.Location.Y > position3.Location.Y)
                    JumperGoUp();
                else CanChangePositionFlag = true;
            }
            if (position == Position.position2 & side % 2 != 0)
            {
                if (Jumper.Location.X > position1.Location.X)
                    JumperGoLeft();
                else CanChangePositionFlag = true;
            }
            //
            if (position == Position.position3 & side % 2 == 0)
            {
                if (Jumper.Location.Y < position2.Location.Y)
                    JumperGoDown();
                else CanChangePositionFlag = true;
            }
            if (position == Position.position3 & side % 2 != 0)
            {
                if (Jumper.Location.X < position4.Location.X)
                    JumperGoRight();
                else CanChangePositionFlag = true;
            }
            //
            if (position == Position.position4 & side % 2 == 0)
            {
                if (Jumper.Location.Y < position5.Location.Y)
                    JumperGoDown();
                else CanChangePositionFlag = true;
            }
            if (position == Position.position4 & side % 2 != 0)
            {
                if (Jumper.Location.X > position3.Location.X)
                    JumperGoLeft();
                else CanChangePositionFlag = true;
            }
            //
            if (position == Position.position5 & side % 2 == 0)
            {
                if (Jumper.Location.Y > position4.Location.Y)
                    JumperGoUp();
                else CanChangePositionFlag = true;
            }
            if (position == Position.position5 & side % 2 != 0)
            {
                if (Jumper.Location.X > position6.Location.X)
                    JumperGoLeft();
                else CanChangePositionFlag = true;
            }
            //
            if (position == Position.position6 & side % 2 == 0)
            {
                if (Jumper.Location.Y > position1.Location.Y)
                    JumperGoUp();
                else CanChangePositionFlag = true;
            }
            if (position == Position.position6 & side % 2 != 0)
            {
                if (Jumper.Location.X < position5.Location.X)
                    JumperGoRight();
                else CanChangePositionFlag = true;
            }

        }
        /// <summary>
        /// Движение вверх
        /// </summary>
        private void JumperGoUp()
        {
            Jumper.Location = new Point(Jumper.Location.X, Jumper.Location.Y - 1);
        }
        /// <summary>
        /// Движение вниз
        /// </summary>
        private void JumperGoDown()
        {
            Jumper.Location = new Point(Jumper.Location.X, Jumper.Location.Y + 1);
        }
        /// <summary>
        /// Движение влево
        /// </summary>
        private void JumperGoLeft()
        {
            Jumper.Location = new Point(Jumper.Location.X-1, Jumper.Location.Y);
        }
        /// <summary>
        /// Движение вправо
        /// </summary>
        private void JumperGoRight()
        {
            Jumper.Location = new Point(Jumper.Location.X + 1, Jumper.Location.Y);
        }
        /// <summary>
        /// Таймер , отвечающий за передвижения кубов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (Key == true & button21.Size.Height > 342) button21.Height--;
            if (Key == true & button18.Location.X > 37)
            {
                button18.Location = new Point(button18.Location.X - 1,button18.Location.Y);
                button18.Width++;
            }
            MoveKey();
            MoveJumper();
            MoveFair();
        }
        /// <summary>
        /// Таймер , отвечающий за смену цвета ключа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_color_Tick(object sender, EventArgs e)
        { 
            count++;
            button_key.BackColor=count % 2==0 ? Color.Black : Color.Yellow;
        }
        /// <summary>
        /// Событие для поимки ключа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_key_MouseEnter(object sender, EventArgs e)
        {
            if (button_key.BackColor == Color.Yellow)
            {
                if (checkSound) Sound.PlayKey();
                Key = true;
                button_key.Visible = false;
            }
            else base.TouchWall();
        }
        /// <summary>
        /// Событие , меняющее  цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Black;
            button_wall1.BackColor = Color.White;
            button_wall2.BackColor = Color.White;
            button_wall3.BackColor = Color.White;
            button_wall4.BackColor = Color.White;
            button14.BackColor = Color.White;
            button18.BackColor = Color.White;
            button17.BackColor = Color.White;
            button1.BackColor = Color.White;
            button10.BackColor = Color.White;
            button11.BackColor = Color.White;
            button6.BackColor = Color.White;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
            button3.BackColor = Color.White;
            button5.BackColor = Color.White;
            button8.BackColor = Color.White;
            button7.BackColor = Color.White;
            button9.BackColor = Color.White;
            button13.BackColor = Color.White;
            button12.BackColor = Color.White;
            button23.BackColor = Color.White;
            button20.BackColor = Color.White;
            button0.BackColor = Color.White;
            button19.BackColor = Color.White;
            button21.BackColor = Color.White;
            button22.BackColor = Color.White;
            button26.BackColor = Color.White;
            button27.BackColor = Color.White;
            position1.BackColor= Color.Black;
            position2.BackColor = Color.Black;
            position3.BackColor = Color.Black;
            position4.BackColor = Color.Black;
            position5.BackColor = Color.Black;
            position6.BackColor = Color.Black;
            place1.BackColor = Color.Black;
            place2.BackColor = Color.Black;
            place3.BackColor = Color.Black;
            place4.BackColor = Color.Black;
            place5.BackColor = Color.Black;
            place6.BackColor = Color.Black;
            place7.BackColor = Color.Black;
            place8.BackColor = Color.Black;
        }
        /// <summary>
        /// Событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_wall4_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Событие , отменяющее смену цвета
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            button_wall1.BackColor = Color.Black;
            button_wall2.BackColor = Color.Black;
            button_wall3.BackColor = Color.Black;
            button_wall4.BackColor = Color.Black;
            button14.BackColor = Color.Black;
            button18.BackColor = Color.Black;
            button17.BackColor = Color.Black;
            button1.BackColor = Color.Black;
            button10.BackColor = Color.Black;
            button11.BackColor = Color.Black;
            button6.BackColor = Color.Black;
            button2.BackColor = Color.Black;
            button4.BackColor = Color.Black;
            button3.BackColor = Color.Black;
            button5.BackColor = Color.Black;
            button8.BackColor = Color.Black;
            button7.BackColor = Color.Black;
            button9.BackColor = Color.Black;
            button13.BackColor = Color.Black;
            button12.BackColor = Color.Black;
            button23.BackColor = Color.Black;
            button20.BackColor = Color.Black;
            button0.BackColor = Color.Black;
            button19.BackColor = Color.Black;
            button21.BackColor = Color.Black;
            button22.BackColor = Color.Black;
            button26.BackColor = Color.Black;
            button27.BackColor = Color.Black;
            position1.BackColor = Color.White;
            position2.BackColor = Color.White;
            position3.BackColor = Color.White;
            position4.BackColor = Color.White;
            position5.BackColor = Color.White;
            position6.BackColor = Color.White;
            place1.BackColor = Color.White;
            place2.BackColor = Color.White;
            place3.BackColor = Color.White;
            place4.BackColor = Color.White;
            place5.BackColor = Color.White;
            place6.BackColor = Color.White;
            place7.BackColor = Color.White;
            place8.BackColor = Color.White;
        }
        /// <summary>
        /// Событие , при задевании блока
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_fair_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Событие , при достижении финиша
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_finish_MouseEnter(object sender, EventArgs e)
        {
            if (Key) NextLevel();
           
        }
    }
} 
