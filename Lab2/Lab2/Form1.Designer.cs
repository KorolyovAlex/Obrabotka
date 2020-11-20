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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.RChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showRHistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showGHistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showBHistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showREqualHistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showGEqualHistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showBEqualHistButton = new System.Windows.Forms.ToolStripMenuItem();
            this.GChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.REqualChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GEqualChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BEqualChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.firstAverage = new System.Windows.Forms.Label();
            this.secondAverage = new System.Windows.Forms.Label();
            this.thirdAverage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.RChart)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.REqualChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GEqualChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEqualChart)).BeginInit();
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
            this.showBHistButton,
            this.showREqualHistButton,
            this.showGEqualHistButton,
            this.showBEqualHistButton});
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
            // showBHistButton
            // 
            this.showBHistButton.Name = "showBHistButton";
            this.showBHistButton.Size = new System.Drawing.Size(82, 20);
            this.showBHistButton.Text = "Show B Hist";
            this.showBHistButton.Click += new System.EventHandler(this.showBHistButton_Click);
            // 
            // showREqualHistButton
            // 
            this.showREqualHistButton.Name = "showREqualHistButton";
            this.showREqualHistButton.Size = new System.Drawing.Size(114, 20);
            this.showREqualHistButton.Text = "Show R Equal Hist";
            this.showREqualHistButton.Click += new System.EventHandler(this.showREqualHistButton_Click);
            // 
            // showGEqualHistButton
            // 
            this.showGEqualHistButton.Name = "showGEqualHistButton";
            this.showGEqualHistButton.Size = new System.Drawing.Size(115, 20);
            this.showGEqualHistButton.Text = "Show G Equal Hist";
            this.showGEqualHistButton.Click += new System.EventHandler(this.showGEqualHistButton_Click);
            // 
            // showBEqualHistButton
            // 
            this.showBEqualHistButton.Name = "showBEqualHistButton";
            this.showBEqualHistButton.Size = new System.Drawing.Size(114, 20);
            this.showBEqualHistButton.Text = "Show B Equal Hist";
            this.showBEqualHistButton.Click += new System.EventHandler(this.showBEqualHistButton_Click);
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
            // REqualChart
            // 
            chartArea4.Name = "ChartArea1";
            this.REqualChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.REqualChart.Legends.Add(legend4);
            this.REqualChart.Location = new System.Drawing.Point(12, 40);
            this.REqualChart.Name = "REqualChart";
            series4.BackImageTransparentColor = System.Drawing.Color.White;
            series4.BackSecondaryColor = System.Drawing.Color.White;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Components";
            this.REqualChart.Series.Add(series4);
            this.REqualChart.Size = new System.Drawing.Size(1326, 300);
            this.REqualChart.TabIndex = 4;
            this.REqualChart.Text = "chart1";
            this.REqualChart.Visible = false;
            // 
            // GEqualChart
            // 
            chartArea5.Name = "ChartArea1";
            this.GEqualChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.GEqualChart.Legends.Add(legend5);
            this.GEqualChart.Location = new System.Drawing.Point(12, 40);
            this.GEqualChart.Name = "GEqualChart";
            series5.BackImageTransparentColor = System.Drawing.Color.White;
            series5.BackSecondaryColor = System.Drawing.Color.White;
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.Green;
            series5.Legend = "Legend1";
            series5.Name = "Components";
            this.GEqualChart.Series.Add(series5);
            this.GEqualChart.Size = new System.Drawing.Size(1326, 300);
            this.GEqualChart.TabIndex = 5;
            this.GEqualChart.Text = "chart1";
            this.GEqualChart.Visible = false;
            // 
            // BEqualChart
            // 
            chartArea6.Name = "ChartArea1";
            this.BEqualChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.BEqualChart.Legends.Add(legend6);
            this.BEqualChart.Location = new System.Drawing.Point(12, 40);
            this.BEqualChart.Name = "BEqualChart";
            series6.BackImageTransparentColor = System.Drawing.Color.White;
            series6.BackSecondaryColor = System.Drawing.Color.White;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Components";
            this.BEqualChart.Series.Add(series6);
            this.BEqualChart.Size = new System.Drawing.Size(1326, 300);
            this.BEqualChart.TabIndex = 6;
            this.BEqualChart.Text = "chart1";
            this.BEqualChart.Visible = false;
            // 
            // firstAverage
            // 
            this.firstAverage.AutoSize = true;
            this.firstAverage.Location = new System.Drawing.Point(79, 378);
            this.firstAverage.Name = "firstAverage";
            this.firstAverage.Size = new System.Drawing.Size(53, 13);
            this.firstAverage.TabIndex = 7;
            this.firstAverage.Text = "Порог 1: ";
            // 
            // secondAverage
            // 
            this.secondAverage.AutoSize = true;
            this.secondAverage.Location = new System.Drawing.Point(208, 378);
            this.secondAverage.Name = "secondAverage";
            this.secondAverage.Size = new System.Drawing.Size(50, 13);
            this.secondAverage.TabIndex = 8;
            this.secondAverage.Text = "Порог 2:";
            // 
            // thirdAverage
            // 
            this.thirdAverage.AutoSize = true;
            this.thirdAverage.Location = new System.Drawing.Point(333, 378);
            this.thirdAverage.Name = "thirdAverage";
            this.thirdAverage.Size = new System.Drawing.Size(50, 13);
            this.thirdAverage.TabIndex = 9;
            this.thirdAverage.Text = "Порог 3:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 450);
            this.Controls.Add(this.thirdAverage);
            this.Controls.Add(this.secondAverage);
            this.Controls.Add(this.firstAverage);
            this.Controls.Add(this.BEqualChart);
            this.Controls.Add(this.GEqualChart);
            this.Controls.Add(this.REqualChart);
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
            ((System.ComponentModel.ISupportInitialize)(this.REqualChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GEqualChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BEqualChart)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem showREqualHistButton;
        private System.Windows.Forms.ToolStripMenuItem showGEqualHistButton;
        private System.Windows.Forms.ToolStripMenuItem showBEqualHistButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart REqualChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart GEqualChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart BEqualChart;
        private System.Windows.Forms.Label firstAverage;
        private System.Windows.Forms.Label secondAverage;
        private System.Windows.Forms.Label thirdAverage;
    }
}

