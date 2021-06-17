using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace ListsWebApp.Models
{
    public class ListWA
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
