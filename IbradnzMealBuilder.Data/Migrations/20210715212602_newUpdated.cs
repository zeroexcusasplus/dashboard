using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IbradnzMealBuilder.Data.Migrations
{
    public partial class newUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "TrainingVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "TrainingDay",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "TechniqueVideo",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Subscription",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Program",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "ProfileImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "MuscleGroup",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "MealType",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "MealBuilder",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Meal",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "LiveZoom",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Faq",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "Customer",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DateExpiredOn",
                table: "CountryPhoneCode",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
