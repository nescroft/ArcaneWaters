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

        public CraftingItemsXml(string title, string body)
        {
            Title = title;
            Body = body;
            DateCreated = DateTime.UtcNow;
        }
    }
}
