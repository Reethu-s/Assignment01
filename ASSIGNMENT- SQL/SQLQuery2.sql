CREATE TABLE Student (
  StudentId INT PRIMARY KEY,
  StudentName VARCHAR(50),
  CourseName VARCHAR(50),
  CityName VARCHAR(50),
  ContactNo INT
);

SELECT * FROM Student

INSERT INTO Student(StudentId,studentName, CourseName, CityName, ContactNo) VALUES
(1, 'reethu', 'Python', 'Bangalore', 76542),
(2, 'rim', 'Angular',   'Hyderabad', 76543),
(3, 'rakshanda','HTML', 'Gurgoan', 76544),
(4, 'rubai', 'Angular', 'Hyderabad', 76545),
(5, 'reruru', 'Python', 'Pune', 76546),
(6, 'rihanna', 'Java',  'Hyderabad', 76547),
(7, 'rachel', 'Python', 'Chennai', 76548),
(8, 'rethulish','CSS',  'Hyderabad', 76549),
(9, 'Rixie', 'Angular', 'Hyderabad', 76550),
(10, 'Ruby', 'Angular', 'Bangalore', 76551);


--1.
SELECT Count(StudentID)
FROM Student
where CourseName = 'Angular';


--2.
SELECT Count(StudentID)
FROM Student
where CityName = 'Hyderabad';


--CITY BASED
SELECT CityName,COUNT(StudentId)
FROM Student
GROUP BY CityName

 

 

--COURSE BASED
SELECT CourseName,COUNT(StudentId)
FROM Student
GROUP BY CourseName

 

 

--CITY AND COURSE BASED
SELECT CityName,CourseName,COUNT(StudentId)
FROM Student
GROUP BY CityName,CourseName


