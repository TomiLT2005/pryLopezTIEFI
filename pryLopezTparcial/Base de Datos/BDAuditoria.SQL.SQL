CREATE DATABASE Auditoria;
GO


USE Auditoria;
GO


CREATE TABLE Roles (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL
);
GO


INSERT INTO Roles (Nombre) VALUES ('Admin'), ('Usuario');
GO


CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL,
    Contraseña NVARCHAR(50) NOT NULL,
    Correo NVARCHAR(100),
    Telefono NVARCHAR(20),
    RolId INT NOT NULL,
    FOREIGN KEY (RolId) REFERENCES Roles(Id)
);
GO


INSERT INTO Usuarios (Nombre, Contraseña, Correo, Telefono, RolId)
VALUES ('admin', 'tomi123', 'tomilopeztorres@gmail.com', '(03472) 582169', 1);
GO



CREATE TABLE Sesiones (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdUsuario INT NOT NULL,
    FechaInicio DATE NOT NULL,
    HoraInicio TIME(0) NOT NULL,
    HoraFin TIME(0) NOT NULL,
    TiempoTranscurrido TIME(0) NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(Id)
);
GO
