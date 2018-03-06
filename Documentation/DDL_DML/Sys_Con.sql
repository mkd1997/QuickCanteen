create PROFILE app_user limit;

create tablespace data datafile 'C:\oraclexe\app\oracle\oradata\XE\qcdbf.dbf'
size 100M
autoextend on maxsize 300M
extent management local uniform size 64K;

CREATE USER qc IDENTIFIED BY qc
    DEFAULT TABLESPACE data
    QUOTA 100 M ON users
    PROFILE app_user;
    
grant create session to qc;    