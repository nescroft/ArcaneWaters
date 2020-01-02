using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazorServerArcane.Models {
    public partial class ebdbContext : DbContext {
        public ebdbContext () { }

        public ebdbContext (DbContextOptions<ebdbContext> options) : base (options) { }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<BugReports> BugReports { get; set; }
        public virtual DbSet<CraftingItems> CraftingItems { get; set; }
        public virtual DbSet<CraftingItemsXml> CraftingItemsXml { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql ("server=aa1bwrnvnw5kyje.cyeohcx9sfmp.us-east-2.rds.amazonaws.com;port=3306;database=ebdb;user=root;pwd=yXV8EPHxpBy", x => x.ServerVersion ("5.7.22-mysql"));
            }
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Accounts> (entity => {
                entity.HasKey (e => e.AccId)
                    .HasName ("PRIMARY");

                entity.ToTable ("accounts");

                entity.HasIndex (e => e.AccCode)
                    .HasName ("accCode");

                entity.HasIndex (e => e.AccEmail)
                    .HasName ("accEmail")
                    .IsUnique ();

                entity.HasIndex (e => e.AccLastUserId)
                    .HasName ("accLastUserId");

                entity.HasIndex (e => e.AccPassword)
                    .HasName ("accPassword");

                entity.HasIndex (e => e.AccValidated)
                    .HasName ("accValidated");

                entity.Property (e => e.AccId)
                    .HasColumnName ("accId")
                    .HasColumnType ("int(6)");

                entity.Property (e => e.AccCode)
                    .HasColumnName ("accCode")
                    .HasColumnType ("varchar(32)")
                    .HasCharSet ("utf8")
                    .HasCollation ("utf8_general_ci");

                entity.Property (e => e.AccCreationTime)
                    .HasColumnName ("accCreationTime")
                    .HasColumnType ("timestamp")
                    .HasDefaultValueSql ("CURRENT_TIMESTAMP");

                entity.Property (e => e.AccEmail)
                    .IsRequired ()
                    .HasColumnName ("accEmail")
                    .HasColumnType ("varchar(50)")
                    .HasCharSet ("utf8")
                    .HasCollation ("utf8_general_ci");

                entity.Property (e => e.AccGems)
                    .HasColumnName ("accGems")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.AccLastUserId)
                    .HasColumnName ("accLastUserId")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.AccName)
                    .IsRequired ()
                    .HasColumnName ("accName")
                    .HasColumnType ("varchar(20)")
                    .HasCharSet ("utf8")
                    .HasCollation ("utf8_general_ci");

                entity.Property (e => e.AccPassword)
                    .IsRequired ()
                    .HasColumnName ("accPassword")
                    .HasColumnType ("varchar(50)")
                    .HasCharSet ("utf8")
                    .HasCollation ("utf8_general_ci");

                entity.Property (e => e.AccStatus)
                    .HasColumnName ("accStatus")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.AccValidated)
                    .HasColumnName ("accValidated")
                    .HasColumnType ("tinyint(2)");
            });

            modelBuilder.Entity<BugReports> (entity => {
                entity.HasKey (e => e.BugId)
                    .HasName ("PRIMARY");

                entity.ToTable ("bug_reports");

                entity.HasIndex (e => e.BugSubject)
                    .HasName ("bugSubject");

                entity.HasIndex (e => e.BugTime)
                    .HasName ("bugTime");

                entity.HasIndex (e => e.UsrId)
                    .HasName ("usrId");

                entity.Property (e => e.BugId)
                    .HasColumnName ("bugId")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.BugLog)
                    .HasColumnName ("bugLog")
                    .HasColumnType ("mediumtext")
                    .HasCharSet ("utf8")
                    .HasCollation ("utf8_general_ci");

                entity.Property (e => e.BugSubject)
                    .IsRequired ()
                    .HasColumnName ("bugSubject")
                    .HasColumnType ("varchar(80)")
                    .HasCharSet ("utf8")
                    .HasCollation ("utf8_general_ci");

                entity.Property (e => e.BugTime)
                    .HasColumnName ("bugTime")
                    .HasColumnType ("timestamp")
                    .HasDefaultValueSql ("CURRENT_TIMESTAMP");

                entity.Property (e => e.UsrId)
                    .HasColumnName ("usrId")
                    .HasColumnType ("int(11)");
            });

            modelBuilder.Entity<CraftingItems> (entity => {
                entity.ToTable ("crafting_items");

                entity.Property (e => e.Id)
                    .HasColumnName ("id")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.Category)
                    .HasColumnName ("category")
                    .HasColumnType ("varchar(100)")
                    .HasCharSet ("utf8")
                    .HasCollation ("utf8_general_ci");

                entity.Property (e => e.CategoryId)
                    .HasColumnName ("category_id")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.ItemType)
                    .HasColumnName ("item_type")
                    .HasColumnType ("varchar(100)")
                    .HasCharSet ("utf8")
                    .HasCollation ("utf8_general_ci");

                entity.Property (e => e.ItemTypeId)
                    .HasColumnName ("item_type_id")
                    .HasColumnType ("int(11)");
            });

            modelBuilder.Entity<CraftingItemsXml> (entity => {
                entity.ToTable ("crafting_items_xml");

                entity.Property (e => e.Id)
                    .HasColumnName ("id")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.Body)
                    .HasColumnName ("body")
                    .HasColumnType ("text")
                    .HasCharSet ("latin1")
                    .HasCollation ("latin1_swedish_ci");

                entity.Property (e => e.DateCreated)
                    .HasColumnName ("date_created")
                    .HasColumnType ("datetime");

                entity.Property (e => e.Title)
                    .HasColumnName ("title")
                    .HasColumnType ("varchar(100)")
                    .HasCharSet ("latin1")
                    .HasCollation ("latin1_swedish_ci");
            });

            modelBuilder.Entity<Users> (entity => {
                entity.HasNoKey ();

                entity.ToTable ("users");

                entity.HasIndex (e => e.AccId)
                    .HasName ("accId");

                entity.HasIndex (e => e.ArmId)
                    .HasName ("armId");

                entity.HasIndex (e => e.BodyType)
                    .HasName ("usrRace");

                entity.HasIndex (e => e.IsOnline)
                    .HasName ("isOnline");

                entity.HasIndex (e => e.NatType)
                    .HasName ("natType");

                entity.HasIndex (e => e.ShpId)
                    .HasName ("shpId");

                entity.HasIndex (e => e.UsrAdminFlag)
                    .HasName ("usrAdminFlag");

                entity.HasIndex (e => e.UsrCreationTime)
                    .HasName ("usrLoginTime");

                entity.HasIndex (e => e.UsrGender)
                    .HasName ("usrGender");

                entity.HasIndex (e => e.UsrId)
                    .HasName ("usrID");

                entity.HasIndex (e => e.UsrName)
                    .HasName ("usrName")
                    .IsUnique ();

                entity.HasIndex (e => e.UsrTradePermits)
                    .HasName ("usrTradePermits");

                entity.HasIndex (e => e.WpnId)
                    .HasName ("wpnId");

                entity.Property (e => e.AccId)
                    .HasColumnName ("accId")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.AreaId)
                    .HasColumnName ("areaId")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.ArmId)
                    .HasColumnName ("armId")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.BodyType)
                    .HasColumnName ("bodyType")
                    .HasColumnType ("int(6) unsigned")
                    .HasDefaultValueSql ("'1'");

                entity.Property (e => e.CharSpot)
                    .HasColumnName ("charSpot")
                    .HasColumnType ("smallint(6)")
                    .HasDefaultValueSql ("'1'");

                entity.Property (e => e.Class)
                    .HasColumnName ("class")
                    .HasColumnType ("smallint(6)");

                entity.Property (e => e.EyesColor1)
                    .HasColumnName ("eyesColor1")
                    .HasColumnType ("int(11)")
                    .HasDefaultValueSql ("'1'");

                entity.Property (e => e.EyesColor2)
                    .HasColumnName ("eyesColor2")
                    .HasColumnType ("int(11)")
                    .HasDefaultValueSql ("'1'");

                entity.Property (e => e.EyesType)
                    .HasColumnName ("eyesType")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.Faction)
                    .HasColumnName ("faction")
                    .HasColumnType ("smallint(6)");

                entity.Property (e => e.GldId)
                    .HasColumnName ("gldId")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.HairColor1)
                    .HasColumnName ("hairColor1")
                    .HasColumnType ("int(11)")
                    .HasDefaultValueSql ("'1'");

                entity.Property (e => e.HairColor2)
                    .HasColumnName ("hairColor2")
                    .HasColumnType ("int(11)")
                    .HasDefaultValueSql ("'1'");

                entity.Property (e => e.HairType)
                    .HasColumnName ("hairType")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.IsOnline)
                    .HasColumnName ("isOnline")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.LocalX)
                    .HasColumnName ("localX")
                    .HasColumnType ("decimal(10,2)")
                    .HasDefaultValueSql ("'5.06'");

                entity.Property (e => e.LocalY)
                    .HasColumnName ("localY")
                    .HasColumnType ("decimal(10,2)")
                    .HasDefaultValueSql ("'-9.33'");

                entity.Property (e => e.NatType)
                    .HasColumnName ("natType")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.ShpId)
                    .HasColumnName ("shpId")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.Specialty)
                    .HasColumnName ("specialty")
                    .HasColumnType ("smallint(6)");

                entity.Property (e => e.UsrAdminFlag)
                    .HasColumnName ("usrAdminFlag")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.UsrCreationTime)
                    .HasColumnName ("usrCreationTime")
                    .HasColumnType ("timestamp")
                    .HasDefaultValueSql ("CURRENT_TIMESTAMP");

                entity.Property (e => e.UsrFacing)
                    .HasColumnName ("usrFacing")
                    .HasColumnType ("int(11)")
                    .HasDefaultValueSql ("'5'");

                entity.Property (e => e.UsrGender)
                    .HasColumnName ("usrGender")
                    .HasColumnType ("int(11)")
                    .HasDefaultValueSql ("'1'");

                entity.Property (e => e.UsrGold)
                    .HasColumnName ("usrGold")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.UsrId)
                    .HasColumnName ("usrId")
                    .HasColumnType ("int(6)")
                    .ValueGeneratedOnAdd ();

                entity.Property (e => e.UsrName)
                    .IsRequired ()
                    .HasColumnName ("usrName")
                    .HasColumnType ("varchar(15)")
                    .HasCharSet ("utf8")
                    .HasCollation ("utf8_general_ci");

                entity.Property (e => e.UsrTradePermits)
                    .HasColumnName ("usrTradePermits")
                    .HasColumnType ("int(11)")
                    .HasDefaultValueSql ("'24'");

                entity.Property (e => e.UsrXp)
                    .HasColumnName ("usrXP")
                    .HasColumnType ("int(11)");

                entity.Property (e => e.WpnId)
                    .HasColumnName ("wpnId")
                    .HasColumnType ("int(11)");
            });

            OnModelCreatingPartial (modelBuilder);
        }

        partial void OnModelCreatingPartial (ModelBuilder modelBuilder);
    }
}