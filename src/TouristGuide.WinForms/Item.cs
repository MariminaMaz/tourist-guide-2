using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristGuide.WinForms
{
    public class Item      // συγκεκριμένο αντικείμενο μέσα σε Section
    {
        public int Item_id { get; set; }
        public int Section_id { get; set; }
        public string Item_name { get; set; }
        public string Description { get; set; }

    }
}
