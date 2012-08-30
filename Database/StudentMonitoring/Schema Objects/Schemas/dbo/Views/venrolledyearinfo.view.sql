-- =============================================
-- Script Template
-- =============================================

CREATE view venrolledyearinfo
as

SELECT 
EY.id,
EY.note,
EY.student_id,
EY.level_id,
EY.schoolyear_id,
EY.course_id,
EY.section_id,
EY.semester_id,
LVL.name AS [level_name],
SY.name as [schoolyear_name],
C.code as [course_code],
C.name as [course_name],
SC.name as [section_name],
SM.name as [semester_name]

FROM enroll_enrolledyear EY
INNER JOIN enroll_level LVL ON EY.level_id = LVL.id
INNER JOIN enroll_schoolyear SY ON EY.schoolyear_id = SY.id
INNER JOIN enroll_course C ON EY.course_id = C.id
INNER JOIN enroll_section SC ON EY.section_id = SC.id
INNER JOIN enroll_semester SM ON EY.semester_id = SM.id
INNER JOIN core_student ST ON EY.student_id = ST.id
