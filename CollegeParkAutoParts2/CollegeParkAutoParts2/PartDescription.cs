using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CollegeParkAutoParts2
{
    public class PartDescription
    {
        // These members will be used to define a car part
        private long ID;
        private int yr;
        private string mk;
        private string mdl;
        private string cat;
        private string name;
        private decimal price;

        public PartDescription()
        {
            this.ID = 0;
            this.yr = 1960;
            this.mk = "";
            this.mdl = "";
            this.name = "Unknown";
            this.price = 0.00M;
        }

        public PartDescription(long code, int year, string make,
                               string model, string type,
                               string desc, decimal UPrice)
        {
            this.ID = code;
            this.yr = year;
            this.mk = make;
            this.mdl = model;
            this.cat = type;
            this.name = desc;
            this.price = UPrice;
        }

        public long PartNumber
        {
            get { return ID; }
            set { ID = value; }
        }

        public int CarYear
        {
            get { return yr; }
            set { yr = value; }
        }

        public string Make
        {
            get { return mk; }
            set { mk = value; }
        }

        public string Model
        {
            get { return mdl; }
            set { mdl = value; }
        }

        public string Category
        {
            get { return cat; }
            set { cat = value; }
        }

        public string PartName
        {
            get { return name; }
            set { name = value; }
        }

        public decimal UnitPrice
        {
            get { return (price < 0) ? 0.00M : price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return this.PartNumber + " " +
                   this.CarYear.ToString() + " " +
                   this.Make + " " +
                   this.Model + " " +
                   this.Category + " " +
                   this.PartName + " " +
                   this.UnitPrice;
        }
    }
}
