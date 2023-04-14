namespace TestTaskTopomantik
{
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