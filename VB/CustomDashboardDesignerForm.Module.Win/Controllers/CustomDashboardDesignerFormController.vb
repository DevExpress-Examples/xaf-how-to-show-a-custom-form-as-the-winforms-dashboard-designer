Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Dashboards.Win
Imports DevExpress.Persistent.Base

Namespace CustomDashboardDesignerForm.Module.Win.Controllers
    Public Class CustomDashboardDesignerFormController
        Inherits ObjectViewController(Of ObjectView, IDashboardData)

        Private showDashboardDesignerController As WinShowDashboardDesignerController
        Protected Overrides Sub OnActivated()
            MyBase.OnActivated()
            showDashboardDesignerController = Frame.GetController(Of WinShowDashboardDesignerController)()
            If showDashboardDesignerController IsNot Nothing Then
                AddHandler showDashboardDesignerController.DashboardDesignerManager.CreateCustomForm, AddressOf Manager_CreateCustomForm
            End If
        End Sub
        Private Sub Manager_CreateCustomForm(ByVal sender As Object, ByVal e As CreateCustomFormEventArgs)
            e.Form = New CustomDashboardDesignerForm()
        End Sub
        Protected Overrides Sub OnDeactivated()
            MyBase.OnDeactivated()
            If showDashboardDesignerController IsNot Nothing Then
                RemoveHandler showDashboardDesignerController.DashboardDesignerManager.CreateCustomForm, AddressOf Manager_CreateCustomForm
            End If
        End Sub
    End Class
End Namespace
