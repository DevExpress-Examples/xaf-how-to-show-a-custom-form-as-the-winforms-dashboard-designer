Imports System
Imports System.ComponentModel
Imports DevExpress.ExpressApp
Imports System.Collections.Generic
Imports DevExpress.ExpressApp.Updating

Namespace CustomDashboardDesignerForm.Module.Win

    <ToolboxItemFilter("Xaf.Platform.Win")>
    ' For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppModuleBasetopic.aspx.
    Public NotInheritable Partial Class CustomDashboardDesignerFormWindowsFormsModule
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Return ModuleUpdater.EmptyModuleUpdaters
        End Function

        Public Overrides Sub Setup(ByVal application As XafApplication)
            MyBase.Setup(application)
        ' Manage various aspects of the application UI and behavior at the module level.
        End Sub
    End Class
End Namespace
