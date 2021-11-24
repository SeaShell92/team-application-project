BEGIN TRANSACTION;
DROP TABLE IF EXISTS "Booking";
CREATE TABLE IF NOT EXISTS "Booking" (
	"Booking_ID"	INTEGER NOT NULL,
	"Emplyee_ID"	INTEGER NOT NULL,
	"Guest_ID"	INTEGER NOT NULL,
	"Booking_Date"	TEXT NOT NULL,
	"Check_In"	TEXT NOT NULL,
	"Check_Out"	TEXT NOT NULL,
	"No_Of_Nights"	INTEGER NOT NULL,
	"Total_Guests"	INTEGER NOT NULL,
	"Total_Breakfasts"	INTEGER NOT NULL,
	"Has_Paid"	TEXT NOT NULL,
	PRIMARY KEY("Booking_ID" AUTOINCREMENT),
	FOREIGN KEY("Emplyee_ID") REFERENCES "Employee",
	FOREIGN KEY("Guest_ID") REFERENCES "Guest"
);
DROP TABLE IF EXISTS "RoomBooking";
CREATE TABLE IF NOT EXISTS "RoomBooking" (
	"Room_ID"	INTEGER NOT NULL,
	"Booking_ID"	INTEGER NOT NULL,
	PRIMARY KEY("Room_ID","Booking_ID"),
	FOREIGN KEY("Room_ID") REFERENCES "Room",
	FOREIGN KEY("Booking_ID") REFERENCES "Booking"
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
DROP TABLE IF EXISTS "Guest";
CREATE TABLE IF NOT EXISTS "Guest" (
	"Guest_ID"	INTEGER NOT NULL,
	"Guest_Title"	TEXT NOT NULL,
	"Guest_First_Name"	TEXT NOT NULL,
	"Guest_Surname"	TEXT NOT NULL,
	"Guest_Tel"	INTEGER,
	"Guest_Email"	TEXT,
	PRIMARY KEY("Guest_ID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Room";
CREATE TABLE IF NOT EXISTS "Room" (
	"Room_ID"	INTEGER NOT NULL UNIQUE,
	"Room_Type"	TEXT NOT NULL,
	"Room_Name"	TEXT NOT NULL,
	"Price"	INTEGER NOT NULL,
	"Accessibility"	TEXT NOT NULL,
	"Room_Description"	TEXT,
	PRIMARY KEY("Room_ID" AUTOINCREMENT)
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
	PRIMARY KEY("Transaction_ID" AUTOINCREMENT),
	FOREIGN KEY("Employee_ID") REFERENCES "Employee",
	FOREIGN KEY("Booking_ID") REFERENCES "Booking"
);
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

INSERT INTO "Employee" ("Employee_ID","First_Name","Last_Name","Email","Address","Postcode","Role","Managed_By","Username","Password") VALUES (1,'Mark','Jones','mark.jones81@outlook.com','35 Wilson Road, Cardiff','CF5 4LL','Manager','','jones_m1','manager'),
 (2,'Charlotte','Walker','lotte_05@hotmail.co.uk','11 Ffordd Yr Afon, Cardiff','CF15 9TT','Receptionist',1,'walker_c1','staff');
COMMIT;
