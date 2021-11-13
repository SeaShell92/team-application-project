CREATE TABLE "Booking" (
	"Booking_ID"	INTEGER NOT NULL,
	"Emplyee_ID"	INTEGER NOT NULL,
	"Guest_ID"	INTEGER NOT NULL,
	"Booking_Date"	TEXT NOT NULL,
	"Check_In"	TEXT NOT NULL,
	"Check_Out"	TEXT NOT NULL,
	"No_Of_Nights"	INTEGER NOT NULL,
	"Total_Guests"	INTEGER NOT NULL,
	"Total_Breakfasts"	INTEGER NOT NULL,
	"Has_Paid"	INTEGER NOT NULL,
	PRIMARY KEY("Booking_ID" AUTOINCREMENT),
	FOREIGN KEY("Emplyee_ID") REFERENCES "Employee",
	FOREIGN KEY("Guest_ID") REFERENCES "Guest"
);

CREATE TABLE "Employee" (
	"Employee_ID"	INTEGER NOT NULL,
	"First_Name"	TEXT NOT NULL,
	"Last_Name"	TEXT NOT NULL,
	"Address"	TEXT NOT NULL,
	"Postcode"	TEXT NOT NULL,
	"Role"	TEXT NOT NULL,
	"Managed_By"	TEXT NOT NULL,
	PRIMARY KEY("Employee_ID" AUTOINCREMENT)
);

CREATE TABLE "Guest" (
	"Guest_ID"	INTEGER NOT NULL,
	"Guest_Title"	TEXT NOT NULL,
	"Guest_First_Name"	TEXT NOT NULL,
	"Guest_Surname"	TEXT NOT NULL,
	"Guest_Tel"	INTEGER NOT NULL,
	"Guest_Email"	TEXT,
	PRIMARY KEY("Guest_ID" AUTOINCREMENT)
);

CREATE TABLE "Room" (
	"Room_ID"	INTEGER NOT NULL UNIQUE,
	"Room_Type"	TEXT NOT NULL,
	"Room_Name"	TEXT NOT NULL,
	"Price"	TEXT NOT NULL,
	"Accessibility"	TEXT NOT NULL,
	"Room_Description"	TEXT,
	PRIMARY KEY("Room_ID" AUTOINCREMENT)
);

CREATE TABLE "RoomBooking" (
	"Room_ID"	INTEGER NOT NULL,
	"Booking_ID"	INTEGER NOT NULL,
	FOREIGN KEY("Room_ID") REFERENCES "Room",
	FOREIGN KEY("Booking_ID") REFERENCES "Booking",
	PRIMARY KEY("Room_ID","Booking_ID")
);

CREATE TABLE "Transactions" (
	"Transaction_ID"	INTEGER NOT NULL,
	"Employee_ID"	INTEGER NOT NULL,
	"Booking_ID"	INTEGER NOT NULL,
	"Payment_Date"	TEXT,
	"Amount_Due"	TEXT NOT NULL,
	"Amount_Paid"	TEXT NOT NULL,
	"Payment_Method"	TEXT,
	PRIMARY KEY("Transaction_ID" AUTOINCREMENT),
	FOREIGN KEY("Booking_ID") REFERENCES "Booking",
	FOREIGN KEY("Employee_ID") REFERENCES "Employee"
);


