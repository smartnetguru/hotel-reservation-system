﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicles
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim VehicleLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVehicles))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.VehicleTextBox = New System.Windows.Forms.TextBox
        Me.VehiclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HotelDataSet = New Hotel_Management_System.hotelDataSet
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.VehiclesDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VehiclesTableAdapter = New Hotel_Management_System.hotelDataSetTableAdapters.VehiclesTableAdapter
        Me.TableAdapterManager = New Hotel_Management_System.hotelDataSetTableAdapters.TableAdapterManager
        Me.VehiclesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.VehiclesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        VehicleLabel = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.VehiclesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VehiclesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'VehicleLabel
        '
        VehicleLabel.AutoSize = True
        VehicleLabel.Location = New System.Drawing.Point(97, 106)
        VehicleLabel.Name = "VehicleLabel"
        VehicleLabel.Size = New System.Drawing.Size(45, 13)
        VehicleLabel.TabIndex = 2
        VehicleLabel.Text = "Vehicle:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(431, 41)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Harlow Solid Italic", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Vehicles"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(431, 287)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(VehicleLabel)
        Me.TabPage1.Controls.Add(Me.VehicleTextBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(423, 261)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Entry"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'VehicleTextBox
        '
        Me.VehicleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclesBindingSource, "Vehicle", True))
        Me.VehicleTextBox.Location = New System.Drawing.Point(148, 103)
        Me.VehicleTextBox.Name = "VehicleTextBox"
        Me.VehicleTextBox.Size = New System.Drawing.Size(200, 20)
        Me.VehicleTextBox.TabIndex = 3
        '
        'VehiclesBindingSource
        '
        Me.VehiclesBindingSource.DataMember = "Vehicles"
        Me.VehiclesBindingSource.DataSource = Me.HotelDataSet
        '
        'HotelDataSet
        '
        Me.HotelDataSet.DataSetName = "hotelDataSet"
        Me.HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.VehiclesDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(423, 261)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'VehiclesDataGridView
        '
        Me.VehiclesDataGridView.AutoGenerateColumns = False
        Me.VehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehiclesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.VehiclesDataGridView.DataSource = Me.VehiclesBindingSource
        Me.VehiclesDataGridView.Location = New System.Drawing.Point(6, 6)
        Me.VehiclesDataGridView.Name = "VehiclesDataGridView"
        Me.VehiclesDataGridView.Size = New System.Drawing.Size(411, 249)
        Me.VehiclesDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Vehicle"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Vehicle"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'VehiclesTableAdapter
        '
        Me.VehiclesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Accounts_ReceivableTableAdapter = Nothing
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Business_InfoTableAdapter = Nothing
        Me.TableAdapterManager.Business_SourceTableAdapter = Nothing
        Me.TableAdapterManager.Charge_TypeTableAdapter = Nothing
        Me.TableAdapterManager.CompanyTableAdapter = Nothing
        Me.TableAdapterManager.CountriesTableAdapter = Nothing
        Me.TableAdapterManager.CustomersTableAdapter = Nothing
        Me.TableAdapterManager.DateTempTableAdapter = Nothing
        Me.TableAdapterManager.FormTableAdapter = Nothing
        Me.TableAdapterManager.ID_TypeTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.Key_GeneratorTableAdapter = Nothing
        Me.TableAdapterManager.Other_ChargesTableAdapter = Nothing
        Me.TableAdapterManager.Payment_TypeTableAdapter = Nothing
        Me.TableAdapterManager.Payments_ReceivedTableAdapter = Nothing
        Me.TableAdapterManager.PaymentsTableAdapter = Nothing
        Me.TableAdapterManager.Rate_Per_Period_TempTableAdapter = Nothing
        Me.TableAdapterManager.Rate_Per_PeriodTableAdapter = Nothing
        Me.TableAdapterManager.Rate_TemplatesTableAdapter = Nothing
        Me.TableAdapterManager.Rate_TypeTableAdapter = Nothing
        Me.TableAdapterManager.ReservationTableAdapter = Nothing
        Me.TableAdapterManager.Room_RatesTableAdapter = Nothing
        Me.TableAdapterManager.Room_StatusTableAdapter = Nothing
        Me.TableAdapterManager.Room_TypeTableAdapter = Nothing
        Me.TableAdapterManager.RoomsTableAdapter = Nothing
        Me.TableAdapterManager.Transaction_TypeTableAdapter = Nothing
        Me.TableAdapterManager.TransactionsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Hotel_Management_System.hotelDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.User_PermissionTableAdapter = Nothing
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.VehiclesTableAdapter = Me.VehiclesTableAdapter
        '
        'VehiclesBindingNavigator
        '
        Me.VehiclesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VehiclesBindingNavigator.BindingSource = Me.VehiclesBindingSource
        Me.VehiclesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VehiclesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VehiclesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.VehiclesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VehiclesBindingNavigatorSaveItem})
        Me.VehiclesBindingNavigator.Location = New System.Drawing.Point(80, 347)
        Me.VehiclesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VehiclesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VehiclesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VehiclesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VehiclesBindingNavigator.Name = "VehiclesBindingNavigator"
        Me.VehiclesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VehiclesBindingNavigator.Size = New System.Drawing.Size(277, 25)
        Me.VehiclesBindingNavigator.TabIndex = 6
        Me.VehiclesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'VehiclesBindingNavigatorSaveItem
        '
        Me.VehiclesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VehiclesBindingNavigatorSaveItem.Image = CType(resources.GetObject("VehiclesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VehiclesBindingNavigatorSaveItem.Name = "VehiclesBindingNavigatorSaveItem"
        Me.VehiclesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VehiclesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'frmVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 374)
        Me.Controls.Add(Me.VehiclesBindingNavigator)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVehicles"
        Me.Text = "Vehicles"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.VehiclesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VehiclesBindingNavigator.ResumeLayout(False)
        Me.VehiclesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents HotelDataSet As Hotel_Management_System.hotelDataSet
    Friend WithEvents VehiclesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VehiclesTableAdapter As Hotel_Management_System.hotelDataSetTableAdapters.VehiclesTableAdapter
    Friend WithEvents TableAdapterManager As Hotel_Management_System.hotelDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehiclesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VehiclesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VehicleTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VehiclesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
