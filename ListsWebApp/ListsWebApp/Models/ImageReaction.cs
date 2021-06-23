using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListsWebApp.Models
{
    public class ImageReaction
    {
        public int Id { get; set; }
        public int GivenByUserId { get; set; }
        public int ListItemId { get; set; }
        public bool IsPositive { get; set; }
    }
}
