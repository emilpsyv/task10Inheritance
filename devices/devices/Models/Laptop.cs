using Devices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Laptop :
//PortCount field-ı var.

//Width, Height, Weight bildirmədən Laptop və ya Mobile yaratmaq olmasın
namespace devices.Models
{
    internal class Laptop: Device
    {
        public int PortCount;



        public Laptop(int PortCount, double width, double height, double weight): base(width, height, weight)
        {
            this.PortCount = PortCount;
        }
            
        















    }
}
