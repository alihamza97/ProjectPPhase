using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Phidget22;
using Phidget22.Events;

namespace MetisMercury.Classes
{
    class phidget
    {
        public RFID RFID;
        public String TagNr;
        public string ScanNr;
        public string PresentStatus;

      

          public void ProcessTheTag(object sender, RFIDTagEventArgs e)
        {
            TagNr = e.Tag.ToString();
        }
        //contructor
        public phidget()
        {
            try
            {
                RFID = new RFID();
                RFID.Tag += new RFIDTagEventHandler(ProcessTheTag);
            }
            catch(PhidgetException)
            {
                PresentStatus = "Something's wrong";
            }
        }

        public void OpenRFID()
        {
            try
            {
                RFID.Open();
                RFID.AntennaEnabled = true;
                RFID.DeviceSerialNumber.ToString();
                

                PresentStatus = "Rfid Found";
          //      RFID.LED = true;
           
            }
            catch(PhidgetException)
            {
                PresentStatus = "There is no Reader Found";
            }

        }
        public void CloseRFID()
        {
            try
            {
                
                RFID.AntennaEnabled = false;
                RFID.Close();
                PresentStatus = "RFID has been Closed";
            }
            catch (PhidgetException)
            {
                PresentStatus = "No RFID attached,Please Check your Connection";
            }
        }

    }
}
