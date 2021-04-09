CREATE TABLE CarImages(
	
	ID int NOT NULL IDENTITY(1,1) primary key,
	CARID int,
	IMAGEPATH varchar(100),
	HISTORY datetime,

	FOREIGN KEY(CARID) REFERENCES Cars(Id)
);