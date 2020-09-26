Imports System.Windows.Forms

<ProvideToolboxControl("$rootnamespace$.$toolBoxControl$", False)>
Public Class $toolBoxControl$

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MessageBox.Show(String.Format(System.Globalization.CultureInfo.CurrentUICulture, "$message$", Me.ToString()))
    End Sub

End Class
