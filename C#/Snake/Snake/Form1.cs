using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        private int rI, rJ;
        private PictureBox fruit;
        private PictureBox[] snake = new PictureBox[400];
        private Label LabelScore;
        private int dirX, dirY;
        private int _width = 900;
        private int _height = 800;
        private int _sizeOfSides = 40;
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
            this.Text = "SNAKE";
            this._width = _width;
            this._height = _height;
            dirX = 1;
            dirY = 0;
            LabelScore = new Label();
            LabelScore.Text = "Score: 0";
            LabelScore.Location = new Point(810, 10);
            this.Controls.Add(LabelScore);
            snake[0] = new PictureBox();
            snake[0].Location = new Point(201, 201);
            snake[0].Size = new Size(_sizeOfSides - 1, _sizeOfSides - 1);
            snake[0].BackColor = Color.Red;
            this.Controls.Add(snake[0]);
            fruit = new PictureBox();
            fruit.BackColor = Color.Yellow;
            fruit.Size = new Size(_sizeOfSides, _sizeOfSides);
            _generateMap();
            _generateFruit();
            timer.Tick += new EventHandler(_update);
            timer.Interval = 200;
            timer.Start();
            this.KeyDown += new KeyEventHandler(OKP);
        }
        private void _generateFruit()
        {
            Random r = new Random();
            rI = r.Next(0, _height - _sizeOfSides);
            int tempI = rI % _sizeOfSides;
            rI -= tempI;
            rJ = r.Next(0, _height - _sizeOfSides);
            int tempJ = rJ % _sizeOfSides;
            rJ -= tempJ;
            rI++;
            rJ++;
            fruit.Location = new Point(rI, rJ);
            this.Controls.Add(fruit);
        }
        private void _CheckBorders()
        {

            if (snake[0].Location.X < 0)
            {
                snake[0].Location = new Point(snake[0].Location.X + dirX * (_sizeOfSides)+800, snake[0].Location.Y);
            }
            if (snake[0].Location.X > 800)
            {
                snake[0].Location = new Point(snake[0].Location.X + dirX * (_sizeOfSides) - 800, snake[0].Location.Y);
            }
            if (snake[0].Location.Y < 0)
            {
                snake[0].Location = new Point(snake[0].Location.X, snake[0].Location.Y + dirY * (_sizeOfSides) + 800);
            }
            if (snake[0].Location.Y > 800)
            {
                snake[0].Location = new Point(snake[0].Location.X, snake[0].Location.Y + dirY * (_sizeOfSides) - 800);
            }


        }
        private void _eatItself()
        {
            for (int i = 1; i < score; i++)
            {
                if (snake[0].Location ==snake[i].Location)
                {
                    for (int j = i; j <= score; j++)
                        this.Controls.Remove(snake[j]);
                    score = score - (score - i + 1);
                    LabelScore.Text = "Score: " + score;
                }
            }
        }
        private void _eatFruit()
        {
            if(snake[0].Location.X == rI && snake[0].Location.Y == rJ)
            {
                LabelScore.Text = "Score: " + ++score;
                snake[score] = new PictureBox();
                snake[score].Location = new Point(snake[score - 1].Location.X + 40 * dirX, snake[score - 1].Location.Y - 40 * dirY);
                snake[score].Size = new Size(_sizeOfSides - 1, _sizeOfSides - 1);
                snake[score].BackColor = Color.Red;
                this.Controls.Add(snake[score]);
                _generateFruit();
            }
        }
        private void _generateMap()
        {
            for (int i = 0; i < _width/_sizeOfSides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(0, _sizeOfSides * i);
                pic.Size = new Size(_width - 100, 1);
                this.Controls.Add(pic);
            }
            for (int i = 0; i <= _height/_sizeOfSides; i++)
            {
                PictureBox pic = new PictureBox();
                pic.BackColor = Color.Black;
                pic.Location = new Point(_sizeOfSides * i, 0);
                pic.Size = new Size(1, _width);
                this.Controls.Add(pic);
            }
        }
        private void _moveSnake()
        {
            for (int i = score; i >=1; i--)
            {
                snake[i].Location = snake[i - 1].Location; 
            }
            snake[0].Location = new Point(snake[0].Location.X + dirX * (_sizeOfSides), snake[0].Location.Y + dirY * (_sizeOfSides));
            _eatItself();
        }
        private void _update(object myObject,EventArgs eventArgs)
        {
            _eatFruit();
            _moveSnake();
            _CheckBorders();
        }
        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    dirX = 1;
                    dirY = 0;
                    break;
                case "Left":
                    dirX = -1;
                    dirY = 0;
                    break;
                case "Up":
                    dirY = -1;
                    dirX = 0;
                    break;
                case "Down":
                    dirY = 1;
                    dirX = 0;
                    break;

            }
        }
    }
}
