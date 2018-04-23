namespace CustomDashboardDesignerForm.Win {
    partial class CustomDashboardDesignerFormWindowsFormsApplication {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
            this.module3 = new CustomDashboardDesignerForm.Module.CustomDashboardDesignerFormModule();
            this.module4 = new CustomDashboardDesignerForm.Module.Win.CustomDashboardDesignerFormWindowsFormsModule();
            this.dashboardsModule = new DevExpress.ExpressApp.Dashboards.DashboardsModule();
            this.dashboardsWindowsFormsModule = new DevExpress.ExpressApp.Dashboards.Win.DashboardsWindowsFormsModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            //
            // dashboardsModule
            //
            this.dashboardsModule.DashboardDataType = typeof(DevExpress.Persistent.BaseImpl.DashboardData);
            // 
            // CustomDashboardDesignerFormWindowsFormsApplication
            // 
            this.ApplicationName = "CustomDashboardDesignerForm";
            this.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema;
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.dashboardsModule);
            this.Modules.Add(this.dashboardsWindowsFormsModule);
            this.UseOldTemplates = false;
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.CustomDashboardDesignerFormWindowsFormsApplication_DatabaseVersionMismatch);
            this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.CustomDashboardDesignerFormWindowsFormsApplication_CustomizeLanguagesList);

            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
        private CustomDashboardDesignerForm.Module.CustomDashboardDesignerFormModule module3;
        private CustomDashboardDesignerForm.Module.Win.CustomDashboardDesignerFormWindowsFormsModule module4;
        private DevExpress.ExpressApp.Dashboards.DashboardsModule dashboardsModule;
        private DevExpress.ExpressApp.Dashboards.Win.DashboardsWindowsFormsModule dashboardsWindowsFormsModule;
    }
}
