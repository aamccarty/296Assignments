IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191209044052_Initial')
BEGIN
    CREATE TABLE [Jokes] (
        [JokeID] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [KeyWord] nvarchar(max) NULL,
        [JokeLine] nvarchar(max) NULL,
        [PubDate] datetime2 NOT NULL,
        CONSTRAINT [PK_Jokes] PRIMARY KEY ([JokeID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191209044052_Initial')
BEGIN
    CREATE TABLE [Users] (
        [UserId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Phone] nvarchar(max) NULL,
        [JokeID] int NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([UserId]),
        CONSTRAINT [FK_Users_Jokes_JokeID] FOREIGN KEY ([JokeID]) REFERENCES [Jokes] ([JokeID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191209044052_Initial')
BEGIN
    CREATE INDEX [IX_Users_JokeID] ON [Users] ([JokeID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20191209044052_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20191209044052_Initial', N'2.2.6-servicing-10079');
END;

GO

