Imports System.Speech
Imports System.Speech.Synthesis

Public Class Converter


    Inherits System.Windows.Forms.Form
    Public ttsv = CreateObject("SAPI.spvoice")
    Private Sub btno_G_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim objConv As New MassClasslib.MassConvComp()
        Dim f As Double
        Dim h As Double
        Dim c As Double
        Select Case Cbochoose.Text
            Case "Mass Conversion"
                If txt1.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    f = CDbl(txt1.Text)
                    txt2.Text = objConv.gram_to_ounce(f)
                    txt3.Text = objConv.gram_to_pounds(f)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Ounce:" & txt2.Text & vbCrLf & "Pounds: " & txt3.Text
                End If
            Case "Temperature Conversion"
                If txt1.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    h = CDbl(txt1.Text)
                    txt2.Text = objConv.cel_to_far(h)
                    txt3.Text = objConv.cel_to_kel(h)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Farenheit:" & txt2.Text & vbCrLf & "Kelvin is " & txt3.Text
                End If
            Case "Area Conversion"
                If txt1.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    c = CDbl(txt1.Text)
                    txt2.Text = objConv.hec_to_acr(c)
                    txt3.Text = objConv.hec_to_met(c)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Acres: " & txt2.Text & vbCrLf & "Metres: " & txt3.Text
                End If

            Case "Distance Conversion"
                If txt1.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    c = CDbl(txt1.Text)
                    txt2.Text = objConv.met_to_ft(c)
                    txt3.Text = objConv.met_to_mil(c)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Feet: " & txt2.Text & vbCrLf & "Miles: " & txt3.Text
                End If

            Case Else
                MessageBox.Show("Invalid selection")
                'Rctpayslipresult.Text = "++++++++++++++++++++++++++++++" & vbCrLf & "******MANMUA PAYSLIP***" & vbCrLf & "___________________________________________" & vbCrLf & "PERSONAL DETAILS:" & vbCrLf & "NAME:" & Name & vbCrLf &
                ' "MARITAL STATUS= :" & marital & vbCrLf & "GENDER   =" & sex & vbCrLf & "LEAVE =" & Leave & vbCrLf _
                '& "_______________________________________________" & vbCrLf & "BASIC SALARY  = " & Basic & vbCrLf & "RENUMERATION =" & Totalre & vbCrLf & "TAX =       " & txttax.Text & vbCrLf &
                '"ADVANCE   =" & txtadvance.Text & vbCrLf & "NSSF = " & txtnssf.Text & vbCrLf & "NHIF = " & txtnhif.Text & vbCrLf & "TOTAL DEDUCTIONS  =" & txttotal.Text & vbCrLf &
                '"................................................" & vbCrLf & "NET SALARY  =" & txtnetsalary.Text & vbCrLf & "........................................................." & vbCrLf &
                '"COMPILED BY ME**********" & vbCrLf & txtdate1.Text & " -Date"




        End Select

    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        rtbconvert.Clear()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Is The Interface not Interesting?", "Important Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                        )
        welcome.Close()
        Me.Close()
    End Sub

    Private Sub Cbochoose_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbochoose.SelectedIndexChanged


        Select Case Cbochoose.Text
            Case "Mass Conversion"
                Label2.Text = "Grams"
                Label3.Text = "Ounces"
                Label4.Text = "Pounds"
                btn1.Text = " Cvt Grams"
                Button2.Text = "Cvt Ounces"
                Button3.Text = "Cvt Pounds"
            Case "Temperature Conversion"
                Label2.Text = "Celcius"
                Label3.Text = "Farenheits"
                Label4.Text = "Kelvin"
                btn1.Text = " Cvt Celcius"
                Button2.Text = "Cvt Farenheits"
                Button3.Text = "Cvt Kelvin"
            Case "Area Conversion"
                Label2.Text = "Hectares"
                Label3.Text = "Acres"
                Label4.Text = "Square Meters"
                btn1.Text = "Cvt Hectares"
                Button2.Text = "Cvt Acres"
                Button3.Text = "Cvt Square Meters"
            Case "Distance Conversion"
                Label2.Text = "Metres"
                Label3.Text = "Feet"
                Label4.Text = "Mile"
                btn1.Text = "Cvt Metres"
                Button2.Text = "Cvt Feet"
                Button3.Text = "Cvt Miles"

            Case Else
                MessageBox.Show("Choose one of the Convertions")
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim objConv As New MassClasslib.MassConvComp()
        Dim f As Double
        Dim h As Double
        Dim c As Double
        Select Case Cbochoose.Text
            Case "Mass Conversion"
                If txt2.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    f = CDbl(txt2.Text)
                    txt1.Text = objConv.ounce_to_gram(f)
                    txt3.Text = objConv.ounces_to_pounds(f)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Gram:" & txt1.Text & vbCrLf & "Pounds: " & txt3.Text
                End If
            Case "Temperature Conversion"
                If txt2.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    h = CDbl(txt2.Text)
                    txt1.Text = objConv.far_to_cel(h)
                    txt3.Text = objConv.far_to_kel(h)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Celcious:" & txt1.Text & vbCrLf & "Kelvin is " & txt3.Text
                End If
            Case "Area Conversion"
                If txt2.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    c = CDbl(txt2.Text)
                    txt1.Text = objConv.acr_to_hec(c)
                    txt3.Text = objConv.acr_to_met(c)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Hecters: " & txt1.Text & vbCrLf & "Metres: " & txt3.Text
                End If

            Case "Distance Conversion"
                If txt2.Text = ("") Then
                    MessageBox.Show("enter something")
                Else

                    c = CDbl(txt2.Text)
                    txt1.Text = objConv.ft_to_met(c)
                    txt3.Text = objConv.ft_to_mil(c)
                    rtbconvert.Text = "The result is:" & vbCrLf & " metre: " & txt1.Text & vbCrLf & "Miles: " & txt3.Text
                End If

        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objConv As New MassClasslib.MassConvComp()
        Dim f As Double
        Dim h As Double
        Dim c As Double
        Select Case Cbochoose.Text
            Case "Mass Conversion"
                If txt3.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    f = CDbl(txt3.Text)
                    txt1.Text = objConv.pounds_to_grams(f)
                    txt2.Text = objConv.pounds_to_ounces(f)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Grams:" & txt1.Text & vbCrLf & "Ounce: " & txt2.Text
                End If

            Case "Temperature Conversion"
                If txt3.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    h = CDbl(txt3.Text)
                    txt1.Text = objConv.kel_to_cel(h)
                    txt2.Text = objConv.kel_to_far(h)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Celcious:" & txt1.Text & vbCrLf & "Farenheit is " & txt2.Text
                End If

            Case "Area Conversion"
                If txt3.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    c = CDbl(txt3.Text)
                    txt1.Text = objConv.met_to_hec(c)
                    txt2.Text = objConv.met_to_acr(c)
                    rtbconvert.Text = "The result is:" & vbCrLf & " Hectares: " & txt1.Text & vbCrLf & "Acres: " & txt2.Text
                End If

            Case "Distance Conversion"
                If txt3.Text = ("") Then
                    MessageBox.Show("enter something")
                Else
                    c = CDbl(txt3.Text)
                    txt1.Text = objConv.mil_to_met(c)
                    txt2.Text = objConv.mil_to_ft(c)
                    rtbconvert.Text = "The result is:" & vbCrLf & " metres: " & txt1.Text & vbCrLf & "feet: " & txt2.Text
                End If

        End Select
    End Sub


    Private Sub btnreadout_Click(sender As Object, e As EventArgs) Handles btnreadout.Click
        'Dim ttsv = CreateObject("SAPI.spvoice")
        If rtbconvert.Text = ("") Then
            MessageBox.Show("Please calculate some values first!!!")
        Else

            ttsv.speak(rtbconvert.Text)


        End If


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        ttsv.Speak(vbNullString, 2)
        'SAPI = Nothing
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        MessageBox.Show(" Please Enter valid numbers for conversion and to avoid inconviniences !!!!!!!!!!!!!!!!!!!! or call 072227828 for more help.", "Important Message")
    End Sub

    Private Sub Converter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class
