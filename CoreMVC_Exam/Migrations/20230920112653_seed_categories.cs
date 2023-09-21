using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class seed_categories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.Sql(@"
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'BL0010', N'Blenders')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'CM0007', N'Coffee Makers')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'DW0003', N'Dishwashers')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'FP0013', N'Food Processors')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'FR0006', N'Freezers')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'HM0014', N'Hand Mixers')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'IR0011', N'Irons')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'KE0015', N'Kettle')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'MI0004', N'Microwaves')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'OV0005', N'Ovens')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'RE0001', N'Refrigerators')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'TO0012', N'Toasters')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'TV0008', N'Televisions')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'VC0009', N'Vacuum Cleaners')
        INSERT INTO [dbo].[Categories] ([id], [name]) VALUES (N'WM0002', N'Washing Machines')
    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
