--create database iotcafe

create table catrol(
	rolid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	rolname varchar(30) unique not null,
	rolstatus boolean default true NOT NULL	
);

create table catmenu(
	menuid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	menurol integer not null,
	menuname varchar(75) not null,
	menuicon varchar(50) not null,
	menuurl varchar(125) not null,
	menuposition integer not null,
	menustatus boolean default true NOT NULL,
	menufatherid integer, 
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


create table catcooperative(
	cooperativeid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	cooperativename varchar(100) unique Not Null,
	cooperativeaddress varchar(200) Not Null,
	cooperativephone integer not null,
	cooperativeemail varchar(75) not null,
	cooperativeuserid integer not null,
	cooperativestatus boolean default true NOT NULL,
	foreign Key(cooperativeuserid) references catusers(userid)
);

create table catstation(
	stationid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	stationname varchar(60) unique not null,
	stationmac varchar(30) unique not null,
	stationdescription varchar(50) not null,
	stationstatus boolean default true NOT NULL
);

create table catfarm(
	farmid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	farmname varchar(50) unique not null,
	farmaddress varchar(60) not null,
	farmlatitude decimal,
	farmlongitude decimal,
	farmphone integer not null,
	farmcooperativeid integer,
	farmuserid integer,
	farmstatus boolean default true NOT NULL,
	farmstationid integer,
	Foreign Key(farmcooperativeid) references catcooperative(cooperativeid),
	Foreign Key(farmuserid) references catusers(userid),
	Foreign Key(farmstationid) references catstation(stationid)
);

create table catvariety(
	varietyid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	varietydescripcion varchar(50) not null,
	varietystatus boolean default true NOT NULL
);

create table catplot(
	plotid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	plotname varchar(50),
	plotstartdatecycle timestamp not null,
	plotenddatecycle timestamp not null,
	plotvarietyid integer,
	plotareadimension decimal not null,
	plotmeasurementtype varchar(50) not null,
	plotfarmid integer,
	plotuserid integer,
	plotstatus boolean default true NOT NULL,
	Foreign Key(plotvarietyid) references catvariety(varietyid),
	Foreign Key(plotfarmid) references catfarm(farmid),
	Foreign Key(plotuserid) references catUsers(userid)
);

create table catplotcycle(
	plotcycleid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	plotcyclecode integer Not Null,
	plotcyclestartdatecycle timestamp not null,
	plotcycleenddatecycle timestamp not null,
	plotcycleplotid integer,
	plotcyclestatus boolean default true NOT NULL,
	Foreign Key(plotcycleplotid) references catplot(plotid)
);

create table catgather(
	gatherid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	gatherdate timestamp not null,
	gatherbrix decimal not null,
	gatherseedhumidity decimal not null,
	gatherphoto varchar(50) not null,
	gatherplotid integer,
	gatherstatus boolean default false NOT NULL,
	Foreign Key(gatherplotid) references catplot(plotid)
);

create table catwashed(
	washedid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	washeddate timestamp not null,
	washedweighprewashed decimal not null,
	washedphotoprewashed varchar(50) not null,
	washedweighpostwashed decimal not null,
	washedphotopostwashed varchar(50) not null,
	washedplotid integer,
	washedstatus boolean default false NOT NULL,
	Foreign Key(washedplotid) references catplot(plotid)
);

create table catpulped(
	pulpedid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	pulpeddate timestamp not null,
	pulpedweighprewashed decimal not null,
	pulpedphotoprewashed varchar(50) not null,
	pulpedweighpostwashed decimal not null,
	pulpedphotopostwashed varchar(50) not null,
	pulpedplotid integer,
	pulpedstatus boolean default false NOT NULL,
	Foreign Key(pulpedplotid) references catplot(plotid)
);

create table catfermentation(
	fermentationid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	fermentationdate timestamp not null,
	fermentationbrix decimal not null,
	fermentationph decimal not null,
	fermentationphoto varchar(50) not null,
	fermentationplotid integer,
	fermentationstatus boolean default false NOT NULL,
	Foreign Key(fermentationplotid) references catplot(plotid)
);

create table catdrying(
	dryingid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	dryingdate timestamp not null,
	dryingweight decimal not null,
	dryinghumidity decimal not null,
	dryingphoto varchar(50) not null,
	dryingplotid integer,
	dryingstatus boolean default false NOT NULL,
	Foreign Key(dryingplotid) references catplot(plotid)
);

create table catprocess(
	processid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	processname varchar(50) not null,
	processorder integer not null,
	processstatus boolean default true NOT NULL
);

create table catsubprocess(
	subprocessid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	subprocessname varchar(50) not null,
	subprocessorder integer not null,
	subprocessprocessid integer,
	subprocessstatus boolean default true NOT NULL,
	Foreign Key(subprocessprocessid) references catprocess(processid)
);

create table catmeasurement(
	measurementid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	measurementname varchar(50) not null,
	measurementstatus boolean default true NOT NULL
);

create table CatParameterType(
	parametertypeid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	parametertypedescription varchar(50) not null,
	parametertypesubprocessid integer not null,
	parametertypemeasurementid integer not null,
	parametertypeinitialrange decimal not null,
	parametertypeendrange decimal not null,
	Foreign Key(parametertypesubprocessid) references catsubprocess(subprocessid),
	Foreign Key(parametertypemeasurementid) references catmeasurement(measurementid)
);

create table cattraveler(
	travelerid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	travelerplot integer,
	travelerprocess integer,
	travelersubprocessid integer,
	travelerstatus boolean default true NOT NULL,
	Foreign Key(travelerplot) references catplot(plotid),
	Foreign Key(travelerprocess) references catprocess(processid),
	Foreign Key(travelersubprocessid) references catsubprocess(subprocessid)
);

create table catcomponent(
	componentid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	componentname varchar(50) not null,
	componentstatus boolean default true not null
);

create table catsensor(
	sensorid integer Primary Key GENERATED ALWAYS AS IDENTITY NOT NULL,
	sensordate timestamp not null,
	sensorfarm integer not null,
	sensorstation integer not null,
	sensorcomponent integer not null,
	sensorvalue decimal not null,
	Foreign Key(sensorcomponent) references catcomponent(componentid),
	Foreign Key(sensorfarm) references catfarm(farmid),
	Foreign Key(sensorstation) references catstation(stationid)
);