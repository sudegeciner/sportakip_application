USE sports_app;

CREATE TABLE IF NOT EXISTS users (
    id          INT           NOT NULL AUTO_INCREMENT,
    username    VARCHAR(50)   NOT NULL,
    password    VARCHAR(255)  NOT NULL,
    full_name   VARCHAR(100)  NULL,
    phone       VARCHAR(15)   NULL,
    role        ENUM('admin', 'user') NOT NULL DEFAULT 'user',
    created_at  TIMESTAMP     NOT NULL DEFAULT CURRENT_TIMESTAMP,

    CONSTRAINT pk_users          PRIMARY KEY (id),
    CONSTRAINT uq_users_username UNIQUE (username)
);

CREATE TABLE IF NOT EXISTS members (
	id 				INT 			NOT NULL AUTO_INCREMENT,
    full_name		VARCHAR(100)	NULL,
    password		VARCHAR(255)	NOT NULL,
    phone			VARCHAR(15)		NULL,
    birth_date		DATE			NULL,
    created_at		TIMESTAMP		NOT NULL DEFAULT CURRENT_TIMESTAMP,
    
    CONSTRAINT pk_members	PRIMARY KEY(id)
);

CREATE TABLE IF NOT EXISTS exercices (
	id					INT 			NOT NULL AUTO_INCREMENT,,
    member_id			INT				NOT NULL,
    activity			VARCHAR(100)	NOT NULL,
    duration			INT				NOT NULL,
    exercise_date		DATE			NOT NULL,
    created_at			TIMESTAMP		NOT NULL DEFAULT CURRENT_TIMESTAMP,
    
    CONSTRAINT pk_exercices 		PRIMARY KEY(member_id),
    CONSTRAINT fk_exercices_member	FOREIGN KEY(member_id) REFERENCES members(id)
);

CREATE TABLE IF NOT EXISTS progress(
	id				INT				NOT NULL AUTO_INCREMENT,
    member_id		INT				NOT NULL,
    photo_before	VARCHAR(255)	NULL,
    photo_after		VARCHAR(255)	NULL,
    note			TEXT			NULL,
    record_date		DATE			NOT NULL,
    
    CONSTRAINT pk_progress 			PRIMARY KEY(id),
    CONSTRAINT fk_progress_member 	FOREIGN KEY(member_id) REFERENCES members(id)
);

CREATE TABLE IF NOT EXISTS plans(
	id 				INT		NOT NULL AUTO_INCREMENT,
    member_id		INT		NOT NULL,
    plan_detail		TEXT	NOT NULL,
    plan_date		DATE	NOT NULL,
    
    CONSTRAINT pk_plans 		PRIMARY KEY(id),
    CONSTRAINT fk_plans_member  FOREIGN KEY (member_id) REFERENCES members(id)
);

INSERT INTO users(username, password, full_name, phone, role) VALUES
('admin', 'admin123',  'Sude Admin', '05415821460', 'admin'),
('sporcu01', 'pass123', 'Defne Çivrilli', '05326734130', 'user'),
('sporcu02', 'pass456', 'Aysu Çatar', '05224568142', 'user'),
('sporcu03', 'pass789', 'Şahan Geçiner', '05425125960', 'user');

INSERT INTO members(full_name, password, phone, birth_date) VALUES
('Defne Çivrilli', 'pass123', '05326734130', '2000-03-15'),
('Aysu Çatar', 'pass456', '05224568142', '1998-07-22'),
('Şahan Geçiner', 'pass789', '05425125960', '1995-11-05');

INSERT INTO exercices(member_id, activity, duration, exercise_date) VALUES
(1, 'Koşu', 30, '2026-04-01'),
(1, 'Yüzme', 45, '2026-04-03'),
(1, 'Ağırlık', 60, '2026-04-05'),
(2, 'Bisiklet', 40, '2026-04-02'),
(2, 'Pilates', 50, '2026-04-04'),
(3, 'Koşu', 25, '2026-04-01'),
(3, 'Ağırlık', 55, '2026-04-06');	

INSERT INTO progress(member_id, photo_before, photo_after, note, record_date) VALUES
(1, '', '', '3 ayda 5 kg verdi, form düzeldi', '2026-04-25'),
(2, '', '', '2 ayda 3 kg verdi, karın bölgesi', '2026-04-25'),
(3, '', '', '1 ayda kas kütlesi arttı', '2026-04-26');

INSERT INTO plans(member_id, plan_detail, plan_date) VALUES
(1, 'Pzt: Koşu 30dk | Çar: Yüzme 45dk | Cum: Ağırlık 1 saat', '2026-04-28'),
(2, 'Sal: Bisiklet 40dk | Per: Pilates 50dk | Cts: Yüzme 30dk', '2026-04-28'),
(3, 'Pzt: Ağırlık 55dk | Çar: Koşu 25dk | Cum: Bisiklet 45dk', '2026-04-28');

SHOW TABLES;
SELECT * FROM users;
SELECT * FROM members;
SELECT * FROM exercices;
SELECT * FROM progress;
SELECT * FROM plans;