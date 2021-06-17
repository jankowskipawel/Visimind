using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsWebApp.Models
{
    public class ListItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int ListId { get; set; }
        public bool IsDone { get; set; }
    }
}
