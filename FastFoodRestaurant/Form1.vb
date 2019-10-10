Public Class frmMain
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlOnButtonFoods.Visible = True
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonDeserts.Visible = False
        pnlOnButtonMyCart.Visible = False
        pnlOnButtonAboutUs.Visible = False

        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnFoods_Click(sender As Object, e As EventArgs) Handles btnFoods.Click
        pnlOnButtonFoods.Visible = True
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonDeserts.Visible = False
        pnlOnButtonMyCart.Visible = False
        pnlOnButtonAboutUs.Visible = False

        pnlFoods.Visible = True
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        pnlOnButtonFoods.Visible = False
        pnlOnButtonDrinks.Visible = True
        pnlOnButtonDeserts.Visible = False
        pnlOnButtonMyCart.Visible = False
        pnlOnButtonAboutUs.Visible = False

        pnlFoods.Visible = False
        pnlDrinks.Visible = True
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnDeserts_Click(sender As Object, e As EventArgs) Handles btnDeserts.Click
        pnlOnButtonFoods.Visible = False
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonDeserts.Visible = True
        pnlOnButtonMyCart.Visible = False
        pnlOnButtonAboutUs.Visible = False

        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = True
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnMyCart_Click(sender As Object, e As EventArgs) Handles btnMyCart.Click
        pnlOnButtonFoods.Visible = False
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonDeserts.Visible = False
        pnlOnButtonMyCart.Visible = True
        pnlOnButtonAboutUs.Visible = False

        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = True
        pnlAboutUs.Visible = False
    End Sub

    Private Sub btnAboutUs_Click(sender As Object, e As EventArgs) Handles btnAboutUs.Click
        pnlOnButtonFoods.Visible = False
        pnlOnButtonDrinks.Visible = False
        pnlOnButtonDeserts.Visible = False
        pnlOnButtonMyCart.Visible = False
        pnlOnButtonAboutUs.Visible = True

        pnlFoods.Visible = False
        pnlDrinks.Visible = False
        pnlDeserts.Visible = False
        pnlMyCart.Visible = False
        pnlAboutUs.Visible = True
    End Sub

    Private Sub picClose_Click(sender As Object, e As EventArgs) Handles picClose.Click
        Me.Close()
    End Sub

    Private Sub picMinimize_Click(sender As Object, e As EventArgs) Handles picMinimize.Click
        Me.WindowState = WindowState.Minimized
    End Sub

    Private Sub picMaximize_Click(sender As Object, e As EventArgs) Handles picMaximize.Click
        If Me.WindowState = WindowState.Normal Then
            Me.WindowState = WindowState.Maximized
        ElseIf Me.WindowState = WindowState.Maximized Then
            Me.WindowState = WindowState.Normal
        End If
    End Sub
End Class
