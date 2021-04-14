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
    /// Форма меню
    /// </summary>
    public partial class MenuForm : Form
    {
        ChoseLevel chose;               //Форма для выбора уровня 
        Panel cursor;                   //Панель для анимации
       public bool checkSound;          //Переключатель звука
        public MenuForm()
        {
            InitializeComponent();
            cursor = _point1;                   //Панель с изображением курсора определяется в позиции 1
            cursor.Visible = true;              //Делаем ее видимую
            checkSound = false;                 //По умолчанию звук будет выключен
       }
        /// <summary>
        /// Этот конструктор используется для сохранения состояния переменной звука , при переходе из формы выбора уровней
        /// </summary>
        /// <param name="checkSound"></param>
    public MenuForm(bool checkSound)
    {
        this.checkSound = checkSound;       
    }
        /// <summary>
        /// Событие для начала игры с первого уровня
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartGame_Click(object sender, EventArgs e)
        {
            Level1 l2 = new Level1(this.checkSound);
            l2.ShowDialog();                    
        }
        /// <summary>
        /// Событие для  закрытия программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Событие для выбора уровня 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_level_Click(object sender, EventArgs e)
        {
            chose = new ChoseLevel(this.checkSound);
            this.Hide();
            chose.ShowDialog();
        }
        /// <summary>
        /// Метод изменения локации курсора вверх , используется для анимации
        /// </summary>
        private void cursorGoUp()
        {
            cursor.Location = new Point(cursor.Location.X, cursor.Location.Y - 1);
        }
        /// Метод изменения локации курсора вниз , используется для анимации
        private void cursorGoDown()
        {
            cursor.Location = new Point(cursor.Location.X, cursor.Location.Y + 1);
        }
        /// Метод изменения локации курсора налево , используется для анимации
        private void cursorGoLeft()
        {
            cursor.Location = new Point(cursor.Location.X - 1, cursor.Location.Y);
        }
        /// Метод изменения локации курсора направо , используется для анимации
        private void cursorGoRight()
        {
            cursor.Location = new Point(cursor.Location.X + 1, cursor.Location.Y);
        }
        /// <summary>
        /// Метод для перемщения курсора
        /// </summary>
        private void CursorMove()
        {
            if (cursor.Visible == false)
            {
                cursor.Location = new Point(164,93);
                cursor.Visible = true;
            }
            if (cursor.Location.X < _point2.Location.X &cursor.Location.Y == _point1.Location.Y) cursorGoRight();
            if (cursor.Location.X == _point2.Location.X & cursor.Location.Y == _point1.Location.Y) cursorGoDown();
            if (cursor.Location.X < _point4.Location.X& cursor.Location.Y == _point3.Location.Y) cursorGoRight();
           if (cursor.Location.X == _point4.Location.X& cursor.Location.Y > _point5.Location.Y) cursorGoUp();
            if (cursor.Location.X == _point5.Location.X & cursor.Location.Y == _point5.Location.Y) cursor.Visible = false;
           
        }
        /// <summary>
        /// Таймер для метода
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void animation_timer_cursor_Tick(object sender, EventArgs e)
        {
            CursorMove();
        }
        /// <summary>
        /// Атрибут для использования звука
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SoundBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SoundBox.Checked)       
            {
                SoundBox.Text = "Звук есть";
                Sound.PlayCheck();   
                checkSound = true;
            }
            if (!SoundBox.Checked)
            {
                SoundBox.Text = "Звука нет";
                checkSound = false;
            }
        }
    }
}
