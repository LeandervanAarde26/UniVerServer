﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UniVerServer.Migrations
{
    /// <inheritdoc />
    public partial class Addeddeletedflagtoenrollment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("4a99476f-5e3f-433d-8b2c-3c981e4b7fe8"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("68cb58ab-8dd3-48e5-a3b9-333c63b5ee2e"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("7b14087d-b77a-45c1-a058-d3c6881cad8f"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("867556a3-71b2-4433-b708-98ed32f39ee5"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("c260b6f1-5ae7-4066-90e1-1fc6696f0d38"));

            migrationBuilder.AddColumn<bool>(
                name: "ActiveEnrollment",
                table: "Enrollments",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6c058d67-4d10-4fa6-8d6a-4f8b8c5a3a5e"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8650), new DateTime(2024, 10, 30, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8650), new DateTime(2024, 10, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8650) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7a3b56c6-1090-4f14-973f-b9b9d4b707cb"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8680), new DateTime(2025, 1, 30, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8680), new DateTime(2024, 9, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8680) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9fcbf95d-89a4-4e19-a828-3baf4aa75ec0"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8650), new DateTime(2024, 10, 30, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8660), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("adff5e28-7a2d-4f71-8c1b-0b6d59a82390"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8670), new DateTime(2024, 10, 30, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8670), new DateTime(2024, 10, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8670) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d3a2f2f0-8e7e-42e1-9f70-61f2a8c0b5ea"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8660), new DateTime(2024, 10, 30, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8670), new DateTime(2024, 9, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f8a259ab-d2f3-482e-9074-842b4a097e27"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8630), new DateTime(2024, 12, 31, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8640), new DateTime(2024, 10, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8640) });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "ActiveEnrollment", "CourseId", "DateCreated", "Grade", "GradeType", "Identifier", "Modified", "Status", "StudentId" },
                values: new object[,]
                {
                    { new Guid("193ed8a8-fce2-40dd-9aee-dadd4a5d7f85"), false, new Guid("9fcbf95d-89a4-4e19-a828-3baf4aa75ec0"), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8750), 0.00m, 3, "VOID", new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8750), 1, new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78") },
                    { new Guid("2e21fea4-a805-4983-960f-8bdbcc5a8f30"), false, new Guid("6c058d67-4d10-4fa6-8d6a-4f8b8c5a3a5e"), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8750), 0.00m, 3, "VOID", new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8750), 1, new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78") },
                    { new Guid("2f506fcd-39f6-44d0-b751-31c89c336bfd"), false, new Guid("adff5e28-7a2d-4f71-8c1b-0b6d59a82390"), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8760), 0.00m, 3, "VOID", new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8760), 1, new Guid("2881e5ba-daad-41f9-92f2-9d67dcc0bd00") },
                    { new Guid("56d3990a-9898-4b24-9d64-1e25bba49990"), false, new Guid("d3a2f2f0-8e7e-42e1-9f70-61f2a8c0b5ea"), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8760), 0.00m, 3, "VOID", new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8760), 1, new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78") },
                    { new Guid("ecfeac10-df89-4493-9e92-1cdf58974681"), false, new Guid("f8a259ab-d2f3-482e-9074-842b4a097e27"), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8740), 0.00m, 3, "VOID", new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8740), 1, new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78") }
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3f1a17e5-1c8e-4f6b-a5f7-27c5e9d6a41d"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8500), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5d0e2f6c-8d20-4b0a-bf65-77e4ec12b179"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8560), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8560) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a2b92fe1-5918-42f4-957a-0e57c7b3e38b"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 10, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8560), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8550) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b12a9fb8-42cf-4d0a-8a2d-d980dd9ff1e1"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 8, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8580), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c0840d57-4d73-4f7c-afe6-68b79bc01660"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 9, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8570), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e5fe9368-1f62-4d5d-bf98-3c8d12a8764b"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 10, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8570), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("58d25d4c-3b3a-4f52-b282-48e0f458fb79"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68b4d362-9271-4f9f-aa7b-6a9b1953dc3c"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-7a89-b0c1-2d3e4f567890"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a9e3c834-7182-4b3a-80e2-b28a9a7bce42"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("28384e02-4ac9-4098-89b7-405c465c730e"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8420), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8420) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2c5240e9-d233-45bb-8d9b-8d6e709b2937"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8430), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2ebc8d73-d02a-4c97-990a-6793dd0c7386"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8430), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2ebd49a2-8d97-4885-832b-8b2f950cbbd3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("37d7ded2-6d83-4b49-ab75-f0bf5209589f"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("39fe9dbe-592b-440c-8c80-686f5dd47327"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8440), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8440) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("45a5b291-98f8-4876-860a-99b918a1d24f"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8450), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8450) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2881e5ba-daad-41f9-92f2-9d67dcc0bd00"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8350), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("497223a1-720a-408e-8a07-cfa7e48655b3"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8360), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8360), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49b27cdd-b59f-4a26-80a4-6f7a1c1b2fd7"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8360), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8360), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cfdf887-baf3-4847-a68a-18e7117beddc"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8360), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8360), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59332d00-80a2-446c-afca-00a3160c0764"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8370), new DateTime(2024, 7, 2, 7, 0, 34, 841, DateTimeKind.Utc).AddTicks(8370) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("193ed8a8-fce2-40dd-9aee-dadd4a5d7f85"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2e21fea4-a805-4983-960f-8bdbcc5a8f30"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("2f506fcd-39f6-44d0-b751-31c89c336bfd"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("56d3990a-9898-4b24-9d64-1e25bba49990"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("ecfeac10-df89-4493-9e92-1cdf58974681"));

            migrationBuilder.DropColumn(
                name: "ActiveEnrollment",
                table: "Enrollments");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("6c058d67-4d10-4fa6-8d6a-4f8b8c5a3a5e"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 11, 29, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7570), new DateTime(2024, 10, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("7a3b56c6-1090-4f14-973f-b9b9d4b707cb"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7590), new DateTime(2024, 12, 30, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7600), new DateTime(2024, 9, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7600) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("9fcbf95d-89a4-4e19-a828-3baf4aa75ec0"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7570), new DateTime(2025, 1, 29, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7580), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("adff5e28-7a2d-4f71-8c1b-0b6d59a82390"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7590), new DateTime(2024, 12, 30, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7590), new DateTime(2024, 8, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7590) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("d3a2f2f0-8e7e-42e1-9f70-61f2a8c0b5ea"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7580), new DateTime(2025, 1, 29, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7580), new DateTime(2024, 9, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: new Guid("f8a259ab-d2f3-482e-9074-842b4a097e27"),
                columns: new[] { "DateCreated", "EndDate", "StartDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7550), new DateTime(2024, 10, 29, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7560), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7550) });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CourseId", "DateCreated", "Grade", "GradeType", "Identifier", "Modified", "Status", "StudentId" },
                values: new object[,]
                {
                    { new Guid("4a99476f-5e3f-433d-8b2c-3c981e4b7fe8"), new Guid("6c058d67-4d10-4fa6-8d6a-4f8b8c5a3a5e"), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7670), 0.00m, 3, "VOID", new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7670), 1, new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78") },
                    { new Guid("68cb58ab-8dd3-48e5-a3b9-333c63b5ee2e"), new Guid("9fcbf95d-89a4-4e19-a828-3baf4aa75ec0"), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7670), 0.00m, 3, "VOID", new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7670), 1, new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78") },
                    { new Guid("7b14087d-b77a-45c1-a058-d3c6881cad8f"), new Guid("f8a259ab-d2f3-482e-9074-842b4a097e27"), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7660), 0.00m, 3, "VOID", new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7660), 1, new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78") },
                    { new Guid("867556a3-71b2-4433-b708-98ed32f39ee5"), new Guid("d3a2f2f0-8e7e-42e1-9f70-61f2a8c0b5ea"), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7680), 0.00m, 3, "VOID", new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7680), 1, new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78") },
                    { new Guid("c260b6f1-5ae7-4066-90e1-1fc6696f0d38"), new Guid("adff5e28-7a2d-4f71-8c1b-0b6d59a82390"), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7680), 0.00m, 3, "VOID", new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7680), 1, new Guid("2881e5ba-daad-41f9-92f2-9d67dcc0bd00") }
                });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("3f1a17e5-1c8e-4f6b-a5f7-27c5e9d6a41d"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 9, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7390), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7390) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("5d0e2f6c-8d20-4b0a-bf65-77e4ec12b179"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7460), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("a2b92fe1-5918-42f4-957a-0e57c7b3e38b"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7460), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("b12a9fb8-42cf-4d0a-8a2d-d980dd9ff1e1"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 9, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7490), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7480) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("c0840d57-4d73-4f7c-afe6-68b79bc01660"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 8, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7470), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: new Guid("e5fe9368-1f62-4d5d-bf98-3c8d12a8764b"),
                columns: new[] { "Date", "DateCreated" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7470), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7470) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("58d25d4c-3b3a-4f52-b282-48e0f458fb79"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("68b4d362-9271-4f9f-aa7b-6a9b1953dc3c"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a1b2c3d4-e5f6-7a89-b0c1-2d3e4f567890"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a9e3c834-7182-4b3a-80e2-b28a9a7bce42"),
                column: "DateCreated",
                value: new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("28384e02-4ac9-4098-89b7-405c465c730e"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7320), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7320) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2c5240e9-d233-45bb-8d9b-8d6e709b2937"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7330), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2ebc8d73-d02a-4c97-990a-6793dd0c7386"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7330), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("2ebd49a2-8d97-4885-832b-8b2f950cbbd3"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7330), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("37d7ded2-6d83-4b49-ab75-f0bf5209589f"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7340), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("39fe9dbe-592b-440c-8c80-686f5dd47327"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7340), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("45a5b291-98f8-4876-860a-99b918a1d24f"),
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7340), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7340) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("14d52b1e-f5b3-4750-b327-56ddadbd1f78"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7240), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7240), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("2881e5ba-daad-41f9-92f2-9d67dcc0bd00"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7240), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7240), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("497223a1-720a-408e-8a07-cfa7e48655b3"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7250), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7240), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("49b27cdd-b59f-4a26-80a4-6f7a1c1b2fd7"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7250), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7250), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4cfdf887-baf3-4847-a68a-18e7117beddc"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7250), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7250), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("59332d00-80a2-446c-afca-00a3160c0764"),
                columns: new[] { "DateCreated", "ModifiedDate", "PasswordModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7260), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7260), new DateTime(2024, 7, 1, 13, 9, 51, 718, DateTimeKind.Utc).AddTicks(7260) });
        }
    }
}
