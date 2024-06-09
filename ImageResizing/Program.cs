// Developed with Visual Studio 2015 PRO
//
// Required 
// .NET Framework 4.6.1
// OpenCvSharp4 4.2.0.20200108
// OpenCvSharp4.runtime.win 4.2.0.20200108


using OpenCvSharp;
using System;

namespace ImageResizing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Caminho para a imagem de entrada
            string inputImagePath = "./image/chip01.jpg";

            // Carregar a imagem de entrada
            Mat srcImage = Cv2.ImRead(inputImagePath, ImreadModes.Color);

            // Verificar se a imagem foi carregada corretamente
            if (srcImage.Empty())
            {
                Console.WriteLine("Não foi possível carregar a imagem.");
                return;
            }

            // Dimensões da imagem de saída
            int outputWidth = 512;
            int outputHeight = 512;

            // Mat para armazenar a imagem redimensionada
            Mat dstImage = new Mat();

            // Redimensionar a imagem
            Cv2.Resize(srcImage, dstImage, new Size(outputWidth, outputHeight), 0, 0, InterpolationFlags.Linear);

            // Caminho para salvar a imagem redimensionada
            string outputImagePath = "./image/chip01_512x512.jpg";

            // Salvar a imagem redimensionada
            Cv2.ImWrite(outputImagePath, dstImage);

            Console.WriteLine("Imagem redimensionada salva com sucesso.");
        }
    }
}
