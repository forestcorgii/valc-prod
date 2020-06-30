Public Class sfrmQueryDetail
    Public Bol As BOLInfo
    Private Sub sfrmQueryDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Bol.Batch
            lbType.Text = .Type
            lbTrip.Text = .TripNo
            lbFolder.Text = .Folder
        End With

        With Bol
            lbProNumber.Text = .ProNo
            lbFBNumber.Text = .FBNo
        End With

        For Each query In Bol.Query
            With query
                dgvQueryDetails.Rows.Add(.ShipperName, .ConsigneeName, .Start, .Endd, .BillerQuery, .QueryAnswer)
            End With
        Next

    End Sub
End Class