select * from Course
select * from Enrollment
select * from Enrollment,Course,Student where StudentID=2 and Course.CourseID=Enrollment.CourseID and Enrollment.StudentID=Student.ID