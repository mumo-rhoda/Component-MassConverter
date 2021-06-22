# Component-MassConverter
A .NET massconverter component


11/29/2019



CONVERTER

 
INTRODUCTION:
The component is based on metric conversions of Area, Temperature, Mass and Distance typically through multiplicative conversion factors and in a single Graphical Interface. The component is created using C# which is a .NET framework. 
The test interface for our component is Visual Basic Version 6.0 
Below are previews of the functionalities of the User Interface with test data.
Graphical User Interface for Area Conversion
The Interface helps the user input and convert either Hectares, Acres or Square Metres with the help of the text boxes and buttons.
 
Graphical User Interface for Distance Conversion
The Interface enables the user to convert between metres, feet and miles.
 
Graphical User Interface for Mass Conversion.
The interface helps in user conversion of grams, ounces and pounds.
 
Graphical User Interface for Temperature Conversion
The interface helps in user conversion of temperature to either Celsius, Fahrenheit’s or Kelvin.


 
 The Interfaces are implemented using the following exe file in visual basic.
Code for exe file.
Public Class Converter
    Inherits System.Windows.Forms.Form
    Private Sub btno_G_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Dim objConv As New MassClasslib.MassConvComp()
        Dim f As Double
        Dim h As Double
        Dim c As Double
        Select Case Cbochoose.Text
            Case "Mass Conversion"
                f = CDbl(txt1.Text)
                txt2.Text = objConv.gram_to_ounce(f)
                txt3.Text = objConv.gram_to_pounds(f)
            Case "Temperature Conversion"
                h = CDbl(txt1.Text)
                txt2.Text = objConv.cel_to_far(h)
                txt3.Text = objConv.cel_to_kel(h)
            Case "Area Conversion"
                c = CDbl(txt1.Text)
                txt2.Text = objConv.hec_to_acr(c)
                txt3.Text = objConv.hec_to_met(c)
            Case "Distance Conversion"
                c = CDbl(txt1.Text)
                txt2.Text = objConv.met_to_ft(c)
                txt3.Text = objConv.met_to_mil(c)
        End Select
    End Sub
    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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
                f = CDbl(txt2.Text)
                txt1.Text = objConv.ounce_to_gram(f)
                txt3.Text = objConv.ounces_to_pounds(f)
            Case "Temperature Conversion"
                h = CDbl(txt2.Text)
                txt1.Text = objConv.far_to_cel(h)
                txt3.Text = objConv.far_to_kel(h)
            Case "Area Conversion"
                c = CDbl(txt2.Text)
                txt1.Text = objConv.acr_to_hec(c)
                txt3.Text = objConv.acr_to_met(c)
            Case "Distance Conversion"
                c = CDbl(txt2.Text)
                txt1.Text = objConv.ft_to_met(c)
                txt3.Text = objConv.ft_to_mil(c)
        End Select
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim objConv As New MassClasslib.MassConvComp()
        Dim f As Double
        Dim h As Double
        Dim c As Double
        Select Case Cbochoose.Text
            Case "Mass Conversion"
                f = CDbl(txt3.Text)
                txt1.Text = objConv.pounds_to_grams(f)
                txt2.Text = objConv.pounds_to_ounces(f)
            Case "Temperature Conversion"
                h = CDbl(txt3.Text)
                txt1.Text = objConv.kel_to_cel(h)
                txt2.Text = objConv.kel_to_far(h)
            Case "Area Conversion"
                c = CDbl(txt3.Text)
                txt1.Text = objConv.met_to_hec(c)
                txt2.Text = objConv.met_to_acr(c)
            Case "Distance Conversion"
                c = CDbl(txt3.Text)
                txt1.Text = objConv.mil_to_met(c)
                txt2.Text = objConv.mil_to_ft(c)
        End Select
    End Sub
End Class
CONVERTER
Code for implementing the component using C#.
Code for the component.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassClasslib
{
    public class MassConvComp
    {
        public MassConvComp()
        {}
        //mass start
        public double ounce_to_gram(double o) 
            {
                return (int)o*28.35 ;
                }
            public double gram_to_pounds(double g)
                {
                    return (int)g/453.592 ;
        }
            public double pounds_to_ounces(double p)
            {
                return (int)p*16;
            }
            public double gram_to_ounce(double r)
            {
                return (int)r / 28.35;
            }
            public double pounds_to_grams(double u)
            {
                return (int)u * 453.592;
            }
            public double ounces_to_pounds(double n)
            {
                return (int)n / 16;
            }
        //mass end
        //temperature start
            public double cel_to_far(double l)
            {
                return (int)(l*(9/5))+32;
            }
            public double far_to_cel(double a)
            {
                return (int) ((a*32)-32)*(5/9) ;
            }
            public double cel_to_kel(double k)
            {
                return (int)k +273.15;
            }
            public double kel_to_cel(double v)
            {
                return (int)v-273.15;
            }
            public double far_to_kel(double m)
            {
                return (int)(m-32)*(5/9)+273.15;
            }
            public double kel_to_far(double x)
            {
                return (int)(x-273.15)*(9/5)+32;
            }
        //temperature end
        //area start
            public double met_to_hec(double z)
            {
                return (int)z/10000;
            }
            public double hec_to_met(double y)
            {
                return (int)y*10000;
            }
            public double hec_to_acr(double d)
            {
                return (int)d * 2.471;
            }
            public double acr_to_hec(double e)
            {
                return (int)e / 2.471;
            }
            public double met_to_acr(double f)
            {
                return (int)f / 4046.856;
            }
            public double acr_to_met(double i)
            {
                return (int)i * 4046.856;
            }
        //area end
        //distance start
            public double met_to_ft(double h)
            {
                return (int)h*3.281;
            }
            public double ft_to_met(double y)
            {
                return (int)y/3.281;
            }
            public double met_to_mil(double d)
            {
                return (int)d/1609.344;
            }
            public double mil_to_met(double e)
            {
                return (int)e*1609.344;
            }
            public double mil_to_ft(double f)
            {
                return (int)f * 5280;
            }
            public double ft_to_mil(double i)
            {
                return (int)i / 5280;
            }
        //end of distance
}
}





REFERENCES
Balena, F. (2004). Programming Microsoft Visual Basic .NET version 2003. Redmond, Wash: Microsoft Press.
Lowy, J. (2005). Programming. NET Components: Design and Build. NET Applications Using Component-Oriented Programming. " O'Reilly Media, Inc."
Root, R., & Sweeney, M. R. (2006). A tester's guide to .NET programming. Berkeley, Caif: Apress.

    




















