using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication2.Migrations
{
    /// <inheritdoc />
    public partial class mm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Membership_Member_MemberId",
                table: "Membership");

            migrationBuilder.DropForeignKey(
                name: "FK_Membership_Plane_PlaneId",
                table: "Membership");

            migrationBuilder.DropForeignKey(
                name: "FK_Session_Trainer_TrainerId",
                table: "Session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Session",
                table: "Session");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plane",
                table: "Plane");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Membership",
                table: "Membership");

            migrationBuilder.RenameTable(
                name: "Session",
                newName: "sessions");

            migrationBuilder.RenameTable(
                name: "Plane",
                newName: "planes");

            migrationBuilder.RenameTable(
                name: "Membership",
                newName: "members");

            migrationBuilder.RenameIndex(
                name: "IX_Session_TrainerId",
                table: "sessions",
                newName: "IX_sessions_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Membership_PlaneId",
                table: "members",
                newName: "IX_members_PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_Membership_MemberId",
                table: "members",
                newName: "IX_members_MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_sessions",
                table: "sessions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_planes",
                table: "planes",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_sessions_Trainer_TrainerId",
                table: "sessions",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_members_Member_MemberId",
                table: "members");

            migrationBuilder.DropForeignKey(
                name: "FK_members_planes_PlaneId",
                table: "members");

            migrationBuilder.DropForeignKey(
                name: "FK_sessions_Trainer_TrainerId",
                table: "sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_sessions",
                table: "sessions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_planes",
                table: "planes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_members",
                table: "members");

            migrationBuilder.RenameTable(
                name: "sessions",
                newName: "Session");

            migrationBuilder.RenameTable(
                name: "planes",
                newName: "Plane");

            migrationBuilder.RenameTable(
                name: "members",
                newName: "Membership");

            migrationBuilder.RenameIndex(
                name: "IX_sessions_TrainerId",
                table: "Session",
                newName: "IX_Session_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_members_PlaneId",
                table: "Membership",
                newName: "IX_Membership_PlaneId");

            migrationBuilder.RenameIndex(
                name: "IX_members_MemberId",
                table: "Membership",
                newName: "IX_Membership_MemberId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Session",
                table: "Session",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plane",
                table: "Plane",
                column: "Id");

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
                name: "FK_Membership_Plane_PlaneId",
                table: "Membership",
                column: "PlaneId",
                principalTable: "Plane",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Session_Trainer_TrainerId",
                table: "Session",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
