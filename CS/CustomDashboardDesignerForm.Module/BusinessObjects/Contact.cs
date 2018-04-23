using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace CustomDashboardDesignerForm.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class Contact : Person
    {
        public Contact(Session session) : base(session)
        {
        }
    }
}
