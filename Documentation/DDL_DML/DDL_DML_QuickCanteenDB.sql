--------------------------------------------------------
--  File created - Friday-October-13-2017   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table ADMIN_MASTER
--------------------------------------------------------

  CREATE TABLE "MKD"."ADMIN_MASTER" 
   (	"ADMIN_ID" NVARCHAR2(50), 
	"PASS" NVARCHAR2(50), 
	"UNAME" NVARCHAR2(50)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table CANTEEN_MASTER
--------------------------------------------------------

  CREATE TABLE "MKD"."CANTEEN_MASTER" 
   (	"CANTEEN_ID" NVARCHAR2(50), 
	"WALLET1" NUMBER(10,2) DEFAULT ( 0 ), 
	"OPEN_TIME" TIMESTAMP (9), 
	"CLOSE_TIME" TIMESTAMP (9), 
	"RATING" NUMBER(5,1) DEFAULT ( 0 ), 
	"ORDER_LIMIT" NUMBER(*,0) DEFAULT ( 0 ), 
	"PH_NO" NUMBER(*,0), 
	"UNAME" NVARCHAR2(50), 
	"PASS" NVARCHAR2(50)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table FOOD_MASTER
--------------------------------------------------------

  CREATE TABLE "MKD"."FOOD_MASTER" 
   (	"FOOD_ITEM_ID" NUMBER(*,0), 
	"NAME" NCHAR(10)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table MENU_MASTER
--------------------------------------------------------

  CREATE TABLE "MKD"."MENU_MASTER" 
   (	"CANTEEN_ID" NVARCHAR2(50), 
	"FOOD_ITEM_ID" NUMBER(*,0), 
	"QTY" NUMBER(*,0), 
	"RATE" NUMBER(*,0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table ORDER_DETAIL
--------------------------------------------------------

  CREATE TABLE "MKD"."ORDER_DETAIL" 
   (	"ORDER_ID" NUMBER(*,0), 
	"FOOD_ITEM_ID" NUMBER(*,0), 
	"QTY" NUMBER(*,0) DEFAULT ( 0 ), 
	"RATE" NUMBER(18,2)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table ORDER_HEADER
--------------------------------------------------------

  CREATE TABLE "MKD"."ORDER_HEADER" 
   (	"ORDER_ID" NUMBER(*,0), 
	"STU_ID" NVARCHAR2(50), 
	"CANTEEN_ID" NVARCHAR2(50), 
	"AMOUNT" NUMBER(*,0), 
	"STATUS" NVARCHAR2(50), 
	"ORDER_DATE" TIMESTAMP (9)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  DDL for Table STUDENT_MASTER
--------------------------------------------------------

  CREATE TABLE "MKD"."STUDENT_MASTER" 
   (	"ID" NVARCHAR2(50), 
	"NAME" NVARCHAR2(50), 
	"COLLEGE" NVARCHAR2(50), 
	"UNAME" NVARCHAR2(50), 
	"PASS" NVARCHAR2(50), 
	"WALLET" NUMBER(*,0), 
	"BDATE" DATE, 
	"PH_NO" NUMBER(*,0) DEFAULT (0)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
REM INSERTING into MKD.ADMIN_MASTER
SET DEFINE OFF;
Insert into MKD.ADMIN_MASTER (ADMIN_ID,PASS,UNAME) values ('A1','mkd','mkd');
Insert into MKD.ADMIN_MASTER (ADMIN_ID,PASS,UNAME) values ('A2','vsm','vsm');
Insert into MKD.ADMIN_MASTER (ADMIN_ID,PASS,UNAME) values ('A3','sn','sn');
Insert into MKD.ADMIN_MASTER (ADMIN_ID,PASS,UNAME) values ('A4','sdf','ppp');
REM INSERTING into MKD.CANTEEN_MASTER
SET DEFINE OFF;
Insert into MKD.CANTEEN_MASTER (CANTEEN_ID,WALLET1,OPEN_TIME,CLOSE_TIME,RATING,ORDER_LIMIT,PH_NO,UNAME,PASS) values ('CM1',0,null,null,3.4,10,919876543210,'abc','abc');
Insert into MKD.CANTEEN_MASTER (CANTEEN_ID,WALLET1,OPEN_TIME,CLOSE_TIME,RATING,ORDER_LIMIT,PH_NO,UNAME,PASS) values ('CM2',0,null,null,4.3,15,919123456789,'def','def');
Insert into MKD.CANTEEN_MASTER (CANTEEN_ID,WALLET1,OPEN_TIME,CLOSE_TIME,RATING,ORDER_LIMIT,PH_NO,UNAME,PASS) values ('CM3',0,null,null,4,12,9194123567890,'xyz','xyz');
REM INSERTING into MKD.FOOD_MASTER
SET DEFINE OFF;
Insert into MKD.FOOD_MASTER (FOOD_ITEM_ID,NAME) values (1,'Sandwich  ');
Insert into MKD.FOOD_MASTER (FOOD_ITEM_ID,NAME) values (2,'Dosa      ');
REM INSERTING into MKD.MENU_MASTER
SET DEFINE OFF;
Insert into MKD.MENU_MASTER (CANTEEN_ID,FOOD_ITEM_ID,QTY,RATE) values ('CM1',1,30,20);
Insert into MKD.MENU_MASTER (CANTEEN_ID,FOOD_ITEM_ID,QTY,RATE) values ('CM2',1,10,30);
Insert into MKD.MENU_MASTER (CANTEEN_ID,FOOD_ITEM_ID,QTY,RATE) values ('CM1',2,15,40);
REM INSERTING into MKD.ORDER_DETAIL
SET DEFINE OFF;
Insert into MKD.ORDER_DETAIL (ORDER_ID,FOOD_ITEM_ID,QTY,RATE) values (1,1,2,20);
Insert into MKD.ORDER_DETAIL (ORDER_ID,FOOD_ITEM_ID,QTY,RATE) values (1,2,1,40);
REM INSERTING into MKD.ORDER_HEADER
SET DEFINE OFF;
Insert into MKD.ORDER_HEADER (ORDER_ID,STU_ID,CANTEEN_ID,AMOUNT,STATUS,ORDER_DATE) values (1,'S1','CM1',40,'pending',null);
REM INSERTING into MKD.STUDENT_MASTER
SET DEFINE OFF;
Insert into MKD.STUDENT_MASTER (ID,NAME,COLLEGE,UNAME,PASS,WALLET,BDATE,PH_NO) values ('S1','ghi','DDU','ghi','ghi',20,to_date('18-04-97','DD-MM-RR'),919213456780);
Insert into MKD.STUDENT_MASTER (ID,NAME,COLLEGE,UNAME,PASS,WALLET,BDATE,PH_NO) values ('S2','jkl','Nirma','jkl','jkl',40,to_date('27-06-97','DD-MM-RR'),919412356780);
--------------------------------------------------------
--  DDL for Index PK_STUDENT_MASTER
--------------------------------------------------------

  CREATE UNIQUE INDEX "MKD"."PK_STUDENT_MASTER" ON "MKD"."STUDENT_MASTER" ("ID", "UNAME") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM" ;
--------------------------------------------------------
--  Constraints for Table CANTEEN_MASTER
--------------------------------------------------------

  ALTER TABLE "MKD"."CANTEEN_MASTER" ADD CONSTRAINT "PH_CONST" CHECK (
    ph_no LIKE '91%'
) ENABLE;
  ALTER TABLE "MKD"."CANTEEN_MASTER" ADD PRIMARY KEY ("UNAME", "CANTEEN_ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table STUDENT_MASTER
--------------------------------------------------------

  ALTER TABLE "MKD"."STUDENT_MASTER" ADD CONSTRAINT "PK_STUDENT_MASTER" PRIMARY KEY ("ID", "UNAME")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table ADMIN_MASTER
--------------------------------------------------------

  ALTER TABLE "MKD"."ADMIN_MASTER" ADD PRIMARY KEY ("ADMIN_ID", "UNAME")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table MENU_MASTER
--------------------------------------------------------

  ALTER TABLE "MKD"."MENU_MASTER" ADD PRIMARY KEY ("CANTEEN_ID", "FOOD_ITEM_ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table FOOD_MASTER
--------------------------------------------------------

  ALTER TABLE "MKD"."FOOD_MASTER" ADD PRIMARY KEY ("FOOD_ITEM_ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Constraints for Table ORDER_HEADER
--------------------------------------------------------

  ALTER TABLE "MKD"."ORDER_HEADER" ADD PRIMARY KEY ("ORDER_ID")
  USING INDEX PCTFREE 10 INITRANS 2 MAXTRANS 255 COMPUTE STATISTICS 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1 BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "SYSTEM"  ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table MENU_MASTER
--------------------------------------------------------

  ALTER TABLE "MKD"."MENU_MASTER" ADD CONSTRAINT "FII_FK" FOREIGN KEY ("FOOD_ITEM_ID")
	  REFERENCES "MKD"."FOOD_MASTER" ("FOOD_ITEM_ID") ENABLE;
--------------------------------------------------------
--  Ref Constraints for Table ORDER_DETAIL
--------------------------------------------------------

  ALTER TABLE "MKD"."ORDER_DETAIL" ADD CONSTRAINT "OD_FK" FOREIGN KEY ("ORDER_ID")
	  REFERENCES "MKD"."ORDER_HEADER" ("ORDER_ID") ENABLE;
