using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouristGuide.WinForms
{
    public static class Session
    {
        public static bool IsVisitor { get; set; }
        public static int UserId { get; set; }
        public static string Username { get; set; }
    }
}
