namespace Lab6
{
    partial class FunctionGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bntDraw = new System.Windows.Forms.Button();
            this.tbRight = new System.Windows.Forms.TextBox();
            this.tbLeft = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbXLeft = new System.Windows.Forms.Label();
            this.lbXRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntDraw
            // 
            this.bntDraw.Location = new System.Drawing.Point(469, 380);
            this.bntDraw.Name = "bntDraw";
            this.bntDraw.Size = new System.Drawing.Size(141, 43);
            this.bntDraw.TabIndex = 1;
            this.bntDraw.Text = "Построить график";
            this.bntDraw.UseVisualStyleBackColor = true;
            this.bntDraw.Click += new System.EventHandler(this.bntDraw_Click);
            // 
            // tbRight
            // 
            this.tbRight.Location = new System.Drawing.Point(320, 406);
            this.tbRight.Name = "tbRight";
            this.tbRight.Size = new System.Drawing.Size(84, 20);
            this.tbRight.TabIndex = 6;
            // 
            // tbLeft
            // 
            this.tbLeft.Location = new System.Drawing.Point(320, 380);
            this.tbLeft.Name = "tbLeft";
            this.tbLeft.Size = new System.Drawing.Size(84, 20);
            this.tbLeft.TabIndex = 7;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(56, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(643, 303);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "chart1";
            // 
            // lbXLeft
            // 
            this.lbXLeft.AutoSize = true;
            this.lbXLeft.Location = new System.Drawing.Point(185, 383);
            this.lbXLeft.Name = "lbXLeft";
            this.lbXLeft.Size = new System.Drawing.Size(129, 13);
            this.lbXLeft.TabIndex = 9;
            this.lbXLeft.Text = "Левая граница графика";
            // 
            // lbXRight
            // 
            this.lbXRight.AutoSize = true;
            this.lbXRight.Location = new System.Drawing.Point(179, 409);
            this.lbXRight.Name = "lbXRight";
            this.lbXRight.Size = new System.Drawing.Size(135, 13);
            this.lbXRight.TabIndex = 10;
            this.lbXRight.Text = "Правая граница графика";
            // 
            // FunctionGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbXRight);
            this.Controls.Add(this.lbXLeft);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.tbLeft);
            this.Controls.Add(this.tbRight);
            this.Controls.Add(this.bntDraw);
            this.Name = "FunctionGraph";
            this.Text = "FunctionGraph";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bntDraw;
        private System.Windows.Forms.TextBox tbRight;
        private System.Windows.Forms.TextBox tbLeft;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbXLeft;
        private System.Windows.Forms.Label lbXRight;
    }
}