
CREATE view	vsectioninfo
as
SELECT 
SC.id,
SC.name,
SC.note,
SC.course_id,
SC.level_id,
COR.name AS course_name,
LVL.name as level_name

FROM enroll_section SC
INNER JOIN enroll_course COR ON SC.course_id = COR.id
INNER JOIN enroll_level LVL ON SC.level_id = LVL.id
