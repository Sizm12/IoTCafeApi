---Change Status Cooperative Function
  CREATE FUNCTION "public"."sp_statuscooperative"(_id integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catcooperative"
		SET "cooperativestatus"=
		CASE WHEN "cooperativestatus"= true then false else true END
		WHERE "cooperativeid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_statuscooperative"(1)

---Change Status Farm Function
  CREATE FUNCTION "public"."sp_statusfarm"(_id integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catfarm"
		SET "farmstatus"=
		CASE WHEN "farmstatus"= true then false else true END
		WHERE "farmid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_statusfarm"(1)
  
  ---Change Status Plot Function
  CREATE FUNCTION "public"."sp_statusplot"(_id integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catplot"
		SET "plotstatus"=
		CASE WHEN "plotstatus"= true then false else true END
		WHERE "plotid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_statusplot"(1)
  
  ---Change Status User Function
  CREATE FUNCTION "public"."sp_statususer"(_id integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catusers"
		SET "userstatus"=
		CASE WHEN "userstatus"= true then false else true END
		WHERE "userid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_statususer"(1)
  
    ---Change Status Rol Function
  CREATE FUNCTION "public"."sp_statusrol"(_id integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catrol"
		SET "rolstatus"=
		CASE WHEN "rolstatus"= true then false else true END
		WHERE "rolid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_statusrol"(1)
  
 ---Change Status Variety Function
  CREATE FUNCTION "public"."sp_statusvariety"(_id integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catvariety"
		SET "varietystatus"=
		CASE WHEN "varietystatus"= true then false else true END
		WHERE "varietyid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_statusvariety"(1)
  
   ---Change Status Menu Function
  CREATE FUNCTION "public"."sp_statusmenu"(_id integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catmenu"
		SET "menustatus"=
		CASE WHEN "menustatus"= true then false else true END
		WHERE "menuid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_statusmenu"(1)
  
   ---Change Status Station Function
  CREATE FUNCTION "public"."sp_statusstation"(_id integer)
  RETURNS void AS
  $BODY$
      BEGIN
        UPDATE "public"."catstation"
		SET "stationstatus"=
		CASE WHEN "stationstatus"= true then false else true END
		WHERE "stationid"=_id;
      END;
  $BODY$
  LANGUAGE 'plpgsql' VOLATILE
  COST 100;
  
  select * from "public"."sp_statusstation"(1)