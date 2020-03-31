using System;
using System.Collections.Generic;
using System.Text;

namespace AppToturial
{
    public class People
    {
        public string name { get; set; }
        public string icNumber { get; set; }
        public double id { get; set; }     

        public string textDisplay
        {
            get
            {
                return name + " . " + icNumber;
            }
        }

        public string detailsDisplay
        {
            get
            {
                return "The value for this person is :" + id.ToString("N");
            }
        }

    }
}
