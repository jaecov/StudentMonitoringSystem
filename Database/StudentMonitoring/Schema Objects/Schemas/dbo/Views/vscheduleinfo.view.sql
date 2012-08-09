

CREATE view vscheduleinfo
as

SELECT
SCHED.id,
SCHED.course_id,
SCHED.section_id,
SCHED.employee_id,
SCHED.subject_id,
SCHED.room_id,
SCHED.day_id,
SCHED.datestart,
SCHED.dateend,
SCHED.note,

SC.name AS section,
EMP.number as emp_number,
EMP.firstname as emp_firstname,
EMP.middlename as emp_middlename,
EMP.lastname as emp_lastname,
EMP.picture as emp_picture,
SBJ.name as [subject],
RM.name as room,
DY.code as day_code,
DY.name as [day],
CRS.name as course_name,
CRS.code as course_code

FROM enroll_schedule SCHED 
INNER JOIN enroll_section SC ON SCHED.section_id = SC.id
INNER JOIN emp_employee EMP ON SCHED.employee_id = EMP.id
INNER JOIN enroll_subject SBJ ON SCHED.subject_id = SBJ.id
INNER JOIN enroll_room RM ON SCHED.room_id = RM.id
INNER JOIN core_day DY ON SCHED.day_id = DY.id
INNER JOIN enroll_course CRS ON SCHED.course_id = CRS.id

