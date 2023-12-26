DROP DATABASE IF EXISTS musiclibrary;

CREATE DATABASE musiclibrary;
USE musiclibrary;

CREATE TABLE dbo_user(
	username char(50),
    h_pass char(50),
    salt char(50),
    PRIMARY KEY (username)
);

SELECT * from dbo_user