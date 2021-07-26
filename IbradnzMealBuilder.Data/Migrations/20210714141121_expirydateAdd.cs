using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IbradnzMealBuilder.Data.Migrations
{
    public partial class expirydateAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "TrainingVideos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "TrainingDay",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "TechniqueVideo",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Subscription",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Expirydate",
                table: "Subscription",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Program",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "ProfileImage",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "MuscleGroup",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "MealType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "MealBuilder",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Meal",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "LiveZoom",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Faq",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Customer",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "CountryPhoneCode",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "TrainingVideos");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "TrainingDay");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "TechniqueVideo");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "Subscription");

            migrationBuilder.DropColumn(
                name: "Expirydate",
                table: "Subscription");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "Program");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "ProfileImage");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "MuscleGroup");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "MealType");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "MealBuilder");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "Meal");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "LiveZoom");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "Faq");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "DateExpiredOn",
                table: "CountryPhoneCode");
        }
    }
}
