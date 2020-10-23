using System.Drawing;


namespace Lab1
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Bitmap firstImage = new Bitmap(Properties.Resources.SadChelDepressed);

            Bitmap newImage = ImageHandler.MultByConst(firstImage, 2);
            newImage.Save("MultByConst.bmp");

            newImage = ImageHandler.AddConst(firstImage, 150);
            newImage.Save("AddConst.bmp");

            newImage = ImageHandler.LogTransform(firstImage);
            newImage.Save("LogTranform2.bmp");

            newImage = ImageHandler.PowerTransform(firstImage, 3);
            newImage.Save("PowerTransform.bmp");

            newImage = ImageHandler.TransformToNegative(firstImage);
            newImage.Save("Negative.bmp");
        }
    }
}