using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicPlayer_Project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "webApp");

            migrationBuilder.CreateTable(
                name: "Artist",
                schema: "webApp",
                columns: table => new
                {
                    ArtistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    About = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                schema: "webApp",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                schema: "webApp",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Joined = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                schema: "webApp",
                columns: table => new
                {
                    GenreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreID);
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                schema: "webApp",
                columns: table => new
                {
                    PlaylistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    NamePlaylist = table.Column<string>(nullable: true),
                    SongsInPlaylist = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.PlaylistID);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                schema: "webApp",
                columns: table => new
                {
                    AlbumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    SongID = table.Column<int>(nullable: false),
                    ArtistID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.AlbumID);
                    table.ForeignKey(
                        name: "FK_Album_Artist_ArtistID",
                        column: x => x.ArtistID,
                        principalSchema: "webApp",
                        principalTable: "Artist",
                        principalColumn: "ArtistID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                schema: "webApp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "webApp",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                schema: "webApp",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "webApp",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                schema: "webApp",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "webApp",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                schema: "webApp",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "webApp",
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "webApp",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                schema: "webApp",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "webApp",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistUser",
                schema: "webApp",
                columns: table => new
                {
                    PlaylistUserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaylistID = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistUser", x => x.PlaylistUserID);
                    table.ForeignKey(
                        name: "FK_PlaylistUser_Playlist_PlaylistID",
                        column: x => x.PlaylistID,
                        principalSchema: "webApp",
                        principalTable: "Playlist",
                        principalColumn: "PlaylistID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "webApp",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AlbumGenre",
                schema: "webApp",
                columns: table => new
                {
                    AlbumGenreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumID = table.Column<int>(nullable: false),
                    GenreID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlbumGenre", x => x.AlbumGenreID);
                    table.ForeignKey(
                        name: "FK_AlbumGenre_Album_AlbumID",
                        column: x => x.AlbumID,
                        principalSchema: "webApp",
                        principalTable: "Album",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AlbumGenre_Genre_GenreID",
                        column: x => x.GenreID,
                        principalSchema: "webApp",
                        principalTable: "Genre",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Song",
                schema: "webApp",
                columns: table => new
                {
                    SongID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    DurationSong = table.Column<int>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    FileSize = table.Column<int>(nullable: true),
                    AlbumID = table.Column<int>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.SongID);
                    table.ForeignKey(
                        name: "FK_Song_Album_AlbumID",
                        column: x => x.AlbumID,
                        principalSchema: "webApp",
                        principalTable: "Album",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Song_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalSchema: "webApp",
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                schema: "webApp",
                columns: table => new
                {
                    ArtistSongID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistID = table.Column<int>(nullable: false),
                    SongID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => x.ArtistSongID);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Artist_ArtistID",
                        column: x => x.ArtistID,
                        principalSchema: "webApp",
                        principalTable: "Artist",
                        principalColumn: "ArtistID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Song_SongID",
                        column: x => x.SongID,
                        principalSchema: "webApp",
                        principalTable: "Song",
                        principalColumn: "SongID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistCollection",
                schema: "webApp",
                columns: table => new
                {
                    PlaylistCollectionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlaylistID = table.Column<int>(nullable: false),
                    SongID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistCollection", x => x.PlaylistCollectionID);
                    table.ForeignKey(
                        name: "FK_PlaylistCollection_Playlist_PlaylistID",
                        column: x => x.PlaylistID,
                        principalSchema: "webApp",
                        principalTable: "Playlist",
                        principalColumn: "PlaylistID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistCollection_Song_SongID",
                        column: x => x.SongID,
                        principalSchema: "webApp",
                        principalTable: "Song",
                        principalColumn: "SongID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SongGenre",
                schema: "webApp",
                columns: table => new
                {
                    SongGenreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreID = table.Column<int>(nullable: false),
                    SongID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SongGenre", x => x.SongGenreID);
                    table.ForeignKey(
                        name: "FK_SongGenre_Genre_GenreID",
                        column: x => x.GenreID,
                        principalSchema: "webApp",
                        principalTable: "Genre",
                        principalColumn: "GenreID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SongGenre_Song_SongID",
                        column: x => x.SongID,
                        principalSchema: "webApp",
                        principalTable: "Song",
                        principalColumn: "SongID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_ArtistID",
                schema: "webApp",
                table: "Album",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenre_AlbumID",
                schema: "webApp",
                table: "AlbumGenre",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_AlbumGenre_GenreID",
                schema: "webApp",
                table: "AlbumGenre",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_ArtistID",
                schema: "webApp",
                table: "ArtistSong",
                column: "ArtistID");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_SongID",
                schema: "webApp",
                table: "ArtistSong",
                column: "SongID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                schema: "webApp",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "webApp",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                schema: "webApp",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                schema: "webApp",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                schema: "webApp",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "webApp",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "webApp",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistCollection_PlaylistID",
                schema: "webApp",
                table: "PlaylistCollection",
                column: "PlaylistID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistCollection_SongID",
                schema: "webApp",
                table: "PlaylistCollection",
                column: "SongID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistUser_PlaylistID",
                schema: "webApp",
                table: "PlaylistUser",
                column: "PlaylistID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistUser_UserId",
                schema: "webApp",
                table: "PlaylistUser",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Song_AlbumID",
                schema: "webApp",
                table: "Song",
                column: "AlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_Song_UserId",
                schema: "webApp",
                table: "Song",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SongGenre_GenreID",
                schema: "webApp",
                table: "SongGenre",
                column: "GenreID");

            migrationBuilder.CreateIndex(
                name: "IX_SongGenre_SongID",
                schema: "webApp",
                table: "SongGenre",
                column: "SongID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlbumGenre",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "ArtistSong",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "PlaylistCollection",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "PlaylistUser",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "SongGenre",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "AspNetRoles",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "Playlist",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "Genre",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "Song",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "Album",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "AspNetUsers",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "Artist",
                schema: "webApp");
        }
    }
}
