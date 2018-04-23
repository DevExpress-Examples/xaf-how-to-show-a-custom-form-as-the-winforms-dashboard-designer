using CustomDashboardDesignerForm.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Dashboards;
using DevExpress.ExpressApp.Updating;
using DevExpress.Persistent.BaseImpl;
using System;
using System.Reflection;

namespace CustomDashboardDesignerForm.Module.DatabaseUpdate
{
    public class Updater : ModuleUpdater {
        public Updater(IObjectSpace objectSpace, Version currentDBVersion) :
            base(objectSpace, currentDBVersion) {
        }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            Contact contactMary = ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse("FirstName == 'Mary' && LastName == 'Tellitson'"));
            if (contactMary == null)
            {
                contactMary = ObjectSpace.CreateObject<Contact>();
                contactMary.FirstName = "Mary";
                contactMary.LastName = "Tellitson";
                contactMary.Email = "mary_tellitson@md.com";
                contactMary.Birthday = new DateTime(1980, 11, 27);
            }
            Contact contactJohn = ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse("FirstName == 'John' && LastName == 'Nilsen'"));
            if (contactJohn == null)
            {
                contactJohn = ObjectSpace.CreateObject<Contact>();
                contactJohn.FirstName = "John";
                contactJohn.LastName = "Nilsen";
                contactJohn.Email = "john_nilsen@md.com";
                contactJohn.Birthday = new DateTime(1981, 10, 3);
            }
            Contact contactAndrew = ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse("FirstName == 'Andrew' && LastName == 'Fuller'"));
            if (contactAndrew == null)
            {
                contactAndrew = ObjectSpace.CreateObject<Contact>();
                contactAndrew.FirstName = "Andrew";
                contactAndrew.LastName = "Fuller";
                contactAndrew.Email = "andrewfuller@example.com";
                contactAndrew.Birthday = new DateTime(1952, 3, 19);
            }
            Contact contactRobert = ObjectSpace.FindObject<Contact>(CriteriaOperator.Parse("FirstName == 'Robert' && LastName == 'King'"));
            if (contactRobert == null)
            {
                contactRobert = ObjectSpace.CreateObject<Contact>();
                contactRobert.FirstName = "Robert";
                contactRobert.LastName = "King";
                contactRobert.Email = "robertking@example.com";
                contactRobert.Birthday = new DateTime(1975, 4, 25);
            }
            Assembly assembly = Assembly.GetExecutingAssembly();
            DashboardsModule.AddDashboardDataFromResources<DashboardData>(ObjectSpace, "Contacts", assembly, "CustomDashboardDesignerForm.Module.Dashboards.Contacts.xml");

            ObjectSpace.CommitChanges();
        }
    }
}
