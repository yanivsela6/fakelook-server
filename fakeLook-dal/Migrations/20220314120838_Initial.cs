using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fakeLook_dal.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Tags",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Content = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Tags", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Users",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Users", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Posts",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        ImageSorce = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        X_Position = table.Column<double>(type: "float", nullable: false),
            //        Y_Position = table.Column<double>(type: "float", nullable: false),
            //        Z_Position = table.Column<double>(type: "float", nullable: false),
            //        Date = table.Column<DateTime>(type: "datetime2", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Posts", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Posts_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Comments",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        PostId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Comments", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Comments_Posts_PostId",
            //            column: x => x.PostId,
            //            principalTable: "Posts",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Comments_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Likes",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        IsActive = table.Column<bool>(type: "bit", nullable: false),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        PostId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Likes", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Likes_Posts_PostId",
            //            column: x => x.PostId,
            //            principalTable: "Posts",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_Likes_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "PostTag",
            //    columns: table => new
            //    {
            //        PostsId = table.Column<int>(type: "int", nullable: false),
            //        TagsId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_PostTag", x => new { x.PostsId, x.TagsId });
            //        table.ForeignKey(
            //            name: "FK_PostTag_Posts_PostsId",
            //            column: x => x.PostsId,
            //            principalTable: "Posts",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_PostTag_Tags_TagsId",
            //            column: x => x.TagsId,
            //            principalTable: "Tags",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserTaggedPosts",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        PostId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserTaggedPosts", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_UserTaggedPosts_Posts_PostId",
            //            column: x => x.PostId,
            //            principalTable: "Posts",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_UserTaggedPosts_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateTable(
            //    name: "CommentTag",
            //    columns: table => new
            //    {
            //        CommentsId = table.Column<int>(type: "int", nullable: false),
            //        TagsId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_CommentTag", x => new { x.CommentsId, x.TagsId });
            //        table.ForeignKey(
            //            name: "FK_CommentTag_Comments_CommentsId",
            //            column: x => x.CommentsId,
            //            principalTable: "Comments",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //        table.ForeignKey(
            //            name: "FK_CommentTag_Tags_TagsId",
            //            column: x => x.TagsId,
            //            principalTable: "Tags",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Cascade);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "UserTaggedComments",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        UserId = table.Column<int>(type: "int", nullable: false),
            //        CommentId = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_UserTaggedComments", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_UserTaggedComments_Comments_CommentId",
            //            column: x => x.CommentId,
            //            principalTable: "Comments",
            //            principalColumn: "Id");
            //        table.ForeignKey(
            //            name: "FK_UserTaggedComments_Users_UserId",
            //            column: x => x.UserId,
            //            principalTable: "Users",
            //            principalColumn: "Id");
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_PostId",
            //    table: "Comments",
            //    column: "PostId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Comments_UserId",
            //    table: "Comments",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_CommentTag_TagsId",
            //    table: "CommentTag",
            //    column: "TagsId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Likes_PostId",
            //    table: "Likes",
            //    column: "PostId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Likes_UserId",
            //    table: "Likes",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Posts_UserId",
            //    table: "Posts",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_PostTag_TagsId",
            //    table: "PostTag",
            //    column: "TagsId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserTaggedComments_CommentId",
            //    table: "UserTaggedComments",
            //    column: "CommentId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserTaggedComments_UserId",
            //    table: "UserTaggedComments",
            //    column: "UserId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserTaggedPosts_PostId",
            //    table: "UserTaggedPosts",
            //    column: "PostId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_UserTaggedPosts_UserId",
            //    table: "UserTaggedPosts",
            //    column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentTag");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "PostTag");

            migrationBuilder.DropTable(
                name: "UserTaggedComments");

            migrationBuilder.DropTable(
                name: "UserTaggedPosts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
