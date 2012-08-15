

CREATE view vscheduleinfo
as

SELECT
SCHED.id,
SCHED.section_id,
SCHED.employee_id,
SCHED.subject_id,
SCHED.room_id,
SCHED.day_id,
SCHED.datestart,
SCHED.dateend,
SCHED.note,

SC.name AS section_name,
EMP.number as emp_number,
EMP.firstname as emp_firstname,
EMP.middlename as emp_middlename,
EMP.lastname as emp_lastname,
EMP.picture as emp_picture,
SBJ.code as [subject_code],
SBJ.name as [subject_name],
RM.name as room_name,
DY.code as day_code,
DY.name as [day_name],
CRS.id as [course_id],
CRS.name as course_name,
CRS.code as course_code,
SC.level_id,
LVL.name as level_name

FROM enroll_schedule SCHED 
INNER JOIN enroll_section SC ON SCHED.section_id = SC.id
INNER JOIN emp_employee EMP ON SCHED.employee_id = EMP.id
INNER JOIN enroll_subject SBJ ON SCHED.subject_id = SBJ.id
INNER JOIN enroll_room RM ON SCHED.room_id = RM.id
INNER JOIN core_day DY ON SCHED.day_id = DY.id
INNER JOIN enroll_course CRS ON SC.course_id = CRS.id
INNER JOIN enroll_level LVL ON SC.level_id = LVL.id
