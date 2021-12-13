---Select Cooperative Function
CREATE OR REPLACE FUNCTION "public"."sp_getcooperative"()
  RETURNS setof "public"."catcooperative" AS
$BODY$
   SELECT * FROM "public"."catcooperative"
$BODY$
  LANGUAGE sql VOLATILE
  COST 100
  ROWS 1000;
  select * from "public"."sp_getcooperative"()

 ---Select Farm Function 
  CREATE OR REPLACE FUNCTION "public"."sp_getfarm"()
  RETURNS setof "public"."catfarm" AS
$BODY$
   SELECT * FROM "public"."catfarm"
$BODY$
  LANGUAGE sql VOLATILE
  COST 100
  ROWS 1000;
select * from "public"."sp_getfarm"()

 ---Select Rol Function 
  CREATE OR REPLACE FUNCTION "public"."sp_getrol"()
  RETURNS setof "public"."catrol" AS
$BODY$
   SELECT * FROM "public"."catrol"
$BODY$
  LANGUAGE sql VOLATILE
  COST 100
  ROWS 1000;
select * from "public"."sp_getrol"()

 ---Select Plot Function 
  CREATE OR REPLACE FUNCTION "public"."sp_getplot"()
  RETURNS setof "public"."catplot" AS
$BODY$
   SELECT * FROM "public"."catplot"
$BODY$
  LANGUAGE sql VOLATILE
  COST 100
  ROWS 1000;
select * from "public"."sp_getplot"()

 ---Select Station Function 
  CREATE OR REPLACE FUNCTION "public"."sp_getstation"()
  RETURNS setof "public"."catstation" AS
$BODY$
   SELECT * FROM "public"."catstation"
$BODY$
  LANGUAGE sql VOLATILE
  COST 100
  ROWS 1000;
select * from "public"."sp_getstation"()

 ---Select Users Function 
  CREATE OR REPLACE FUNCTION "public"."sp_getuser"()
  RETURNS setof "public"."catusers" AS
$BODY$
   SELECT * FROM "public"."catusers"
$BODY$
  LANGUAGE sql VOLATILE
  COST 100
  ROWS 1000;
select * from "public"."sp_getuser"()

CREATE OR REPLACE FUNCTION public."sp_CatUserGetByCredential"(
	_email character,
	_password character)
    RETURNS TABLE(userid integer, rolid integer, rolname character varying) 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
begin 
	return query select A.userid, 
						B.rolid, 
						B.rolname 
				from catusers as A inner join catrol as B 
					on B.rolid=A.userrolid
				where A.useremail=_email 
					 and A.userpassword=_password 
					 and A.userstatus=true 
					 and B.rolstatus=true;
end;
$BODY$;

CREATE OR REPLACE FUNCTION public."sp_CatUserGetById"(
	_userid integer)
    RETURNS SETOF catusers 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
begin
	
return query select * from "public"."catusers" where userid=_userid;
	
end;
$BODY$;

 ---Select Menu Function 
  CREATE OR REPLACE FUNCTION "public"."sp_getmenu"()
  RETURNS setof "public"."catmenu" AS
$BODY$
   SELECT * FROM "public"."catmenu"
$BODY$
  LANGUAGE sql VOLATILE
  COST 100
  ROWS 1000;
select * from "public"."sp_getmenu"()

CREATE OR REPLACE FUNCTION public."sp_CatMenuGetByRolId"(_rolid integer)
    RETURNS SETOF catmenu 
    LANGUAGE 'plpgsql'
    COST 100
    VOLATILE PARALLEL UNSAFE
    ROWS 1000

AS $BODY$
begin

return query select * from "public"."catmenu" where menurol=_rolid;

end;
$BODY$;

 ---Select Variety Function 
  CREATE OR REPLACE FUNCTION "public"."sp_getvariety"()
  RETURNS setof "public"."catvariety" AS
$BODY$
   SELECT * FROM "public"."catvariety"
$BODY$
  LANGUAGE sql VOLATILE
  COST 100
  ROWS 1000;
select * from "public"."sp_getvariety"()

---Select Farms by Cooperative Id
CREATE OR REPLACE FUNCTION "public"."sp_findfarmbycooperative"(_id integer)
RETURNS setof "public"."catfarm" AS
$BODY$
SELECT * FROM "public"."catfarm" WHERE "farmcooperativeid"= _id
$BODY$
LANGUAGE sql VOLATILE
COST 100
ROWS 1000

select * from "public"."sp_findfarmbycooperative"(1)

---Select Plots  by Farm Id
CREATE OR REPLACE FUNCTION "public"."sp_findplotbyfarm"(_id integer)
RETURNS setof "public"."catplot" AS
$BODY$
SELECT * FROM "public"."catplot" WHERE "plotfarmid"= _id
$BODY$
LANGUAGE sql VOLATILE
COST 100
ROWS 1000

select * from "public"."sp_findfarmbycooperative"(1)

---Select users by Role Id
CREATE OR REPLACE FUNCTION "public"."sp_finduserbyrole"(_id integer)
RETURNS setof "public"."catusers" AS
$BODY$
SELECT * FROM "public"."catusers" WHERE "userrolid"= _id
$BODY$
LANGUAGE sql VOLATILE
COST 100
ROWS 1000

select * from "public"."sp_finduserbyrole"(1)