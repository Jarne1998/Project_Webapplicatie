using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicPlayer_Project.Migrations
{
    public partial class InitalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "webApp");

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
                });

            migrationBuilder.CreateTable(
                name: "PlaylistUser",
                schema: "webApp",
                columns: table => new
                {
                    PlaylistUserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(nullable: false),
                    PlaylistID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistUser", x => x.PlaylistUserID);
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
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                schema: "webApp",
                columns: table => new
                {
                    PlaylistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SongsInPlaylist = table.Column<int>(nullable: false),
                    PlaylistCollectionsPlaylistCollectionID = table.Column<int>(nullable: true),
                    PlaylistUsersPlaylistUserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.PlaylistID);
                    table.ForeignKey(
                        name: "FK_Playlist_PlaylistCollection_PlaylistCollectionsPlaylistCollectionID",
                        column: x => x.PlaylistCollectionsPlaylistCollectionID,
                        principalSchema: "webApp",
                        principalTable: "PlaylistCollection",
                        principalColumn: "PlaylistCollectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Playlist_PlaylistUser_PlaylistUsersPlaylistUserID",
                        column: x => x.PlaylistUsersPlaylistUserID,
                        principalSchema: "webApp",
                        principalTable: "PlaylistUser",
                        principalColumn: "PlaylistUserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                schema: "webApp",
                columns: table => new
                {
                    GenreID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    AlbumGenresAlbumGenreID = table.Column<int>(nullable: true),
                    SongGenresSongGenreID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreID);
                    table.ForeignKey(
                        name: "FK_Genre_AlbumGenre_AlbumGenresAlbumGenreID",
                        column: x => x.AlbumGenresAlbumGenreID,
                        principalSchema: "webApp",
                        principalTable: "AlbumGenre",
                        principalColumn: "AlbumGenreID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Genre_SongGenre_SongGenresSongGenreID",
                        column: x => x.SongGenresSongGenreID,
                        principalSchema: "webApp",
                        principalTable: "SongGenre",
                        principalColumn: "SongGenreID",
                        onDelete: ReferentialAction.Restrict);
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
                    FileType = table.Column<string>(nullable: true),
                    SongGenresSongGenreID = table.Column<int>(nullable: true),
                    PlaylistCollectionsPlaylistCollectionID = table.Column<int>(nullable: true),
                    ArtistSongsArtistSongID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Song", x => x.SongID);
                    table.ForeignKey(
                        name: "FK_Song_ArtistSong_ArtistSongsArtistSongID",
                        column: x => x.ArtistSongsArtistSongID,
                        principalSchema: "webApp",
                        principalTable: "ArtistSong",
                        principalColumn: "ArtistSongID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Song_PlaylistCollection_PlaylistCollectionsPlaylistCollectionID",
                        column: x => x.PlaylistCollectionsPlaylistCollectionID,
                        principalSchema: "webApp",
                        principalTable: "PlaylistCollection",
                        principalColumn: "PlaylistCollectionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Song_SongGenre_SongGenresSongGenreID",
                        column: x => x.SongGenresSongGenreID,
                        principalSchema: "webApp",
                        principalTable: "SongGenre",
                        principalColumn: "SongGenreID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Album",
                schema: "webApp",
                columns: table => new
                {
                    AlbumID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: true),
                    ReleaseDate = table.Column<DateTime>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    SongID = table.Column<int>(nullable: false),
                    ArtistID = table.Column<int>(nullable: false),
                    AlbumGenresAlbumGenreID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.AlbumID);
                    table.ForeignKey(
                        name: "FK_Album_AlbumGenre_AlbumGenresAlbumGenreID",
                        column: x => x.AlbumGenresAlbumGenreID,
                        principalSchema: "webApp",
                        principalTable: "AlbumGenre",
                        principalColumn: "AlbumGenreID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Album_Song_SongID",
                        column: x => x.SongID,
                        principalSchema: "webApp",
                        principalTable: "Song",
                        principalColumn: "SongID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "webApp",
                columns: table => new
                {
                    UserID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Joined = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    PlaylistUsersPlaylistUserID = table.Column<int>(nullable: true),
                    SongsSongID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_User_PlaylistUser_PlaylistUsersPlaylistUserID",
                        column: x => x.PlaylistUsersPlaylistUserID,
                        principalSchema: "webApp",
                        principalTable: "PlaylistUser",
                        principalColumn: "PlaylistUserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_User_Song_SongsSongID",
                        column: x => x.SongsSongID,
                        principalSchema: "webApp",
                        principalTable: "Song",
                        principalColumn: "SongID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Artist",
                schema: "webApp",
                columns: table => new
                {
                    ArtistID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    About = table.Column<string>(nullable: true),
                    AlbumsAlbumID = table.Column<int>(nullable: true),
                    ArtistSongsArtistSongID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.ArtistID);
                    table.ForeignKey(
                        name: "FK_Artist_Album_AlbumsAlbumID",
                        column: x => x.AlbumsAlbumID,
                        principalSchema: "webApp",
                        principalTable: "Album",
                        principalColumn: "AlbumID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Artist_ArtistSong_ArtistSongsArtistSongID",
                        column: x => x.ArtistSongsArtistSongID,
                        principalSchema: "webApp",
                        principalTable: "ArtistSong",
                        principalColumn: "ArtistSongID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Album_AlbumGenresAlbumGenreID",
                schema: "webApp",
                table: "Album",
                column: "AlbumGenresAlbumGenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Album_SongID",
                schema: "webApp",
                table: "Album",
                column: "SongID");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_AlbumsAlbumID",
                schema: "webApp",
                table: "Artist",
                column: "AlbumsAlbumID");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_ArtistSongsArtistSongID",
                schema: "webApp",
                table: "Artist",
                column: "ArtistSongsArtistSongID");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_AlbumGenresAlbumGenreID",
                schema: "webApp",
                table: "Genre",
                column: "AlbumGenresAlbumGenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Genre_SongGenresSongGenreID",
                schema: "webApp",
                table: "Genre",
                column: "SongGenresSongGenreID");

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_PlaylistCollectionsPlaylistCollectionID",
                schema: "webApp",
                table: "Playlist",
                column: "PlaylistCollectionsPlaylistCollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_PlaylistUsersPlaylistUserID",
                schema: "webApp",
                table: "Playlist",
                column: "PlaylistUsersPlaylistUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Song_ArtistSongsArtistSongID",
                schema: "webApp",
                table: "Song",
                column: "ArtistSongsArtistSongID");

            migrationBuilder.CreateIndex(
                name: "IX_Song_PlaylistCollectionsPlaylistCollectionID",
                schema: "webApp",
                table: "Song",
                column: "PlaylistCollectionsPlaylistCollectionID");

            migrationBuilder.CreateIndex(
                name: "IX_Song_SongGenresSongGenreID",
                schema: "webApp",
                table: "Song",
                column: "SongGenresSongGenreID");

            migrationBuilder.CreateIndex(
                name: "IX_User_PlaylistUsersPlaylistUserID",
                schema: "webApp",
                table: "User",
                column: "PlaylistUsersPlaylistUserID");

            migrationBuilder.CreateIndex(
                name: "IX_User_SongsSongID",
                schema: "webApp",
                table: "User",
                column: "SongsSongID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "Genre",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "Playlist",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "User",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "Album",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "PlaylistUser",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "AlbumGenre",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "Song",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "ArtistSong",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "PlaylistCollection",
                schema: "webApp");

            migrationBuilder.DropTable(
                name: "SongGenre",
                schema: "webApp");
        }
    }
}
