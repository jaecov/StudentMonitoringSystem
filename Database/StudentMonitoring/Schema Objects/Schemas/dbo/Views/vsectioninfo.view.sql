
CREATE View vsectioninfo
as

SELECT
S.id,
S.name,
S.course_id,
C.name AS course_name,
c.code as course_code

FROM enroll_section S
INNER JOIN enroll_course C ON S.course_id = C.id