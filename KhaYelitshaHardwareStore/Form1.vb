Public Class Form1
    ' List to hold selected items
    Private selectedItems As New List(Of Item)
    Private totalPrice As Decimal = 0
    Private vatBefore As Decimal = 0
    Private vatAfter As Decimal = 0
    
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        selectedItems.Clear()
        totalPrice = 0

        ' Check each checkbox and add the corresponding item to the list
        If chkMouse.Checked Then
            Dim item As New Item("Mouse", 150) ' Price in Rands
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        If chkKeyboard.Checked Then
            Dim item As New Item("Keyboard", 300)
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        If chkMonitor.Checked Then
            Dim item As New Item("Monitor", 2000)
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        If chkPrinter.Checked Then
            Dim item As New Item("Printer", 1200)
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        If chkSpeaker.Checked Then
            Dim item As New Item("Speaker", 800)
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        ' Internal components
        If chkCPU.Checked Then
            Dim item As New Item("CPU", 3500)
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        If chkRAM.Checked Then
            Dim item As New Item("RAM", 1000)
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        If chkHardDrive.Checked Then
            Dim item As New Item("Hard Drive", 1500)
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        If chkPowerSupply.Checked Then
            Dim item As New Item("Power Supply", 850)
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        If chkMotherboard.Checked Then
            Dim item As New Item("Motherboard", 3000)
            selectedItems.Add(item)
            totalPrice += item.ItemPrice
        End If

        ' Calculate VAT (15% before deduction)
        vatBefore = totalPrice * 0.15
        vatAfter = vatBefore

        ' Apply discount if more than 2 items are purchased
        If selectedItems.Count > 2 Then
            Dim discount As Decimal = totalPrice * 0.15
            totalPrice -= discount
        End If

        ' Update ListBox with the results
        lstDisplay.Items.Clear()
        lstDisplay.Items.Add("**********WELCOME***********")
        lstDisplay.Items.Add("Selected Items:")
        For Each item In selectedItems
            lstDisplay.Items.Add(item.ItemName & " - R" & item.ItemPrice)
        Next
        lstDisplay.Items.Add("Total Price: R" & totalPrice)
        lstDisplay.Items.Add("VAT Before Deduction: R" & vatBefore)
        lstDisplay.Items.Add("VAT After Deduction: R" & vatAfter)
        lstDisplay.Items.Add("")
        lstDisplay.Items.Add("***THANK YOU FOR SHOPPING WITH US***")
    End Sub
    'Sub procedure to for clearing fields
    Public Sub Clear()
        lstDisplay.Items.Clear()
        totalPrice = 0
        vatBefore = 0
        vatAfter = 0
        chkMouse.Checked = False
        chkKeyboard.Checked = False
        chkMonitor.Checked = False
        chkPrinter.Checked = False
        chkSpeaker.Checked = False
        chkCPU.Checked = False
        chkRAM.Checked = False
        chkHardDrive.Checked = False
        chkPowerSupply.Checked = False
        chkMotherboard.Checked = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
