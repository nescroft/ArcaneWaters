using System;
using System.Collections.Generic;

namespace BlazorServerArcane.Models
{
    public partial class Users
    {
        public int UsrId { get; set; }
        public int AccId { get; set; }
        public string UsrName { get; set; }
        public int ShpId { get; set; }
        public int UsrGender { get; set; }
        public uint BodyType { get; set; }
        public int IsOnline { get; set; }
        public int UsrAdminFlag { get; set; }
        public int ArmId { get; set; }
        public int WpnId { get; set; }
        public int AreaId { get; set; }
        public decimal LocalX { get; set; }
        public decimal LocalY { get; set; }
        public int UsrFacing { get; set; }
        public int UsrXp { get; set; }
        public int UsrGold { get; set; }
        public int HairType { get; set; }
        public int HairColor1 { get; set; }
        public int HairColor2 { get; set; }
        public int EyesType { get; set; }
        public int EyesColor1 { get; set; }
        public int EyesColor2 { get; set; }
        public int NatType { get; set; }
        public int UsrTradePermits { get; set; }
        public DateTime UsrCreationTime { get; set; }
        public short CharSpot { get; set; }
        public short Class { get; set; }
        public short Specialty { get; set; }
        public short Faction { get; set; }
        public int GldId { get; set; }
    }
}
