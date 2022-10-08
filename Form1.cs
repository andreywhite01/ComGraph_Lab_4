using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Input;

namespace ComGraph_Lab_4
{
    public partial class Form1 : Form
    {
        float xc = 0;
        float yc = 0;
        float xScale = 50;
        float yScale = 50;

        MyFigure fig;
        Thread thMoving;
        bool isMoving = false;


        public Form1()
        {
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            InitializeComponent();
            KeyPreview = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fig = new MyFigure(xc, yc, xScale, yScale);
        }

        private void drawAxis(Graphics g)
        {
            Pen greenPen    = new Pen(Color.Green);
            Pen bluePen     = new Pen(Color.Blue);

            g.DrawLine(greenPen, new PointF(-pictureBox1.Width / 2.0f, 0.0f), new PointF(pictureBox1.Width / 2.0f, 0.0f));
            g.DrawLine(bluePen, new PointF(0.0f, -pictureBox1.Height / 2.0f), new PointF(0.0f, pictureBox1.Height / 2.0f));
        }

        // отображение изображения на pictureBox
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);

            drawAxis(g);
            g.DrawLines(new Pen(Color.Red), fig.getPoints());

            float[] centerCoordinates = fig.getCenterCoordinates();
            tbX.Text = String.Format("{0}", centerCoordinates[0]);
            tbY.Text = String.Format("{0}", -centerCoordinates[1]);
        }

        #region нажатие и отпускние ЛКМ на кнопки передвижения и повотора
        private void upMoving()
        {
            if (InvokeRequired)
            {
                do
                {
                    fig.upMove();
                    pictureBox1.Image = null;
                    Thread.Sleep(60);
                } while (isMoving);
            }
        }
        private void downMoving()
        {
            if (InvokeRequired)
            {
                do
                {
                    fig.downMove();
                    pictureBox1.Image = null;
                    Thread.Sleep(60);
                } while (isMoving);
            }
        }
        private void leftMoving()
        {
            if (InvokeRequired)
            {
                do
                {
                    fig.leftMove();
                    pictureBox1.Image = null;
                    Thread.Sleep(60);
                } while (isMoving);
            }
        }
        private void rightMoving()
        {
            if (InvokeRequired)
            {
                do
                {
                    fig.rightMove();
                    pictureBox1.Image = null;
                    Thread.Sleep(60);
                } while (isMoving);
            }
        }
        private void rotateMoving()
        {
            if (InvokeRequired)
            {
                do
                {
                    fig.rotateMove();
                    pictureBox1.Image = null;
                    Thread.Sleep(120);
                } while (isMoving);
            }
        }

        private void btnUp_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            thMoving = new Thread(upMoving);
            thMoving.Start();

        }
        private void btnUp_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void btnDown_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            thMoving = new Thread(downMoving);
            thMoving.Start();

        }
        private void btnDown_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void btnLeft_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            thMoving = new Thread(leftMoving);
            thMoving.Start();

        }
        private void btnLeft_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void btnRight_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            thMoving = new Thread(rightMoving);
            thMoving.Start();

        }
        private void btnRight_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }

        private void btnRotate_MouseDown(object sender, MouseEventArgs e)
        {
            isMoving = true;
            thMoving = new Thread(rotateMoving);
            thMoving.Start();

        }
        private void btnRotate_MouseUp(object sender, MouseEventArgs e)
        {
            isMoving = false;
        }
        #endregion

        #region трансформирование фигуры
        // обновление координат центра фигуры через textBox
        private void tbX_Changed(object sender, EventArgs e)
        {
            float x;
            if (float.TryParse(((TextBox)sender).Text, out x))
            {
                fig.toPoint(x, fig.yc);
            }
        }
        private void tbY_Changed(object sender, EventArgs e)
        {
            float y;
            if (float.TryParse(((TextBox)sender).Text, out y))
            {
                fig.toPoint(fig.xc, -y);
            }
        }

        // установление центра фигуры в начало координат
        private void btnCenter_Click(object sender, EventArgs e)
        {
            fig.toCenter();
            pictureBox1.Image = null;
        }

        // сброс настроек к настройкам по умолчанию
        private void btnToDefault_Click(object sender, EventArgs e)
        {
            fig.toDefault();
            pictureBox1.Image = null;
        }

        public void reflectX_Click(object sender, EventArgs e)
        {
            fig.reflectX();
            pictureBox1.Image = null;
        }
        public void reflectY_Click(object sender, EventArgs e)
        {
            fig.reflectY();
            pictureBox1.Image = null;
        }
        public void reflect45_Click(object sender, EventArgs e)
        {
            fig.reflect45();
            pictureBox1.Image = null;
        }
        public void refl_45_Click(object sender, EventArgs e)
        {
            fig.reflect_45();
            pictureBox1.Image = null;
        }
        #endregion

        #region изменение параметров повотора - координаты точки повотора и угла
        // установление абсциссы центра точки вращения
        private void tbXToRotate_TextChanged(object sender, EventArgs e)
        {
            float tmp;
            if (float.TryParse(((TextBox)sender).Text, out tmp))
            {
                fig.roateAroundX = tmp;
                pictureBox1.Image = null;
            }
        }

        // обновление ординаты центра точки вращения
        private void tbYToRotate_TextChanged(object sender, EventArgs e)
        {
            float tmp;
            if (float.TryParse(((TextBox)sender).Text, out tmp))
            {
                fig.roateAroundY = -tmp;
                pictureBox1.Image = null;
            }
        }

        // обновление угла поворота
        private void tbAngle_TextChanged(object sender, EventArgs e)
        {
            float tmp;
            if (float.TryParse(((TextBox)sender).Text, out tmp))
            {
                fig.angle = tmp;
                pictureBox1.Image = null;
            }
        }
        #endregion

        // обработчик горячих клавиш
        protected override bool ProcessCmdKey(ref Message message, Keys keyData)
        {
            {
                if (keyData == (Keys.Control | Keys.Left))
                    fig.scaleX(0.99f);
                if (keyData == (Keys.Control | Keys.Right))
                    fig.scaleX(1.01f);
                if (keyData == (Keys.Control | Keys.Down))
                    fig.scaleY(0.99f);
                if (keyData == (Keys.Control | Keys.Up))
                    fig.scaleY(1.01f);
                if (keyData == (Keys.Control | Keys.Oemplus))
                {
                    fig.scaleX(1.01f);
                    fig.scaleY(1.01f);
                }
                if (keyData == (Keys.Control | Keys.OemMinus))
                {
                    fig.scaleX(0.99f);
                    fig.scaleY(0.99f);
                }
                pictureBox1.Image = null;
            }
            {
                if (keyData == Keys.Left)
                    fig.leftMove();
                if (keyData == Keys.Right)
                    fig.rightMove();
                if (keyData == Keys.Down)
                    fig.downMove();
                if (keyData == Keys.Up)
                    fig.upMove();
                pictureBox1.Image = null;
            }
            return base.ProcessCmdKey(ref message, keyData);
        }
    }
















    public class MyFigure
    {
        public MyFigure(float cx, float yc, float xScale, float yScale)
        {
            defaultPointsF = new float[NUMBER_OF_POINTS, 3];
            pointsF = new float[NUMBER_OF_POINTS, 3];
            points = new PointF[NUMBER_OF_POINTS];
            setStartPicturePoints();
        }

        private void setStartPicturePoints()
        {
            // угол между противолежащими вершинами фигуры
            float angleToRotate = 3.0f * 360.0f / 7.0f;
            // координаты первой точки
            float[] v = { xc, yc - yScale, 1 };
            // запишем эту точки в 3 массива

            // * по умолчанию - для возможности восстановить исходную картинку
            set(defaultPointsF, v, 0);
            // * pointF - в текущее положение картинка, для удобных операций над точками
            set(pointsF, v, 0);
            // * points - массив типа PointF - для рисования
            set(points, v, 0);

            // запишем в массивы остальные точки фигуры
            for (int i = 1; i < NUMBER_OF_POINTS; ++i)
            {
                v = rotate(v, angleToRotate, xc, yc);
                set(defaultPointsF, v, i);
                set(pointsF, v, i);
                set(points, v, i);
            }

        }

        public float[] getCenterCoordinates()
        {
            coordinates = new float[2] { xc, yc };
            return coordinates;
        }

        // возврат точек фигуры
        public PointF[] getPoints()
        {
            return points;
        }

        #region функции копирования
        // запись одномерного массива float в i-ую строку двумерного массива float
        private void set(float[,] m, float[] vec, int index)
        {
            for (int i = 0; i < vec.Length; i++)
            {
                m[index, i] = vec[i];
            }
        }
        // запись одномерного одной точки, записанной в массив float, в i-ую позицию массива PointF 
        private void set(PointF[] points, float[] pointF, int index)
        {
            points[index] = new PointF(pointF[0], pointF[1]);
        }
        // запись двумерного массива точек float в одномерный массив PointF
        private void set(PointF[] points, float[,] pointF)
        {
            for (int i = 0; i < points.Length; ++i)
            {
                points[i] = new PointF(pointF[i, 0], pointF[i, 1]);
            }
        }
        #endregion

        #region отражение
        public void reflectX()
        {
            float[,] reflMatrix = {
                { 1, 0, 0  },
                { 0, -1, 0 },
                { 0, 0, 1 } };

            makeMove(reflMatrix);
        }
        public void reflectY()
        {
            float[,] reflMatrix = {
                { -1, 0, 0  },
                { 0, 1, 0 },
                { 0, 0, 1 } };

            makeMove(reflMatrix);
        }
        public void reflect45()
        {
            float[,] reflMatrix = {
                { 0, -1, 0  },
                { -1, 0, 0 },
                { 0, 0, 1 } };

            makeMove(reflMatrix);
        }
        public void reflect_45()
        {
            float[,] reflMatrix = {
                { 0, 1, 0  },
                { 1, 0, 0 },
                { 0, 0, 1 } };

            makeMove(reflMatrix);
        }
        #endregion

        #region масштабирование
        public void scaleX(float k)
        {
            float[,] moveMatrix = {
                { k, 0, 0  },
                { 0, 1, 0 },
                { 0, 0, 1 } };

            makeMove(moveMatrix);
        }
        public void scaleY(float k)
        {
            float[,] moveMatrix = {
                { 1, 0, 0  },
                { 0, k, 0 },
                { 0, 0, 1 } };
            makeMove(moveMatrix);
        }
        #endregion

        #region перемещение
        public void upMove()
        {
            float[,] moveMatrix = {
                { 1, 0, 0  },
                { 0, 1, 0 },
                { 0, -moveStep, 1 } };
            makeMove(moveMatrix);
        }
        public void downMove()
        {
            float[,] moveMatrix = {
                { 1, 0, 0  },
                { 0, 1, 0 },
                { 0, moveStep, 1 } };
            makeMove(moveMatrix);
        }
        public void leftMove()
        {
            float[,] moveMatrix = {
                { 1, 0, 0  },
                { 0, 1, 0 },
                { -moveStep, 0, 1 } };
            makeMove(moveMatrix);
        }
        public void rightMove()
        {
            float[,] moveMatrix = {
                { 1, 0, 0  },
                { 0, 1, 0 },
                { moveStep, 0, 1 } };
            makeMove(moveMatrix);
        }
        #endregion

        #region вращение
        public void rotateMove()
        {
            float[,] rotateMatrix = {
                { (float)Math.Cos(angle), (float)Math.Sin(angle), 0  },
                { -(float)Math.Sin(angle), (float)Math.Cos(angle), 0 },
                { 0, 0, 1 } };
            float[,] moveToCenterMatrix = new float[3, 3]
            {
                { 1,0,0},
                { 0,1,0},
                { -roateAroundX,-roateAroundY,1}
            };
            float[,] moveBackMatrix = new float[3, 3]
            {
                { 1,0,0},
                { 0,1,0},
                { roateAroundX, roateAroundY,1}
            };

            makeMove(moveToCenterMatrix);
            makeMove(rotateMatrix);
            makeMove(moveBackMatrix);
        }
        #endregion

        #region трансформация фигуры
        public void toDefault()
        {
            xc = 0.0f;
            yc = 0.0f;
            xScale = 50.0f;
            yScale = 50.0f;

            pointsF = (float[,])defaultPointsF.Clone();
            set(points, pointsF);
        }
        public void toCenter()
        {
            float[,] moveMatrix = {
                { 1, 0, 0  },
                { 0, 1, 0 },
                { -xc, -yc, 1 } };
            makeMove(moveMatrix);
        }
        public void toPoint(float x, float y)
        {
            float[,] moveMatrix = {
                { 1, 0, 0  },
                { 0, 1, 0 },
                { -xc + x, -yc + y, 1 } };
            makeMove(moveMatrix);
        }
        // изменение координат умножением на матрицу преобразования
        private void makeMove(float[,] moveMatrix)
        {
            float[] centerAfterTransform = getPointAfterTransform(moveMatrix);
            refreshCenter(centerAfterTransform);
            refreshPoints(moveMatrix);
        }
        #endregion

        #region скалярное умножение
        // скалярное умножение матриц
        private float[,] dot(float[,] m1, float[,] m2)
        {
            float[,] newMatrix = new float[m1.GetLength(0), m2.GetLength(1)];
            for (int row = 0; row < m1.GetLength(0); row++)
            {
                for (int col = 0; col < m2.GetLength(1); col++)
                {
                    newMatrix[row, col] = 0;
                    for (int i = 0; i < m1.GetLength(1); i++)
                    {
                        newMatrix[row, col] += m1[row, i] * m2[i, col];
                    }
                }
            }
            return newMatrix;
        }
        // скалярное умножение матрицы вектор на матрицу
        private float[] dot(float[] vec, float[,] matr)
        {
            float[] newVec = new float[vec.Length];
            for (int i = 0; i < vec.Length; i++)
            {
                newVec[i] = 0;
                for (int j = 0; j < vec.Length; j++)
                {
                    newVec[i] += vec[j] * matr[j, i];
                }
            }
            return newVec;
        }
        #endregion

        // вращение копии точки на угол angle вокруг точки {xc, yc}
        private float[] rotate(float[] m, float angle, float xc = 0, float yc = 0)
        {
            angle = angle / 180.0f * (float)Math.PI;
            float[,] rotateMatrix = {
                { (float)Math.Cos(angle), (float)Math.Sin(angle), 0  },
                { -(float)Math.Sin(angle), (float)Math.Cos(angle), 0 },
                { -xc * ((float)Math.Cos(angle) - 1) + yc * (float)Math.Sin(angle), -xc * (float)Math.Sin(angle) - yc * ((float)Math.Cos(angle) - 1), 1 } };

            return dot(m, rotateMatrix);
        }

        // обновление центра фигуры
        private void refreshCenter(float[] newCenter)
        {
            xc = newCenter[0];
            yc = newCenter[1];
        }
        // обновляем точки
        private void refreshPoints(float[,] moveMatrix)
        {
            pointsF = dot(pointsF, moveMatrix);
            set(points, pointsF);
        }
        // подействовать на точку матрицей преобразования и вернуть измененную точку
        private float[] getPointAfterTransform(float[,] moveMatrix)
        {
            float[] center = new float[3] { xc, yc, 1 };
            return dot(center, moveMatrix);
        }

        #region Переменные
        const int NUMBER_OF_POINTS = 8;

        public float xc = 0;
        public float yc = 0;
        float moveStep = 5;
        public float xScale = 50;
        public float yScale = 50;

        public float angle = 0.0f;
        public float roateAroundX = 0.0f;
        public float roateAroundY = 0.0f;

        public bool _isMoving = false;

        float[,] pointsF;
        PointF[] points;
        float[,] defaultPointsF;

        float[] coordinates;
        #endregion
    }

}
