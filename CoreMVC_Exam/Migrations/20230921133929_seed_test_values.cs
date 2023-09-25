using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreMVC_Exam.Migrations
{
    /// <inheritdoc />
    public partial class seed_test_values : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO [dbo].[Clients] ([passport_id], [full_name], [address], [phone_number], [birthday]) VALUES (N'111111', N'Мирный Кирилл Константинович', N'ул. 2-й Краснознамённой 255', N'+79591113480', CONVERT(DATETIME, '2023-09-21 16:26:24', 120))
INSERT INTO [dbo].[Orders] ([id], [product_id], [client_id], [start_date], [end_date], [price]) VALUES (N'111111', N'111111', N'111111', CONVERT(DATETIME, '2023-09-21 16:26:24', 120), CONVERT(DATETIME, '2023-09-21 16:26:24', 120), CAST(25.5000 AS Money))
INSERT INTO [dbo].[Products] ([id], [category_id], [serial_number], [price], [year], [brand], [model]) VALUES (N'111111', N'RE0001', N'8721-0892-0867-4459-9223-2874', CAST(1000.0000 AS Money), CONVERT(DATETIME, '2023-09-21 16:26:24', 120), N'Hitachi', N'R-BG410PU6XG')
");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
