BEGIN TRANSACTION;
INSERT INTO "Employee" ("Employee_ID","First_Name","Last_Name","Address","Postcode","Role","Managed_By") VALUES (1,'Mark','Jones','35 Wilson Rd, Cardiff','CF5 4LL','Manager',''),
 (2,'Charlotte','Walker','11 Ffordd Yr Afon, Cardiff','CF15 9TT','Receptionist','1');
COMMIT;
