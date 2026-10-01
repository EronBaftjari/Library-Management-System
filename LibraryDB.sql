DROP TABLE MEMBERS CASCADE CONSTRAINTS;
DROP TABLE Genres CASCADE CONSTRAINTS;
DROP TABLE Books CASCADE CONSTRAINTS;
DROP TABLE LoanBooks CASCADE CONSTRAINTS;
DROP TABLE Loans CASCADE CONSTRAINTS;


PROMPT CREATING Table MEMBERS
PROMPT
CREATE TABLE MEMBERS(
MemberID NUMERIC (4) ,
Forename VARCHAR2 (30) ,
Surname VARCHAR2 (30),
DateOfBirth DATE,
PhoneNumber VARCHAR2 (10),
Address VARCHAR2 (50),
County VARCHAR2 (30),
City VARCHAR2 (25),
PostCode VARCHAR2 (8),
Active VARCHAR2(1) DEFAULT 'Y' ,
JoinDate Date DEFAULT SYSDATE ,
CONSTRAINT pk_Members PRIMARY KEY (MemberID)

);

PROMPT CREATING Table GENRES
PROMPT 
CREATE TABLE Genres(
GenreID NUMERIC(3),
GenreName VARCHAR2 (20),
CONSTRAINT pk_Genres PRIMARY KEY (GenreID)
);



PROMPT CREATING Table Books
PROMPT
CREATE TABLE Books(
BookID NUMERIC(4),
GenreID NUMERIC(4),
Title VARCHAR2 (30),
Author VARCHAR2 (20),
ISBN VARCHAR2 (10),
PublishedDate Date,
isAvailable VARCHAR2(1) DEFAULT 'Y',
CONSTRAINT pk_Books PRIMARY KEY(BookID),
CONSTRAINT fk_Genres_Books FOREIGN KEY(GenreID) REFERENCES Genres(GenreID)

);

PROMPT CREATING Table Loans
PROMPT
CREATE TABLE Loans(
LoanID NUMERIC(4),
MemberID NUMERIC(4),
LoanDate DATE DEFAULT SYSDATE,
DueDate DATE DEFAULT SYSDATE + 14,
CONSTRAINT pk_Loans PRIMARY KEY (LoanID),

CONSTRAINT fk_MemberID_Loan FOREIGN KEY (MemberID) REFERENCES Members(MemberID)


);

CREATE TABLE LoanBooks(
LoanID NUMERIC(4),
BookID NUMERIC(4),
ReturnDATE DATE,
CONSTRAINT pk_LoanBooks PRIMARY KEY(LoanID,BookID),
CONSTRAINT fk_LoanID FOREIGN KEY (LoanID) REFERENCES Loans(LoanID),
CONSTRAINT fk_BookID FOREIGN KEY (BookID) REFERENCES Books(BookID)
);

PROMPT
PROMPT POPULATING Table Genres
INSERT INTO Genres (GenreID,GenreName) VALUES (1,'Heroic');
INSERT INTO Genres (GenreID,GenreName) VALUES (2,'Romance');
INSERT INTO Genres (GenreID,GenreName) VALUES (3,'Comedy');
INSERT INTO Genres (GenreID,GenreName) VALUES (4,'Horror');

PROMPT 
PROMPT POPULATING TABLE Members
INSERT INTO Members(MemberID,Forename,Surname,DateOfBirth,PhoneNumber,Address,County,City,PostCode,JoinDate)
VALUES(1,'Eron','Baftijari',TO_DATE('2000-05-12','YYYY-MM-DD'),'0897654736','13 Caheranne Village','Kerry','Tralee','V92X5X6',TO_DATE('2023-05-12','YYYY-MM-DD'));
INSERT INTO Members(MemberID,Forename,Surname,DateOfBirth,PhoneNumber,Address,County,City,PostCode,JoinDate)
VALUES(2,'John','brosnon',TO_DATE('1980-06-02','YYYY-MM-DD'),'0876754321','14 Cashlow ','Kerry','Tralee','V92P7P8',TO_DATE('2023-05-12','YYYY-MM-DD'));
INSERT INTO Members(MemberID,Forename,Surname,DateOfBirth,PhoneNumber,Address,County,City,PostCode,JoinDate)
VALUES(3,'Anne','Coffey',TO_DATE('2010-08-05','YYYY-MM-DD'),'0667896543','67 Apartment Juan Tubo ','Cork','Ashe Street','v92Y7Y6',TO_DATE('2023-06-11','YYYY-MM-DD'));
INSERT INTO Members(MemberID,Forename,Surname,DateOfBirth,PhoneNumber,Address,County,City,PostCode,JoinDate)
VALUES(4,'Bekim','Baftijari',TO_DATE('1920-08-19','YYYY-MM-DD'),'0871361400','13 Caheranne Village','Kerry','Tralee','V92X5X6',TO_DATE('2024-06-12','YYYY-MM-DD'));
INSERT INTO Members(MemberID,Forename,Surname,DateOfBirth,PhoneNumber,Address,County,City,PostCode,JoinDate)
VALUES(5,'Sarah','Costello',TO_DATE('2000-09-10','YYYY-MM-DD'),'0876785743','19 Caheranne Village','Kerry','Tralee','V92X5X6',TO_DATE('2025-06-12','YYYY-MM-DD'));
INSERT INTO Members(MemberID,Forename,Surname,DateOfBirth,PhoneNumber,Address,County,City,PostCode,JoinDate)
VALUES(6,'Albin','Kastrati',TO_DATE('2006-05-12','YYYY-MM-DD'),'0891212343','16 Bully ring','Kerry','Tralee','V9289IO',TO_DATE('2022-12-12','YYYY-MM-DD'));
INSERT INTO Members(MemberID,Forename,Surname,DateOfBirth,PhoneNumber,Address,County,City,PostCode,JoinDate)
VALUES(7,'Wiktoria','Depta',TO_DATE('2003-09-20','YYYY-MM-DD'),'0874617507','78 Nounchally Village','Dublin','Jameson street','V92P2P6',TO_DATE('2022-12-12','YYYY-MM-DD'));
INSERT INTO Members(MemberID,Forename,Surname,DateOfBirth,PhoneNumber,Address,County,City,PostCode,JoinDate)
VALUES(8,'James','Bond',TO_DATE('2012-09-23','YYYY-MM-DD'),'0897897890','18 Mills street Village','Kerry','Tralee','V67U8U9',TO_DATE('2022-12-12','YYYY-MM-DD'));

PROMPT 
PROMPT POPULATING TABLE Books
INSERT INTO Books(BookID,GenreID,Title,Author,ISBN,PublishedDate)
VALUES(1,2,'Bond Of the stars','Harry Potter','1111111111',TO_DATE('2012-09-23','YYYY-MM-DD'));
INSERT INTO Books(BookID,GenreID,Title,Author,ISBN,PublishedDate)
VALUES(2,3,'Diary of Wimpy Kid','Don correy','3423234567',TO_DATE('2016-08-23','YYYY-MM-DD'));
INSERT INTO Books(BookID,GenreID,Title,Author,ISBN,PublishedDate)
VALUES(3,1,'Love me as i am','Zeynep Cowley','8989787654',TO_DATE('2001-01-01','YYYY-MM-DD'));
INSERT INTO Books(BookID,GenreID,Title,Author,ISBN,PublishedDate)
VALUES(4,4,'Invicible','Chris reidy','1212343532',TO_DATE('2006-09-23','YYYY-MM-DD'));
INSERT INTO Books(BookID,GenreID,Title,Author,ISBN,PublishedDate)
VALUES(5,1,'The Boys of the Totter','Matty Witoswki','9080908987',TO_DATE('2013-09-11','YYYY-MM-DD'));
INSERT INTO Books(BookID,GenreID,Title,Author,ISBN,PublishedDate)
VALUES(6,1,'It will remember us','Rifa Kerqueili','1253649875',TO_DATE('2008-12-23','YYYY-MM-DD'));
INSERT INTO Books(BookID,GenreID,Title,Author,ISBN,PublishedDate)
VALUES(7,3,'Question my Will ','Ganje Bushier','8979685756',TO_DATE('1970-09-23','YYYY-MM-DD'));
INSERT INTO Books(BookID,GenreID,Title,Author,ISBN,PublishedDate)
VALUES(8,2,'All is ours','Ryan Ottley','1020304959',TO_DATE('1987-05-12','YYYY-MM-DD'));

PROMPT 
PROMPT POPULATING TABLE Loans
INSERT INTO Loans(LoanID,MemberID,LoanDate,DueDate)
VALUES(1,1,TO_DATE('2023-12-12','YYYY-MM-DD'),TO_DATE('2023-12-26','YYYY-MM-DD'));
INSERT INTO Loans(LoanID,MemberID,LoanDate,DueDate)
VALUES(2,1,TO_DATE('2023-12-12','YYYY-MM-DD'),TO_DATE('2023-12-26','YYYY-MM-DD'));
INSERT INTO Loans(LoanID,MemberID,LoanDate,DueDate)
VALUES(3,2,TO_DATE('2024-09-10','YYYY-MM-DD'),TO_DATE('2024-09-24','YYYY-MM-DD'));
INSERT INTO Loans(LoanID,MemberID,LoanDate,DueDate)
VALUES(4,5,TO_DATE('2024-09-02','YYYY-MM-DD'),TO_DATE('2024-09-16','YYYY-MM-DD'));
INSERT INTO Loans(LoanID,MemberID,LoanDate,DueDate)
VALUES(5,5,TO_DATE('2026-07-07','YYYY-MM-DD'),TO_DATE('2026-07-21','YYYY-MM-DD'));
INSERT INTO Loans(LoanID,MemberID,LoanDate,DueDate)
VALUES(9,6,TO_DATE('2026-08-01','YYYY-MM-DD'),TO_DATE('2026-08-15','YYYY-MM-DD'));
INSERT INTO Loans(LoanID,MemberID,LoanDate,DueDate)
VALUES(10,7,TO_DATE('2026-10-11','YYYY-MM-DD'),TO_DATE('2026-10-25','YYYY-MM-DD'));
INSERT INTO Loans(LoanID,MemberID,LoanDate,DueDate)
VALUES(11,2,TO_DATE('2023-12-12','YYYY-MM-DD'),TO_DATE('2023-12-26','YYYY-MM-DD'));

PROMPT
PROMPT POPULATING TABLE LoanBooks

INSERT INTO LoanBooks(LoanID, BookID, ReturnDate)
VALUES(1, 1, TO_DATE('2023-12-20','YYYY-MM-DD'));
INSERT INTO LoanBooks(LoanID, BookID, ReturnDate)
VALUES(2, 2, NULL);
INSERT INTO LoanBooks(LoanID, BookID, ReturnDate)
VALUES(3, 3, TO_DATE('2024-09-20','YYYY-MM-DD'));
INSERT INTO LoanBooks(LoanID, BookID, ReturnDate)
VALUES(3, 4, TO_DATE('2024-09-15','YYYY-MM-DD'));
INSERT INTO LoanBooks(LoanID, BookID, ReturnDate)
VALUES(5, 5, TO_DATE('2026-07-15','YYYY-MM-DD'));
INSERT INTO LoanBooks(LoanID, BookID, ReturnDate)
VALUES(9, 6, TO_DATE('2026-08-10','YYYY-MM-DD'));
INSERT INTO LoanBooks(LoanID, BookID, ReturnDate)
VALUES(10, 7, TO_DATE('2026-10-20','YYYY-MM-DD'));
INSERT INTO LoanBooks(LoanID, BookID, ReturnDate)
VALUES(11, 8, TO_DATE('2023-12-20','YYYY-MM-DD'));



COMMIT;
