BEGIN TRANSACTION;
DROP TABLE IF EXISTS "RoomBooking";
CREATE TABLE IF NOT EXISTS "RoomBooking" (
	"Room_ID"	INTEGER NOT NULL,
	"Booking_ID"	INTEGER NOT NULL,
	FOREIGN KEY("Booking_ID") REFERENCES "Booking",
	FOREIGN KEY("Room_ID") REFERENCES "Room",
	PRIMARY KEY("Room_ID","Booking_ID")
);
DROP TABLE IF EXISTS "Employee";
CREATE TABLE IF NOT EXISTS "Employee" (
	"Employee_ID"	INTEGER NOT NULL,
	"First_Name"	TEXT NOT NULL,
	"Last_Name"	TEXT NOT NULL,
	"Email"	TEXT NOT NULL,
	"Address"	TEXT NOT NULL,
	"Postcode"	TEXT NOT NULL,
	"Role"	TEXT NOT NULL,
	"Managed_By"	INTEGER,
	"Username"	TEXT NOT NULL,
	"Password"	TEXT NOT NULL,
	PRIMARY KEY("Employee_ID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Transactions";
CREATE TABLE IF NOT EXISTS "Transactions" (
	"Transaction_ID"	INTEGER NOT NULL,
	"Employee_ID"	INTEGER NOT NULL,
	"Booking_ID"	INTEGER NOT NULL,
	"Payment_Date"	TEXT NOT NULL,
	"Amount_Due"	INTEGER NOT NULL,
	"Amount_Paid"	INTEGER NOT NULL,
	"Payment_Method"	TEXT NOT NULL,
	"Description"	TEXT,
	FOREIGN KEY("Booking_ID") REFERENCES "Booking",
	FOREIGN KEY("Employee_ID") REFERENCES "Employee",
	PRIMARY KEY("Transaction_ID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Booking";
CREATE TABLE IF NOT EXISTS "Booking" (
	"Booking_ID"	INTEGER NOT NULL,
	"Employee_ID"	INTEGER NOT NULL,
	"Guest_ID"	INTEGER NOT NULL,
	"Booking_Date"	TEXT NOT NULL,
	"Check_In"	TEXT NOT NULL,
	"Check_Out"	TEXT NOT NULL,
	"No_Of_Nights"	INTEGER NOT NULL,
	"Total_Guests"	INTEGER NOT NULL,
	"Total_Breakfasts"	INTEGER NOT NULL,
	"Has_Paid"	TEXT NOT NULL,
	"Cancelled_By"	INTEGER,
	FOREIGN KEY("Employee_ID") REFERENCES "Employee",
	FOREIGN KEY("Guest_ID") REFERENCES "Guest",
	PRIMARY KEY("Booking_ID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Room";
CREATE TABLE IF NOT EXISTS "Room" (
	"Room_ID"	INTEGER NOT NULL,
	"Room_Type"	TEXT NOT NULL,
	"Room_Name"	TEXT NOT NULL,
	"Price"	INTEGER NOT NULL,
	"Accessibility"	TEXT NOT NULL,
	"Room_Description"	TEXT,
	PRIMARY KEY("Room_ID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Guest";
CREATE TABLE IF NOT EXISTS "Guest" (
	"Guest_ID"	INTEGER NOT NULL,
	"Guest_Title"	TEXT NOT NULL,
	"Guest_First_Name"	TEXT NOT NULL,
	"Guest_Surname"	TEXT NOT NULL,
	"Guest_Tel"	TEXT,
	"Guest_Email"	TEXT UNIQUE,
	PRIMARY KEY("Guest_ID" AUTOINCREMENT)
);
INSERT INTO "RoomBooking" ("Room_ID","Booking_ID") VALUES (7,1),
 (18,2),
 (19,2),
 (16,3),
 (17,3),
 (9,3),
 (21,4),
 (22,4),
 (14,4),
 (18,4),
 (12,4),
 (13,4),
 (11,4);
INSERT INTO "Employee" ("Employee_ID","First_Name","Last_Name","Email","Address","Postcode","Role","Managed_By","Username","Password") VALUES (1,'Mark','Jones','mark.jones81@outlook.com','35 Wilson Road, Cardiff','CF5 4LL','Manager',NULL,'jones_m1','manager'),
 (2,'Charlotte','Walker','lotte_05@hotmail.co.uk','11 Ffordd Yr Afon, Cardiff','CF15 9TT','Receptionist',1,'walker_c1','staff');
INSERT INTO "Booking" ("Booking_ID","Employee_ID","Guest_ID","Booking_Date","Check_In","Check_Out","No_Of_Nights","Total_Guests","Total_Breakfasts","Has_Paid","Cancelled_By") VALUES (1,2,1,'16/01/2022','2022-01-21','2022-01-23',2,1,2,'No',NULL),
 (2,2,2,'16/01/2022','2022-01-28','2022-01-30',2,4,2,'No',NULL),
 (3,1,3,'16/01/2022','2022-01-27','2022-01-30',3,5,10,'No',NULL),
 (4,1,4,'16/01/2022','2022-02-04','2022-02-11',7,10,30,'Yes',NULL);
INSERT INTO "Room" ("Room_ID","Room_Type","Room_Name","Price","Accessibility","Room_Description") VALUES (1,'Single','1A',70,'N/A','1 Guest Only'),
 (2,'Single','1B',70,'N/A','1 Guest Only'),
 (3,'Single','1C',70,'N/A','1 Guest Only'),
 (4,'Single','1D',70,'N/A','1 Guest Only'),
 (5,'Single','1E',70,'N/A','1 Guest Only'),
 (6,'Single','1F',70,'N/A','1 Guest Only'),
 (7,'Single','1G',70,'N/A','1 Guest Only'),
 (8,'Single','1H',70,'N/A','1 Guest Only'),
 (9,'Single','2A',70,'N/A','1 Guest Only'),
 (10,'Single','2B',70,'N/A','1 Guest Only'),
 (11,'Single','2C',70,'N/A','1 Guest Only'),
 (12,'Single','2D',70,'N/A','1 Guest Only'),
 (13,'Single','2E',70,'N/A','1 Guest Only'),
 (14,'Single','2F',70,'Disabled','1 Guest Only'),
 (15,'Single','2G',70,'Disabled','1 Guest Only'),
 (16,'Double','3A',110,'N/A','Up to 2 Guests'),
 (17,'Double','3B',110,'N/A','Up to 2 Guests'),
 (18,'Double','3C',110,'N/A','Up to 2 Guests'),
 (19,'Double','3D',110,'N/A','Up to 2 Guests'),
 (20,'Double','3E',110,'N/A','Up to 2 Guests'),
 (21,'Double','3F',110,'N/A','Up to 2 Guests'),
 (22,'Double','3G',110,'N/A','Up to 2 Guests'),
 (23,'Double','3H',110,'Disabled','Up to 2 Guests'),
 (24,'Family','4A',160,'N/A','Up to 4 Guests'),
 (25,'Family','4B',160,'N/A','Up to 4 Guests'),
 (26,'Family','4C',160,'Disabled','Up to 4 Guests'),
 (27,'Family','4D',160,'Disabled','Up to 4 Guests');
INSERT INTO "Guest" ("Guest_ID","Guest_Title","Guest_First_Name","Guest_Surname","Guest_Tel","Guest_Email") VALUES (1,'Miss','Joanna','Bickerdike','07463325894','jbickerdike4@outlook.com'),
 (2,'Mrs','Agna','Maria','07363797355','amaria2@gmail.com'),
 (3,'Mr','Robby','Plumley','07141279624','rplumley1@outlook.com'),
 (4,'Dr','Casper','Broadbent','','casperb3@hotmail.com');
COMMIT;
