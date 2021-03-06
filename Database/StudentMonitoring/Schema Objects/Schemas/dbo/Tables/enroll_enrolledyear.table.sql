﻿CREATE table enroll_enrolledyear
(
id INT IDENTITY NOT NULL,
student_id int NOT NULL,
level_id INT NOT NULL,
schoolyear_id INT NOT NULL,
semester_id INT NOT NULL,
course_id INT NOT NULL,
section_id INT NOT NULL,
note varchar(100)
PRIMARY KEY CLUSTERED ([id] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF)
);
