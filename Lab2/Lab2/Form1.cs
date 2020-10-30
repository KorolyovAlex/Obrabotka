using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly Bitmap _image;

        private int[] histDataR;
        private int[] histDataG;
        private int[] histDataB;
        private Chart currentChart;

        public Form1()
        {
            InitializeComponent();

            _image = new Bitmap(Properties.Resources.cakes);

            histDataR = new int[256];
            histDataG = new int[256];
            histDataB = new int[256];
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GetHistData();

            DrawHist(histDataR, RChart);
            DrawHist(histDataG, GChart);
            DrawHist(histDataB, BChart);

            RChart.Show();
            currentChart = RChart;
        }

        private void GetHistData()
        {
            for (int width = 0; width < _image.Size.Width; width++)
            {
                for (int height = 0; height < _image.Size.Height; height++)
                {
                    Color pixel = _image.GetPixel(width, height);
                    histDataR[pixel.R]++;
                    histDataG[pixel.G]++;
                    histDataB[pixel.B]++;
                }
            }

            DrawHist(histDataR, RChart);
        }

        private void DrawHist(int[] histData, Chart chart)
        {
            for(int i = 0; i < histData.Length; i++)
            {
                chart.Series["Components"].Points.AddXY(i, histData[i]);
            }
        }
        
        private void ChangeHist(Chart newChart)
        {
            currentChart.Hide();
            newChart.Show();
            currentChart = newChart;
        }

        private void showRHistButton_Click(object sender, EventArgs e)
        {
            ChangeHist(RChart);
        }

        private void showGHistButton_Click(object sender, EventArgs e)
        {
            ChangeHist(GChart);
        }

        private void showBHistButton_Click(object sender, EventArgs e)
        {
            ChangeHist(BChart);
        }
    }
}
