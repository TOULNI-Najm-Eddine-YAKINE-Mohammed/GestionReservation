
CREATE TABLE chambre
(
    id serial NOT NULL,
    num integer NOT NULL,
    CONSTRAINT chambre_pkey PRIMARY KEY (id),
    CONSTRAINT chambre_num_key UNIQUE (num)
);

INSERT INTO chambre (num) VALUES (1);
INSERT INTO chambre (num) VALUES (2);
INSERT INTO chambre (num) VALUES (3);
INSERT INTO chambre (num) VALUES (4);
INSERT INTO chambre (num) VALUES (5);
INSERT INTO chambre (num) VALUES (6);
INSERT INTO chambre (num) VALUES (7);
INSERT INTO chambre (num) VALUES (8);
INSERT INTO chambre (num) VALUES (9);
INSERT INTO chambre (num) VALUES (10);
INSERT INTO chambre (num) VALUES (11);
INSERT INTO chambre (num) VALUES (12);


CREATE TABLE client
(
    id serial NOT NULL,
    name varchar(255) NOT NULL,
    cin varchar(255) NOT NULL,
    CONSTRAINT client_pkey PRIMARY KEY (id)
);


CREATE TABLE reservation
(
    id serial NOT NULL,
    date_from timestamp without time zone NOT NULL,
    date_to timestamp without time zone NOT NULL,
    id_chambre integer NOT NULL,
    id_client integer NOT NULL,
    CONSTRAINT reservation_pkey PRIMARY KEY (id),
    CONSTRAINT reservation_id_chambre_fkey FOREIGN KEY (id_chambre)
        REFERENCES chambre (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE,
    CONSTRAINT reservation_id_client_fkey FOREIGN KEY (id_client)
        REFERENCES client (id) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE
);

ALTER DATABASE "gestion_reservation" SET DateStyle=dmy, iso;
