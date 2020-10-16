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
            for (int width = 0; width < image.Size.Width; width++)
            {
                for (int height = 0; height < image.Size.Height; height++)
                {
                    Color pixel = image.GetPixel(width, height);
                    int alpha = pixel.A;
                    int red = CheckValue((int)Math.Log10(1 + pixel.R));
                    int green = CheckValue((int)Math.Log10(1 + pixel.G));
                    int blue = CheckValue((int)Math.Log10(1 + pixel.B));

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