---Insert Rol Function
CREATE FUNCTION "public"."sp_addrol"(_name char)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catrol"(
		 "rolname")
	VALUES (_name);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addrol"('Mefcca');

---Insert Users Function
CREATE FUNCTION "public"."sp_adduser"(
	_name char,
	_email char,
	_password char, 
	_phone integer,
	_image char,
	_role integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catusers"(
		 "username", "useremail", "userpassword", "userphone", "userimageurl", "userrolid")
	VALUES (_name, _email, _password, _phone, _image, _role);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_adduser"('Samuel Zeledon', 'email3@email.com', 'pass123', 76923186, 'Image.jpg', 1);
  
---Insert Cooperative Function-----------------------
CREATE FUNCTION "public"."sp_addcooperative"(
	_name char, 
	_address char, 
	_email char,
	_phone integer,
	_userid integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catcooperative"(
		 "cooperativename", "cooperativeaddress", "cooperativeemail", "cooperativephone", "cooperativeuserid")
	VALUES (_name, _address, _email, _phone, _userid);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addcooperative"('Prodecop', 'Direccion Prodecoop','email@prodecop.com', 76923186, 1);

---Insert Station Function
CREATE FUNCTION "public"."sp_addstation"(
	_name char, 
	_mac char,
	_description char)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catstation"(
		 "stationname", "stationmac", "stationdescription")
	VALUES (_name, _mac, _description);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addstation"('Prototipo1', 'd1-d2-d3-d4','Prototipo Numero 1');

---Insert Farms Function
CREATE FUNCTION "public"."sp_addfarm"(
	_name char, 
	_address char, 
	_latitude decimal,
	_longitude decimal,
	_phone integer,
	_cooperative integer,
	_user integer,
	_station integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catfarm"(
		 "farmname", "farmaddress", "farmlatitude", "farmlongitude", "farmphone", "farmcooperativeid", "farmuserid", "farmstationid")
	VALUES (_name, _address, _latitude, _longitude, _phone, _cooperative, _user, _station);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addfarm"('El Paraiso', 'Direccion Finca', 475.12, 212.5, 76923186,1,1,1);

---Insert Variety Function
CREATE FUNCTION "public"."sp_addvariety"(_description char)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catvariety"(
		 "varietydescripcion")
	VALUES (_description);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addvariety"('Cafe');

---Insert Plots Function
CREATE FUNCTION "public"."sp_addplot"(
	_name char, 
	_startdate timestamp, 
	_enddate timestamp,
	_variety integer,
	_area decimal,
	_measurement char,
	_farm integer,
	_user integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catplot"(
		 "plotname", "plotstartdatecycle", "plotenddatecycle", "plotvarietyid", "plotareadimension", "plotmeasurementtype", "plotfarmid", "plotuserid")
	VALUES (_name, _startdate, _enddate, _variety, _area, _measurement, _farm, _user);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addplot"('Parcela 1','1999-01-08 04:05:06', '1999-01-08 04:05:06', 1, 475.5, 'Manzanas', 1, 1);

---Insert Gather Function
CREATE FUNCTION "public"."sp_addgather"( 
	_date timestamp, 
	_brix decimal,
	_humidity decimal,
	_photo char,
	_plot integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catgather"(
		 "gatherdate", "gatherbrix", "gatherseedhumidity", "gatherphoto", "gatherplotid")
	VALUES (_date, _brix, _humidity, _photo, _plot);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addgather"('1999-01-08 04:05:06', 16, 35, 'Foto', 1);

--Insert Washed Function
CREATE FUNCTION "public"."sp_addwashed"( 
	_date timestamp, 
	_weightpre decimal,
	_photopre char,
	_weightpost decimal,
	_photopost char,
	_plot integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catwashed"(
		 "washeddate", "washedweighprewashed", "washedphotoprewashed", "washedweighpostwashed", "washedphotopostwashed", "washedplotid")
	VALUES (_date, _weightpre, _photopre, _weightpost, _photopost, _plot);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addwashed"('1999-01-08 04:05:06', 35.1, 'Foto',35.1, 'Foto', 1);

--Insert Pulped Function
CREATE FUNCTION "public"."sp_addpulped"( 
	_date timestamp, 
	_weightpre decimal,
	_photopre char,
	_weightpost decimal,
	_photopost char,
	_plot integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catpulped"(
		 "pulpeddate", "pulpedweighprewashed", "pulpedphotoprewashed", "pulpedweighpostwashed", "pulpedphotopostwashed", "pulpedplotid")
	VALUES (_date, _weightpre, _photopre, _weightpost, _photopost, _plot);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addpulped"('1999-01-08 04:05:06', 35.1, 'Foto',35.1, 'Foto', 1);

--Insert Fermentation Function
CREATE FUNCTION "public"."sp_addfermentation"( 
	_date timestamp, 
	_brix decimal,
	_ph decimal,
	_photo char,
	_plot integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catfermentation"(
		 "fermentationdate", "fermentationbrix", "fermentationph", "fermentationphoto", "fermentationplotid")
	VALUES (_date, _brix, _ph, _photo, _plot);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addfermentation"('1999-01-08 04:05:06', 35.1, 6, 'Foto', 1);

--Insert Drying Function
CREATE FUNCTION "public"."sp_adddrying"( 
	_date timestamp, 
	_weight decimal,
	_humidity decimal,
	_photo char,
	_plot integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catdrying"(
		 "dryingdate", "dryingweight", "dryinghumidity", "dryingphoto", "dryingplotid")
	VALUES (_date, _weight, _humidity, _photo, _plot);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_adddrying"('1999-01-08 04:05:06', 35.1, 25.3, 'Foto', 1);

--Insert PlotCycle Function
CREATE FUNCTION "public"."sp_addplotcycle"( 
	_code integer, 
	_startdate timestamp, 
	_enddate timestamp,
	_plot integer)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catplotcycle"(
		 "plotcyclecode", "plotcyclestartdatecycle", "plotcycleenddatecycle", "plotcycleplotid")
	VALUES (_code, _startdate, _enddate, _plot);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addplotcycle"(145,'1999-01-08 04:05:06', '1999-01-08 04:05:06', 1);

--Insert Measurement Function
CREATE FUNCTION "public"."sp_addmeasurement"( 
	_name char)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catmeasurement"(
		 "measurementname")
	VALUES (_name);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addmeasurement"('Medida 1');

--Insert Menu Function
CREATE FUNCTION "public"."sp_addmenu"( 
	_name char,
	_rol integer,
	_url char,
	_father integer
)
  RETURNS void AS
  $BODY$
      BEGIN
        INSERT INTO "public"."catmenu"(
		 "menuname","menurol","menuurl","menufatherid")
	VALUES (_name, _rol, _url, _father);
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
select * from "public"."sp_addmenu"('Menu 2', 1, 'url2', 1);