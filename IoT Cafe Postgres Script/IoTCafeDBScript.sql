create table catrol(
	rolid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	rolname varchar(30) unique not null,
	rolstatus boolean default true NOT NULL	
);

create table catmenu(
	menuid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	menurol integer not null,
	menuname varchar(75) not null,
	menuurl varchar(125) not null,
	menustatus boolean default true NOT NULL,
	menufatherid integer not null, 
	Foreign Key(menurol) references catrol(rolid),
	Foreign Key(menufatherid) references catmenu(menuid)
);

create table catusers(
	userid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	username varchar(75) unique not null, ---FirstName and LastName
	useremail varchar(60) unique not null,
	userpassword varchar(100) not null,
	userphone integer not null,
	userimageurl char(70) not null,
	userrolid integer not null, 
	userstatus boolean default true NOT NULL,
	Foreign Key(userrolid) references catrol(rolid)
);