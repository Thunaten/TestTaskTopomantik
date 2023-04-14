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
}