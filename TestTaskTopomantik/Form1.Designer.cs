namespace TestTaskTopomantik
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.VertexLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddBtn1 = new System.Windows.Forms.Button();
            this.RemoveBtn1 = new System.Windows.Forms.Button();
            this.labelX1 = new System.Windows.Forms.Label();
            this.labelY1 = new System.Windows.Forms.Label();
            this.labelY2 = new System.Windows.Forms.Label();
            this.labelX2 = new System.Windows.Forms.Label();
            this.RemoveBtn2 = new System.Windows.Forms.Button();
            this.AddBtn2 = new System.Windows.Forms.Button();
            this.VertexLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelPolygon1 = new System.Windows.Forms.Label();
            this.labelPolygon2 = new System.Windows.Forms.Label();
            this.TextBoxX1 = new System.Windows.Forms.TextBox();
            this.TextBoxY1 = new System.Windows.Forms.TextBox();
            this.TextBoxX2 = new System.Windows.Forms.TextBox();
            this.TextBoxY2 = new System.Windows.Forms.TextBox();
            this.AreaCalcBtn = new System.Windows.Forms.Button();
            this.CrossBtn = new System.Windows.Forms.Button();
            this.SumBtn = new System.Windows.Forms.Button();
            this.TextBoxArea = new System.Windows.Forms.TextBox();
            this.labelPolygonArea = new System.Windows.Forms.Label();
            this.ChartCreateBtn = new System.Windows.Forms.Button();
            this.ChartPolygon = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.lableComments = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // VertexLayoutPanel1
            // 
            this.VertexLayoutPanel1.AutoScroll = true;
            this.VertexLayoutPanel1.Location = new System.Drawing.Point(910, 35);
            this.VertexLayoutPanel1.Name = "VertexLayoutPanel1";
            this.VertexLayoutPanel1.Size = new System.Drawing.Size(93, 182);
            this.VertexLayoutPanel1.TabIndex = 0;
            // 
            // AddBtn1
            // 
            this.AddBtn1.Location = new System.Drawing.Point(810, 109);
            this.AddBtn1.Name = "AddBtn1";
            this.AddBtn1.Size = new System.Drawing.Size(94, 52);
            this.AddBtn1.TabIndex = 1;
            this.AddBtn1.Text = "Добавить вершину";
            this.AddBtn1.UseVisualStyleBackColor = true;
            this.AddBtn1.Click += new System.EventHandler(this.AddBtn1_Click);
            // 
            // RemoveBtn1
            // 
            this.RemoveBtn1.Location = new System.Drawing.Point(810, 167);
            this.RemoveBtn1.Name = "RemoveBtn1";
            this.RemoveBtn1.Size = new System.Drawing.Size(94, 50);
            this.RemoveBtn1.TabIndex = 2;
            this.RemoveBtn1.Text = "Очистить данные";
            this.RemoveBtn1.UseVisualStyleBackColor = true;
            this.RemoveBtn1.Click += new System.EventHandler(this.RemoveBtn1_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(810, 53);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(21, 20);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "X:";
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(864, 53);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(20, 20);
            this.labelY1.TabIndex = 6;
            this.labelY1.Text = "Y:";
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(864, 299);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(20, 20);
            this.labelY2.TabIndex = 14;
            this.labelY2.Text = "Y:";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(810, 299);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(21, 20);
            this.labelX2.TabIndex = 13;
            this.labelX2.Text = "X:";
            // 
            // RemoveBtn2
            // 
            this.RemoveBtn2.Location = new System.Drawing.Point(810, 413);
            this.RemoveBtn2.Name = "RemoveBtn2";
            this.RemoveBtn2.Size = new System.Drawing.Size(94, 50);
            this.RemoveBtn2.TabIndex = 10;
            this.RemoveBtn2.Text = "Очистить данные";
            this.RemoveBtn2.UseVisualStyleBackColor = true;
            this.RemoveBtn2.Click += new System.EventHandler(this.RemoveBtn2_Click);
            // 
            // AddBtn2
            // 
            this.AddBtn2.Location = new System.Drawing.Point(810, 355);
            this.AddBtn2.Name = "AddBtn2";
            this.AddBtn2.Size = new System.Drawing.Size(94, 52);
            this.AddBtn2.TabIndex = 9;
            this.AddBtn2.Text = "Добавить вершину";
            this.AddBtn2.UseVisualStyleBackColor = true;
            this.AddBtn2.Click += new System.EventHandler(this.AddBtn2_Click);
            // 
            // VertexLayoutPanel2
            // 
            this.VertexLayoutPanel2.AutoScroll = true;
            this.VertexLayoutPanel2.Location = new System.Drawing.Point(910, 299);
            this.VertexLayoutPanel2.Name = "VertexLayoutPanel2";
            this.VertexLayoutPanel2.Size = new System.Drawing.Size(93, 182);
            this.VertexLayoutPanel2.TabIndex = 8;
            // 
            // labelPolygon1
            // 
            this.labelPolygon1.AutoSize = true;
            this.labelPolygon1.Location = new System.Drawing.Point(810, 9);
            this.labelPolygon1.Name = "labelPolygon1";
            this.labelPolygon1.Size = new System.Drawing.Size(179, 20);
            this.labelPolygon1.TabIndex = 16;
            this.labelPolygon1.Text = "Первый многоугольник:";
            // 
            // labelPolygon2
            // 
            this.labelPolygon2.AutoSize = true;
            this.labelPolygon2.Location = new System.Drawing.Point(810, 265);
            this.labelPolygon2.Name = "labelPolygon2";
            this.labelPolygon2.Size = new System.Drawing.Size(174, 20);
            this.labelPolygon2.TabIndex = 17;
            this.labelPolygon2.Text = "Второй многоугольник:";
            // 
            // TextBoxX1
            // 
            this.TextBoxX1.Location = new System.Drawing.Point(810, 76);
            this.TextBoxX1.Name = "TextBoxX1";
            this.TextBoxX1.Size = new System.Drawing.Size(38, 27);
            this.TextBoxX1.TabIndex = 18;
            this.TextBoxX1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxX1_KeyPress);
            // 
            // TextBoxY1
            // 
            this.TextBoxY1.Location = new System.Drawing.Point(864, 76);
            this.TextBoxY1.Name = "TextBoxY1";
            this.TextBoxY1.Size = new System.Drawing.Size(38, 27);
            this.TextBoxY1.TabIndex = 19;
            this.TextBoxY1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxY1_KeyPress);
            // 
            // TextBoxX2
            // 
            this.TextBoxX2.Location = new System.Drawing.Point(810, 322);
            this.TextBoxX2.Name = "TextBoxX2";
            this.TextBoxX2.Size = new System.Drawing.Size(38, 27);
            this.TextBoxX2.TabIndex = 20;
            this.TextBoxX2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxX2_KeyPress);
            // 
            // TextBoxY2
            // 
            this.TextBoxY2.Location = new System.Drawing.Point(864, 322);
            this.TextBoxY2.Name = "TextBoxY2";
            this.TextBoxY2.Size = new System.Drawing.Size(38, 27);
            this.TextBoxY2.TabIndex = 21;
            this.TextBoxY2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxY2_KeyPress);
            // 
            // AreaCalcBtn
            // 
            this.AreaCalcBtn.Location = new System.Drawing.Point(12, 402);
            this.AreaCalcBtn.Name = "AreaCalcBtn";
            this.AreaCalcBtn.Size = new System.Drawing.Size(197, 66);
            this.AreaCalcBtn.TabIndex = 23;
            this.AreaCalcBtn.Text = "Расчитать площадь многоугольника";
            this.AreaCalcBtn.UseVisualStyleBackColor = true;
            this.AreaCalcBtn.Click += new System.EventHandler(this.AreaCalcBtn_Click);
            // 
            // CrossBtn
            // 
            this.CrossBtn.Location = new System.Drawing.Point(386, 403);
            this.CrossBtn.Name = "CrossBtn";
            this.CrossBtn.Size = new System.Drawing.Size(197, 66);
            this.CrossBtn.TabIndex = 24;
            this.CrossBtn.Text = "Построить пересечение многоугольников";
            this.CrossBtn.UseVisualStyleBackColor = true;
            this.CrossBtn.Click += new System.EventHandler(this.CrossBtn_Click);
            // 
            // SumBtn
            // 
            this.SumBtn.Location = new System.Drawing.Point(589, 403);
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.Size = new System.Drawing.Size(201, 64);
            this.SumBtn.TabIndex = 25;
            this.SumBtn.Text = "Объеденить многоугольники";
            this.SumBtn.UseVisualStyleBackColor = true;
            this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // TextBoxArea
            // 
            this.TextBoxArea.Location = new System.Drawing.Point(297, 403);
            this.TextBoxArea.Name = "TextBoxArea";
            this.TextBoxArea.Size = new System.Drawing.Size(83, 27);
            this.TextBoxArea.TabIndex = 26;
            // 
            // labelPolygonArea
            // 
            this.labelPolygonArea.AutoSize = true;
            this.labelPolygonArea.Location = new System.Drawing.Point(215, 406);
            this.labelPolygonArea.Name = "labelPolygonArea";
            this.labelPolygonArea.Size = new System.Drawing.Size(76, 20);
            this.labelPolygonArea.TabIndex = 27;
            this.labelPolygonArea.Text = "Площадь:";
            // 
            // ChartCreateBtn
            // 
            this.ChartCreateBtn.Location = new System.Drawing.Point(810, 223);
            this.ChartCreateBtn.Name = "ChartCreateBtn";
            this.ChartCreateBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChartCreateBtn.Size = new System.Drawing.Size(193, 39);
            this.ChartCreateBtn.TabIndex = 28;
            this.ChartCreateBtn.Text = "Выполнить построение";
            this.ChartCreateBtn.UseVisualStyleBackColor = true;
            this.ChartCreateBtn.Click += new System.EventHandler(this.ChartCreateBtn_Click);
            // 
            // ChartPolygon
            // 
            this.ChartPolygon.AddRandomSeries = false;
            this.ChartPolygon.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.ChartPolygon.ChartArea.CursorReDraw = false;
            this.ChartPolygon.IsWindowLess = false;
            // 
            // 
            // 
            this.ChartPolygon.Legend.Location = new System.Drawing.Point(657, 81);
            this.ChartPolygon.Legend.Visible = false;
            this.ChartPolygon.Localize = null;
            this.ChartPolygon.Location = new System.Drawing.Point(12, 9);
            this.ChartPolygon.Name = "ChartPolygon";
            this.ChartPolygon.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ChartPolygon.PrimaryXAxis.Margin = true;
            this.ChartPolygon.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.ChartPolygon.PrimaryYAxis.Margin = true;
            this.ChartPolygon.Size = new System.Drawing.Size(778, 375);
            this.ChartPolygon.TabIndex = 29;
            // 
            // 
            // 
            this.ChartPolygon.Title.Name = "Default";
            this.ChartPolygon.VisualTheme = "";
            // 
            // lableComments
            // 
            this.lableComments.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lableComments.Location = new System.Drawing.Point(215, 433);
            this.lableComments.Name = "lableComments";
            this.lableComments.Size = new System.Drawing.Size(182, 60);
            this.lableComments.TabIndex = 30;
            this.lableComments.Text = "При наличии двух многоугольников -\r\nнаходит площадь первого";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1014, 490);
            this.Controls.Add(this.ChartPolygon);
            this.Controls.Add(this.ChartCreateBtn);
            this.Controls.Add(this.labelPolygonArea);
            this.Controls.Add(this.TextBoxArea);
            this.Controls.Add(this.SumBtn);
            this.Controls.Add(this.CrossBtn);
            this.Controls.Add(this.AreaCalcBtn);
            this.Controls.Add(this.TextBoxY2);
            this.Controls.Add(this.TextBoxX2);
            this.Controls.Add(this.TextBoxY1);
            this.Controls.Add(this.TextBoxX1);
            this.Controls.Add(this.labelPolygon2);
            this.Controls.Add(this.labelPolygon1);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.RemoveBtn2);
            this.Controls.Add(this.AddBtn2);
            this.Controls.Add(this.VertexLayoutPanel2);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.RemoveBtn1);
            this.Controls.Add(this.AddBtn1);
            this.Controls.Add(this.VertexLayoutPanel1);
            this.Controls.Add(this.lableComments);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel VertexLayoutPanel1;
        private Button AddBtn1;
        private Button RemoveBtn1;
        private Label labelX1;
        private Label labelY1;
        private Label labelY2;
        private Label labelX2;
        private Button RemoveBtn2;
        private Button AddBtn2;
        private FlowLayoutPanel VertexLayoutPanel2;
        private Label labelPolygon1;
        private Label labelPolygon2;
        private TextBox TextBoxX1;
        private TextBox TextBoxY1;
        private TextBox TextBoxX2;
        private TextBox TextBoxY2;
        private Button AreaCalcBtn;
        private Button CrossBtn;
        private Button SumBtn;
        private TextBox TextBoxArea;
        private Label labelPolygonArea;
        private Button ChartCreateBtn;
        private Syncfusion.Windows.Forms.Chart.ChartControl ChartPolygon;
        private Label lableComments;
    }
}