Public Class FormUtama
    Sub navHandle(WhichForm)
        WhichForm.TopMost = True
        WhichForm.TopLevel = False
        pnlKonten.Controls.Add(WhichForm)
        WhichForm.Show()
        WhichForm.Dock = DockStyle.Fill
    End Sub
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        navHandle(FormDashboard)
        FormAlternatif.Hide()
        FormKriteria.Hide()
        FormNilaiKeputusan.Hide()
        FormHasil.Hide()
    End Sub
    Private Sub btnAlternatif_Click(sender As Object, e As EventArgs) Handles btnAlternatif.Click
        navHandle(FormAlternatif)
        FormDashboard.Hide()
        FormKriteria.Hide()
        FormNilaiKeputusan.Hide()
        FormHasil.Hide()
    End Sub
    Private Sub btnKriteria_Click(sender As Object, e As EventArgs) Handles btnKriteria.Click
        navHandle(FormKriteria)
        FormAlternatif.Hide()
        FormDashboard.Hide()
        FormNilaiKeputusan.Hide()
        FormHasil.Hide()
    End Sub
    Private Sub btnNilaiKeputusan_Click(sender As Object, e As EventArgs) Handles btnNilaiKeputusan.Click
        navHandle(FormNilaiKeputusan)
        FormAlternatif.Hide()
        FormKriteria.Hide()
        FormDashboard.Hide()
        FormHasil.Hide()
    End Sub
    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click
        navHandle(FormHasil)
        FormAlternatif.Hide()
        FormKriteria.Hide()
        FormNilaiKeputusan.Hide()
        FormDashboard.Hide()
    End Sub
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles Me.Load
        navHandle(FormDashboard)
    End Sub
End Class