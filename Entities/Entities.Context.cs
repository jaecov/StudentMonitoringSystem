//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.EntityClient;

namespace StudentMonitoringSystem.Entities
{
    public partial class StudentMonitoringEntities : ObjectContext
    {
    	public const string ConnectionString = "name=StudentMonitoringEntities";
    	public const string ContainerName = "StudentMonitoringEntities";
    
    	#region Constructors
    
    	public StudentMonitoringEntities()
    		: base(ConnectionString, ContainerName)
    	{
    		
    		 
    		this.ContextOptions.LazyLoadingEnabled = false;
    		OnContextCreated();
    	}
    
    	public StudentMonitoringEntities(string connectionString)
    		: base(connectionString, ContainerName)
    	{
    		
    		 
    		this.ContextOptions.LazyLoadingEnabled = false;
    		OnContextCreated();
    	}
    
    	public StudentMonitoringEntities(EntityConnection connection)
    		: base(connection, ContainerName)
    	{
    		
    		 
    		this.ContextOptions.LazyLoadingEnabled = false;
    		OnContextCreated();
    	}
    
    	partial void OnContextCreated();
    
    	#endregion
    
        #region ObjectSet Properties
    
    	public ObjectSet<C__RefactorLog> C__RefactorLog
    	{
    		get { return _c__RefactorLog  ?? (_c__RefactorLog = CreateObjectSet<C__RefactorLog>("C__RefactorLog")); }
    	}
    	private ObjectSet<C__RefactorLog> _c__RefactorLog;
    
    	public ObjectSet<audt_audittrail> audt_audittrail
    	{
    		get { return _audt_audittrail  ?? (_audt_audittrail = CreateObjectSet<audt_audittrail>("audt_audittrail")); }
    	}
    	private ObjectSet<audt_audittrail> _audt_audittrail;
    
    	public ObjectSet<audt_log> audt_log
    	{
    		get { return _audt_log  ?? (_audt_log = CreateObjectSet<audt_log>("audt_log")); }
    	}
    	private ObjectSet<audt_log> _audt_log;
    
    	public ObjectSet<core_barangay> core_barangay
    	{
    		get { return _core_barangay  ?? (_core_barangay = CreateObjectSet<core_barangay>("core_barangay")); }
    	}
    	private ObjectSet<core_barangay> _core_barangay;
    
    	public ObjectSet<core_city> core_city
    	{
    		get { return _core_city  ?? (_core_city = CreateObjectSet<core_city>("core_city")); }
    	}
    	private ObjectSet<core_city> _core_city;
    
    	public ObjectSet<core_civilstatus> core_civilstatus
    	{
    		get { return _core_civilstatus  ?? (_core_civilstatus = CreateObjectSet<core_civilstatus>("core_civilstatus")); }
    	}
    	private ObjectSet<core_civilstatus> _core_civilstatus;
    
    	public ObjectSet<core_contact> core_contact
    	{
    		get { return _core_contact  ?? (_core_contact = CreateObjectSet<core_contact>("core_contact")); }
    	}
    	private ObjectSet<core_contact> _core_contact;
    
    	public ObjectSet<core_gender> core_gender
    	{
    		get { return _core_gender  ?? (_core_gender = CreateObjectSet<core_gender>("core_gender")); }
    	}
    	private ObjectSet<core_gender> _core_gender;
    
    	public ObjectSet<core_province> core_province
    	{
    		get { return _core_province  ?? (_core_province = CreateObjectSet<core_province>("core_province")); }
    	}
    	private ObjectSet<core_province> _core_province;
    
    	public ObjectSet<core_student> core_student
    	{
    		get { return _core_student  ?? (_core_student = CreateObjectSet<core_student>("core_student")); }
    	}
    	private ObjectSet<core_student> _core_student;
    
    	public ObjectSet<core_systemsettings> core_systemsettings
    	{
    		get { return _core_systemsettings  ?? (_core_systemsettings = CreateObjectSet<core_systemsettings>("core_systemsettings")); }
    	}
    	private ObjectSet<core_systemsettings> _core_systemsettings;
    
    	public ObjectSet<core_user> core_user
    	{
    		get { return _core_user  ?? (_core_user = CreateObjectSet<core_user>("core_user")); }
    	}
    	private ObjectSet<core_user> _core_user;
    
    	public ObjectSet<emp_contact> emp_contact
    	{
    		get { return _emp_contact  ?? (_emp_contact = CreateObjectSet<emp_contact>("emp_contact")); }
    	}
    	private ObjectSet<emp_contact> _emp_contact;
    
    	public ObjectSet<enroll_course> enroll_course
    	{
    		get { return _enroll_course  ?? (_enroll_course = CreateObjectSet<enroll_course>("enroll_course")); }
    	}
    	private ObjectSet<enroll_course> _enroll_course;
    
    	public ObjectSet<enroll_room> enroll_room
    	{
    		get { return _enroll_room  ?? (_enroll_room = CreateObjectSet<enroll_room>("enroll_room")); }
    	}
    	private ObjectSet<enroll_room> _enroll_room;
    
    	public ObjectSet<enroll_schedule> enroll_schedule
    	{
    		get { return _enroll_schedule  ?? (_enroll_schedule = CreateObjectSet<enroll_schedule>("enroll_schedule")); }
    	}
    	private ObjectSet<enroll_schedule> _enroll_schedule;
    
    	public ObjectSet<enroll_section> enroll_section
    	{
    		get { return _enroll_section  ?? (_enroll_section = CreateObjectSet<enroll_section>("enroll_section")); }
    	}
    	private ObjectSet<enroll_section> _enroll_section;
    
    	public ObjectSet<enroll_subject> enroll_subject
    	{
    		get { return _enroll_subject  ?? (_enroll_subject = CreateObjectSet<enroll_subject>("enroll_subject")); }
    	}
    	private ObjectSet<enroll_subject> _enroll_subject;
    
    	public ObjectSet<log_entrybook> log_entrybook
    	{
    		get { return _log_entrybook  ?? (_log_entrybook = CreateObjectSet<log_entrybook>("log_entrybook")); }
    	}
    	private ObjectSet<log_entrybook> _log_entrybook;
    
    	public ObjectSet<log_entrybook_archive> log_entrybook_archive
    	{
    		get { return _log_entrybook_archive  ?? (_log_entrybook_archive = CreateObjectSet<log_entrybook_archive>("log_entrybook_archive")); }
    	}
    	private ObjectSet<log_entrybook_archive> _log_entrybook_archive;
    
    	public ObjectSet<sms_inbox> sms_inbox
    	{
    		get { return _sms_inbox  ?? (_sms_inbox = CreateObjectSet<sms_inbox>("sms_inbox")); }
    	}
    	private ObjectSet<sms_inbox> _sms_inbox;
    
    	public ObjectSet<sms_inbox_archive> sms_inbox_archive
    	{
    		get { return _sms_inbox_archive  ?? (_sms_inbox_archive = CreateObjectSet<sms_inbox_archive>("sms_inbox_archive")); }
    	}
    	private ObjectSet<sms_inbox_archive> _sms_inbox_archive;
    
    	public ObjectSet<sms_networkprovider> sms_networkprovider
    	{
    		get { return _sms_networkprovider  ?? (_sms_networkprovider = CreateObjectSet<sms_networkprovider>("sms_networkprovider")); }
    	}
    	private ObjectSet<sms_networkprovider> _sms_networkprovider;
    
    	public ObjectSet<sms_networkprovidercode> sms_networkprovidercode
    	{
    		get { return _sms_networkprovidercode  ?? (_sms_networkprovidercode = CreateObjectSet<sms_networkprovidercode>("sms_networkprovidercode")); }
    	}
    	private ObjectSet<sms_networkprovidercode> _sms_networkprovidercode;
    
    	public ObjectSet<sms_notification> sms_notification
    	{
    		get { return _sms_notification  ?? (_sms_notification = CreateObjectSet<sms_notification>("sms_notification")); }
    	}
    	private ObjectSet<sms_notification> _sms_notification;
    
    	public ObjectSet<sms_outbox> sms_outbox
    	{
    		get { return _sms_outbox  ?? (_sms_outbox = CreateObjectSet<sms_outbox>("sms_outbox")); }
    	}
    	private ObjectSet<sms_outbox> _sms_outbox;
    
    	public ObjectSet<sms_outbox_archive> sms_outbox_archive
    	{
    		get { return _sms_outbox_archive  ?? (_sms_outbox_archive = CreateObjectSet<sms_outbox_archive>("sms_outbox_archive")); }
    	}
    	private ObjectSet<sms_outbox_archive> _sms_outbox_archive;
    
    	public ObjectSet<sms_sent> sms_sent
    	{
    		get { return _sms_sent  ?? (_sms_sent = CreateObjectSet<sms_sent>("sms_sent")); }
    	}
    	private ObjectSet<sms_sent> _sms_sent;
    
    	public ObjectSet<sms_sent_archive> sms_sent_archive
    	{
    		get { return _sms_sent_archive  ?? (_sms_sent_archive = CreateObjectSet<sms_sent_archive>("sms_sent_archive")); }
    	}
    	private ObjectSet<sms_sent_archive> _sms_sent_archive;
    
    	public ObjectSet<sms_status> sms_status
    	{
    		get { return _sms_status  ?? (_sms_status = CreateObjectSet<sms_status>("sms_status")); }
    	}
    	private ObjectSet<sms_status> _sms_status;
    
    	public ObjectSet<vstudentinfo> vstudentinfoes
    	{
    		get { return _vstudentinfoes  ?? (_vstudentinfoes = CreateObjectSet<vstudentinfo>("vstudentinfoes")); }
    	}
    	private ObjectSet<vstudentinfo> _vstudentinfoes;
    
    	public ObjectSet<core_guardian> core_guardian
    	{
    		get { return _core_guardian  ?? (_core_guardian = CreateObjectSet<core_guardian>("core_guardian")); }
    	}
    	private ObjectSet<core_guardian> _core_guardian;
    
    	public ObjectSet<emp_employee> emp_employee
    	{
    		get { return _emp_employee  ?? (_emp_employee = CreateObjectSet<emp_employee>("emp_employee")); }
    	}
    	private ObjectSet<emp_employee> _emp_employee;
    
    	public ObjectSet<vemployeeinfo> vemployeeinfoes
    	{
    		get { return _vemployeeinfoes  ?? (_vemployeeinfoes = CreateObjectSet<vemployeeinfo>("vemployeeinfoes")); }
    	}
    	private ObjectSet<vemployeeinfo> _vemployeeinfoes;

        #endregion

        #region GenericObjectSets
    				
    	public ObjectSet<T> GetObjectSet<T>() where T : class    		
    	{							
    		if(typeof(T) == typeof(C__RefactorLog))
    		{
    			return (ObjectSet<T>)(object)C__RefactorLog;
    		}
    								
    		if(typeof(T) == typeof(audt_audittrail))
    		{
    			return (ObjectSet<T>)(object)audt_audittrail;
    		}
    								
    		if(typeof(T) == typeof(audt_log))
    		{
    			return (ObjectSet<T>)(object)audt_log;
    		}
    								
    		if(typeof(T) == typeof(core_barangay))
    		{
    			return (ObjectSet<T>)(object)core_barangay;
    		}
    								
    		if(typeof(T) == typeof(core_city))
    		{
    			return (ObjectSet<T>)(object)core_city;
    		}
    								
    		if(typeof(T) == typeof(core_civilstatus))
    		{
    			return (ObjectSet<T>)(object)core_civilstatus;
    		}
    								
    		if(typeof(T) == typeof(core_contact))
    		{
    			return (ObjectSet<T>)(object)core_contact;
    		}
    								
    		if(typeof(T) == typeof(core_gender))
    		{
    			return (ObjectSet<T>)(object)core_gender;
    		}
    								
    		if(typeof(T) == typeof(core_province))
    		{
    			return (ObjectSet<T>)(object)core_province;
    		}
    								
    		if(typeof(T) == typeof(core_student))
    		{
    			return (ObjectSet<T>)(object)core_student;
    		}
    								
    		if(typeof(T) == typeof(core_systemsettings))
    		{
    			return (ObjectSet<T>)(object)core_systemsettings;
    		}
    								
    		if(typeof(T) == typeof(core_user))
    		{
    			return (ObjectSet<T>)(object)core_user;
    		}
    								
    		if(typeof(T) == typeof(emp_contact))
    		{
    			return (ObjectSet<T>)(object)emp_contact;
    		}
    								
    		if(typeof(T) == typeof(enroll_course))
    		{
    			return (ObjectSet<T>)(object)enroll_course;
    		}
    								
    		if(typeof(T) == typeof(enroll_room))
    		{
    			return (ObjectSet<T>)(object)enroll_room;
    		}
    								
    		if(typeof(T) == typeof(enroll_schedule))
    		{
    			return (ObjectSet<T>)(object)enroll_schedule;
    		}
    								
    		if(typeof(T) == typeof(enroll_section))
    		{
    			return (ObjectSet<T>)(object)enroll_section;
    		}
    								
    		if(typeof(T) == typeof(enroll_subject))
    		{
    			return (ObjectSet<T>)(object)enroll_subject;
    		}
    								
    		if(typeof(T) == typeof(log_entrybook))
    		{
    			return (ObjectSet<T>)(object)log_entrybook;
    		}
    								
    		if(typeof(T) == typeof(log_entrybook_archive))
    		{
    			return (ObjectSet<T>)(object)log_entrybook_archive;
    		}
    								
    		if(typeof(T) == typeof(sms_inbox))
    		{
    			return (ObjectSet<T>)(object)sms_inbox;
    		}
    								
    		if(typeof(T) == typeof(sms_inbox_archive))
    		{
    			return (ObjectSet<T>)(object)sms_inbox_archive;
    		}
    								
    		if(typeof(T) == typeof(sms_networkprovider))
    		{
    			return (ObjectSet<T>)(object)sms_networkprovider;
    		}
    								
    		if(typeof(T) == typeof(sms_networkprovidercode))
    		{
    			return (ObjectSet<T>)(object)sms_networkprovidercode;
    		}
    								
    		if(typeof(T) == typeof(sms_notification))
    		{
    			return (ObjectSet<T>)(object)sms_notification;
    		}
    								
    		if(typeof(T) == typeof(sms_outbox))
    		{
    			return (ObjectSet<T>)(object)sms_outbox;
    		}
    								
    		if(typeof(T) == typeof(sms_outbox_archive))
    		{
    			return (ObjectSet<T>)(object)sms_outbox_archive;
    		}
    								
    		if(typeof(T) == typeof(sms_sent))
    		{
    			return (ObjectSet<T>)(object)sms_sent;
    		}
    								
    		if(typeof(T) == typeof(sms_sent_archive))
    		{
    			return (ObjectSet<T>)(object)sms_sent_archive;
    		}
    								
    		if(typeof(T) == typeof(sms_status))
    		{
    			return (ObjectSet<T>)(object)sms_status;
    		}
    								
    		if(typeof(T) == typeof(vstudentinfo))
    		{
    			return (ObjectSet<T>)(object)vstudentinfoes;
    		}
    								
    		if(typeof(T) == typeof(core_guardian))
    		{
    			return (ObjectSet<T>)(object)core_guardian;
    		}
    								
    		if(typeof(T) == typeof(emp_employee))
    		{
    			return (ObjectSet<T>)(object)emp_employee;
    		}
    								
    		if(typeof(T) == typeof(vemployeeinfo))
    		{
    			return (ObjectSet<T>)(object)vemployeeinfoes;
    		}
    				
    		return null;
    	}				

        #endregion
    }
}
