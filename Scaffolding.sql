Create Database Journal

use Journal

Create table article (
	Id UNIQUEIDENTIFIER primary key not null DEFAULT NEWID(),
	Head nvarchar(30) not null,
	Body nvarchar(max) not null
)

Create table categories (
	Id UNIQUEIDENTIFIER primary key not null DEFAULT NEWID(),
	section nvarchar(30) not null,
)

Create table author (
	Id UNIQUEIDENTIFIER primary key not null DEFAULT NEWID(),
	FirstName nvarchar(20) not null,
	LastName nvarchar(20) not null
)

alter table article
add authorId UNIQUEIDENTIFIER

alter table article
add constraint FK_authID_article foreign key (authorId) references author(Id);

alter table categories
add articleId UNIQUEIDENTIFIER

alter table categories
add constraint FK_articleID_categ foreign key (articleId) references article(Id);

insert into Author (FirstName, LastName) values ('Warden', 'Howsden');
insert into Author (FirstName, LastName) values ('Yancy', 'Welden');
insert into Author (FirstName, LastName) values ('Dana', 'Peacey');
insert into Author (FirstName, LastName) values ('Maren', 'Renon');
insert into Author (FirstName, LastName) values ('Emmey', 'Frise');



insert into article (Head, Body) values ('Company: Original Cast Album', 'benchmark turn-key paradigms');
insert into article (Head, Body) values ('Compulsion', 'reinvent strategic metrics');
insert into article (Head, Body) values ('Secret Agent, The', 'generate customized metrics');
insert into article (Head, Body) values ('City of Fear', 'reinvent user-centric technologies');
insert into article (Head, Body) values ('Secret Life of Zoey, The', 'exploit cutting-edge action-items');
insert into article (Head, Body) values ('Amadeus', 'target robust infomediaries');
insert into article (Head, Body) values ('Rare Breed, The', 'envisioneer turn-key e-services');
insert into article (Head, Body) values ('Thank Your Lucky Stars', 'reinvent clicks-and-mortar e-commerce');
insert into article (Head, Body) values ('Employee of the Month', 'drive 24/365 interfaces');
insert into article (Head, Body) values ('Boys, Les', 'expedite bleeding-edge channels');

insert into categories (section) values ('Adventure|Children');
insert into categories (section) values ('Children|Drama');
insert into categories (section) values ('Crime|Drama|Mystery|Thriller');

select * from author