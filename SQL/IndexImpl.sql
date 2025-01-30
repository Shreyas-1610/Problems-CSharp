CREATE TABLE parts(
    part_id   INT NOT NULL, 
    part_name VARCHAR(100)
);

ALTER TABLE parts
ADD PRIMARY KEY(part_id);

INSERT INTO parts(part_id, part_name) VALUES
    (1,'Frame'),
    (2,'Head Tube'),
    (3,'Handlebar Grip'),
    (4,'Shock Absorber'),
    (5,'Fork');

CREATE CLUSTERED INDEX ix_parts_id
ON parts (part_id); 

SELECT 
    part_id, 
    part_name
FROM 
    parts
WHERE 
    part_id = 5;

CREATE TABLE part_prices(
    part_id int,
    valid_from date,
    price decimal(18,4) not null,
    PRIMARY KEY(part_id, valid_from) 
);
