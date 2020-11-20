using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private const byte MAX_VALUE = 255;
        private const byte MIN_VALUE = 0;
        private const byte FIXED_MAX_VALUE = 255;
        private const byte FIXED_MIN_VALUE = 0;

        private readonly Bitmap _image;

        private int[] histDataR;
        private int[] histDataG;
        private int[] histDataB;

        private int[] equalHistDataR;
        private int[] equalHistDataG;
        private int[] equalHistDataB;

        private int[,] gradient;
        private Chart currentChart;

        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            _image = new Bitmap(Properties.Resources.aquared);

            histDataR = new int[256];
            histDataG = new int[256];
            histDataB = new int[256];

            equalHistDataR = new int[256];
            equalHistDataG = new int[256];
            equalHistDataB = new int[256];
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            GetHistData();
            GetEqualHistData();

            DrawHist(histDataR, RChart);
            DrawHist(histDataG, GChart);
            DrawHist(histDataB, BChart);

            DrawHist(equalHistDataR, REqualChart);
            DrawHist(equalHistDataG, GEqualChart);
            DrawHist(equalHistDataB, BEqualChart);

            LinearContrast();

            GetImages();

            GetAverage();

            CountGradient();

            GetProbability();

            RChart.Show();
            currentChart = RChart;
            startButton.Enabled = false;
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
        }

        private void GetEqualHistData()
        {
            Bitmap equalImage = new Bitmap(Properties.Resources.aquared);

            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            int[] minR = new int[256];
            int[] maxR = new int[256];
            int[] newR = new int[256];
            int currentR = 0;

            int[] minG = new int[256];
            int[] maxG = new int[256];
            int[] newG = new int[256];
            int currentG = 0;

            int[] minB = new int[256];
            int[] maxB = new int[256];
            int[] newB = new int[256];
            int currentB = 0;

            int pixelAverage = (equalImage.Width * equalImage.Height) / (MAX_VALUE + 1);

            for (int i = 0; i <= MAX_VALUE; i++)
            {
                minR[i] = currentR;
                sumR += histDataR[i];
                while(sumR > pixelAverage)
                {
                    sumR -= pixelAverage;
                    if (currentR < 255)
                    {
                        currentR++;
                    }
                }

                maxR[i] = currentR;
                newR[i] = maxR[i] - minR[i];

                minG[i] = currentG;
                sumG += histDataG[i];
                while (sumG > pixelAverage)
                {
                    sumG -= pixelAverage;
                    if (currentG < 255)
                    {
                        currentG++;
                    }
                }

                maxG[i] = currentG;
                newG[i] = maxG[i] - minG[i];

                minB[i] = currentB;
                sumB += histDataB[i];
                while (sumB > pixelAverage)
                {
                    sumB -= pixelAverage;
                    if (currentB < 255)
                    {
                        currentB++;
                    }
                }

                maxB[i] = currentB;
                newB[i] = maxB[i] - minB[i];
            }

            for (int width = 0; width < equalImage.Size.Width; width++)
            {
                for (int height = 0; height < equalImage.Size.Height; height++)
                {
                    Color pixel = equalImage.GetPixel(width, height);

                    int alpha = pixel.A;
                    int red;
                    if (minR[pixel.R] == maxR[pixel.R])
                    {
                        red = minR[pixel.R];
                    }
                    else
                    {
                        red = minR[pixel.R] + rand.Next(newR[pixel.R] + 1);
                    }
                    equalHistDataR[red]++;

                    int green;
                    if (minG[pixel.G] == maxG[pixel.G])
                    {
                        green = minG[pixel.G];
                    }
                    else
                    {
                        green = minG[pixel.G] + rand.Next(newG[pixel.G] + 1);
                    }
                    equalHistDataG[green]++;

                    int blue;
                    if (minB[pixel.B] == maxB[pixel.B])
                    {
                        blue = minB[pixel.B];
                    }
                    else
                    {
                        blue = minB[pixel.B] + rand.Next(newB[pixel.B] + 1);
                    }
                    equalHistDataB[blue]++;

                    Color newColor = Color.FromArgb(alpha, red, green, blue);
                    equalImage.SetPixel(width, height, newColor);
                }
            }

            equalImage.Save("EqualizedImage.bmp");
        }

        private void LinearContrast()
        {
            Bitmap newImage = new Bitmap(Properties.Resources.aquared);

            int maxR = GetMaxValue(histDataR);
            int minR = GetMinValue(histDataR);

            int maxG = GetMaxValue(histDataG);
            int minG = GetMinValue(histDataG);

            int maxB = GetMaxValue(histDataB);
            int minB = GetMinValue(histDataB);

            for (int width = 0; width < newImage.Size.Width; width++)
            {
                for (int height = 0; height < newImage.Size.Height; height++)
                {
                    Color pixel = newImage.GetPixel(width, height);
                    int alpha = pixel.A;
                    int red = (pixel.R - minR) * (FIXED_MAX_VALUE - FIXED_MIN_VALUE) / (maxR - minR) + FIXED_MIN_VALUE;
                    int green = (pixel.G - minG) * (FIXED_MAX_VALUE - FIXED_MIN_VALUE) / (maxG - minG) + FIXED_MIN_VALUE;
                    int blue = (pixel.B - minB) * (FIXED_MAX_VALUE - FIXED_MIN_VALUE) / (maxB - minB) + FIXED_MIN_VALUE;

                    Color newColor = Color.FromArgb(alpha, red, green, blue);
                    newImage.SetPixel(width, height, newColor);
                }
            }
            newImage.Save("LinearContrast.bmp");
        }

        private void GetImages()
        {
            Bitmap newImage = new Bitmap(Properties.Resources.cakes);

            List<Bitmap> images = new List<Bitmap>();

            for (int i = 0; i < 8; i++)
            {
                images.Add(new Bitmap(Properties.Resources.cakes));
            }

            int alpha;
            int red;
            int green;
            int blue;

            for (int width = 0; width < newImage.Size.Width; width++)
            {
                for (int height = 0; height < newImage.Size.Height; height++)
                {
                    Color pixel = newImage.GetPixel(width, height);

                    char[] binaryR = ConvertToBinary(pixel.R);
                    char[] binaryG = ConvertToBinary(pixel.G);
                    char[] binaryB = ConvertToBinary(pixel.B);

                    for(int k = 0; k < 8; k++)
                    {
                        alpha = pixel.A;
                        red = binaryR[k] == '1' ? (int)Math.Pow(2, 7 - k) : 0;
                        green = binaryG[k] == '1' ? (int)Math.Pow(2, 7 - k) : 0;
                        blue = binaryB[k] == '1' ? (int)Math.Pow(2, 7 - k) : 0;

                        Color newColor = Color.FromArgb(alpha, red, green, blue);
                        images[7 - k].SetPixel(width, height, newColor);
                    }
                }
            }

            int counter = 1; 
            foreach(Bitmap image in images)
            {
                image.Save($"image{counter++}.bmp");
            }
        }

        private void GetAverage()
        {
            int brightnessSum = 0;
            int lowerSum = 0;
            int lowerCount = 0;
            int upperSum = 0;
            int upperCount = 0;

            for (int i = 0; i < histDataR.Length; i++)
            {
                brightnessSum += i * histDataR[i];
            }

            int average = brightnessSum / (_image.Width * _image.Height);
            int previousAverage;

            do
            {
                lowerSum = 0;
                lowerCount = 0;
                upperSum = 0;
                upperCount = 0;

                for (int width = 0; width < _image.Size.Width; width++)
                {
                    for (int height = 0; height < _image.Size.Height; height++)
                    {
                        Color pixel = _image.GetPixel(width, height);

                        if (pixel.R < average)
                        {
                            lowerSum += pixel.R;
                            lowerCount++;
                        }
                        else
                        {
                            upperSum += pixel.R;
                            upperCount++;
                        }
                    }
                }

                previousAverage = average;

                average = (upperSum / upperCount + lowerSum / lowerCount) / 2;
            }
            while (Math.Abs(previousAverage - average) >= 1);

            firstAverage.Text += $" {average}";
        }

        private void CountGradient()
        {
            gradient = new int[_image.Width, _image.Height];
            int gradX = 0;
            int gradY = 0;

            for (int i = 1; i < _image.Width - 1; i++)
            {
                for (int j = 1; j < _image.Height - 1; j++)
                {
                    gradX = Math.Abs(_image.GetPixel(i + 1, j).R - _image.GetPixel(i - 1, j).R);
                    gradY = Math.Abs(_image.GetPixel(i, j + 1).R - _image.GetPixel(i, j - 1).R);

                    if (gradX > gradY)
                    {
                        gradient[i, j] = gradX;
                    }
                    else
                    {
                        gradient[i, j] = gradY;
                    }
                }
            }

            for (int i = 1; i < _image.Width - 1; i++)
            {
                gradX = Math.Abs(_image.GetPixel(i + 1, 0).R - _image.GetPixel(i - 1, 0).R);
                gradY = Math.Abs(_image.GetPixel(i, 1).R - _image.GetPixel(i, 0).R);

                if (gradX > gradY)
                {
                    gradient[i, 0] = gradX;
                }
                else
                {
                    gradient[i, 0] = gradY;
                }
            }

            for (int i = 1; i < _image.Width - 1; i++)
            {
                gradX = Math.Abs(_image.GetPixel(i + 1, _image.Height - 1).R - _image.GetPixel(i - 1, _image.Height - 1).R);
                gradY = Math.Abs(_image.GetPixel(i, _image.Height - 1).R - _image.GetPixel(i, _image.Height - 2).R);

                if (gradX > gradY)
                {
                    gradient[i, _image.Height - 1] = gradX;
                }
                else
                {
                    gradient[i, _image.Height - 1] = gradY;
                }
            }

            for (int j = 1; j < _image.Height - 1; j++)
            {
                gradX = Math.Abs(_image.GetPixel(1, j).R - _image.GetPixel(0, j).R);
                gradY = Math.Abs(_image.GetPixel(0, j + 1).R - _image.GetPixel(0, j - 1).R);

                if (gradX > gradY)
                {
                    gradient[0, j] = gradX;
                }
                else
                {
                    gradient[0, j] = gradY;
                }
            }

            for (int j = 1; j < _image.Height - 1; j++)
            {
                gradX = Math.Abs(_image.GetPixel(_image.Width - 1, j).R - _image.GetPixel(_image.Width - 2, j).R);
                gradY = Math.Abs(_image.GetPixel(_image.Width - 1, j + 1).R - _image.GetPixel(_image.Width - 1, j - 1).R);

                if (gradX > gradY)
                {
                    gradient[_image.Width - 1, j] = gradX;
                }
                else
                {
                    gradient[_image.Width - 1, j] = gradY;
                }
            }

            gradX = Math.Abs(_image.GetPixel(1, 0).R - _image.GetPixel(1, 0).R);
            gradY = Math.Abs(_image.GetPixel(0, 1).R - _image.GetPixel(0, 0).R);
            if (gradX > gradY)
            {
                gradient[0, 0] = gradX;
            }
            else
            {
                gradient[0, 0] = gradY;
            }

            gradX = Math.Abs(_image.GetPixel(_image.Width - 1, 0).R - _image.GetPixel(_image.Width - 2, 0).R);
            gradY = Math.Abs(_image.GetPixel(_image.Width - 1, 1).R - _image.GetPixel(_image.Width - 1, 0).R);
            if (gradX > gradY)
            {
                gradient[_image.Width - 1, 0] = gradX;
            }
            else
            {
                gradient[_image.Width - 1, 0] = gradY;
            }

            gradX = Math.Abs(_image.GetPixel(1, _image.Height - 1).R - _image.GetPixel(0, _image.Height - 1).R);
            gradY = Math.Abs(_image.GetPixel(0, _image.Height - 1).R - _image.GetPixel(0, _image.Height - 2).R);
            if (gradX > gradY)
            {
                gradient[0, _image.Height - 1] = gradX;
            }
            else
            {
                gradient[0, _image.Height - 1] = gradY;
            }

            gradX = Math.Abs(_image.GetPixel(_image.Width - 1, _image.Height - 1).R - _image.GetPixel(_image.Width - 2, _image.Height - 1).R);
            gradY = Math.Abs(_image.GetPixel(_image.Width - 1, _image.Height - 1).R - _image.GetPixel(_image.Width - 1, _image.Height - 2).R);
            if (gradX > gradY)
            {
                gradient[_image.Width - 1, _image.Height - 1] = gradX;
            }
            else
            {
                gradient[_image.Width - 1, _image.Height - 1] = gradY;
            }

            int gradientMultiplySum = 0;
            int gradientSum = 0;
            for (int i = 1; i < _image.Width - 1; i++)
            {
                for (int j = 1; j < _image.Height - 1; j++)
                {
                    gradientMultiplySum += _image.GetPixel(i, j).R * gradient[i, j];
                    gradientSum += gradient[i, j];
                }
            }

            int average = gradientMultiplySum / gradientSum;
            secondAverage.Text += $" {average}";
        }

        private void GetProbability()
        {
            double[] brightnessProbability = new double[256];

            int pixelsCount = _image.Width * _image.Height;

            for (int i = 0; i < brightnessProbability.Length; i++)
            {
                brightnessProbability[i] = (double)histDataR[i] / pixelsCount;
            }

            double lowerProb = 0;
            double upperProb = 0;

            double dispersion = 0;
            double maxDispersion = 0;

            int maxAverage = 0;

            double u0 = 0;
            double u1 = 0;

            for (int average = 0; average <= MAX_VALUE; average++)
            {
                for (int i = 0; i <= average; i++)
                {
                    lowerProb += brightnessProbability[i];
                }

                for (int i = average + 1; i < brightnessProbability.Length; i++)
                {
                    upperProb += brightnessProbability[i];
                }

                u0 = 0;
                u1 = 0;

                for (int i = 0; i <= average; i++)
                {
                    u0 += i * brightnessProbability[i] / lowerProb;
                }

                for (int i = average + 1; i < brightnessProbability.Length; i++)
                {
                    u1 += i * brightnessProbability[i] / upperProb;
                }

                dispersion = lowerProb * upperProb * Math.Pow((u0 - u1), 2);

                if(maxDispersion < dispersion)
                {
                    maxDispersion = dispersion;
                    maxAverage = average;
                }
            }

            thirdAverage.Text += $" {maxAverage}";
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

        private int GetMinValue(int[] data)
        {
            int i = MIN_VALUE;

            while(true)
            {
                if(data[i] != 0)
                {
                    return i;
                }
                i++;
            }
        }

        private int GetMaxValue(int[] data)
        {
            int i = MAX_VALUE;

            while (true)
            {
                if (data[i] != 0)
                {
                    return i;
                }
                i--;
            }
        }

        private char[] ConvertToBinary(int number)
        {
            StringBuilder binary = new StringBuilder();
            while(number > 1)
            {
                binary.Append(number % 2);
                number /= 2;
            }
            binary.Append(number);

            while(binary.Length < 8)
            {
                binary.Append(0);
            }

            char[] charArray = binary.ToString().ToCharArray();
            Array.Reverse(charArray);
            return charArray;
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

        private void showREqualHistButton_Click(object sender, EventArgs e)
        {
            ChangeHist(REqualChart);
        }

        private void showGEqualHistButton_Click(object sender, EventArgs e)
        {
            ChangeHist(GEqualChart);
        }

        private void showBEqualHistButton_Click(object sender, EventArgs e)
        {
            ChangeHist(BEqualChart);
        }
    }
}