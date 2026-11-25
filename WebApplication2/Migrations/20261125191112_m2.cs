using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_members_Member_MemberId",
                table: "members");

            migrationBuilder.DropForeignKey(
                name: "FK_members_planes_PlaneId",
                table: "members");

            migrationBuilder.DropPrimaryKey(
                name: "PK_members",
                table: "members");

            migrationBuilder.RenameTable(
                name: "members",
                newName: "Membership");

            migrationBuilder.RenameIndex(
                name: "IX_members_PlaneId",
                table: "Membership",
                newName: "IX_Membership_PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_members_MemberId",
                table: "Membership",
                newName: "IX_Membership_MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Membership",
                table: "Membership",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Membership_Member_MemberId",
                table: "Membership",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Membership_planes_PlaneId",
                table: "Membership",
                column: "PlaneId",
                principalTable: "planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membership_Member_MemberId",
                table: "Membership");

            migrationBuilder.DropForeignKey(
                name: "FK_Membership_planes_PlaneId",
                table: "Membership");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Membership",
                table: "Membership");

            migrationBuilder.RenameTable(
                name: "Membership",
                newName: "members");

            migrationBuilder.RenameIndex(
                name: "IX_Membership_PlaneId",
                table: "members",
                newName: "IX_members_PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_Membership_MemberId",
                table: "members",
                newName: "IX_members_MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_members",
                table: "members",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_members_Member_MemberId",
                table: "members",
                column: "MemberId",
                principalTable: "Member",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_members_planes_PlaneId",
                table: "members",
                column: "PlaneId",
                principalTable: "planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
