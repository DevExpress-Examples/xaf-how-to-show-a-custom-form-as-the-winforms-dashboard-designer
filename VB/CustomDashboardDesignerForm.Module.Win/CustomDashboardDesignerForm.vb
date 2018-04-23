Imports DevExpress.DashboardWin

Namespace CustomDashboardDesignerForm.Module.Win
    Partial Public Class CustomDashboardDesignerForm
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Public ReadOnly Property Designer() As DashboardDesigner
            Get
                Return dashboardDesigner
            End Get
        End Property
    End Class
End Namespace