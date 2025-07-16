-- CREAR TABLA ANIMAL
create table animal (
    id SERIAL PRIMARY KEY,
    nombre VARCHAR(255) NOT NULL,
    especie VARCHAR(255) not null,
    url_img VARCHAR(255) not null
);

-- INSRTAR DATOS
insert into animal (nombre, especie, url_img) values
('Perro', 'Canino', 'https://images.pexels.com/photos/733416/pexels-photo-733416.jpeg'),
('Gato', 'Felino', 'https://images.pexels.com/photos/104827/cat-pet-animal-domestic-104827.jpeg'),
('Loro', 'Ave', 'https://images.pexels.com/photos/2317904/pexels-photo-2317904.jpeg'),
('Tortuga', 'Reptil', 'https://images.pexels.com/photos/1618606/pexels-photo-1618606.jpeg'),
('Conejo', 'Mamifero', 'https://images.pexels.com/photos/372166/pexels-photo-372166.jpeg'),
('Hamster', 'Roedor', 'https://images.pexels.com/photos/3586056/pexels-photo-3586056.jpeg'),
('Tiburon', 'Pez', 'https://images.pexels.com/photos/11348763/pexels-photo-11348763.jpeg'),
('Cerdo', 'mamifero', 'https://images.pexels.com/photos/66258/staniel-cay-swimming-pig-seagull-fish-66258.jpeg');