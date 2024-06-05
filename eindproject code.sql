
drop schema if exists eindproject_itn6;
create schema if not exists eindproject_itn6;
use eindproject_itn6;




drop table if exists eindproject_itn6.team;
create table if not exists eindproject_itn6.team(
idteam int not null auto_increment,
naamteam varchar(50),
afkortingteamnaam varchar(10),
werelddeel varchar(25),
primary key(idteam)
);




drop table if exists eindproject_itn6.game;
create table if not exists eindproject_itn6.game(
 IdGame INT AUTO_INCREMENT ,
    GameName VARCHAR(255) NOT NULL,
    DateGame DATE NOT NULL,
    WinnerTeamId INT NOT NULL,
    LoserTeamId INT NOT NULL,
    ScoreWinner INT,
    ScoreLoser INT,
    GameTime INT,
primary key(IdGame),
FOREIGN KEY (WinnerTeamId) REFERENCES eindproject_itn6.team(idteam),
FOREIGN KEY (LoserTeamId) REFERENCES eindproject_itn6.team(idteam)
);




drop table if exists eindproject_itn6.speler;
create table if not exists eindproject_itn6.speler(
idspeler int not null auto_increment,
naamspeler varchar(30),
geboortedatumspeler date,
nationaliteitspeler text not null,
geslachtspeler varchar(1),
FKTeam int, 
primary key (idspeler),
foreign key(FKTeam) references eindproject_itn6.team(idteam)
);

insert into eindproject_itn6.team
(idteam,naamteam,afkortingteamnaam,werelddeel) values
/*("Team1","Teamz","Europa");*/
('1','Team Liquid', 'TL', 'Noord-Amerika'),
('2','Fnatic', 'FNC', 'Europa'),
('3','Natus Vincere', 'NAVI', 'Europa'),
('4','Astralis', 'AST', 'Europa'),
('5','Evil Geniuses', 'EG', 'Noord-Amerika');


insert into eindproject_itn6.game
(GameName,DateGame,WinnerTeamId,LoserTeamId,ScoreWinner,ScoreLoser,GameTime) values 
('VALORANT', '2003-05-10', 1, 2, 2, 1, 14589),
('VALORANT', '2005-12-17', 2, 1, 3, 0, 33578),
('VALORANT', '2007-07-13', 3, 1, 2, 1, 1798),
('Counter-Strike', '2021-01-15', 4, 5, 16, 12, 3600),
('Counter-Strike', '2021-02-20', 5, 3, 16, 14, 3900),
('Dota 2', '2021-03-25', 3, 2, 2, 0, 2700),
('Dota 2', '2021-04-30', 1, 4, 2, 1, 3000),
('League of Legends', '2021-05-05', 2, 5, 3, 2, 3200),
('League of Legends', '2021-06-10', 5, 4, 3, 1, 3100),
('Overwatch', '2021-07-15', 4, 1, 4, 3, 3500),
('Overwatch', '2021-08-20', 1, 3, 4, 2, 3600),
('Rocket League', '2021-09-25', 3, 5, 5, 4, 2000),
('Rocket League', '2021-10-30', 2, 1, 5, 3, 1900),
('Fortnite', '2021-11-05', 1, 2, 1, 0, 1200),
('Fortnite', '2021-12-10', 5, 3, 1, 0, 1100),
('Apex Legends', '2022-01-15', 4, 1, 2, 1, 1300),
('Apex Legends', '2022-02-20', 3, 2, 2, 0, 1400),
('PUBG', '2022-03-25', 5, 4, 1, 0, 1600),
('PUBG', '2022-04-30', 2, 3, 1, 0, 1700),
('Call of Duty', '2022-05-05', 4, 5, 2, 1, 1800);







insert into eindproject_itn6.speler
(naamspeler,geboortedatumspeler,FKTeam, nationaliteitspeler,geslachtspeler) values
('Jake Yip "Stewie2k"', '1998-01-07', 1, 'Verenigde Staten', 'M'),
('Keith Markovic "NAF"', '1998-06-05', 1, 'Canada', 'M'),
('Jonathan Jablonowski "EliGE"', '1997-07-02', 1, 'Verenigde Staten', 'M'),
('Russel Van Dulken "Twistzz"', '1999-01-14', 1, 'Canada', 'M'),
('Michael Wince "Grim"', '2000-07-03', 1, 'Verenigde Staten', 'M'),
('Ludvig Brolin "Brollan"', '2002-06-17', 2, 'Zweden', 'M'),
('Freddy Johansson "KRIMZ"', '1994-04-01', 2, 'Zweden', 'M'),
('Jesper Wecksell "JW"', '1995-02-23', 2, 'Zweden', 'M'),
('Ludwig Ahgren "Flusha"', '1993-08-19', 2, 'Zweden', 'M'),
('Maikil Selim "Golden"', '1994-06-05', 2, 'Zweden', 'M'),
('Egor Vasilyev "flamie"', '1997-04-05', 3, 'Rusland', 'M'),
('Oleksandr Kostyliev "s1mple"', '1997-10-02', 3, 'Oekraïne', 'M'),
('Denis Sharipov "electronic"', '1998-09-02', 3, 'Rusland', 'M'),
('Egor Zhabotinsky "1uke"', '1998-07-22', 3, 'Rusland', 'M'),
('Kirill Mikhailov "Boombl4"', '1998-05-22', 3, 'Rusland', 'M'),
('Nicolai Reedtz "dev1ce"', '1995-09-08', 4, 'Denemarken', 'M'),
('Peter Rasmussen "dupreeh"', '1993-03-26', 4, 'Denemarken', 'M'),
('Andreas Højsleth "Xyp9x"', '1995-09-11', 4, 'Denemarken', 'M'),
('Emil Reif "Magisk"', '1998-03-05', 4, 'Denemarken', 'M'),
('Lukas Rossander "gla1ve"', '1995-12-07', 4, 'Denemarken', 'M'),
('Vincent Cayonte "Brehze"', '1998-05-22', 5, 'Verenigde Staten', 'M'),
('Ethan Arnold "Ethan"', '2000-06-26', 5, 'Verenigde Staten', 'M'),
('Tarik Celik "tarik"', '1996-02-19', 5, 'Verenigde Staten', 'M'),
('Peter Jarguz "stanislaw"', '1994-06-08', 5, 'Canada', 'M'),
('Tsvetelin Dimitrov "CeRq"', '1999-09-05', 5, 'Bulgarije', 'M');




Select * FROM eindproject_itn6.speler;

select s.*
from eindproject_itn6.speler  as s
join  eindproject_itn6.team as t on t.idteam = s.FKTeam
where t.idteam=1
order by t.idteam,s.naamspeler desc;




select * 
from eindproject_itn6.speler s for update;


