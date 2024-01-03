DROP DATABASE IF EXISTS musiclibrary;

CREATE DATABASE musiclibrary;
USE musiclibrary;

CREATE TABLE dbo_user(
	username char(50),
    h_pass char(50),
    salt char(50),
    PRIMARY KEY (username)
);

CREATE TABLE dbo_Artist(
	ArtistID char(50),
    ArtistName char(50),
    DebutYear date,
    PRIMARY KEY (ArtistID)
);

CREATE TABLE dbo_Album(
	AlbumID char(50),
    ArtistID char(50),
    Title char(50) charset utf8mb4,
    ReleaseYear date,
    PRIMARY KEY (AlbumID),
    FOREIGN KEY (ArtistID) REFERENCES dbo_Artist(ArtistID)
);

CREATE TABLE dbo_Playlist(
	PlaylistID int auto_increment,
    username char(50),
    PRIMARY KEY (PlaylistID),
    FOREIGN KEY (username) REFERENCES dbo_user(username)
);

CREATE TABLE dbo_MusicFile(
	SongID char(50),
    ArtistID char(50),
    FilePath char(100),
	Title char(50),
    FOREIGN KEY (ArtistID) REFERENCES dbo_Artist(ArtistID),
    PRIMARY KEY (SongID)
);

CREATE TABLE dbo_AlbumInfo(
	SongID char(50),
    AlbumID char(50),
    FOREIGN KEY (SongID) REFERENCES dbo_MusicFile(SongID),
    FOREIGN KEY (AlbumID) REFERENCES dbo_Album(AlbumID),
    PRIMARY KEY (SongID, AlbumID)
);

CREATE TABLE dbo_PlaylistInfo(
	PlaylistID int,
    SongID char(50),
    FOREIGN KEY (SongID) REFERENCES dbo_MusicFile(SongID),
    FOREIGN KEY (PlaylistID) REFERENCES dbo_Playlist(PlaylistID),
    PRIMARY KEY (PlaylistID, SongID)
);

SELECT * from dbo_user