DROP DATABASE IF EXISTS musiclibrary;

CREATE DATABASE musiclibrary;
USE musiclibrary;

CREATE TABLE dbo_user(
	username char(50),
    h_pass char(50),
    PRIMARY KEY (username)
);

CREATE TABLE dbo_salt(
	username char(50),
    salt char(50),
    FOREIGN KEY (username) REFERENCES dbo_user(username),
    PRIMARY KEY (username, salt)
);