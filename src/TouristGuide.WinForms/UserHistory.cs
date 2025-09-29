using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristGuide.WinForms
{
    public class UserHistory
    {
        public int History_id { get; set; }
        public int User_id { get; set; }
        public int Item_id { get; set; }
        public DateTime Visited_at { get; set; }
    }
}
