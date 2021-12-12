using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTCafeApi.Model.Stage._4___Fermentation.Entities
{
    public class FermentationEntites
    {
        public int Fermentationid { get; set; }
        public DateTime Fermentationdate { get; set; }
        public decimal Fermentationbrix { get; set; }
        public decimal Fermentationph { get; set; }
        public string Fermentationphoto { get; set; }
        public int Fermentationplotid { get; set; }
        public bool Fermentationstatus { get; set; }
    }
}
