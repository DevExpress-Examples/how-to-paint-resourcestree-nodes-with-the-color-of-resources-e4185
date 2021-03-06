﻿Namespace SchedulerResourcesTreeColors
    Partial Public Class Form1
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
            Me.schedulerControl1 = New DevExpress.XtraScheduler.SchedulerControl()
            Me.schedulerStorage1 = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
            Me.taskDependenciesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.tasksDataSet1 = New SchedulerResourcesTreeColors.TasksDataSet()
            Me.tasksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.resourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.resourcesTree1 = New DevExpress.XtraScheduler.UI.ResourcesTree()
            Me.resourceTreeColumn1 = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
            Me.tasksTableAdapter = New SchedulerResourcesTreeColors.TasksDataSetTableAdapters.TasksTableAdapter()
            Me.taskDependenciesTableAdapter = New SchedulerResourcesTreeColors.TasksDataSetTableAdapters.TaskDependenciesTableAdapter()
            Me.resourcesTableAdapter = New SchedulerResourcesTreeColors.TasksDataSetTableAdapters.ResourcesTableAdapter()
            Me.ResourceTreeColumn2 = New DevExpress.XtraScheduler.Native.ResourceTreeColumn()
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.taskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tasksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.tasksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'schedulerControl1
            '
            Me.schedulerControl1.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt
            Me.schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
            Me.schedulerControl1.Location = New System.Drawing.Point(206, 12)
            Me.schedulerControl1.Name = "schedulerControl1"
            Me.schedulerControl1.Size = New System.Drawing.Size(572, 332)
            Me.schedulerControl1.Start = New Date(2008, 8, 31, 0, 0, 0, 0)
            Me.schedulerControl1.Storage = Me.schedulerStorage1
            Me.schedulerControl1.TabIndex = 0
            Me.schedulerControl1.Text = "schedulerControl1"
            Me.schedulerControl1.Views.DayView.TimeRulers.Add(TimeRuler1)
            Me.schedulerControl1.Views.GanttView.ResourcesPerPage = 6
            Me.schedulerControl1.Views.GanttView.ShowResourceHeaders = False
            Me.schedulerControl1.Views.WorkWeekView.TimeRulers.Add(TimeRuler2)
            '
            'schedulerStorage1
            '
            Me.schedulerStorage1.AppointmentDependencies.DataSource = Me.taskDependenciesBindingSource
            Me.schedulerStorage1.AppointmentDependencies.Mappings.DependentId = "Dependent"
            Me.schedulerStorage1.AppointmentDependencies.Mappings.ParentId = "Id"
            Me.schedulerStorage1.AppointmentDependencies.Mappings.Type = "Type"
            Me.schedulerStorage1.Appointments.DataSource = Me.tasksBindingSource
            Me.schedulerStorage1.Appointments.Mappings.AppointmentId = "Id"
            Me.schedulerStorage1.Appointments.Mappings.End = "EndTime"
            Me.schedulerStorage1.Appointments.Mappings.Label = "Label"
            Me.schedulerStorage1.Appointments.Mappings.ResourceId = "ResourceId"
            Me.schedulerStorage1.Appointments.Mappings.Start = "StartTime"
            Me.schedulerStorage1.Appointments.Mappings.Subject = "Subject"
            Me.schedulerStorage1.Resources.DataSource = Me.resourcesBindingSource
            Me.schedulerStorage1.Resources.Mappings.Caption = "Description"
            Me.schedulerStorage1.Resources.Mappings.Color = "Color"
            Me.schedulerStorage1.Resources.Mappings.Id = "Id"
            Me.schedulerStorage1.Resources.Mappings.ParentId = "ParentId"
            '
            'taskDependenciesBindingSource
            '
            Me.taskDependenciesBindingSource.DataMember = "TaskDependencies"
            Me.taskDependenciesBindingSource.DataSource = Me.tasksDataSet1
            '
            'tasksDataSet1
            '
            Me.tasksDataSet1.DataSetName = "TasksDataSet"
            Me.tasksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            '
            'tasksBindingSource
            '
            Me.tasksBindingSource.DataMember = "Tasks"
            Me.tasksBindingSource.DataSource = Me.tasksDataSet1
            '
            'resourcesBindingSource
            '
            Me.resourcesBindingSource.DataMember = "Resources"
            Me.resourcesBindingSource.DataSource = Me.tasksDataSet1
            '
            'resourcesTree1
            '
            Me.resourcesTree1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.resourcesTree1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.resourceTreeColumn1, Me.ResourceTreeColumn2})
            Me.resourcesTree1.Location = New System.Drawing.Point(9, 12)
            Me.resourcesTree1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.resourcesTree1.Name = "resourcesTree1"
            Me.resourcesTree1.SchedulerControl = Me.schedulerControl1
            Me.resourcesTree1.Size = New System.Drawing.Size(192, 332)
            Me.resourcesTree1.TabIndex = 1
            '
            'resourceTreeColumn1
            '
            Me.resourceTreeColumn1.Caption = "Description"
            Me.resourceTreeColumn1.FieldName = "Description"
            Me.resourceTreeColumn1.Name = "resourceTreeColumn1"
            Me.resourceTreeColumn1.Visible = True
            Me.resourceTreeColumn1.VisibleIndex = 0
            '
            'tasksTableAdapter
            '
            Me.tasksTableAdapter.ClearBeforeFill = True
            '
            'taskDependenciesTableAdapter
            '
            Me.taskDependenciesTableAdapter.ClearBeforeFill = True
            '
            'resourcesTableAdapter
            '
            Me.resourcesTableAdapter.ClearBeforeFill = True
            '
            'ResourceTreeColumn2
            '
            Me.ResourceTreeColumn2.Caption = "ResourceTreeColumn2"
            Me.ResourceTreeColumn2.FieldName = "Id"
            Me.ResourceTreeColumn2.Name = "ResourceTreeColumn2"
            '
            'Form1
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(790, 387)
            Me.Controls.Add(Me.resourcesTree1)
            Me.Controls.Add(Me.schedulerControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.schedulerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.schedulerStorage1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.taskDependenciesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tasksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.tasksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.resourcesTree1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private schedulerControl1 As DevExpress.XtraScheduler.SchedulerControl
        Private schedulerStorage1 As DevExpress.XtraScheduler.SchedulerStorage
        Private WithEvents resourcesTree1 As DevExpress.XtraScheduler.UI.ResourcesTree
        Private tasksDataSet1 As TasksDataSet
        Private resourceTreeColumn1 As DevExpress.XtraScheduler.Native.ResourceTreeColumn
        Private tasksBindingSource As System.Windows.Forms.BindingSource
        Private tasksTableAdapter As SchedulerResourcesTreeColors.TasksDataSetTableAdapters.TasksTableAdapter
        Private taskDependenciesBindingSource As System.Windows.Forms.BindingSource
        Private taskDependenciesTableAdapter As SchedulerResourcesTreeColors.TasksDataSetTableAdapters.TaskDependenciesTableAdapter
        Private resourcesBindingSource As System.Windows.Forms.BindingSource
        Private resourcesTableAdapter As SchedulerResourcesTreeColors.TasksDataSetTableAdapters.ResourcesTableAdapter
        Friend WithEvents ResourceTreeColumn2 As DevExpress.XtraScheduler.Native.ResourceTreeColumn
    End Class
End Namespace

