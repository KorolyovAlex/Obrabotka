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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            chartArea7.Name = "ChartArea1";
            this.RChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.RChart.Legends.Add(legend7);
            this.RChart.Location = new System.Drawing.Point(12, 40);
            this.RChart.Name = "RChart";
            series7.BackImageTransparentColor = System.Drawing.Color.White;
            series7.BackSecondaryColor = System.Drawing.Color.White;
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.Name = "Components";
            this.RChart.Series.Add(series7);
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
            chartArea8.Name = "ChartArea1";
            this.GChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.GChart.Legends.Add(legend8);
            this.GChart.Location = new System.Drawing.Point(12, 40);
            this.GChart.Name = "GChart";
            series8.BackImageTransparentColor = System.Drawing.Color.White;
            series8.BackSecondaryColor = System.Drawing.Color.White;
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.Green;
            series8.Legend = "Legend1";
            series8.Name = "Components";
            this.GChart.Series.Add(series8);
            this.GChart.Size = new System.Drawing.Size(1326, 300);
            this.GChart.TabIndex = 2;
            this.GChart.Text = "chart1";
            this.GChart.Visible = false;
            // 
            // BChart
            // 
            chartArea9.Name = "ChartArea1";
            this.BChart.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.BChart.Legends.Add(legend9);
            this.BChart.Location = new System.Drawing.Point(12, 40);
            this.BChart.Name = "BChart";
            series9.BackImageTransparentColor = System.Drawing.Color.White;
            series9.BackSecondaryColor = System.Drawing.Color.White;
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.Blue;
            series9.Legend = "Legend1";
            series9.Name = "Components";
            this.BChart.Series.Add(series9);
            this.BChart.Size = new System.Drawing.Size(1326, 300);
            this.BChart.TabIndex = 3;
            this.BChart.Text = "chart1";
            this.BChart.Visible = false;
            // 
            // REqualChart
            // 
            chartArea10.Name = "ChartArea1";
            this.REqualChart.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.REqualChart.Legends.Add(legend10);
            this.REqualChart.Location = new System.Drawing.Point(12, 40);
            this.REqualChart.Name = "REqualChart";
            series10.BackImageTransparentColor = System.Drawing.Color.White;
            series10.BackSecondaryColor = System.Drawing.Color.White;
            series10.ChartArea = "ChartArea1";
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.Name = "Components";
            this.REqualChart.Series.Add(series10);
            this.REqualChart.Size = new System.Drawing.Size(1326, 300);
            this.REqualChart.TabIndex = 4;
            this.REqualChart.Text = "chart1";
            this.REqualChart.Visible = false;
            // 
            // GEqualChart
            // 
            chartArea11.Name = "ChartArea1";
            this.GEqualChart.ChartAreas.Add(chartArea11);
            legend11.Name = "Legend1";
            this.GEqualChart.Legends.Add(legend11);
            this.GEqualChart.Location = new System.Drawing.Point(12, 40);
            this.GEqualChart.Name = "GEqualChart";
            series11.BackImageTransparentColor = System.Drawing.Color.White;
            series11.BackSecondaryColor = System.Drawing.Color.White;
            series11.ChartArea = "ChartArea1";
            series11.Color = System.Drawing.Color.Green;
            series11.Legend = "Legend1";
            series11.Name = "Components";
            this.GEqualChart.Series.Add(series11);
            this.GEqualChart.Size = new System.Drawing.Size(1326, 300);
            this.GEqualChart.TabIndex = 5;
            this.GEqualChart.Text = "chart1";
            this.GEqualChart.Visible = false;
            // 
            // BEqualChart
            // 
            chartArea12.Name = "ChartArea1";
            this.BEqualChart.ChartAreas.Add(chartArea12);
            legend12.Name = "Legend1";
            this.BEqualChart.Legends.Add(legend12);
            this.BEqualChart.Location = new System.Drawing.Point(12, 40);
            this.BEqualChart.Name = "BEqualChart";
            series12.BackImageTransparentColor = System.Drawing.Color.White;
            series12.BackSecondaryColor = System.Drawing.Color.White;
            series12.ChartArea = "ChartArea1";
            series12.Color = System.Drawing.Color.Blue;
            series12.Legend = "Legend1";
            series12.Name = "Components";
            this.BEqualChart.Series.Add(series12);
            this.BEqualChart.Size = new System.Drawing.Size(1326, 300);
            this.BEqualChart.TabIndex = 6;
            this.BEqualChart.Text = "chart1";
            this.BEqualChart.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 450);
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
    }
}

