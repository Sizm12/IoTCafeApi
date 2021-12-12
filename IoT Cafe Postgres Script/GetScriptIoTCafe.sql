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