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
    public partial class Level1 : LevelForm
    {  
        byte score;         //переменная для подсчета очков , требуемых для прохождения уровня
        bool trap1;         //флаг для ловушки1
        bool trap2;          //флаг для ловушки2
        bool trap3;          //флаг для ловушки3
        bool trap_black_holl;   //флаг для ловушки4
        public Level1(bool sound):base(sound)           //Конструктор , принимающий в себя параметр , отвечающий за звук
        {
            InitializeComponent();
            StartGame();
        }
        protected override void StartGame()
        {
            Point point = button_start.Location;        
            point.Offset(point.X / 2, point.Y / 2);         //Определение положения курсора
            Cursor.Position = PointToScreen(point);


            button2.Height =290;                            //Стена , которая увеличивалась , приводится к стандартному размеру
            trap1 = false;                                  
            trap2 = false;                                  //Флаги для ловушек в исходное положение
            trap3 = false;

            panel_trap3.Visible = true;                     //        
            panel10.Visible = true;                 

          
            button34.Location = new Point(306, 48);                 //Стена , которая опускается , занимает свое положение
            button_black_holl.Location = new Point(401, 61);        //Ловушка возвращается на свое положение
            button_black_holl.BackColor = Color.White;              //Меняется цвет
            button_black_holl.Size = new Size(11, 15);              //Устанавливается преждний размер

            button34.Width = 10;
            
            trap_black_holl = false;                                //флаг на ловушку
          
            Cursor.Position = PointToScreen(point);                  //Курсор на позицию
            score = 0;                                               //Очки для прохождения

            panel1.Visible = true;                                   //Кристаллы 
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
            panel5.Visible = true;
            panel6.Visible = true;
            panel7.Visible = true;
            panel8.Visible = true;
            panel9.Visible = true;   
        }
        /// <summary>
        /// Переход на следующий уровень
        /// </summary>
        protected override void NextLevel()
        {
            base.NextLevel();       // музыка
                Level3 level = new Level3(this.checkSound);    //объект следующего уровня
                this.Hide();                                    //прячем это окно
                level.ShowDialog();                             //переходим на новый уровень
        }
        /// <summary>
        /// событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.TouchWall();
        }
        /// <summary>
        /// При задевании кристалла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel4_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).Visible = false;
            if (checkSound) Sound.PlayKey();
            score++;
        }
        /// <summary>
        /// Событие, для перехода на следующий уровень
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_finish_MouseEnter(object sender, EventArgs e)
        {
            if (score == 9) NextLevel();
        }
        /// <summary>
        /// Переключатель ловушек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_trap1_MouseEnter(object sender, EventArgs e)
        {
            trap2 = false;
            trap1 = true;
        }
        /// <summary>
        /// Метод , увеличивающий стену
        /// </summary>
        private void GrowWallDown()
        {
            if (button2.Height < 333)
            {
                Button bt2 = button2;
                bt2.Height = button2.Height + 1;
                button2 = bt2;
                if (bt2.Location.Y < 91) bt2.Location = new Point(bt2.Location.X, bt2.Location.Y + 1);
            }
            if (button2.Location.Y < 91) button2.Location = new Point(button2.Location.X, button2.Location.Y + 1);
        }
        /// <summary>
        /// Рост стены вверх
        /// </summary>
        private void GrowWallUp()
        {
            
            if (button2.Location.Y <= 91& button2.Location.Y>61) button2.Location = new Point(button2.Location.X, button2.Location.Y - 1);
        }
        /// <summary>
        /// Расширение стены
        /// </summary>
        private void WallWide()
        {
            
            if (button34.Size.Width < 59) button34.Width = button34.Width + 1;
        }
        /// <summary>
        /// Таймер , управляющий ростом ловушек, если они активированы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if(trap1)GrowWallDown();
            if (trap2) GrowWallUp();
            if (trap3) WallWide();
            if (trap_black_holl) GrowBlackHall();
        }
        /// <summary>
        /// другой переключатель ловушек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_trap2_MouseEnter(object sender, EventArgs e)
        {
            trap2 = true;
            trap1 = false;
        }
        /// <summary>
        /// Срабатывание ловушки №3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_trap3_MouseEnter(object sender, EventArgs e)
        {
            trap3 = true;
            panel_trap3.Visible = false;
           
        }
        /// <summary>
        /// Отключение ловушки №3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_trap3_MouseLeave(object sender, EventArgs e)
        {
            panel_trap3.Visible = false;
        }
        /// <summary>
        /// Срабатывание ловушки блэкхолл
        /// </summary>
        private void GrowBlackHall()
        {
            button_black_holl.BackColor = Color.Black;
            if (button_black_holl.Location.X > 355)
            {
                button_black_holl.Width++;
                button_black_holl.Location = new Point(button_black_holl.Location.X - 1, button_black_holl.Location.Y);
               
            }
            if (button_black_holl.Location.Y < 130)
            {
                button_black_holl.Location = new Point(button_black_holl.Location.X, button_black_holl.Location.Y+1);
            }
        }
        /// <summary>
        /// Событие , активирующее блэкхолл
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel10_MouseEnter(object sender, EventArgs e)
        {
            trap_black_holl = true;
            panel10.Visible = false;
        }
        /// <summary>
        /// Событие , переключающее цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_illusion_MouseMove(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Black;
        }
        /// <summary>
        /// Событие , переключающее цвет обратно
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel_illusion_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        /// <summary>
        /// Событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button73_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button29_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button36_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
        /// <summary>
        /// Событие , при задевании блэкхолла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_black_holl_MouseEnter(object sender, EventArgs e)
        {
            if(button_black_holl.BackColor!=Color.White)base.TouchWall();
        }
        /// <summary>
        /// Событие , при задевании стены
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button33_MouseEnter(object sender, EventArgs e)
        {
            base.TouchWall();
        }
    }
}
