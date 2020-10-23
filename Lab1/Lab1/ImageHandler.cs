using System;
using System.Drawing;

namespace Lab1
{
    public static class ImageHandler
    {
        private const int MAX_RGB_VALUE = 255;
        private const int MIN_RGB_VALUE = 0;

        public static Bitmap AddConst(Bitmap image, int term)
        {
            for (int width = 0; width < image.Size.Width; width++)
            {
                for (int height = 0; height < image.Size.Height; height++)
                {
                    Color pixel = image.GetPixel(width, height);
                    int alpha = pixel.A;
                    int red = CheckValue(pixel.R + term);
                    int green = CheckValue(pixel.G + term);
                    int blue = CheckValue(pixel.B + term);

                    Color newColor = Color.FromArgb(alpha, red, green, blue);
                    image.SetPixel(width, height, newColor);
                }
            }
            return image;
        }

        public static Bitmap MultByConst(Bitmap image, int multiplier)
        {
            for (int width = 0; width < image.Size.Width; width++)
            {
                for (int height = 0; height < image.Size.Height; height++)
                {
                    Color pixel = image.GetPixel(width, height);
                    int alpha = pixel.A;
                    int red = CheckValue(pixel.R * multiplier);
                    int green = CheckValue(pixel.G * multiplier);
                    int blue = CheckValue(pixel.B * multiplier);

                    Color newColor = Color.FromArgb(alpha, red, green, blue);
                    image.SetPixel(width, height, newColor);
                }
            }
            return image;
        }

        public static Bitmap LogTransform(Bitmap image)
        {
            int maxR = 0, maxG = 0, maxB = 0;

            for (int width = 0; width < image.Size.Width; width++)
            {
                for (int height = 0; height < image.Size.Height; height++)
                {
                    Color pixel = image.GetPixel(width, height);

                    maxR = pixel.R > maxR ? pixel.R : maxR;
                    maxG = pixel.G > maxG ? pixel.G : maxG;
                    maxB = pixel.B > maxB ? pixel.B : maxB;
                }
            }

            for (int width = 0; width < image.Size.Width; width++)
            {
                for (int height = 0; height < image.Size.Height; height++)
                {
                    Color pixel = image.GetPixel(width, height);

                    int alpha = pixel.A;
                    int red = CheckValue((int)(MAX_RGB_VALUE * Math.Log10(1 + pixel.R) / Math.Log10(1 + maxR)));
                    int green = CheckValue((int)(MAX_RGB_VALUE * Math.Log10(1 + pixel.G) / Math.Log10(1 + maxG)));
                    int blue = CheckValue((int)(MAX_RGB_VALUE * Math.Log10(1 + pixel.B) / Math.Log10(1 + maxB)));

                    Color newColor = Color.FromArgb(alpha, red, green, blue);
                    image.SetPixel(width, height, newColor);
                }
            }
            return image;
        }

        public static Bitmap PowerTransform(Bitmap image, int power)
        {
            for (int width = 0; width < image.Size.Width; width++)
            {
                for (int height = 0; height < image.Size.Height; height++)
                {
                    Color pixel = image.GetPixel(width, height);
                    int alpha = pixel.A;
                    int red = CheckValue((int)Math.Pow(pixel.R, power));
                    int green = CheckValue((int)Math.Pow(pixel.G, power));
                    int blue = CheckValue((int)Math.Pow(pixel.B, power));

                    Color newColor = Color.FromArgb(alpha, red, green, blue);
                    image.SetPixel(width, height, newColor);
                }
            }
            return image;
        }

        public static Bitmap TransformToNegative(Bitmap image)
        {
            for (int width = 0; width < image.Size.Width; width++)
            {
                for (int height = 0; height < image.Size.Height; height++)
                {
                    Color pixel = image.GetPixel(width, height);
                    int alpha = pixel.A;
                    int red = MAX_RGB_VALUE - pixel.R;
                    int green = MAX_RGB_VALUE - pixel.G;
                    int blue = MAX_RGB_VALUE - pixel.B;

                    Color newColor = Color.FromArgb(alpha, red, green, blue);
                    image.SetPixel(width, height, newColor);
                }
            }
            return image;
        }

        private static int CheckValue(int value)
        {
            if(value > MAX_RGB_VALUE)
            {
                return MAX_RGB_VALUE;
            }
            if(value < MIN_RGB_VALUE)
            {
                return MIN_RGB_VALUE;
            }

            return value;
        }
    }
}