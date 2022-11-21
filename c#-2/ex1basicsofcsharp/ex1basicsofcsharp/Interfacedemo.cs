using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1basicsofcsharp
{
    internal interface IUniversalRemote
    {
        public void switchOn();
        public void switchOff();
        public void changeChannel(String channel);
        public void changeVolume(int volume);
        //public string changechannel(string cahnnel)
        //public int changevolume(int volume)
        //another tv has to implement iIUniversalRemote
        
      
    }
    internal class TCL : IUniversalRemote
    {
        bool tvStatus = false;
        String Currentchannel = "Adithya";
        int currentvolume = 8;
        public void changeChannel(string channel)
        {
            Console.WriteLine("*****TCL TV*****");
            Console.WriteLine("Current Channel: "+Currentchannel);
            Currentchannel = channel;
            Console.WriteLine($"Channel changed to: {Currentchannel}");
        }

        public void changeVolume(int volume)
        {
            volume = Convert.ToInt32(volume);

            Console.WriteLine("Current Volume: " + currentvolume);
            currentvolume += volume;
            Console.WriteLine("Volume Increased: " + currentvolume);
        }

        public void switchOff()
        {
            if (tvStatus)
            {
                tvStatus = false;
                Console.WriteLine("TCL Tv is Switched Off");
            }
            else
            {
                Console.WriteLine("TCL TV is already switchedOff ");
            }
        }

        public void switchOn()
        {
            if (!tvStatus)
            {
                tvStatus = true;
                Console.WriteLine("TCL Tv is Switched on");
            }
            else
            {
                Console.WriteLine("TCL TV is already SwitchedOn");
            }
            //throw new NotImplementedException();
        }
    }
    internal class sonyTv : IUniversalRemote
    {

        bool tvStatus = false;
        String Currentchannel = "KTV";
        int currentvolume = 10;

        

        public void changeChannel(string channel)
        {
            Console.WriteLine("*****SONY TV*****");
            Console.WriteLine($"Current channel is: {Currentchannel}");
            Currentchannel = channel;
            Console.WriteLine($"Channel Changed to: {Currentchannel}");
            //throw new NotImplementedException();
        }

       


        public void changeVolume(int volume)
        {
            volume = Convert.ToInt32(volume);
           
                Console.WriteLine("Current Volume: "+currentvolume);
                currentvolume += volume;
                Console.WriteLine("Volume Increased: "+currentvolume);
            
            
           
            //throw new NotImplementedException();
        }

        public void switchOff()
        {
            if (tvStatus)
            {
                tvStatus = false;
                Console.WriteLine("Sony Tv is Switched Off");
            }
            else
            {
                Console.WriteLine("Sony Tv is already switchedOff ");
            }
            //throw new NotImplementedException();
        }

        public void switchOn()
        {
            if (!tvStatus)
            {
                tvStatus=true;
                Console.WriteLine("Sony Tv is Switched on");
            }
            else
            {
                Console.WriteLine("Sony TV is already SwitchedOn");
            }
            //throw new NotImplementedException();
        }
    }

    internal class Interfacedemo
    {
        public static void interfacetest()
        {
            IUniversalRemote iURemote = new sonyTv();
            iURemote.changeChannel("SunTV");
            iURemote.changeVolume(3);
            iURemote.switchOn();
            iURemote.switchOff();
            iURemote = new TCL();
            iURemote.changeChannel("Discovery");
            iURemote.changeVolume(20);
            iURemote.switchOn();
            iURemote.switchOff();

        }
    }
}
