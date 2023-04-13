
namespace Calculator
{
    partial class Form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coef_f = new System.Windows.Forms.TextBox();
            this.coef_e = new System.Windows.Forms.TextBox();
            this.coef_d = new System.Windows.Forms.TextBox();
            this.coef_c = new System.Windows.Forms.TextBox();
            this.coef_b = new System.Windows.Forms.TextBox();
            this.coef_a = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._value0 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this._value2 = new System.Windows.Forms.TextBox();
            this._value1 = new System.Windows.Forms.TextBox();
            this.labelx2 = new System.Windows.Forms.Label();
            this.labelx1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button2 = new System.Windows.Forms.Button();
            this.labelx3 = new System.Windows.Forms.Label();
            this.labelx4 = new System.Windows.Forms.Label();
            this.labelx5 = new System.Windows.Forms.Label();
            this._value3 = new System.Windows.Forms.TextBox();
            this._value4 = new System.Windows.Forms.TextBox();
            this._value5 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Степень уравнения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Решим уравнение вида:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox1.Location = new System.Drawing.Point(175, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coef_f);
            this.groupBox1.Controls.Add(this.coef_e);
            this.groupBox1.Controls.Add(this.coef_d);
            this.groupBox1.Controls.Add(this.coef_c);
            this.groupBox1.Controls.Add(this.coef_b);
            this.groupBox1.Controls.Add(this.coef_a);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(31, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 230);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Введите коэффициенты уравнения:";
            // 
            // coef_f
            // 
            this.coef_f.Location = new System.Drawing.Point(44, 192);
            this.coef_f.Name = "coef_f";
            this.coef_f.Size = new System.Drawing.Size(35, 20);
            this.coef_f.TabIndex = 11;
            this.coef_f.Visible = false;
            // 
            // coef_e
            // 
            this.coef_e.Location = new System.Drawing.Point(44, 158);
            this.coef_e.Name = "coef_e";
            this.coef_e.Size = new System.Drawing.Size(35, 20);
            this.coef_e.TabIndex = 10;
            this.coef_e.Visible = false;
            // 
            // coef_d
            // 
            this.coef_d.Location = new System.Drawing.Point(44, 127);
            this.coef_d.Name = "coef_d";
            this.coef_d.Size = new System.Drawing.Size(35, 20);
            this.coef_d.TabIndex = 9;
            this.coef_d.Visible = false;
            // 
            // coef_c
            // 
            this.coef_c.Location = new System.Drawing.Point(44, 98);
            this.coef_c.Name = "coef_c";
            this.coef_c.Size = new System.Drawing.Size(35, 20);
            this.coef_c.TabIndex = 8;
            this.coef_c.Visible = false;
            // 
            // coef_b
            // 
            this.coef_b.Location = new System.Drawing.Point(44, 69);
            this.coef_b.Name = "coef_b";
            this.coef_b.Size = new System.Drawing.Size(35, 20);
            this.coef_b.TabIndex = 7;
            this.coef_b.Visible = false;
            // 
            // coef_a
            // 
            this.coef_a.Location = new System.Drawing.Point(44, 37);
            this.coef_a.Name = "coef_a";
            this.coef_a.Size = new System.Drawing.Size(35, 20);
            this.coef_a.TabIndex = 6;
            this.coef_a.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "f";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "e";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "d";
            this.label7.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "c";
            this.label6.Visible = false;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "b";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "a";
            this.label4.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._value5);
            this.groupBox2.Controls.Add(this._value4);
            this.groupBox2.Controls.Add(this._value3);
            this.groupBox2.Controls.Add(this.labelx5);
            this.groupBox2.Controls.Add(this.labelx4);
            this.groupBox2.Controls.Add(this.labelx3);
            this.groupBox2.Controls.Add(this._value0);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this._value2);
            this.groupBox2.Controls.Add(this._value1);
            this.groupBox2.Controls.Add(this.labelx2);
            this.groupBox2.Controls.Add(this.labelx1);
            this.groupBox2.Location = new System.Drawing.Point(259, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 230);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Найти корни:";
            // 
            // _value0
            // 
            this._value0.Location = new System.Drawing.Point(137, 19);
            this._value0.Name = "_value0";
            this._value0.Size = new System.Drawing.Size(56, 20);
            this._value0.TabIndex = 6;
            this._value0.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(116, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "x:";
            this.label13.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "label12";
            this.label12.Visible = false;
            // 
            // _value2
            // 
            this._value2.Location = new System.Drawing.Point(51, 53);
            this._value2.Name = "_value2";
            this._value2.Size = new System.Drawing.Size(48, 20);
            this._value2.TabIndex = 3;
            this._value2.Visible = false;
            // 
            // _value1
            // 
            this._value1.Location = new System.Drawing.Point(51, 23);
            this._value1.Name = "_value1";
            this._value1.Size = new System.Drawing.Size(48, 20);
            this._value1.TabIndex = 2;
            this._value1.Visible = false;
            // 
            // labelx2
            // 
            this.labelx2.AutoSize = true;
            this.labelx2.Location = new System.Drawing.Point(24, 56);
            this.labelx2.Name = "labelx2";
            this.labelx2.Size = new System.Drawing.Size(21, 13);
            this.labelx2.TabIndex = 1;
            this.labelx2.Text = "x2:";
            this.labelx2.Visible = false;
            // 
            // labelx1
            // 
            this.labelx1.AutoSize = true;
            this.labelx1.Location = new System.Drawing.Point(24, 27);
            this.labelx1.Name = "labelx1";
            this.labelx1.Size = new System.Drawing.Size(21, 13);
            this.labelx1.TabIndex = 0;
            this.labelx1.Text = "x1:";
            this.labelx1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(787, 446);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Решить уравнение:";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Location = new System.Drawing.Point(515, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 364);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "График функции:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(54, 37);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Func";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(396, 303);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Графики функции";
            this.chart1.Titles.Add(title1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 446);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Задать пределы функции";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelx3
            // 
            this.labelx3.AutoSize = true;
            this.labelx3.Location = new System.Drawing.Point(24, 85);
            this.labelx3.Name = "labelx3";
            this.labelx3.Size = new System.Drawing.Size(21, 13);
            this.labelx3.TabIndex = 7;
            this.labelx3.Text = "x3:";
            // 
            // labelx4
            // 
            this.labelx4.AutoSize = true;
            this.labelx4.Location = new System.Drawing.Point(24, 118);
            this.labelx4.Name = "labelx4";
            this.labelx4.Size = new System.Drawing.Size(21, 13);
            this.labelx4.TabIndex = 8;
            this.labelx4.Text = "x4:";
            // 
            // labelx5
            // 
            this.labelx5.AutoSize = true;
            this.labelx5.Location = new System.Drawing.Point(24, 150);
            this.labelx5.Name = "labelx5";
            this.labelx5.Size = new System.Drawing.Size(21, 13);
            this.labelx5.TabIndex = 9;
            this.labelx5.Text = "x5:";
            // 
            // _value3
            // 
            this._value3.Location = new System.Drawing.Point(51, 82);
            this._value3.Name = "_value3";
            this._value3.Size = new System.Drawing.Size(48, 20);
            this._value3.TabIndex = 10;
            // 
            // _value4
            // 
            this._value4.Location = new System.Drawing.Point(51, 115);
            this._value4.Name = "_value4";
            this._value4.Size = new System.Drawing.Size(48, 20);
            this._value4.TabIndex = 11;
            // 
            // _value5
            // 
            this._value5.Location = new System.Drawing.Point(51, 143);
            this._value5.Name = "_value5";
            this._value5.Size = new System.Drawing.Size(49, 20);
            this._value5.TabIndex = 12;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 513);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox coef_f;
        private System.Windows.Forms.TextBox coef_e;
        private System.Windows.Forms.TextBox coef_d;
        private System.Windows.Forms.TextBox coef_c;
        private System.Windows.Forms.TextBox coef_b;
        private System.Windows.Forms.TextBox coef_a;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelx2;
        private System.Windows.Forms.Label labelx1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _value2;
        private System.Windows.Forms.TextBox _value1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox _value0;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelx5;
        private System.Windows.Forms.Label labelx4;
        private System.Windows.Forms.Label labelx3;
        private System.Windows.Forms.TextBox _value5;
        private System.Windows.Forms.TextBox _value4;
        private System.Windows.Forms.TextBox _value3;
    }
}

