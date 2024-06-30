CREATE TABLE Clientes (
    DNI INT PRIMARY KEY,
    Nombre VARCHAR(100) NOT NULL
);
CREATE TABLE Especies (
    IdEspecie INT PRIMARY KEY IDENTITY(1,1),
    NombreEspecie VARCHAR(100) NOT NULL,
    EdadMadurez INT NOT NULL,
    PesoPromedio DECIMAL(18,2) NOT NULL
);
CREATE TABLE Animales (
    IdAnimal INT PRIMARY KEY identity(1,1),
    NombreAnimal VARCHAR(100) NOT NULL,
    Peso DECIMAL(18,2) NOT NULL,
    Edad INT NOT NULL,
    DNICliente INT,
    IdEspecie INT,
    FOREIGN KEY (DNICliente) REFERENCES Clientes(DNI),
    FOREIGN KEY (IdEspecie) REFERENCES Especies(IdEspecie)
);
CREATE TABLE Usuarios (
    IdUsuario INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario VARCHAR(100) NOT NULL UNIQUE,
    Clave VARCHAR(100) NOT NULL
);