using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;


namespace SubconverterTools.Utils
{
    /// <summary>
    /// 二维码工具
    /// </summary>
    public class QRCode
    {
        /// <summary>
        /// 生成二维码
        /// </summary>
        /// <param name="text"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Bitmap GenerateQRCode(string text, int width = 600, int height = 600)
        {
            if (text == string.Empty) {
                return null;
            }
            // 创建二维码生成器
            var qr = new QRCodeWriter();
            // 使用QRCodeWriter对象的encode方法生成QR Code的位矩阵
            var qrBitMatrix = qr.encode(text, BarcodeFormat.QR_CODE, width, height);
            // 创建Bitmap
            var bitmap = new Bitmap(width, height);
            // 将位矩阵转换为Bitmap
            for (int x = 0; x < qrBitMatrix.Width; x++)
            {
                for (int y = 0; y < qrBitMatrix.Height; y++)
                {
                    Color color = qrBitMatrix[x, y] ? Color.Black : Color.White;
                    bitmap.SetPixel(x, y, color);
                }
            }
            return bitmap;
        }
    }
}
