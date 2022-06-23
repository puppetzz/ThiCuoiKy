namespace _102200337_TruongVanMinhHieu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HocPhans",
                c => new
                    {
                        MaHocPhan = c.String(nullable: false, maxLength: 128),
                        TenHocPhan = c.String(),
                    })
                .PrimaryKey(t => t.MaHocPhan);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        MaSinhVien = c.String(nullable: false, maxLength: 128),
                        TenSinhVien = c.String(),
                        LopSinhHoat = c.String(),
                        GioiTinh = c.Boolean(nullable: false),
                        DiemBaiTap = c.Double(nullable: false),
                        DiemGiuaKy = c.Double(nullable: false),
                        DiemCuoiKy = c.Double(nullable: false),
                        NgayThi = c.DateTime(nullable: false),
                        MaHocPhan = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaSinhVien)
                .ForeignKey("dbo.HocPhans", t => t.MaHocPhan)
                .Index(t => t.MaHocPhan);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "MaHocPhan", "dbo.HocPhans");
            DropIndex("dbo.SinhViens", new[] { "MaHocPhan" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.HocPhans");
        }
    }
}
