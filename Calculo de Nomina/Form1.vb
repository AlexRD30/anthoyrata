Public Class Form1

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close()
    End Sub

   
   
    Private Sub cmdlimpiar_Click(sender As Object, e As EventArgs) Handles cmdlimpiar.Click
        TxtAFP.Clear()
        TxtARS.Clear()
        Txthora.Clear()
        TxtOtros.Clear()
        TxtpresioH.Clear()
        TxtSueldo.Clear()
        Txtsueldoneto.Clear()
        TxtTotal.Clear()
        rbndiurno.Checked = False
        rbnnocturno.Checked = False
        ChkAFP.Checked = False
        ChkARS.Checked = False
        ChKOtros.Checked = False

    End Sub

    Private Sub rbndiurno_CheckedChanged(sender As Object, e As EventArgs) Handles rbndiurno.CheckedChanged
        If rbndiurno.Checked = True Then
            TxtpresioH.Text = 150
        Else
            TxtpresioH.Clear()

        End If
    End Sub
    Private Sub rbnnocturno_CheckedChanged(sender As Object, e As EventArgs) Handles rbnnocturno.CheckedChanged
        If rbnnocturno.Checked = True Then

            TxtpresioH.Text = 200
        End If
    End Sub

    Private Sub ChkAFP_CheckedChanged(sender As Object, e As EventArgs) Handles ChkAFP.CheckedChanged
        If ChkAFP.Checked = True Then
            TxtAFP.Text = Val(TxtSueldo.Text) * 0.04
        Else
            TxtAFP.Clear()

        End If
    End Sub

    Private Sub ChkARS_CheckedChanged(sender As Object, e As EventArgs) Handles ChkARS.CheckedChanged
        If ChkARS.Checked = True Then
            TxtARS.Text = Val(TxtSueldo.Text) * 0.03
        End If
    End Sub

    Private Sub ChKOtros_CheckedChanged(sender As Object, e As EventArgs) Handles ChKOtros.CheckedChanged
        If ChKOtros.Checked = True Then
            TxtOtros.Text = Val(TxtSueldo.Text) * 0.02
        End If
    End Sub

    Private Sub cmdcalcular_Click(sender As Object, e As EventArgs) Handles cmdcalcular.Click
        TxtTotal.Text = Val(TxtAFP.Text) + Val(TxtARS.Text) + Val(TxtOtros.Text)

        Txtsueldoneto.Text = Val(Txthora.Text) * Val(TxtpresioH.Text) + Val(TxtSueldo.Text) - Val(TxtTotal.Text)



    End Sub

    
    
End Class
