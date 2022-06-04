Public Class UserInfoFrm

    Dim UserDataRow As DataRowView
    Private Sub UserInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UserInfoDataSet.UsersInfo' table. You can move, or remove it, as needed.
        Me.UsersInfoTableAdapter.Fill(Me.UserInfoDataSet.UsersInfo)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UsersInfoDataGridView.AllowUserToAddRows = True
        UsersInfoDataGridView.AllowUserToDeleteRows = True

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim user As String
        Dim MsgStr As String
        UserDataRow = UsersInfoBindingSource.Current
        user = UserDataRow.Item("UserName")
        MsgStr = "هل أنت متأكد من حذف المستخدم" & "(" & user & ")"
        If MsgBox(MsgStr, MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "تنبية") = MsgBoxResult.Yes Then
            UsersInfoBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UsersInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UserInfoDataSet)
        UsersInfoDataGridView.AllowUserToAddRows = False
        UsersInfoDataGridView.AllowUserToDeleteRows = False
    End Sub
End Class