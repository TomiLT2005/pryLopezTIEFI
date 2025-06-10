CREATE DATABASE Auditoria;
GO

USE Auditoria;
GO

-- Tabla Roles
CREATE TABLE Roles (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(50) NOT NULL
);
GO

INSERT INTO Roles (Nombre) VALUES ('Admin'), ('Supervisor'), ('Usuario');
GO

-- Tabla Usuarios
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
VALUES 
('admin', 'tomi123', 'tomilopeztorres@gmail.com', '(03472) 582169', 1),
('supervisor', '123', 'supervisor@empresa.com', '(03472) 123456', 2), -- Supervisor
('usuario', '123', 'usuario@empresa.com', '(03472) 654321', 3); -- Usuario común
GO

-- Tabla Sesiones
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

-- Tabla Tareas
CREATE TABLE Tareas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);
GO

-- Tabla Lugares
CREATE TABLE Lugares (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);
GO

-- Tabla Registros
CREATE TABLE Registros (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FechaRegistro DATE NOT NULL,
    TareaId INT NOT NULL,
    LugarId INT NOT NULL,
    Insumos BIT NOT NULL DEFAULT 0,
    Vacacion BIT NOT NULL DEFAULT 0,
    Estudio BIT NOT NULL DEFAULT 0,
    Salario BIT NOT NULL DEFAULT 0,
    Recibo BIT NOT NULL DEFAULT 0,
    Comentarios NVARCHAR(255) NULL,
    FOREIGN KEY (TareaId) REFERENCES Tareas(Id),
    FOREIGN KEY (LugarId) REFERENCES Lugares(Id)
);
GO

-- Insertar Tareas
INSERT INTO Tareas (Nombre) VALUES 
('Auditoría'), 
('Consultas'), 
('Inspección'), 
('Reclamos'), 
('Visitas');
GO

-- Insertar Lugares
INSERT INTO Lugares (Nombre) VALUES 
('Empresa'), 
('Servicios'), 
('Oficina');
GO
