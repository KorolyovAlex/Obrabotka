namespace Lab2
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.RChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showRHistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showGHistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.showBHistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.BChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.RChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BChart)).BeginInit();
            this.SuspendLayout();
            // 
            // RChart
            // 
            chartArea1.Name = "ChartArea1";
            this.RChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RChart.Legends.Add(legend1);
            this.RChart.Location = new System.Drawing.Point(12, 40);
            this.RChart.Name = "RChart";
            series1.BackImageTransparentColor = System.Drawing.Color.White;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Components";
            this.RChart.Series.Add(series1);
            this.RChart.Size = new System.Drawing.Size(1326, 300);
            this.RChart.TabIndex = 0;
            this.RChart.Text = "RChart";
            this.RChart.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startButton,
            this.showRHistButton,
            this.showGHistButton,
            this.showBHistButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startButton
            // 
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(43, 20);
            this.startButton.Text = "Start";
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // showRHistButton
            // 
            this.showRHistButton.Name = "showRHistButton";
            this.showRHistButton.Size = new System.Drawing.Size(82, 20);
            this.showRHistButton.Text = "Show R Hist";
            this.showRHistButton.Click += new System.EventHandler(this.showRHistButton_Click);
            // 
            // showGHistButton
            // 
            this.showGHistButton.Name = "showGHistButton";
            this.showGHistButton.Size = new System.Drawing.Size(83, 20);
            this.showGHistButton.Text = "Show G Hist";
            this.showGHistButton.Click += new System.EventHandler(this.showGHistButton_Click);
            // 
            // GChart
            // 
            chartArea2.Name = "ChartArea1";
            this.GChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.GChart.Legends.Add(legend2);
            this.GChart.Location = new System.Drawing.Point(12, 40);
            this.GChart.Name = "GChart";
            series2.BackImageTransparentColor = System.Drawing.Color.White;
            series2.BackSecondaryColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Components";
            this.GChart.Series.Add(series2);
            this.GChart.Size = new System.Drawing.Size(1326, 300);
            this.GChart.TabIndex = 2;
            this.GChart.Text = "chart1";
            this.GChart.Visible = false;
            // 
            // showBHistButton
            // 
            this.showBHistButton.Name = "showBHistButton";
            this.showBHistButton.Size = new System.Drawing.Size(82, 20);
            this.showBHistButton.Text = "Show B Hist";
            this.showBHistButton.Click += new System.EventHandler(this.showBHistButton_Click);
            // 
            // BChart
            // 
            chartArea3.Name = "ChartArea1";
            this.BChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.BChart.Legends.Add(legend3);
            this.BChart.Location = new System.Drawing.Point(12, 40);
            this.BChart.Name = "BChart";
            series3.BackImageTransparentColor = System.Drawing.Color.White;
            series3.BackSecondaryColor = System.Drawing.Color.White;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Components";
            this.BChart.Series.Add(series3);
            this.BChart.Size = new System.Drawing.Size(1326, 300);
            this.BChart.TabIndex = 3;
            this.BChart.Text = "chart1";
            this.BChart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 450);
            this.Controls.Add(this.BChart);
            this.Controls.Add(this.GChart);
            this.Controls.Add(this.RChart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RChart)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart RChart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart GChart;
        private System.Windows.Forms.ToolStripMenuItem showRHistButton;
        private System.Windows.Forms.ToolStripMenuItem showGHistButton;
        private System.Windows.Forms.ToolStripMenuItem showBHistButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart BChart;
    }
}

