using System;
using System.Collections.Generic;

namespace BlazorServerArcane.XmlClasses {
    public class AchievementData {
        public string achievementName { get; set; }
        public string actionType { get; set; }
        public string achievementDescription { get; set; }
        public string count { get; set; }
        public string achievementUniqueID { get; set; }
        public string itemType { get; set; }
        public string itemCategory { get; set; }
        public string iconPath { get; set; }
        public string tier { get; set; }
    }

}