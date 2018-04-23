Namespace CustomDashboardDesignerForm.Win
    Partial Public Class CustomDashboardDesignerFormWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New CustomDashboardDesignerForm.Module.CustomDashboardDesignerFormModule()
            Me.module4 = New CustomDashboardDesignerForm.Module.Win.CustomDashboardDesignerFormWindowsFormsModule()
            Me.dashboardsModule = New DevExpress.ExpressApp.Dashboards.DashboardsModule()
            Me.dashboardsWindowsFormsModule = New DevExpress.ExpressApp.Dashboards.Win.DashboardsWindowsFormsModule()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            ' dashboardsModule
            '
            Me.dashboardsModule.DashboardDataType = GetType(DevExpress.Persistent.BaseImpl.DashboardData)
            ' 
            ' CustomDashboardDesignerFormWindowsFormsApplication
            ' 
            Me.ApplicationName = "CustomDashboardDesignerForm"
            Me.CheckCompatibilityType = DevExpress.ExpressApp.CheckCompatibilityType.DatabaseSchema
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.dashboardsModule)
            Me.Modules.Add(Me.dashboardsWindowsFormsModule)
            Me.UseOldTemplates = False

            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As CustomDashboardDesignerForm.Module.CustomDashboardDesignerFormModule
        Private module4 As CustomDashboardDesignerForm.Module.Win.CustomDashboardDesignerFormWindowsFormsModule
        Private dashboardsModule As DevExpress.ExpressApp.Dashboards.DashboardsModule
        Private dashboardsWindowsFormsModule As DevExpress.ExpressApp.Dashboards.Win.DashboardsWindowsFormsModule
    End Class
End Namespace
