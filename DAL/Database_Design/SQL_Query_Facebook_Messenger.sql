-- Create Facebook and Messenger Database
CREATE DATABASE FACEBOOKNMESSENGER
USE FACEBOOKNMESSENGER

-- Create User Table
CREATE TABLE Users (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    email_address VARCHAR(100) NOT NULL UNIQUE,
    phone_number VARCHAR(15),
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50),
    password VARCHAR(255) NOT NULL,
    created_datetime DATETIME,
    updated_datetime DATETIME,
);

-- Create Profile Table
CREATE TABLE Profiles (
    ID INT IDENTITY(1,1) PRIMARY KEY,
    user_id INT NOT NULL,
    first_name NVARCHAR(50) NOT NULL,
    last_name NVARCHAR(50),
    date_of_birth DATE,
    gender NVARCHAR(10) CHECK (gender IN ('Male', 'Female', 'Other')),
    country NVARCHAR(50),
    avatar_photo NVARCHAR(255),
    cover_photo NVARCHAR(255),
    bio NVARCHAR(MAX),
    FOREIGN KEY (user_id) REFERENCES Users(ID) ON DELETE CASCADE
);