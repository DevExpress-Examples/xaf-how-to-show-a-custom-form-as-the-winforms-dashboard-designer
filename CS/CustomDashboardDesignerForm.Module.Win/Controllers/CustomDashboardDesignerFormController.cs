using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Dashboards.Win;
using DevExpress.Persistent.Base;

namespace CustomDashboardDesignerForm.Module.Win.Controllers {
    public class CustomDashboardDesignerFormController : ObjectViewController<ObjectView, IDashboardData> {
        private WinShowDashboardDesignerController showDashboardDesignerController;
        protected override void OnActivated() {
            base.OnActivated();
            showDashboardDesignerController = Frame.GetController<WinShowDashboardDesignerController>();
            if(showDashboardDesignerController != null) {
                showDashboardDesignerController.DashboardDesignerManager.CreateCustomForm += Manager_CreateCustomForm;
            }
        }
        private void Manager_CreateCustomForm(object sender, CreateCustomFormEventArgs e) {
            e.Form = new CustomDashboardDesignerForm();
        }
        protected override void OnDeactivated() {
            base.OnDeactivated();
            if(showDashboardDesignerController != null) {
                showDashboardDesignerController.DashboardDesignerManager.CreateCustomForm -= Manager_CreateCustomForm;
            }
        }
    }
}
