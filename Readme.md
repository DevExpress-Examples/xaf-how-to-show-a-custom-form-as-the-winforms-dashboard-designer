<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128593320/16.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T473819)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[CustomDashboardDesignerFormController.cs](./CS/CustomDashboardDesignerForm.Module.Win/Controllers/CustomDashboardDesignerFormController.cs) (VB: [CustomDashboardDesignerFormController.vb](./VB/CustomDashboardDesignerForm.Module.Win/Controllers/CustomDashboardDesignerFormController.vb))**
* [CustomDashboardDesignerForm.cs](./CS/CustomDashboardDesignerForm.Module.Win/CustomDashboardDesignerForm.cs) (VB: [CustomDashboardDesignerForm.vb](./VB/CustomDashboardDesignerForm.Module.Win/CustomDashboardDesignerForm.vb))
<!-- default file list end -->
# How to show a custom form as the WinForms Dashboard Designer


<p><strong>Scenario</strong><br>This example describes how to show a custom form as the WinForms Dashboard Designer used to create and modify dashboards in the WinForms XAF applications. This can be required for the menu customization. For example, add custom BarItems or remove some default BarItems.<br><br><strong>Steps to implement<br></strong>1. Add a new <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsXtraFormtopic">XtraForm</a> or <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraBarsRibbonRibbonFormtopic">RibbonForm</a> to the project.<br>2. Add <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWinDashboardDesignertopic">DashboardDesigner</a> to the newly created form as it is described in the <strong>Create a Designer Application</strong> chapter of the <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument12137">Creating a WinForms Designer and Using It to Create a Dashboard</a> article.<br>3. Add a property of the DashboardDesigner type to the custom form.<br>4. In the Windows Forms module, add a Controller that is activated in the <a href="https://documentation.devexpress.com/#eXpressAppFramework/clsDevExpressPersistentBaseIDashboardDatatopic">IDashboardData</a> Views only.<br>5. Access the <strong>WinShowDashboardDesignerController</strong> using the <a href="https://documentation.devexpress.com/#eXpressAppFramework/DevExpressExpressAppFrame_GetController%7eControllerType%7etopic">Frame.GetController<ControllerType></a> method.<br>6. Access the <strong>DashboardDesignerManager</strong> object using the <strong>WinShowDashboardDesignerController.DashboardDesignerManager</strong> property.<br>7. Handle the <strong>DashboardDesignerManager.CreateCustomForm</strong> event. Create and assign a custom XtraForm to the <strong>CreateCustomFormEventArgs.Form</strong> property.<br><br><strong>See also<br></strong><strong><a href="https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument117716">Access the WinForms Dashboard Designer</a></strong></p>

<br/>


<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-show-a-custom-form-as-the-winforms-dashboard-designer&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=xaf-how-to-show-a-custom-form-as-the-winforms-dashboard-designer&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
