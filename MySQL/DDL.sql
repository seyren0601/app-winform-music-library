DROP DATABASE IF EXISTS musiclibrary;

CREATE DATABASE musiclibrary;
USE musiclibrary;

CREATE TABLE dbo_user(
	username char(50),
    h_pass char(50),
    salt char(50),
	administrator tinyint,
    PRIMARY KEY (username)
);

CREATE TABLE dbo_Playlist(
	PlaylistID int auto_increment unique,
    PlaylistName char(100) char set utf8mb4,
    username char(50),
    PRIMARY KEY (PlaylistID),
    FOREIGN KEY (username) 
		REFERENCES dbo_user(username)
        ON DELETE CASCADE
);

CREATE TABLE dbo_Artist(
	ArtistID char(50),
    ArtistName char(50),
    DebutYear int,
    PRIMARY KEY (ArtistID)
);

CREATE TABLE dbo_Album(
	AlbumID char(50),
    ArtistID char(50),
    Title char(50) charset utf8mb4,
    ReleaseYear int,
    PRIMARY KEY (AlbumID),
    FOREIGN KEY (ArtistID) 
		REFERENCES dbo_Artist(ArtistID)
		ON DELETE CASCADE
);

CREATE TABLE dbo_MusicFile(
	SongID char(50),
    ArtistID char(50),
    FilePath char(100),
	Title char(50) charset utf8mb4,
    FOREIGN KEY (ArtistID)
		REFERENCES dbo_Artist(ArtistID)
        ON DELETE CASCADE,
    PRIMARY KEY (SongID)
);

CREATE TABLE dbo_AlbumInfo(
	SongID char(50),
    AlbumID char(50),
    FOREIGN KEY (SongID)
		REFERENCES dbo_MusicFile(SongID)
        ON DELETE CASCADE,
    FOREIGN KEY (AlbumID) 
		REFERENCES dbo_Album(AlbumID)
        ON DELETE CASCADE,
    PRIMARY KEY (SongID, AlbumID)
);

CREATE TABLE dbo_PlaylistInfo(
	PlaylistID int,
    SongID char(50),
    FOREIGN KEY (SongID) 
		REFERENCES dbo_MusicFile(SongID)
		ON DELETE CASCADE,
    FOREIGN KEY (PlaylistID)
		REFERENCES dbo_Playlist(PlaylistID)
        ON DELETE CASCADE,
    PRIMARY KEY (PlaylistID, SongID)
);

select * from dbo_artist;
select dbo_album.Title, dbo_musicfile.songid, dbo_musicfile.Title from dbo_album
inner join dbo_albuminfo on dbo_album.albumid = dbo_albuminfo.albumid
inner join dbo_musicfile on dbo_albuminfo.songid = dbo_musicfile.songid
inner join dbo_artist on dbo_artist.artistid = dbo_musicfile.artistid
where artistname = "yoasobi"
order by dbo_album.Title;

select dbo_user.username, dbo_playlistinfo.playlistid, dbo_playlistinfo.songid from dbo_user
inner join dbo_playlist on dbo_user.username = dbo_playlist.username
inner join dbo_playlistinfo on dbo_playlistinfo.playlistid = dbo_playlist.playlistid;

select * from dbo_musicfiles;
select * from dbo_album;
select * from dbo_albuminfo;
select * from dbo_user;
select * from dbo_playlist;
select * from dbo_playlistinfo;