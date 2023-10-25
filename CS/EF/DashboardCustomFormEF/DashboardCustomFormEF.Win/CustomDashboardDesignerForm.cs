using DevExpress.DashboardWin;

namespace CustomDashboardDesignerForm.Module.Win {
    public partial class CustomDashboardDesignerForm : DevExpress.XtraBars.Ribbon.RibbonForm {
        public CustomDashboardDesignerForm() {
            InitializeComponent();
        }
        public DashboardDesigner Designer {
            get { return dashboardDesigner; }
        }
    }
}