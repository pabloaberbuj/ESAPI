using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMS.TPS.Common.Model.API;


namespace VMS.TPS
{
    class Script
    {
        public Script()
        {
        }
        public void Execute(ScriptContext context)
        {
            VMS.TPS.Common.Model.API.Image imagen = context.PlanSetup.Beams.First().ReferenceImage;
            int x = imagen.XSize;
            int y = imagen.YSize;
            int z = imagen.ZSize;
            MessageBox.Show("Tamaño: (" + x.ToString() + ", " + y.ToString() + ", " + z.ToString() + ")");
            int[,] matrizXY = new int[x, y];
            int[,] matrizXZ = new int[x, y];
            int[,] matrizYZ = new int[y, z];
            try
            {
                imagen.GetVoxels(0, matrizXY);
                MessageBox.Show("Se pudo XY");
            }
            catch (Exception)
            {

                MessageBox.Show("El tamaño XY no es correcto");
            }

            try
            {
                imagen.GetVoxels(0, matrizXZ);
                MessageBox.Show("Se pudo XZ");
            }
            catch (Exception)
            {

                MessageBox.Show("El tamaño XZ no es correcto");
            }

            try
            {
                imagen.GetVoxels(0, matrizYZ);
                MessageBox.Show("Se pudo YZ");
            }
            catch (Exception)
            {

                MessageBox.Show("El tamaño YZ no es correcto");
            }


            Bitmap bitmapXY = new Bitmap(x, y);
            Bitmap bitmapXZ = new Bitmap(x, z);
            Bitmap bitmapYZ = new Bitmap(y, z);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    bitmapXY.SetPixel(i, j, Color.FromArgb(matrizXY[i, j], matrizXY[i, j], matrizXY[i, j]));
                }
            }
            bitmapXY.Save("test.jpg", ImageFormat.Jpeg);
        }
    }
}