using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Device classı var
//Width, Height, Weight field-ları olur.
//OpenDevice və CloseDevice voidləri var.
//Əgər DeviceOpen ilk dəfə və ya DeviceClose methodundan sonra işlənirsə ekrana “Device opening…” yazısını versin.
//Əgər bir neçə dəfə ardıcıl olaraq çağırılıbsa “Device already opened” yazılsın.
//Qanuna uyğunluq DeviceClose voidi üçün də keçərlidir.


namespace Devices.Models
{
    internal class Device
    {
        public double Width;
        public double Height;
        public double Weight;
        public bool isOpened = false;
        
        
        public Device(double width, double height, double weight)
        {
            Width = width;
            Height = height;
            Weight = weight;
        }





        public  void OpenDevice()
        {
            if (!isOpened)
            {
                Console.WriteLine("Device opening...");
                isOpened = true;
            }
            else
            {
                Console.WriteLine("Device already opened");
            }
        }

        public  void CloseDevice()
        {
            if (isOpened)
            {
                Console.WriteLine("Device closing...");
                isOpened = false;
            }
            else
            {
                Console.WriteLine("Device already closed");
            }


        }
    }
}
