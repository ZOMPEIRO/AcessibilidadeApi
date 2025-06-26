IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [TB_ACESSIBILIDADE] (
    [idAcessibilidade] int NOT NULL IDENTITY,
    [idUsuario] int NOT NULL,
    [modoContraste] bit NOT NULL,
    [tamanhoFonte] varchar(200) NOT NULL,
    [alertaSonoro] bit NOT NULL,
    [vibração] bit NOT NULL,
    CONSTRAINT [PK_TB_ACESSIBILIDADE] PRIMARY KEY ([idAcessibilidade])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'idAcessibilidade', N'alertaSonoro', N'idUsuario', N'modoContraste', N'tamanhoFonte', N'vibração') AND [object_id] = OBJECT_ID(N'[TB_ACESSIBILIDADE]'))
    SET IDENTITY_INSERT [TB_ACESSIBILIDADE] ON;
INSERT INTO [TB_ACESSIBILIDADE] ([idAcessibilidade], [alertaSonoro], [idUsuario], [modoContraste], [tamanhoFonte], [vibração])
VALUES (1, CAST(0 AS bit), 1, CAST(1 AS bit), '45', CAST(1 AS bit)),
(2, CAST(1 AS bit), 2, CAST(1 AS bit), '45', CAST(1 AS bit)),
(3, CAST(1 AS bit), 3, CAST(0 AS bit), '45', CAST(1 AS bit)),
(4, CAST(1 AS bit), 4, CAST(0 AS bit), '45', CAST(0 AS bit)),
(5, CAST(1 AS bit), 5, CAST(0 AS bit), '45', CAST(0 AS bit)),
(6, CAST(1 AS bit), 6, CAST(0 AS bit), '45', CAST(1 AS bit)),
(7, CAST(1 AS bit), 7, CAST(1 AS bit), '45', CAST(0 AS bit));
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'idAcessibilidade', N'alertaSonoro', N'idUsuario', N'modoContraste', N'tamanhoFonte', N'vibração') AND [object_id] = OBJECT_ID(N'[TB_ACESSIBILIDADE]'))
    SET IDENTITY_INSERT [TB_ACESSIBILIDADE] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250621213815_InitialCreate', N'9.0.6');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250625223218_InitialCreateSecond', N'9.0.6');

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250626002915_terceiraMigracao', N'9.0.6');

COMMIT;
GO

