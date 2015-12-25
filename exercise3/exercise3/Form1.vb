Public Class Form1

    Private Sub rbAustralia_CheckedChanged(sender As Object, e As EventArgs) Handles rbAustralia.CheckedChanged

        If rbFullSize.Checked = True And
            rbAustralia.Checked = True Then
            pbAustraliaFlags.Show()
            pbNewZealandFlag.Hide()
            pbUsaFlag.Hide()
            pbJapanFlag.Hide()
            pbChinaFlag.Hide()
            lblFlag.Text = "Australia"
        End If

        If rbThumbNail.Checked = True And
            rbAustralia.Checked = True Then
            pbThumAus.Show()
            pbThumbNZ.Hide()
            pbThumbUsa.Hide()
            pbThumbJapan.Hide()
            pbThumbChina.Hide()
            lblFlag.Text = "Australia"
        End If

    End Sub

    Private Sub rbNewZealand_CheckedChanged(sender As Object, e As EventArgs) Handles rbNewZealand.CheckedChanged

        If rbFullSize.Checked = True And
            rbNewZealand.Checked = True Then
            pbAustraliaFlags.Hide()
            pbNewZealandFlag.Show()
            pbUsaFlag.Hide()
            pbJapanFlag.Hide()
            pbChinaFlag.Hide()
            lblFlag.Text = "New Zealand"
        End If

        If rbThumbNail.Checked = True And
            rbNewZealand.Checked = True Then
            pbThumAus.Hide()
            pbThumbNZ.Show()
            pbThumbUsa.Hide()
            pbThumbJapan.Hide()
            pbThumbChina.Hide()
            lblFlag.Text = "New Zealand"
        End If

    End Sub

    Private Sub rbUsa_CheckedChanged(sender As Object, e As EventArgs) Handles rbUsa.CheckedChanged

        If rbFullSize.Checked = True And
            rbUsa.Checked = True Then
            pbAustraliaFlags.Hide()
            pbNewZealandFlag.Hide()
            pbUsaFlag.Show()
            pbJapanFlag.Hide()
            pbChinaFlag.Hide()
            lblFlag.Text = "USA"
        End If

        If rbThumbNail.Checked = True And
            rbUsa.Checked = True Then
            pbThumAus.Hide()
            pbThumbNZ.Hide()
            pbThumbUsa.Show()
            pbThumbJapan.Hide()
            pbThumbChina.Hide()
            lblFlag.Text = "USA"
        End If


    End Sub

    Private Sub rbJapan_CheckedChanged(sender As Object, e As EventArgs) Handles rbJapan.CheckedChanged

        If rbFullSize.Checked = True And
            rbJapan.Checked = True Then
            pbAustraliaFlags.Hide()
            pbNewZealandFlag.Hide()
            pbUsaFlag.Hide()
            pbJapanFlag.Show()
            pbChinaFlag.Hide()
            lblFlag.Text = "Japan"
        End If

        If rbThumbNail.Checked = True And
            rbJapan.Checked = True Then
            pbThumAus.Hide()
            pbThumbNZ.Hide()
            pbThumbUsa.Hide()
            pbThumbJapan.Show()
            pbThumbChina.Hide()
            lblFlag.Text = "Japan"
        End If

    End Sub

    Private Sub rbChina_CheckedChanged(sender As Object, e As EventArgs) Handles rbChina.CheckedChanged

        If rbFullSize.Checked = True And
            rbChina.Checked = True Then
            pbAustraliaFlags.Hide()
            pbNewZealandFlag.Hide()
            pbUsaFlag.Hide()
            pbJapanFlag.Hide()
            pbChinaFlag.Show()
            lblFlag.Text = "China"
        End If

        If rbThumbNail.Checked = True And
            rbChina.Checked = True Then
            pbThumAus.Hide()
            pbThumbNZ.Hide()
            pbThumbUsa.Hide()
            pbThumbJapan.Hide()
            pbThumbChina.Show()
            lblFlag.Text = "China"
        End If

    End Sub

    
    Private Sub rbThumbNail_CheckedChanged(sender As Object, e As EventArgs) Handles rbThumbNail.CheckedChanged

        If rbThumbNail.Checked = True And
            rbAustralia.Checked = True Then
            pbThumAus.Show()
            pbThumbNZ.Hide()
            pbThumbUsa.Hide()
            pbThumbJapan.Hide()
            pbThumbChina.Hide()
            lblFlag.Text = "Australia"
        End If

        If rbThumbNail.Checked = True And
            rbNewZealand.Checked = True Then
            pbThumAus.Hide()
            pbThumbNZ.Show()
            pbThumbUsa.Hide()
            pbThumbJapan.Hide()
            pbThumbChina.Hide()
            lblFlag.Text = "New Zealand"
        End If

        If rbThumbNail.Checked = True And
            rbUsa.Checked = True Then
            pbThumAus.Hide()
            pbThumbNZ.Hide()
            pbThumbUsa.Show()
            pbThumbJapan.Hide()
            pbThumbChina.Hide()
            lblFlag.Text = "USA"
        End If

        If rbThumbNail.Checked = True And
            rbJapan.Checked = True Then
            pbThumAus.Hide()
            pbThumbNZ.Hide()
            pbThumbUsa.Hide()
            pbThumbJapan.Show()
            pbThumbChina.Hide()
            lblFlag.Text = "Japan"
        End If

        If rbThumbNail.Checked = True And
            rbChina.Checked = True Then
            pbThumAus.Hide()
            pbThumbNZ.Hide()
            pbThumbUsa.Hide()
            pbThumbJapan.Hide()
            pbThumbChina.Show()
            lblFlag.Text = "China"
        End If

        pbAustraliaFlags.Hide()
        pbNewZealandFlag.Hide()
        pbUsaFlag.Hide()
        pbJapanFlag.Hide()
        pbChinaFlag.Hide()

    End Sub

    Private Sub rbFullSize_CheckedChanged(sender As Object, e As EventArgs) Handles rbFullSize.CheckedChanged

        If rbFullSize.Checked = True And
            rbAustralia.Checked = True Then
            pbAustraliaFlags.Show()
            pbNewZealandFlag.Hide()
            pbUsaFlag.Hide()
            pbJapanFlag.Hide()
            pbChinaFlag.Hide()
            lblFlag.Text = "Australia"
        End If

        If rbFullSize.Checked = True And
            rbNewZealand.Checked = True Then
            pbAustraliaFlags.Hide()
            pbNewZealandFlag.Show()
            pbUsaFlag.Hide()
            pbJapanFlag.Hide()
            pbChinaFlag.Hide()
            lblFlag.Text = "New Zealand"
        End If

        If rbFullSize.Checked = True And
            rbUsa.Checked = True Then
            pbAustraliaFlags.Hide()
            pbNewZealandFlag.Hide()
            pbUsaFlag.Show()
            pbJapanFlag.Hide()
            pbChinaFlag.Hide()
            lblFlag.Text = "USA"
        End If

        If rbFullSize.Checked = True And
            rbJapan.Checked = True Then
            pbAustraliaFlags.Hide()
            pbNewZealandFlag.Hide()
            pbUsaFlag.Hide()
            pbJapanFlag.Show()
            pbChinaFlag.Hide()
            lblFlag.Text = "Japan"
        End If

        If rbFullSize.Checked = True And
            rbChina.Checked = True Then
            pbAustraliaFlags.Hide()
            pbNewZealandFlag.Hide()
            pbUsaFlag.Hide()
            pbJapanFlag.Hide()
            pbChinaFlag.Show()
            lblFlag.Text = "China"
        End If

        pbThumAus.Hide()
        pbThumbNZ.Hide()
        pbThumbUsa.Hide()
        pbThumbJapan.Hide()
        pbThumbChina.Hide()

    End Sub
End Class
