using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleControlField.Enumerators;

namespace SimpleControlField.Models
{
    class Something
    {
        public string Description { get; set; }
        public string Status { get; set; }
        public string Revision { get; set; }
        public string PartNumber { get; set; }
        public SthMaterialEnum Material { get; set; }
        public bool Weld { get; set; }
        public bool Assembly { get; set; }
        public bool Plasma { get; set; }
        public bool Laser { get; set; }
        public bool Purchase { get; set; }
        public bool Lathe { get; set; }
        public bool Drill { get; set; }
        public bool Fold { get; set; }
        public bool Roll { get; set; }
        public bool Saw { get; set; }
        public string Length { get; set; }
        public string Weight { get; set; }
        public string SupplierName { get; set; }
        public string SupplierCode { get; set; }


    }
}
