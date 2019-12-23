using System;
using System.Collections.Generic;

namespace BlazorServerArcane.Models
{
    public partial class CraftingItems
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Category { get; set; }
        public int? ItemTypeId { get; set; }
        public string ItemType { get; set; }
    }
}
