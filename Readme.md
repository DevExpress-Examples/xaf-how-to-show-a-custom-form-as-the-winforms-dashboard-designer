<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T473819)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# How to show a custom form as the WinForms Dashboard Designer

This example describes how to show a custom form as the WinForms Dashboard Designer used to create and modify dashboards in the WinForms XAF applications. This can be required for the menu customization. For example, add custom BarItems or remove some default BarItems.

## Implementation Details
1. Add a new <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsXtraFormtopic">XtraForm</a> or <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraBarsRibbonRibbonFormtopic">RibbonForm</a> to the project.
2. Add <a href="https://documentation.devexpress.com/#Dashboard/clsDevExpressDashboardWinDashboardDesignertopic">DashboardDesigner</a> to the newly created form as it is described in the Create a Designer Application chapter of the <a href="https://documentation.devexpress.com/#Dashboard/CustomDocument12137">Creating a WinForms Designer and Using It to Create a Dashboard</a> article.
3. Add a property of the DashboardDesigner type to the custom form.
4. In the Windows Forms module, add a Controller that is activated in the <a href="https://documentation.devexpress.com/#eXpressAppFramework/clsDevExpressPersistentBaseIDashboardDatatopic">IDashboardData</a> Views only.
5. Access the WinShowDashboardDesignerController using the <a href="https://documentation.devexpress.com/#eXpressAppFramework/DevExpressExpressAppFrame_GetController%7eControllerType%7etopic">Frame.GetController<ControllerType></a> method.
6. Access the DashboardDesignerManager object using the WinShowDashboardDesignerController.DashboardDesignerManager property.
7. Handle the DashboardDesignerManager.CreateCustomForm event. Create and assign a custom XtraForm to the CreateCustomFormEventArgs.Form property.See also<a href="https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument117716">Access the WinForms Dashboard Designer</a>




## Files to Review

* **[CustomDashboardDesignerFormController.cs](CS/EF/DashboardCustomFormEF/DashboardCustomFormEF.Win/Controllers/CustomDashboardDesignerFormController.cs)**
* [CustomDashboardDesignerForm.cs](CS/EF/DashboardCustomFormEF/DashboardCustomFormEF.Win/CustomDashboardDesignerForm.cs)
