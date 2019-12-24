using System;
using System.Collections.Generic;

namespace BlazorServerArcane.Models
{
    public partial class CraftingItemsXml
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime? DateCreated { get; set; }
    }
}
