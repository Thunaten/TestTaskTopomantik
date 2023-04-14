using Syncfusion.Windows.Forms.Chart;
using System.Globalization;

namespace TestTaskTopomantik
{
    public partial class Form1 : Form
    {
        Polygon firstPolygon = new Polygon();
        Polygon secondPolygon = new Polygon();
        Polygon crossPolygon = new Polygon();
        Polygon activePolygon = new Polygon();
        Polygon sumPolygon = new Polygon();
        ChartSeries polygonChart1 = new ChartSeries("Polygon 1");
        ChartSeries polygonChart2 = new ChartSeries("Polygon 2");
        ChartSeries polygonChartCross = new ChartSeries("Polygon Cross");
        ChartSeries polygonChartSum = new ChartSeries("Polygon Sum");

        public Form1()
        {
            InitializeComponent();
        }

        private void AddBtn1_Click(object sender, EventArgs e)
        {
            double x1Value = Convert.ToDouble(TextBoxX1.Text);
            double y1Value = Convert.ToDouble(TextBoxY1.Text);

            Vertex addingVertex = new Vertex(x1Value, y1Value);

            firstPolygon.AddVertex(addingVertex);

            VertexLayoutPanel1.Controls.Add(new Label() { Text = "X: " + x1Value + " Y: " + y1Value });
        }

        private void RemoveBtn1_Click(object sender, EventArgs e)
        {
            firstPolygon.ClearData();
            VertexLayoutPanel1.Controls.Clear();
        }

        private void ChartCreateBtn_Click(object sender, EventArgs e)
        {
            polygonChart1.Points.Clear();
            polygonChart2.Points.Clear();
            polygonChartSum.Points.Clear();
            polygonChartCross.Points.Clear();
            polygonChart1.SortPoints = false;
            polygonChart2.SortPoints = false;

            for (int i = 0; i <= firstPolygon.listOfPolygonVertex.Count; i++)
            {
                if (i < firstPolygon.listOfPolygonVertex.Count)
                {
                    polygonChart1.Points.Add(firstPolygon.listOfPolygonVertex[i].X, firstPolygon.listOfPolygonVertex[i].Y);
                }
                else if (i == firstPolygon.listOfPolygonVertex.Count)
                {
                    polygonChart1.Points.Add(firstPolygon.listOfPolygonVertex[0].X, firstPolygon.listOfPolygonVertex[0].Y);
                }
            }

            polygonChart1.Type = ChartSeriesType.Line;
            this.ChartPolygon.Series.Add(polygonChart1);

            if (secondPolygon.listOfPolygonVertex.Count != 0)
            {
                for (int i = 0; i <= secondPolygon.listOfPolygonVertex.Count; i++)
                {
                    if (i < secondPolygon.listOfPolygonVertex.Count)
                    {
                        polygonChart2.Points.Add(secondPolygon.listOfPolygonVertex[i].X, secondPolygon.listOfPolygonVertex[i].Y);
                    }
                    else if (i == secondPolygon.listOfPolygonVertex.Count)
                    {
                        polygonChart2.Points.Add(secondPolygon.listOfPolygonVertex[0].X, secondPolygon.listOfPolygonVertex[0].Y);
                    }
                }
                polygonChart2.Type = ChartSeriesType.Line;
                this.ChartPolygon.Series.Add(polygonChart2);

                activePolygon = firstPolygon;
            }
        }

        private void AddBtn2_Click(object sender, EventArgs e)
        {
            double x2Value = Convert.ToDouble(TextBoxX2.Text);
            double y2Value = Convert.ToDouble(TextBoxY2.Text);

            Vertex addingVertex = new Vertex(x2Value, y2Value);

            secondPolygon.AddVertex(addingVertex);

            VertexLayoutPanel2.Controls.Add(new Label() { Text = "X: " + x2Value + " Y: " + y2Value });
        }

        private void RemoveBtn2_Click(object sender, EventArgs e)
        {
            secondPolygon.ClearData();
            VertexLayoutPanel2.Controls.Clear();
        }

        private void TextBoxX1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBoxY1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBoxX2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void TextBoxY2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void AreaCalcBtn_Click(object sender, EventArgs e)
        {
            TextBoxArea.Text = Convert.ToString(activePolygon.AreaFind());
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            polygonChartCross.Points.Clear();
            polygonChartCross.SortPoints = false;

            crossPolygon.listOfPolygonVertex = crossPolygon.FindCrossPoint(firstPolygon, secondPolygon);

            polygonChartSum.Points.Clear();
            polygonChart1.Points.Clear();
            polygonChart2.Points.Clear();

            for (int i = 0; i <= crossPolygon.listOfPolygonVertex.Count; i++)
            {
                if (i < crossPolygon.listOfPolygonVertex.Count)
                {
                    polygonChartCross.Points.Add(crossPolygon.listOfPolygonVertex[i].X, crossPolygon.listOfPolygonVertex[i].Y);
                }
                else if (i == crossPolygon.listOfPolygonVertex.Count)
                {
                    polygonChartCross.Points.Add(crossPolygon.listOfPolygonVertex[0].X, crossPolygon.listOfPolygonVertex[0].Y);
                }
            }

            polygonChartCross.Type = ChartSeriesType.Line;
            this.ChartPolygon.Series.Add(polygonChartCross);

            activePolygon = crossPolygon;
        }

        private void SumBtn_Click(object sender, EventArgs e)
        {
            sumPolygon.SumPoligon(firstPolygon, secondPolygon);

            polygonChart1.Points.Clear();
            polygonChart2.Points.Clear();
            polygonChartCross.Points.Clear();
            polygonChartSum.Points.Clear();
            polygonChartSum.SortPoints = false;

            for (int i = 0; i <= sumPolygon.listOfPolygonVertex.Count; i++)
            {
                if (i < sumPolygon.listOfPolygonVertex.Count)
                {
                    polygonChartSum.Points.Add(sumPolygon.listOfPolygonVertex[i].X, sumPolygon.listOfPolygonVertex[i].Y);
                }
                else if (i == sumPolygon.listOfPolygonVertex.Count)
                {
                    polygonChartSum.Points.Add(sumPolygon.listOfPolygonVertex[0].X, sumPolygon.listOfPolygonVertex[0].Y);
                }
            }

            polygonChartSum.Type = ChartSeriesType.Line;
            this.ChartPolygon.Series.Add(polygonChartSum);
        }
    }

    public class Vertex
    {
        public double X;
        public double Y;

        public Vertex(double x, double y)
        {
            X = x;
            Y = y;
        }
    }

    public class Polygon
    {
        public List<Vertex> listOfPolygonVertex = new List<Vertex>();

        public List<Vertex> AddVertex(Vertex vertex)
        {
            listOfPolygonVertex.Add(vertex);
            return listOfPolygonVertex;
        }

        public List<Vertex> ClearData()
        {
            listOfPolygonVertex.Clear();
            return listOfPolygonVertex;
        }

        public double AreaFind()
        {
            double sum = 0;

            for (int i = 0; i <= listOfPolygonVertex.Count - 1; i++)
            {
                if (i < listOfPolygonVertex.Count - 1)
                {
                    sum += (listOfPolygonVertex[i].X * listOfPolygonVertex[i + 1].Y) - (listOfPolygonVertex[i].Y * listOfPolygonVertex[i + 1].X);
                }
                else if (i == listOfPolygonVertex.Count - 1)
                {
                    sum += (listOfPolygonVertex[i].X * listOfPolygonVertex[0].Y) - (listOfPolygonVertex[i].Y * listOfPolygonVertex[0].X);
                }
            }
            sum = sum / 2;

            return Math.Abs(sum);
        }

        public List<Vertex> FindCrossPoint(Polygon firstPolygonForCross, Polygon secondPolygonForCross)
        {
            double a1;
            double b1;
            double c1;
            double a2;
            double b2;
            double c2;
            double crossPointX;
            double crossPointY;

            listOfPolygonVertex.Clear();

            for (int i = 0; i <= firstPolygonForCross.listOfPolygonVertex.Count - 1; i++)
            {
                if (i < firstPolygonForCross.listOfPolygonVertex.Count - 1)
                {
                    for (int j = 0; j <= secondPolygonForCross.listOfPolygonVertex.Count - 1; j++)
                    {
                        if (j < secondPolygonForCross.listOfPolygonVertex.Count - 1)
                        {
                            a1 = firstPolygonForCross.listOfPolygonVertex[i + 1].Y - firstPolygonForCross.listOfPolygonVertex[i].Y;
                            b1 = firstPolygonForCross.listOfPolygonVertex[i].X - firstPolygonForCross.listOfPolygonVertex[i + 1].X;
                            c1 = -1 * firstPolygonForCross.listOfPolygonVertex[i].X * firstPolygonForCross.listOfPolygonVertex[i + 1].Y +
                                firstPolygonForCross.listOfPolygonVertex[i].Y * firstPolygonForCross.listOfPolygonVertex[i + 1].X;

                            a2 = secondPolygonForCross.listOfPolygonVertex[j + 1].Y - secondPolygonForCross.listOfPolygonVertex[j].Y;
                            b2 = secondPolygonForCross.listOfPolygonVertex[j].X - secondPolygonForCross.listOfPolygonVertex[j + 1].X;
                            c2 = -1 * secondPolygonForCross.listOfPolygonVertex[j].X * secondPolygonForCross.listOfPolygonVertex[j + 1].Y +
                                secondPolygonForCross.listOfPolygonVertex[j].Y * secondPolygonForCross.listOfPolygonVertex[j + 1].X;

                            //Проверка на парралельность прямых
                            if ((a1 * b2 - a2 * b1) != 0)
                            {
                                crossPointX = (b1 * c2 - b2 * c1) / (b2 * a1 - b1 * a2);
                                crossPointY = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);

                                if (((crossPointX >= firstPolygonForCross.listOfPolygonVertex[i].X && crossPointX <= firstPolygonForCross.listOfPolygonVertex[i + 1].X)
                                    || (crossPointX <= firstPolygonForCross.listOfPolygonVertex[i].X && crossPointX >= firstPolygonForCross.listOfPolygonVertex[i + 1].X))
                                    && ((crossPointX >= secondPolygonForCross.listOfPolygonVertex[j].X && crossPointX <= secondPolygonForCross.listOfPolygonVertex[j + 1].X)
                                    || (crossPointX <= secondPolygonForCross.listOfPolygonVertex[j].X && crossPointX >= secondPolygonForCross.listOfPolygonVertex[j + 1].X)))
                                {
                                    Vertex crossPoint = new Vertex(crossPointX, crossPointY);
                                    listOfPolygonVertex.Add(crossPoint);
                                }
                            }
                        }
                        else if (j == secondPolygonForCross.listOfPolygonVertex.Count - 1)
                        {
                            a1 = firstPolygonForCross.listOfPolygonVertex[i + 1].Y - firstPolygonForCross.listOfPolygonVertex[i].Y;
                            b1 = firstPolygonForCross.listOfPolygonVertex[i].X - firstPolygonForCross.listOfPolygonVertex[i + 1].X;
                            c1 = -1 * firstPolygonForCross.listOfPolygonVertex[i].X * firstPolygonForCross.listOfPolygonVertex[i + 1].Y +
                                firstPolygonForCross.listOfPolygonVertex[i].Y * firstPolygonForCross.listOfPolygonVertex[i + 1].X;

                            a2 = secondPolygonForCross.listOfPolygonVertex[0].Y - secondPolygonForCross.listOfPolygonVertex[j].Y;
                            b2 = secondPolygonForCross.listOfPolygonVertex[j].X - secondPolygonForCross.listOfPolygonVertex[0].X;
                            c2 = -1 * secondPolygonForCross.listOfPolygonVertex[j].X * secondPolygonForCross.listOfPolygonVertex[0].Y +
                                secondPolygonForCross.listOfPolygonVertex[j].Y * secondPolygonForCross.listOfPolygonVertex[0].X;

                            //Проверка на парралельность прямых
                            if ((a1 * b2 - a2 * b1) != 0)
                            {
                                crossPointX = (b1 * c2 - b2 * c1) / (b2 * a1 - b1 * a2);
                                crossPointY = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);

                                if (((crossPointX >= firstPolygonForCross.listOfPolygonVertex[i].X && crossPointX <= firstPolygonForCross.listOfPolygonVertex[i + 1].X)
                                    || (crossPointX <= firstPolygonForCross.listOfPolygonVertex[i].X && crossPointX >= firstPolygonForCross.listOfPolygonVertex[i + 1].X))
                                    && ((crossPointX >= secondPolygonForCross.listOfPolygonVertex[j].X && crossPointX <= secondPolygonForCross.listOfPolygonVertex[0].X)
                                    || (crossPointX <= secondPolygonForCross.listOfPolygonVertex[j].X && crossPointX >= secondPolygonForCross.listOfPolygonVertex[0].X)))
                                {
                                    Vertex crossPoint = new Vertex(crossPointX, crossPointY);
                                    listOfPolygonVertex.Add(crossPoint);
                                }
                            }
                        }
                    }
                }
                else if (i == firstPolygonForCross.listOfPolygonVertex.Count - 1)
                {
                    for (int j = secondPolygonForCross.listOfPolygonVertex.Count - 1; j > 0; j--)
                    {
                        if (j == secondPolygonForCross.listOfPolygonVertex.Count - 1)
                        {
                            a1 = firstPolygonForCross.listOfPolygonVertex[0].Y - firstPolygonForCross.listOfPolygonVertex[i].Y;
                            b1 = firstPolygonForCross.listOfPolygonVertex[i].X - firstPolygonForCross.listOfPolygonVertex[0].X;
                            c1 = -1 * firstPolygonForCross.listOfPolygonVertex[i].X * firstPolygonForCross.listOfPolygonVertex[0].Y +
                                firstPolygonForCross.listOfPolygonVertex[i].Y * firstPolygonForCross.listOfPolygonVertex[0].X;

                            a2 = secondPolygonForCross.listOfPolygonVertex[0].Y - secondPolygonForCross.listOfPolygonVertex[j].Y;
                            b2 = secondPolygonForCross.listOfPolygonVertex[j].X - secondPolygonForCross.listOfPolygonVertex[0].X;
                            c2 = -1 * secondPolygonForCross.listOfPolygonVertex[j].X * secondPolygonForCross.listOfPolygonVertex[0].Y +
                                secondPolygonForCross.listOfPolygonVertex[j].Y * secondPolygonForCross.listOfPolygonVertex[0].X;

                            //Проверка на парралельность прямых
                            if ((a1 * b2 - a2 * b1) != 0)
                            {
                                crossPointX = (b1 * c2 - b2 * c1) / (b2 * a1 - b1 * a2);
                                crossPointY = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);

                                if (((crossPointX >= firstPolygonForCross.listOfPolygonVertex[i].X && crossPointX <= firstPolygonForCross.listOfPolygonVertex[0].X)
                                    || (crossPointX <= firstPolygonForCross.listOfPolygonVertex[i].X && crossPointX >= firstPolygonForCross.listOfPolygonVertex[0].X))
                                    && ((crossPointX >= secondPolygonForCross.listOfPolygonVertex[j].X && crossPointX <= secondPolygonForCross.listOfPolygonVertex[0].X)
                                    || (crossPointX <= secondPolygonForCross.listOfPolygonVertex[j].X && crossPointX >= secondPolygonForCross.listOfPolygonVertex[0].X)))
                                {
                                    Vertex crossPoint = new Vertex(crossPointX, crossPointY);
                                    listOfPolygonVertex.Add(crossPoint);
                                }
                            }
                        }
                        else if (j > 0)
                        {
                            a1 = firstPolygonForCross.listOfPolygonVertex[0].Y - firstPolygonForCross.listOfPolygonVertex[i].Y;
                            b1 = firstPolygonForCross.listOfPolygonVertex[i].X - firstPolygonForCross.listOfPolygonVertex[0].X;
                            c1 = -1 * firstPolygonForCross.listOfPolygonVertex[i].X * firstPolygonForCross.listOfPolygonVertex[0].Y +
                                firstPolygonForCross.listOfPolygonVertex[i].Y * firstPolygonForCross.listOfPolygonVertex[0].X;

                            a2 = secondPolygonForCross.listOfPolygonVertex[j].Y - secondPolygonForCross.listOfPolygonVertex[j - 1].Y;
                            b2 = secondPolygonForCross.listOfPolygonVertex[j - 1].X - secondPolygonForCross.listOfPolygonVertex[j].X;
                            c2 = -1 * secondPolygonForCross.listOfPolygonVertex[j - 1].X * secondPolygonForCross.listOfPolygonVertex[j].Y +
                                secondPolygonForCross.listOfPolygonVertex[j - 1].Y * secondPolygonForCross.listOfPolygonVertex[j].X;

                            //Проверка на парралельность прямых
                            if ((a1 * b2 - a2 * b1) != 0)
                            {
                                crossPointX = (b1 * c2 - b2 * c1) / (b2 * a1 - b1 * a2);
                                crossPointY = (a2 * c1 - a1 * c2) / (a1 * b2 - a2 * b1);

                                if (((crossPointX >= firstPolygonForCross.listOfPolygonVertex[i].X && crossPointX <= firstPolygonForCross.listOfPolygonVertex[0].X)
                                    || (crossPointX <= firstPolygonForCross.listOfPolygonVertex[i].X && crossPointX >= firstPolygonForCross.listOfPolygonVertex[0].X))
                                    && ((crossPointX >= secondPolygonForCross.listOfPolygonVertex[j - 1].X && crossPointX <= secondPolygonForCross.listOfPolygonVertex[j].X)
                                    || (crossPointX <= secondPolygonForCross.listOfPolygonVertex[j - 1].X && crossPointX >= secondPolygonForCross.listOfPolygonVertex[j].X)))
                                {
                                    Vertex crossPoint = new Vertex(crossPointX, crossPointY);
                                    listOfPolygonVertex.Add(crossPoint);
                                }
                            }
                        }
                    }
                }
            }
            return listOfPolygonVertex;
        }

        public void SumPoligon(Polygon firstPolygonForSum, Polygon secondPolygonForSum)
        {
            listOfPolygonVertex.Clear();

            FindCrossPoint(firstPolygonForSum, secondPolygonForSum);
            Polygon tempPolygon = new Polygon();

            for (int i = 0; i <= listOfPolygonVertex.Count - 1; i++)
            {
                if (i < listOfPolygonVertex.Count - 1)
                {
                    foreach (Vertex vertex in firstPolygonForSum.listOfPolygonVertex)
                    {
                        if (((vertex.X >= listOfPolygonVertex[i].X && vertex.X <= listOfPolygonVertex[i + 1].X)
                            || (vertex.X <= listOfPolygonVertex[i].X && vertex.X >= listOfPolygonVertex[i + 1].X))
                            || ((vertex.Y >= listOfPolygonVertex[i].Y && vertex.Y <= listOfPolygonVertex[i + 1].Y)
                            || (vertex.Y <= listOfPolygonVertex[i].Y && vertex.Y >= listOfPolygonVertex[i + 1].Y)))
                        {
                            tempPolygon.listOfPolygonVertex.Add(vertex);
                        }
                    }
                    foreach (Vertex vertex in secondPolygonForSum.listOfPolygonVertex)
                    {
                        if (((vertex.X >= listOfPolygonVertex[i].X && vertex.X <= listOfPolygonVertex[i + 1].X)
                            || (vertex.X <= listOfPolygonVertex[i].X && vertex.X >= listOfPolygonVertex[i + 1].X))
                            || ((vertex.Y >= listOfPolygonVertex[i].Y && vertex.Y <= listOfPolygonVertex[i + 1].Y)
                            || (vertex.Y <= listOfPolygonVertex[i].Y && vertex.Y >= listOfPolygonVertex[i + 1].Y)))
                        {
                            tempPolygon.listOfPolygonVertex.Add(vertex);
                        }
                    }
                    tempPolygon.listOfPolygonVertex.Add(listOfPolygonVertex[i]);
                }
                else if (i == listOfPolygonVertex.Count - 1)
                {
                    foreach (Vertex vertex in firstPolygonForSum.listOfPolygonVertex)
                    {
                        if (((vertex.X >= listOfPolygonVertex[i].X && vertex.X <= listOfPolygonVertex[0].X)
                            || (vertex.X <= listOfPolygonVertex[i].X && vertex.X >= listOfPolygonVertex[0].X))
                            || ((vertex.Y >= listOfPolygonVertex[i].Y && vertex.Y <= listOfPolygonVertex[0].Y)
                            || (vertex.Y <= listOfPolygonVertex[i].Y && vertex.Y >= listOfPolygonVertex[0].Y)))
                        {
                            tempPolygon.listOfPolygonVertex.Add(vertex);
                        }
                    }
                    foreach (Vertex vertex in secondPolygonForSum.listOfPolygonVertex)
                    {
                        if (((vertex.X >= listOfPolygonVertex[i].X && vertex.X <= listOfPolygonVertex[0].X)
                            || (vertex.X <= listOfPolygonVertex[i].X && vertex.X >= listOfPolygonVertex[0].X))
                            || ((vertex.Y >= listOfPolygonVertex[i].Y && vertex.Y <= listOfPolygonVertex[0].Y)
                            || (vertex.Y <= listOfPolygonVertex[i].Y && vertex.Y >= listOfPolygonVertex[0].Y)))
                        {
                            tempPolygon.listOfPolygonVertex.Add(vertex);
                        }
                    }
                    tempPolygon.listOfPolygonVertex.Add(listOfPolygonVertex[i]);
                }
            }

            listOfPolygonVertex = tempPolygon.listOfPolygonVertex;
        }
    }
}