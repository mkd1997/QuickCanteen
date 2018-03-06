CREATE TABLE account_master (
    uname   NVARCHAR2(50) PRIMARY KEY references ,
    pass    NVARCHAR2(50),
    role1   NVARCHAR2(50)
        CONSTRAINT role_const CHECK (
                role1 = 'admin'
            OR
                role1 = 'manager'
            OR
                role1 = 'student'
        )
);

CREATE TABLE canteen_master (
    canteen_id    NVARCHAR2(50),
    wallet1       NUMERIC(10,2) DEFAULT ( 0 ),
    open_time     TIMESTAMP(7),
    close_time    TIMESTAMP(7),
    rating        DECIMAL(5,1) DEFAULT ( 0 ),
    order_limit   INT DEFAULT ( 0 ),
    ph_no         INT,
    uname         NVARCHAR2(50),
    pass          NVARCHAR2(50),
    PRIMARY KEY ( uname,canteen_id )
);

CREATE TABLE admin_master (
    admin_id   NVARCHAR2(50),
    pass       NVARCHAR2(50),
    uname      NVARCHAR2(50),
    PRIMARY KEY ( admin_id,uname )
);

CREATE TABLE canteen_master (
    canteen_id    NVARCHAR2(50),
    wallet1       NUMERIC(10,2) DEFAULT ( 0 ),
    open_time     TIMESTAMP(7),
    close_time    TIMESTAMP(7),
    rating        DECIMAL(5,1) DEFAULT ( 0 ),
    order_limit   INT DEFAULT ( 0 ),
    ph_no         INT,
    uname         NVARCHAR2(50),
    pass          NVARCHAR2(50),
    PRIMARY KEY ( uname,canteen_id )
);

CREATE TABLE food_master (
    food_item_id   INT PRIMARY KEY,
    name           NCHAR(10)
);

CREATE TABLE menu_master (
    canteen_id     NVARCHAR2(50),
    food_item_id   INT,
    qty            INT,
    rate           INT,
    PRIMARY KEY ( canteen_id,food_item_id ),
    CONSTRAINT fii_fk FOREIGN KEY ( food_item_id )
        REFERENCES food_master
);

CREATE TABLE order_detail (
    order_id       INT,
    food_item_id   INT,
    qty            INT DEFAULT ( 0 ),
    rate           DECIMAL(18,2),
    CONSTRAINT od_fk FOREIGN KEY ( order_id )
        REFERENCES order_header
);

CREATE TABLE order_header (
    order_id      INT,
    stu_id        NVARCHAR2(50),
    canteen_id    NVARCHAR2(50),
    order_dated   DATE,
    amount        INT,
    status        NVARCHAR2(50),
    PRIMARY KEY ( order_id )
);

CREATE TABLE student_master (
    id        NVARCHAR2(50),
    name      NVARCHAR2(50),
    college   NVARCHAR2(50),
    uname     NVARCHAR2(50),
    pass      NVARCHAR2(50),
    wallet    INT,
    bdate     DATE,
    ph_no     INT DEFAULT ( 0 ),
    CONSTRAINT pk_student_master PRIMARY KEY ( id,uname )
);
