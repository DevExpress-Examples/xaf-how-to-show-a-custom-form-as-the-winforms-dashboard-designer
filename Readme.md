<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128593320/23.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T473819)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# XAF - How to show a custom form as a WinForms Dashboard Designer

This example describes how to display a custom form as a WinForms Dashboard Designer that is used to create and modify dashboards in WinForms XAF applications. This can be required for menu customization. For example, you may need to add custom BarItems or remove default BarItems.

<kbd>![image](https://github.com/DevExpress-Examples/XAF_how-to-show-a-custom-form-as-the-winforms-dashboard-designer-t473819/assets/14300209/1e3d446a-3514-433e-8347-094e433c68aa)</kbd>

## Implementation Details

1. Add a new [XtraForm](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.XtraForm) or [RibbonForm](https://docs.devexpress.com/WindowsForms/DevExpress.XtraBars.Ribbon.RibbonForm) to the project.
2. Add [DashboardDesigner](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardDesigner) to the newly created form as it is described in the following topic: [Create a WinForms Dashboard Designer (.NET Framework)](https://docs.devexpress.com/Dashboard/12137/get-started/build-winforms-dashboard-applications/create-a-winforms-dashboard-designer-in-net-framework).
3. Add a property of the `DashboardDesigner` type to the custom form.
4. In the Windows Forms module, add a Controller that is activated in the [IDashboardData](https://docs.devexpress.com/eXpressAppFramework/DevExpress.Persistent.Base.IDashboardData) Views only.
5. Access the `WinShowDashboardDesignerController` using the [Frame.GetController<ControllerType>](https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Frame.GetControllers(System.Type)) method.
6. Access the `DashboardDesignerManager` object using the `WinShowDashboardDesignerController.DashboardDesignerManager` property.
7. Handle the `DashboardDesignerManager.CreateCustomForm` event. Create and assign a custom `XtraForm` to the `CreateCustomFormEventArgs.Form` property. For more imformation, refer to the following topic: [Access the WinForms Dashboard Designer](https://docs.devexpress.com/eXpressAppFramework/117716/analytics/dashboards/access-the-winforms-dashboard-designer).

## Files to Review

* [CustomDashboardDesignerFormController.cs](CS/EF/DashboardCustomFormEF/DashboardCustomFormEF.Win/Controllers/CustomDashboardDesignerFormController.cs)
* [CustomDashboardDesignerForm.cs](CS/EF/DashboardCustomFormEF/DashboardCustomFormEF.Win/CustomDashboardDesignerForm.cs)

## Documentation

* [Create a WinForms Dashboard Designer (.NET Framework)](https://docs.devexpress.com/Dashboard/12137/get-started/build-winforms-dashboard-applications/create-a-winforms-dashboard-designer-in-net-framework)
* [Access the WinForms Dashboard Designer](https://docs.devexpress.com/eXpressAppFramework/117716/analytics/dashboards/access-the-winforms-dashboard-designer)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-show-a-custom-form-as-the-winforms-dashboard-designer&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-show-a-custom-form-as-the-winforms-dashboard-designer&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
