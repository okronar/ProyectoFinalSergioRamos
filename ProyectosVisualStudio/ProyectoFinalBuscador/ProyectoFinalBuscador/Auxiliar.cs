using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalBuscador
{
    internal class Auxiliar
    {
        public static String imgToString(Bitmap img) {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, ImageFormat.Png);

            byte[] arr = ms.GetBuffer();
            string output = Convert.ToBase64String(arr);
            return output;
            
        }

        public static Bitmap stringToImg (string consultaSql)
        {
            byte[] arr = Convert.FromBase64String(consultaSql);

            MemoryStream ms = new MemoryStream();
            ms.Write(arr, 0, Convert.ToInt32(arr.Length));

            Bitmap bm = new Bitmap(ms, false);
            ms.Dispose();
            return bm;
        }

    }
}
