<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.gbCountry = New System.Windows.Forms.GroupBox()
        Me.rbChina = New System.Windows.Forms.RadioButton()
        Me.rbJapan = New System.Windows.Forms.RadioButton()
        Me.rbUsa = New System.Windows.Forms.RadioButton()
        Me.rbNewZealand = New System.Windows.Forms.RadioButton()
        Me.rbAustralia = New System.Windows.Forms.RadioButton()
        Me.rbThumbNail = New System.Windows.Forms.RadioButton()
        Me.rbFullSize = New System.Windows.Forms.RadioButton()
        Me.gbImageSize = New System.Windows.Forms.GroupBox()
        Me.lblFlag = New System.Windows.Forms.Label()
        Me.pbThumAus = New System.Windows.Forms.PictureBox()
        Me.pbThumbUsa = New System.Windows.Forms.PictureBox()
        Me.pbThumbJapan = New System.Windows.Forms.PictureBox()
        Me.pbThumbChina = New System.Windows.Forms.PictureBox()
        Me.pbThumbNZ = New System.Windows.Forms.PictureBox()
        Me.pbChinaFlag = New System.Windows.Forms.PictureBox()
        Me.pbJapanFlag = New System.Windows.Forms.PictureBox()
        Me.pbUsaFlag = New System.Windows.Forms.PictureBox()
        Me.pbNewZealandFlag = New System.Windows.Forms.PictureBox()
        Me.pbAustraliaFlags = New System.Windows.Forms.PictureBox()
        Me.lblMyName = New System.Windows.Forms.Label()
        Me.gbCountry.SuspendLayout()
        Me.gbImageSize.SuspendLayout()
        CType(Me.pbThumAus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumbUsa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumbJapan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumbChina, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbThumbNZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbChinaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbJapanFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbUsaFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbNewZealandFlag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAustraliaFlags, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCountry
        '
        Me.gbCountry.Controls.Add(Me.rbChina)
        Me.gbCountry.Controls.Add(Me.rbJapan)
        Me.gbCountry.Controls.Add(Me.rbUsa)
        Me.gbCountry.Controls.Add(Me.rbNewZealand)
        Me.gbCountry.Controls.Add(Me.rbAustralia)
        Me.gbCountry.Location = New System.Drawing.Point(39, 22)
        Me.gbCountry.Name = "gbCountry"
        Me.gbCountry.Size = New System.Drawing.Size(200, 214)
        Me.gbCountry.TabIndex = 1
        Me.gbCountry.TabStop = False
        Me.gbCountry.Text = "Country"
        '
        'rbChina
        '
        Me.rbChina.AutoSize = True
        Me.rbChina.Location = New System.Drawing.Point(18, 157)
        Me.rbChina.Name = "rbChina"
        Me.rbChina.Size = New System.Drawing.Size(52, 17)
        Me.rbChina.TabIndex = 4
        Me.rbChina.Text = "China"
        Me.rbChina.UseVisualStyleBackColor = True
        '
        'rbJapan
        '
        Me.rbJapan.AutoSize = True
        Me.rbJapan.Location = New System.Drawing.Point(19, 134)
        Me.rbJapan.Name = "rbJapan"
        Me.rbJapan.Size = New System.Drawing.Size(54, 17)
        Me.rbJapan.TabIndex = 3
        Me.rbJapan.Text = "Japan"
        Me.rbJapan.UseVisualStyleBackColor = True
        '
        'rbUsa
        '
        Me.rbUsa.AutoSize = True
        Me.rbUsa.Location = New System.Drawing.Point(19, 111)
        Me.rbUsa.Name = "rbUsa"
        Me.rbUsa.Size = New System.Drawing.Size(47, 17)
        Me.rbUsa.TabIndex = 2
        Me.rbUsa.Text = "USA"
        Me.rbUsa.UseVisualStyleBackColor = True
        '
        'rbNewZealand
        '
        Me.rbNewZealand.AutoSize = True
        Me.rbNewZealand.Location = New System.Drawing.Point(19, 88)
        Me.rbNewZealand.Name = "rbNewZealand"
        Me.rbNewZealand.Size = New System.Drawing.Size(89, 17)
        Me.rbNewZealand.TabIndex = 1
        Me.rbNewZealand.Text = "New Zealand"
        Me.rbNewZealand.UseVisualStyleBackColor = True
        '
        'rbAustralia
        '
        Me.rbAustralia.AutoSize = True
        Me.rbAustralia.Checked = True
        Me.rbAustralia.Location = New System.Drawing.Point(19, 65)
        Me.rbAustralia.Name = "rbAustralia"
        Me.rbAustralia.Size = New System.Drawing.Size(65, 17)
        Me.rbAustralia.TabIndex = 0
        Me.rbAustralia.TabStop = True
        Me.rbAustralia.Text = "Australia"
        Me.rbAustralia.UseVisualStyleBackColor = True
        '
        'rbThumbNail
        '
        Me.rbThumbNail.AutoSize = True
        Me.rbThumbNail.Location = New System.Drawing.Point(6, 34)
        Me.rbThumbNail.Name = "rbThumbNail"
        Me.rbThumbNail.Size = New System.Drawing.Size(79, 17)
        Me.rbThumbNail.TabIndex = 2
        Me.rbThumbNail.Text = "Thumb Nail"
        Me.rbThumbNail.UseVisualStyleBackColor = True
        '
        'rbFullSize
        '
        Me.rbFullSize.AutoSize = True
        Me.rbFullSize.Checked = True
        Me.rbFullSize.Location = New System.Drawing.Point(6, 77)
        Me.rbFullSize.Name = "rbFullSize"
        Me.rbFullSize.Size = New System.Drawing.Size(64, 17)
        Me.rbFullSize.TabIndex = 3
        Me.rbFullSize.TabStop = True
        Me.rbFullSize.Text = "Full Size"
        Me.rbFullSize.UseVisualStyleBackColor = True
        '
        'gbImageSize
        '
        Me.gbImageSize.Controls.Add(Me.rbThumbNail)
        Me.gbImageSize.Controls.Add(Me.rbFullSize)
        Me.gbImageSize.Location = New System.Drawing.Point(39, 301)
        Me.gbImageSize.Name = "gbImageSize"
        Me.gbImageSize.Size = New System.Drawing.Size(200, 100)
        Me.gbImageSize.TabIndex = 4
        Me.gbImageSize.TabStop = False
        Me.gbImageSize.Text = "Image Size"
        '
        'lblFlag
        '
        Me.lblFlag.AutoSize = True
        Me.lblFlag.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFlag.ForeColor = System.Drawing.Color.Blue
        Me.lblFlag.Location = New System.Drawing.Point(583, 77)
        Me.lblFlag.Name = "lblFlag"
        Me.lblFlag.Size = New System.Drawing.Size(115, 29)
        Me.lblFlag.TabIndex = 5
        Me.lblFlag.Text = "Australia"
        '
        'pbThumAus
        '
        Me.pbThumAus.Image = Global.exercise3.My.Resources.Resources.au
        Me.pbThumAus.Location = New System.Drawing.Point(588, 119)
        Me.pbThumAus.Name = "pbThumAus"
        Me.pbThumAus.Size = New System.Drawing.Size(100, 50)
        Me.pbThumAus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumAus.TabIndex = 14
        Me.pbThumAus.TabStop = False
        '
        'pbThumbUsa
        '
        Me.pbThumbUsa.Image = Global.exercise3.My.Resources.Resources.us1
        Me.pbThumbUsa.Location = New System.Drawing.Point(588, 119)
        Me.pbThumbUsa.Name = "pbThumbUsa"
        Me.pbThumbUsa.Size = New System.Drawing.Size(100, 50)
        Me.pbThumbUsa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumbUsa.TabIndex = 13
        Me.pbThumbUsa.TabStop = False
        '
        'pbThumbJapan
        '
        Me.pbThumbJapan.Image = Global.exercise3.My.Resources.Resources.jp1
        Me.pbThumbJapan.Location = New System.Drawing.Point(588, 119)
        Me.pbThumbJapan.Name = "pbThumbJapan"
        Me.pbThumbJapan.Size = New System.Drawing.Size(100, 50)
        Me.pbThumbJapan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumbJapan.TabIndex = 12
        Me.pbThumbJapan.TabStop = False
        '
        'pbThumbChina
        '
        Me.pbThumbChina.Image = Global.exercise3.My.Resources.Resources.cn1
        Me.pbThumbChina.Location = New System.Drawing.Point(588, 119)
        Me.pbThumbChina.Name = "pbThumbChina"
        Me.pbThumbChina.Size = New System.Drawing.Size(100, 50)
        Me.pbThumbChina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumbChina.TabIndex = 11
        Me.pbThumbChina.TabStop = False
        '
        'pbThumbNZ
        '
        Me.pbThumbNZ.Image = Global.exercise3.My.Resources.Resources.nz
        Me.pbThumbNZ.Location = New System.Drawing.Point(588, 119)
        Me.pbThumbNZ.Name = "pbThumbNZ"
        Me.pbThumbNZ.Size = New System.Drawing.Size(100, 50)
        Me.pbThumbNZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbThumbNZ.TabIndex = 10
        Me.pbThumbNZ.TabStop = False
        '
        'pbChinaFlag
        '
        Me.pbChinaFlag.Image = Global.exercise3.My.Resources.Resources.cn1
        Me.pbChinaFlag.Location = New System.Drawing.Point(331, 119)
        Me.pbChinaFlag.Name = "pbChinaFlag"
        Me.pbChinaFlag.Size = New System.Drawing.Size(600, 300)
        Me.pbChinaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbChinaFlag.TabIndex = 9
        Me.pbChinaFlag.TabStop = False
        '
        'pbJapanFlag
        '
        Me.pbJapanFlag.Image = Global.exercise3.My.Resources.Resources.jp1
        Me.pbJapanFlag.Location = New System.Drawing.Point(331, 119)
        Me.pbJapanFlag.Name = "pbJapanFlag"
        Me.pbJapanFlag.Size = New System.Drawing.Size(600, 300)
        Me.pbJapanFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbJapanFlag.TabIndex = 8
        Me.pbJapanFlag.TabStop = False
        '
        'pbUsaFlag
        '
        Me.pbUsaFlag.Image = Global.exercise3.My.Resources.Resources.us1
        Me.pbUsaFlag.Location = New System.Drawing.Point(331, 119)
        Me.pbUsaFlag.Name = "pbUsaFlag"
        Me.pbUsaFlag.Size = New System.Drawing.Size(600, 300)
        Me.pbUsaFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbUsaFlag.TabIndex = 7
        Me.pbUsaFlag.TabStop = False
        '
        'pbNewZealandFlag
        '
        Me.pbNewZealandFlag.Image = Global.exercise3.My.Resources.Resources.nz
        Me.pbNewZealandFlag.Location = New System.Drawing.Point(331, 119)
        Me.pbNewZealandFlag.Name = "pbNewZealandFlag"
        Me.pbNewZealandFlag.Size = New System.Drawing.Size(600, 300)
        Me.pbNewZealandFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbNewZealandFlag.TabIndex = 6
        Me.pbNewZealandFlag.TabStop = False
        '
        'pbAustraliaFlags
        '
        Me.pbAustraliaFlags.Image = Global.exercise3.My.Resources.Resources.au
        Me.pbAustraliaFlags.Location = New System.Drawing.Point(331, 119)
        Me.pbAustraliaFlags.Name = "pbAustraliaFlags"
        Me.pbAustraliaFlags.Size = New System.Drawing.Size(600, 300)
        Me.pbAustraliaFlags.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAustraliaFlags.TabIndex = 0
        Me.pbAustraliaFlags.TabStop = False
        '
        'lblMyName
        '
        Me.lblMyName.AutoSize = True
        Me.lblMyName.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMyName.Location = New System.Drawing.Point(505, 22)
        Me.lblMyName.Name = "lblMyName"
        Me.lblMyName.Size = New System.Drawing.Size(256, 32)
        Me.lblMyName.TabIndex = 15
        Me.lblMyName.Text = "Flags of the World"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 552)
        Me.Controls.Add(Me.lblMyName)
        Me.Controls.Add(Me.pbThumAus)
        Me.Controls.Add(Me.pbThumbUsa)
        Me.Controls.Add(Me.pbThumbJapan)
        Me.Controls.Add(Me.pbThumbChina)
        Me.Controls.Add(Me.pbThumbNZ)
        Me.Controls.Add(Me.lblFlag)
        Me.Controls.Add(Me.gbImageSize)
        Me.Controls.Add(Me.gbCountry)
        Me.Controls.Add(Me.pbAustraliaFlags)
        Me.Controls.Add(Me.pbChinaFlag)
        Me.Controls.Add(Me.pbJapanFlag)
        Me.Controls.Add(Me.pbUsaFlag)
        Me.Controls.Add(Me.pbNewZealandFlag)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.gbCountry.ResumeLayout(False)
        Me.gbCountry.PerformLayout()
        Me.gbImageSize.ResumeLayout(False)
        Me.gbImageSize.PerformLayout()
        CType(Me.pbThumAus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumbUsa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumbJapan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumbChina, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbThumbNZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbChinaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbJapanFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbUsaFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbNewZealandFlag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAustraliaFlags, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbAustraliaFlags As System.Windows.Forms.PictureBox
    Friend WithEvents gbCountry As System.Windows.Forms.GroupBox
    Friend WithEvents rbChina As System.Windows.Forms.RadioButton
    Friend WithEvents rbJapan As System.Windows.Forms.RadioButton
    Friend WithEvents rbUsa As System.Windows.Forms.RadioButton
    Friend WithEvents rbNewZealand As System.Windows.Forms.RadioButton
    Friend WithEvents rbAustralia As System.Windows.Forms.RadioButton
    Friend WithEvents rbThumbNail As System.Windows.Forms.RadioButton
    Friend WithEvents rbFullSize As System.Windows.Forms.RadioButton
    Friend WithEvents gbImageSize As System.Windows.Forms.GroupBox
    Friend WithEvents lblFlag As System.Windows.Forms.Label
    Friend WithEvents pbNewZealandFlag As System.Windows.Forms.PictureBox
    Friend WithEvents pbUsaFlag As System.Windows.Forms.PictureBox
    Friend WithEvents pbJapanFlag As System.Windows.Forms.PictureBox
    Friend WithEvents pbChinaFlag As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumbNZ As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumbChina As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumbJapan As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumbUsa As System.Windows.Forms.PictureBox
    Friend WithEvents pbThumAus As System.Windows.Forms.PictureBox
    Friend WithEvents lblMyName As System.Windows.Forms.Label

End Class
