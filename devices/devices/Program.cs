using devices.Models;
using Devices.Models;

namespace Devices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Device device = new Device(12, 13, 4);
            device.CloseDevice();
            device.OpenDevice();
            device.OpenDevice();
            device.CloseDevice();

            Mobile mobile = new Mobile(2, 23, 43, 33);
            mobile.AddNumber();

            mobile.GetNumber();

            mobile.RemoveNumber(1);
            mobile.GetNumber();

            mobile.AddNumber();
            mobile.RemoveNumIndex(0);
            mobile.GetNumber();




































        }

      
    }
}
//Device-ı inherit edən Mobile və Laptop classları var.
//Mobile :
//string[] SimCards field-ı var.
//Mobile classından obyekt yaranan zaman SimCardCount parametrini məcbur qəbul edir. SimCardCount minimum 1 maksimum 2 ola bilər. Bu parametr SimCards field-inin uzunluğunu təyin edir.
//AddNumber, RemoveNumber, GetNumbers methodları ilə istifadəçi nömrələrə baxa, nömrə əlavə və ya nömrənin indeksini bildirərək silə bilər.
//Laptop :
//PortCount field-ı var.

//Width, Height, Weight bildirmədən Laptop və ya Mobile yaratmaq olmasın