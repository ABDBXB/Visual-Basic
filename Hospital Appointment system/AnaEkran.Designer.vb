<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnaEkran
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
        Me.components = New System.ComponentModel.Container()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.DoktorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New randevusistemi.Database1DataSet1()
        Me.PoliklinikBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet3 = New randevusistemi.Database1DataSet3()
        Me.DoktorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet2 = New randevusistemi.Database1DataSet2()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DoktorTableAdapter = New randevusistemi.Database1DataSet1TableAdapters.doktorTableAdapter()
        Me.DoktorTableAdapter1 = New randevusistemi.Database1DataSet2TableAdapters.doktorTableAdapter()
        Me.PoliklinikTableAdapter = New randevusistemi.Database1DataSet3TableAdapters.poliklinikTableAdapter()
        Me.button1450 = New System.Windows.Forms.Button()
        Me.button1440 = New System.Windows.Forms.Button()
        Me.button1430 = New System.Windows.Forms.Button()
        Me.button1420 = New System.Windows.Forms.Button()
        Me.button1410 = New System.Windows.Forms.Button()
        Me.button1400 = New System.Windows.Forms.Button()
        Me.button1350 = New System.Windows.Forms.Button()
        Me.button1340 = New System.Windows.Forms.Button()
        Me.button1330 = New System.Windows.Forms.Button()
        Me.button1320 = New System.Windows.Forms.Button()
        Me.button1310 = New System.Windows.Forms.Button()
        Me.button1300 = New System.Windows.Forms.Button()
        Me.button1150 = New System.Windows.Forms.Button()
        Me.button1140 = New System.Windows.Forms.Button()
        Me.button1130 = New System.Windows.Forms.Button()
        Me.button1120 = New System.Windows.Forms.Button()
        Me.button1110 = New System.Windows.Forms.Button()
        Me.button1100 = New System.Windows.Forms.Button()
        Me.button1050 = New System.Windows.Forms.Button()
        Me.button1040 = New System.Windows.Forms.Button()
        Me.button1030 = New System.Windows.Forms.Button()
        Me.button1020 = New System.Windows.Forms.Button()
        Me.button1010 = New System.Windows.Forms.Button()
        Me.button1000 = New System.Windows.Forms.Button()
        Me.button950 = New System.Windows.Forms.Button()
        Me.button940 = New System.Windows.Forms.Button()
        Me.button930 = New System.Windows.Forms.Button()
        Me.button920 = New System.Windows.Forms.Button()
        Me.button910 = New System.Windows.Forms.Button()
        Me.button900 = New System.Windows.Forms.Button()
        Me.button1550 = New System.Windows.Forms.Button()
        Me.button1540 = New System.Windows.Forms.Button()
        Me.button1530 = New System.Windows.Forms.Button()
        Me.button1520 = New System.Windows.Forms.Button()
        Me.button1510 = New System.Windows.Forms.Button()
        Me.button1500 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PoliklinikBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DoktorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(368, 403)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(88, 35)
        Me.Button3.TabIndex = 29
        Me.Button3.Text = "Randevuyu Kaydet"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(563, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(368, 12)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 26
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DoktorBindingSource, "poliklinik", True))
        Me.ComboBox2.DataSource = Me.PoliklinikBindingSource
        Me.ComboBox2.DisplayMember = "poliklinik_ad"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(164, 12)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 25
        Me.ComboBox2.ValueMember = "poliklinik_ad"
        '
        'DoktorBindingSource
        '
        Me.DoktorBindingSource.DataMember = "doktor"
        Me.DoktorBindingSource.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PoliklinikBindingSource
        '
        Me.PoliklinikBindingSource.DataMember = "poliklinik"
        Me.PoliklinikBindingSource.DataSource = Me.Database1DataSet3
        '
        'Database1DataSet3
        '
        Me.Database1DataSet3.DataSetName = "Database1DataSet3"
        Me.Database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DoktorBindingSource1
        '
        Me.DoktorBindingSource1.DataMember = "doktor"
        Me.DoktorBindingSource1.DataSource = Me.Database1DataSet2
        '
        'Database1DataSet2
        '
        Me.Database1DataSet2.DataSetName = "Database1DataSet2"
        Me.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(523, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Tarih:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Doktor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Poliklink:"
        '
        'DoktorTableAdapter
        '
        Me.DoktorTableAdapter.ClearBeforeFill = True
        '
        'DoktorTableAdapter1
        '
        Me.DoktorTableAdapter1.ClearBeforeFill = True
        '
        'PoliklinikTableAdapter
        '
        Me.PoliklinikTableAdapter.ClearBeforeFill = True
        '
        'button1450
        '
        Me.button1450.BackColor = System.Drawing.Color.LimeGreen
        Me.button1450.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1450.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1450.Location = New System.Drawing.Point(529, 231)
        Me.button1450.Name = "button1450"
        Me.button1450.Size = New System.Drawing.Size(61, 32)
        Me.button1450.TabIndex = 85
        Me.button1450.Text = "14:50"
        Me.button1450.UseVisualStyleBackColor = False
        '
        'button1440
        '
        Me.button1440.BackColor = System.Drawing.Color.LimeGreen
        Me.button1440.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1440.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1440.Location = New System.Drawing.Point(462, 231)
        Me.button1440.Name = "button1440"
        Me.button1440.Size = New System.Drawing.Size(61, 32)
        Me.button1440.TabIndex = 84
        Me.button1440.Text = "14:40"
        Me.button1440.UseVisualStyleBackColor = False
        '
        'button1430
        '
        Me.button1430.BackColor = System.Drawing.Color.LimeGreen
        Me.button1430.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1430.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1430.Location = New System.Drawing.Point(395, 231)
        Me.button1430.Name = "button1430"
        Me.button1430.Size = New System.Drawing.Size(61, 32)
        Me.button1430.TabIndex = 83
        Me.button1430.Text = "14:30"
        Me.button1430.UseVisualStyleBackColor = False
        '
        'button1420
        '
        Me.button1420.BackColor = System.Drawing.Color.LimeGreen
        Me.button1420.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1420.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1420.Location = New System.Drawing.Point(328, 231)
        Me.button1420.Name = "button1420"
        Me.button1420.Size = New System.Drawing.Size(61, 32)
        Me.button1420.TabIndex = 82
        Me.button1420.Text = "14:20"
        Me.button1420.UseVisualStyleBackColor = False
        '
        'button1410
        '
        Me.button1410.BackColor = System.Drawing.Color.LimeGreen
        Me.button1410.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1410.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1410.Location = New System.Drawing.Point(261, 231)
        Me.button1410.Name = "button1410"
        Me.button1410.Size = New System.Drawing.Size(61, 32)
        Me.button1410.TabIndex = 81
        Me.button1410.Text = "14:10"
        Me.button1410.UseVisualStyleBackColor = False
        '
        'button1400
        '
        Me.button1400.BackColor = System.Drawing.Color.LimeGreen
        Me.button1400.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1400.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1400.Location = New System.Drawing.Point(194, 231)
        Me.button1400.Name = "button1400"
        Me.button1400.Size = New System.Drawing.Size(61, 32)
        Me.button1400.TabIndex = 80
        Me.button1400.Text = "14:00"
        Me.button1400.UseVisualStyleBackColor = False
        '
        'button1350
        '
        Me.button1350.BackColor = System.Drawing.Color.LimeGreen
        Me.button1350.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1350.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1350.Location = New System.Drawing.Point(529, 193)
        Me.button1350.Name = "button1350"
        Me.button1350.Size = New System.Drawing.Size(61, 32)
        Me.button1350.TabIndex = 79
        Me.button1350.Text = "13:50"
        Me.button1350.UseVisualStyleBackColor = False
        '
        'button1340
        '
        Me.button1340.BackColor = System.Drawing.Color.LimeGreen
        Me.button1340.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1340.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1340.Location = New System.Drawing.Point(462, 193)
        Me.button1340.Name = "button1340"
        Me.button1340.Size = New System.Drawing.Size(61, 32)
        Me.button1340.TabIndex = 78
        Me.button1340.Text = "13:40"
        Me.button1340.UseVisualStyleBackColor = False
        '
        'button1330
        '
        Me.button1330.BackColor = System.Drawing.Color.LimeGreen
        Me.button1330.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1330.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1330.Location = New System.Drawing.Point(395, 193)
        Me.button1330.Name = "button1330"
        Me.button1330.Size = New System.Drawing.Size(61, 32)
        Me.button1330.TabIndex = 77
        Me.button1330.Text = "13:30"
        Me.button1330.UseVisualStyleBackColor = False
        '
        'button1320
        '
        Me.button1320.BackColor = System.Drawing.Color.LimeGreen
        Me.button1320.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1320.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1320.Location = New System.Drawing.Point(328, 193)
        Me.button1320.Name = "button1320"
        Me.button1320.Size = New System.Drawing.Size(61, 32)
        Me.button1320.TabIndex = 76
        Me.button1320.Text = "13:20"
        Me.button1320.UseVisualStyleBackColor = False
        '
        'button1310
        '
        Me.button1310.BackColor = System.Drawing.Color.LimeGreen
        Me.button1310.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1310.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1310.Location = New System.Drawing.Point(261, 193)
        Me.button1310.Name = "button1310"
        Me.button1310.Size = New System.Drawing.Size(61, 32)
        Me.button1310.TabIndex = 75
        Me.button1310.Text = "13:10"
        Me.button1310.UseVisualStyleBackColor = False
        '
        'button1300
        '
        Me.button1300.BackColor = System.Drawing.Color.LimeGreen
        Me.button1300.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1300.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1300.Location = New System.Drawing.Point(194, 193)
        Me.button1300.Name = "button1300"
        Me.button1300.Size = New System.Drawing.Size(61, 32)
        Me.button1300.TabIndex = 74
        Me.button1300.Text = "13:00"
        Me.button1300.UseVisualStyleBackColor = False
        '
        'button1150
        '
        Me.button1150.BackColor = System.Drawing.Color.LimeGreen
        Me.button1150.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1150.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1150.Location = New System.Drawing.Point(529, 155)
        Me.button1150.Name = "button1150"
        Me.button1150.Size = New System.Drawing.Size(61, 32)
        Me.button1150.TabIndex = 73
        Me.button1150.Text = "11:50"
        Me.button1150.UseVisualStyleBackColor = False
        '
        'button1140
        '
        Me.button1140.BackColor = System.Drawing.Color.LimeGreen
        Me.button1140.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1140.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1140.Location = New System.Drawing.Point(462, 155)
        Me.button1140.Name = "button1140"
        Me.button1140.Size = New System.Drawing.Size(61, 32)
        Me.button1140.TabIndex = 72
        Me.button1140.Text = "11:40"
        Me.button1140.UseVisualStyleBackColor = False
        '
        'button1130
        '
        Me.button1130.BackColor = System.Drawing.Color.LimeGreen
        Me.button1130.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1130.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1130.Location = New System.Drawing.Point(395, 155)
        Me.button1130.Name = "button1130"
        Me.button1130.Size = New System.Drawing.Size(61, 32)
        Me.button1130.TabIndex = 71
        Me.button1130.Text = "11:30"
        Me.button1130.UseVisualStyleBackColor = False
        '
        'button1120
        '
        Me.button1120.BackColor = System.Drawing.Color.LimeGreen
        Me.button1120.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1120.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1120.Location = New System.Drawing.Point(328, 155)
        Me.button1120.Name = "button1120"
        Me.button1120.Size = New System.Drawing.Size(61, 32)
        Me.button1120.TabIndex = 70
        Me.button1120.Text = "11:20"
        Me.button1120.UseVisualStyleBackColor = False
        '
        'button1110
        '
        Me.button1110.BackColor = System.Drawing.Color.LimeGreen
        Me.button1110.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1110.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1110.Location = New System.Drawing.Point(261, 155)
        Me.button1110.Name = "button1110"
        Me.button1110.Size = New System.Drawing.Size(61, 32)
        Me.button1110.TabIndex = 69
        Me.button1110.Text = "11:10"
        Me.button1110.UseVisualStyleBackColor = False
        '
        'button1100
        '
        Me.button1100.BackColor = System.Drawing.Color.LimeGreen
        Me.button1100.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1100.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1100.Location = New System.Drawing.Point(194, 155)
        Me.button1100.Name = "button1100"
        Me.button1100.Size = New System.Drawing.Size(61, 32)
        Me.button1100.TabIndex = 68
        Me.button1100.Text = "11:00"
        Me.button1100.UseVisualStyleBackColor = False
        '
        'button1050
        '
        Me.button1050.BackColor = System.Drawing.Color.LimeGreen
        Me.button1050.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1050.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1050.Location = New System.Drawing.Point(529, 117)
        Me.button1050.Name = "button1050"
        Me.button1050.Size = New System.Drawing.Size(61, 32)
        Me.button1050.TabIndex = 67
        Me.button1050.Text = "10:50"
        Me.button1050.UseVisualStyleBackColor = False
        '
        'button1040
        '
        Me.button1040.BackColor = System.Drawing.Color.LimeGreen
        Me.button1040.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1040.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1040.Location = New System.Drawing.Point(462, 117)
        Me.button1040.Name = "button1040"
        Me.button1040.Size = New System.Drawing.Size(61, 32)
        Me.button1040.TabIndex = 66
        Me.button1040.Text = "10:40"
        Me.button1040.UseVisualStyleBackColor = False
        '
        'button1030
        '
        Me.button1030.BackColor = System.Drawing.Color.LimeGreen
        Me.button1030.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1030.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1030.Location = New System.Drawing.Point(395, 117)
        Me.button1030.Name = "button1030"
        Me.button1030.Size = New System.Drawing.Size(61, 32)
        Me.button1030.TabIndex = 65
        Me.button1030.Text = "10:30"
        Me.button1030.UseVisualStyleBackColor = False
        '
        'button1020
        '
        Me.button1020.BackColor = System.Drawing.Color.LimeGreen
        Me.button1020.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1020.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1020.Location = New System.Drawing.Point(328, 117)
        Me.button1020.Name = "button1020"
        Me.button1020.Size = New System.Drawing.Size(61, 32)
        Me.button1020.TabIndex = 64
        Me.button1020.Text = "10:20"
        Me.button1020.UseVisualStyleBackColor = False
        '
        'button1010
        '
        Me.button1010.BackColor = System.Drawing.Color.LimeGreen
        Me.button1010.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1010.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1010.Location = New System.Drawing.Point(261, 117)
        Me.button1010.Name = "button1010"
        Me.button1010.Size = New System.Drawing.Size(61, 32)
        Me.button1010.TabIndex = 63
        Me.button1010.Text = "10:10"
        Me.button1010.UseVisualStyleBackColor = False
        '
        'button1000
        '
        Me.button1000.BackColor = System.Drawing.Color.LimeGreen
        Me.button1000.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1000.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1000.Location = New System.Drawing.Point(194, 117)
        Me.button1000.Name = "button1000"
        Me.button1000.Size = New System.Drawing.Size(61, 32)
        Me.button1000.TabIndex = 62
        Me.button1000.Text = "10:00"
        Me.button1000.UseVisualStyleBackColor = False
        '
        'button950
        '
        Me.button950.BackColor = System.Drawing.Color.LimeGreen
        Me.button950.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button950.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button950.Location = New System.Drawing.Point(529, 79)
        Me.button950.Name = "button950"
        Me.button950.Size = New System.Drawing.Size(61, 32)
        Me.button950.TabIndex = 61
        Me.button950.Text = "09:50"
        Me.button950.UseVisualStyleBackColor = False
        '
        'button940
        '
        Me.button940.BackColor = System.Drawing.Color.LimeGreen
        Me.button940.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button940.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button940.Location = New System.Drawing.Point(462, 79)
        Me.button940.Name = "button940"
        Me.button940.Size = New System.Drawing.Size(61, 32)
        Me.button940.TabIndex = 60
        Me.button940.Text = "09:40"
        Me.button940.UseVisualStyleBackColor = False
        '
        'button930
        '
        Me.button930.BackColor = System.Drawing.Color.LimeGreen
        Me.button930.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button930.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button930.Location = New System.Drawing.Point(395, 79)
        Me.button930.Name = "button930"
        Me.button930.Size = New System.Drawing.Size(61, 32)
        Me.button930.TabIndex = 59
        Me.button930.Text = "09:30"
        Me.button930.UseVisualStyleBackColor = False
        '
        'button920
        '
        Me.button920.BackColor = System.Drawing.Color.LimeGreen
        Me.button920.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button920.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button920.Location = New System.Drawing.Point(328, 79)
        Me.button920.Name = "button920"
        Me.button920.Size = New System.Drawing.Size(61, 32)
        Me.button920.TabIndex = 58
        Me.button920.Text = "09:20"
        Me.button920.UseVisualStyleBackColor = False
        '
        'button910
        '
        Me.button910.BackColor = System.Drawing.Color.LimeGreen
        Me.button910.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button910.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button910.Location = New System.Drawing.Point(261, 79)
        Me.button910.Name = "button910"
        Me.button910.Size = New System.Drawing.Size(61, 32)
        Me.button910.TabIndex = 57
        Me.button910.Text = "09:10"
        Me.button910.UseVisualStyleBackColor = False
        '
        'button900
        '
        Me.button900.BackColor = System.Drawing.Color.LimeGreen
        Me.button900.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button900.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button900.Location = New System.Drawing.Point(194, 79)
        Me.button900.Name = "button900"
        Me.button900.Size = New System.Drawing.Size(61, 32)
        Me.button900.TabIndex = 56
        Me.button900.Text = "09:00"
        Me.button900.UseVisualStyleBackColor = False
        '
        'button1550
        '
        Me.button1550.BackColor = System.Drawing.Color.LimeGreen
        Me.button1550.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1550.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1550.Location = New System.Drawing.Point(529, 269)
        Me.button1550.Name = "button1550"
        Me.button1550.Size = New System.Drawing.Size(61, 32)
        Me.button1550.TabIndex = 91
        Me.button1550.Text = "15:50"
        Me.button1550.UseVisualStyleBackColor = False
        '
        'button1540
        '
        Me.button1540.BackColor = System.Drawing.Color.LimeGreen
        Me.button1540.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1540.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1540.Location = New System.Drawing.Point(462, 269)
        Me.button1540.Name = "button1540"
        Me.button1540.Size = New System.Drawing.Size(61, 32)
        Me.button1540.TabIndex = 90
        Me.button1540.Text = "15:40"
        Me.button1540.UseVisualStyleBackColor = False
        '
        'button1530
        '
        Me.button1530.BackColor = System.Drawing.Color.LimeGreen
        Me.button1530.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1530.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1530.Location = New System.Drawing.Point(395, 269)
        Me.button1530.Name = "button1530"
        Me.button1530.Size = New System.Drawing.Size(61, 32)
        Me.button1530.TabIndex = 89
        Me.button1530.Text = "15:30"
        Me.button1530.UseVisualStyleBackColor = False
        '
        'button1520
        '
        Me.button1520.BackColor = System.Drawing.Color.LimeGreen
        Me.button1520.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1520.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1520.Location = New System.Drawing.Point(328, 269)
        Me.button1520.Name = "button1520"
        Me.button1520.Size = New System.Drawing.Size(61, 32)
        Me.button1520.TabIndex = 88
        Me.button1520.Text = "15:20"
        Me.button1520.UseVisualStyleBackColor = False
        '
        'button1510
        '
        Me.button1510.BackColor = System.Drawing.Color.LimeGreen
        Me.button1510.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1510.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1510.Location = New System.Drawing.Point(261, 269)
        Me.button1510.Name = "button1510"
        Me.button1510.Size = New System.Drawing.Size(61, 32)
        Me.button1510.TabIndex = 87
        Me.button1510.Text = "15:10"
        Me.button1510.UseVisualStyleBackColor = False
        '
        'button1500
        '
        Me.button1500.BackColor = System.Drawing.Color.LimeGreen
        Me.button1500.Cursor = System.Windows.Forms.Cursors.Hand
        Me.button1500.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.button1500.Location = New System.Drawing.Point(194, 269)
        Me.button1500.Name = "button1500"
        Me.button1500.Size = New System.Drawing.Size(61, 32)
        Me.button1500.TabIndex = 86
        Me.button1500.Text = "15:00"
        Me.button1500.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(403, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "00:00"
        '
        'AnaEkran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.button1550)
        Me.Controls.Add(Me.button1540)
        Me.Controls.Add(Me.button1530)
        Me.Controls.Add(Me.button1520)
        Me.Controls.Add(Me.button1510)
        Me.Controls.Add(Me.button1500)
        Me.Controls.Add(Me.button1450)
        Me.Controls.Add(Me.button1440)
        Me.Controls.Add(Me.button1430)
        Me.Controls.Add(Me.button1420)
        Me.Controls.Add(Me.button1410)
        Me.Controls.Add(Me.button1400)
        Me.Controls.Add(Me.button1350)
        Me.Controls.Add(Me.button1340)
        Me.Controls.Add(Me.button1330)
        Me.Controls.Add(Me.button1320)
        Me.Controls.Add(Me.button1310)
        Me.Controls.Add(Me.button1300)
        Me.Controls.Add(Me.button1150)
        Me.Controls.Add(Me.button1140)
        Me.Controls.Add(Me.button1130)
        Me.Controls.Add(Me.button1120)
        Me.Controls.Add(Me.button1110)
        Me.Controls.Add(Me.button1100)
        Me.Controls.Add(Me.button1050)
        Me.Controls.Add(Me.button1040)
        Me.Controls.Add(Me.button1030)
        Me.Controls.Add(Me.button1020)
        Me.Controls.Add(Me.button1010)
        Me.Controls.Add(Me.button1000)
        Me.Controls.Add(Me.button950)
        Me.Controls.Add(Me.button940)
        Me.Controls.Add(Me.button930)
        Me.Controls.Add(Me.button920)
        Me.Controls.Add(Me.button910)
        Me.Controls.Add(Me.button900)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Name = "AnaEkran"
        Me.Text = "Form1"
        CType(Me.DoktorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PoliklinikBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DoktorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Database1DataSet1 As Database1DataSet1
    Friend WithEvents DoktorBindingSource As BindingSource
    Friend WithEvents DoktorTableAdapter As Database1DataSet1TableAdapters.doktorTableAdapter
    Friend WithEvents Database1DataSet2 As Database1DataSet2
    Friend WithEvents DoktorBindingSource1 As BindingSource
    Friend WithEvents DoktorTableAdapter1 As Database1DataSet2TableAdapters.doktorTableAdapter
    Friend WithEvents Database1DataSet3 As Database1DataSet3
    Friend WithEvents PoliklinikBindingSource As BindingSource
    Friend WithEvents PoliklinikTableAdapter As Database1DataSet3TableAdapters.poliklinikTableAdapter
    Private WithEvents button1450 As Button
    Private WithEvents button1440 As Button
    Private WithEvents button1430 As Button
    Private WithEvents button1420 As Button
    Private WithEvents button1410 As Button
    Private WithEvents button1400 As Button
    Private WithEvents button1350 As Button
    Private WithEvents button1340 As Button
    Private WithEvents button1330 As Button
    Private WithEvents button1320 As Button
    Private WithEvents button1310 As Button
    Private WithEvents button1300 As Button
    Private WithEvents button1150 As Button
    Private WithEvents button1140 As Button
    Private WithEvents button1130 As Button
    Private WithEvents button1120 As Button
    Private WithEvents button1110 As Button
    Private WithEvents button1100 As Button
    Private WithEvents button1050 As Button
    Private WithEvents button1040 As Button
    Private WithEvents button1030 As Button
    Private WithEvents button1020 As Button
    Private WithEvents button1010 As Button
    Private WithEvents button1000 As Button
    Private WithEvents button950 As Button
    Private WithEvents button940 As Button
    Private WithEvents button930 As Button
    Private WithEvents button920 As Button
    Private WithEvents button910 As Button
    Private WithEvents button900 As Button
    Private WithEvents button1550 As Button
    Private WithEvents button1540 As Button
    Private WithEvents button1530 As Button
    Private WithEvents button1520 As Button
    Private WithEvents button1510 As Button
    Private WithEvents button1500 As Button
    Friend WithEvents Label2 As Label
End Class
