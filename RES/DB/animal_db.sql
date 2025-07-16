-- CREAR TABLA ANIMAL
create table animal (
    id SERIAL PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    especie VARCHAR(255) not null
);

-- INSRTAR DATOS
insert into animal (nombre, especie) values
('Perro', 'Canino'),
('Gato', 'Felino'),
('Loro', 'Ave'),
('Tortuga', 'Reptil'),
('Conejo', 'Mamifero'),
('Hamster', 'Roedor'),
('Tiburon', 'Pez'),
('Cacatua', 'Ave'),
('Iguana', 'Reptil');