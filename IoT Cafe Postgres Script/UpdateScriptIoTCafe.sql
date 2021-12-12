---Update User Function
 CREATE FUNCTION "public"."sp_updateuser"(
	_id integer, 
	_name char, 
	_email char,
	_password char,
	_phone integer,
	_image char,
	_rol integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catusers"
	SET "username"=_name, "useremail"=_email, "userpassword"=_password, "userphone"=_phone, "userimageurl"=_image, "userrolid"=_rol
	WHERE "userid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_updateuser"(1,'Isaac Molina', 's.zeledon.cbe@gmail.com', 'yknmkyk', 123456, 'Foto.png',1);
  
    ---Update Farm Function
 CREATE FUNCTION "public"."sp_updatefarm"(
	_id integer, 
	_name char, 
	_address char,
	_latitude decimal,
	_longitude decimal,
	_phone integer,
	_cooperative integer,
	_station integer,
	_user integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catfarm"
	SET "farmname"=_name, "farmaddress"=_address, "farmlatitude"=_latitude, "farmlongitude"=_longitude, "farmphone"=_phone, "farmcooperativeid"=_cooperative, "farmuserid"=_user, "farmstationid"=_station 
	WHERE "farmid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_updatefarm"(1,'Paraiso', 'Direccion', 475.12, 214.45, 123456, 1,1,1);

---Update Cooperative Function
 CREATE FUNCTION "public"."sp_updatecooperative"(
	_id integer, 
	_name char, 
	_address char,
	_phone integer,
	_email char,
	_user integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catcooperative"
	SET "cooperativename"=_name, "cooperativeaddress"=_address, "cooperativephone"=_phone, "cooperativeemail"=_email, "cooperativeuserid"=_user
	WHERE "cooperativeid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_updatecooperative"(1,'Prod', 'Direccion2', 4567, 'email@',1);

---Update Plot Function
 CREATE FUNCTION "public"."sp_updateplot"(
	_id integer, 
	_name char, 
	_startdate timestamp,
	_enddate timestamp,
	_area decimal,
	_measurement char,
	_farm integer,
	_variety integer,
	_user integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catplot"
	SET "plotname"=_name, "plotstartdatecycle"=_startdate, "plotenddatecycle"=_enddate, 
	"plotareadimension"=_area, "plotmeasurementtype"=_measurement, "plotfarmid"=_farm, 
	"plotuserid"=_user, "plotvarietyid"=_variety 
	WHERE "plotid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_updateplot"(1,'Parcela 2', '1999-01-08 04:05:06', '1999-01-08 04:05:06', 475.12, 'Metros Cuadrados', 1, 1,1);
 
 ---Update Rol Function
 CREATE FUNCTION "public"."sp_updaterol"(
	_id integer, 
	_name char)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catrol"
	SET "rolname"=_name
	WHERE "rolid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_updaterol"(1,'ICDF');
  
   ---Update Variety Function
 CREATE FUNCTION "public"."sp_updatevariety"(
	_id integer, 
	_name char)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catvariety"
	SET "varietydescripcion"=_name
	WHERE "varietyid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_updatevariety"(1,'Cacao');
  
   ---Update Station Function
 CREATE FUNCTION "public"."sp_updatestation"(
	_id integer, 
	_name char,
	_mac char,
	_description char)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catstation"
	SET "stationname"=_name, "stationmac"=_mac, "stationdescription"=_description
	WHERE "stationid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_updatestation"(1,'Prototipo 3', 'f4-f4-f4-f4', 'Prototipo No.3');
  
  ---Update Menu Function
 CREATE FUNCTION "public"."sp_updatemenu"(
	_id integer, 
	_name char,
	_url char,
	_rol integer,
    _father integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catmenu"
	SET "menuname"=_name, "menuurl"=_url, "menurol"=_rol, "menufatherid"=_father
	WHERE "menuid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_updatemenu"(1,'Menu 3', '*/*/', '1', 1);