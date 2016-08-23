<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmNumericCalc.aspx.cs" Inherits="NumericSequenceCalc.frmNumericCalc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Numeric Sequence Calculator</title>
    
    <script type="text/javascript">
        function IsNumber(e) {
            
            e = (e) ? e : window.event;
            var charCode = e.which ? e.which : e.keyCode;            
            if (charCode > 31 && (charCode < 48 || charCode > 57))
            {
                return false;
            }
            return true;
        }

        function IsNumberEmpty() {
            var txt = document.getElementById('txtNumber');
            var err = document.getElementById('lblError');
            var calcType=document.getElementById('ddlCalcType').value;
            if (calcType == 0)
            {
                err.innerHTML = "Please select calculation type.";
                return false;
            }
            
            if (txt.value == '')
            {
                
                err.innerHTML = "Please enter valid number.";
                return false;
            }
            else if (txt.value == '0')
            {
                err.innerHTML = "Please enter greater than 0.";
                return false;
            }
            else if (txt.value>90 && calcType==5)
            {
                err.innerHTML = "Please enter less than 90.";
                return false;
            }
        }
    </script>
</head>
<body >
    <form id="form1" runat="server">
    <center>
        <asp:Panel ID="pnlMain" runat="server" BorderStyle="Solid" Width="65%" >
        <table style="font-size:large;">
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblHeading" runat="server" Text="Enter whole number to see output as per selected Calculation Type" ForeColor="Green" Font-Italic="true" Font-Bold="true"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:RegularExpressionValidator ID="revNumber" runat="server" ErrorMessage="Invalid Number*" ForeColor="Red" ControlToValidate="txtNumber" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
            </td> 
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblError" runat="server" Text="" ForeColor="Red"></asp:Label>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:DropDownList ID="ddlCalcType" runat="server" Font-Size="Large" Width="95%">
                <asp:ListItem Text="Select Calculation Type" Value="0"></asp:ListItem>
                <asp:ListItem Text="Display all numbers up to & including the number entered" Value="1"></asp:ListItem>
                <asp:ListItem Text="Display all odd numbers up to & including the number entered" Value="2"></asp:ListItem>
                <asp:ListItem Text="Display all even numbers up to & including the number entered" Value="3"></asp:ListItem>
                <asp:ListItem Text="Display all numbers up to & including the number entered [Except replaces multiple of 3 with C,multiple of 5 with E & multiple of both with Z " Value="4" ></asp:ListItem>
                <asp:ListItem Text="Dispaly all fibonanci numbers up to & including the number entered" Value="5"></asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
            </tr>
        <tr>
            <td>
                <table style="width:100%; table-layout:fixed;">
                    <tr>
                        <td style="width:15%;">
                            <asp:Label ID="lblNumber" runat="server" Text="Enter Number : "></asp:Label>
                        </td>
                        <td style="width:15%;">
                            <asp:TextBox ID="txtNumber" runat="server" Font-Size="Large" Text="" Width="90%" MaxLength="4" onkeypress="return IsNumber(event)"></asp:TextBox>
                            
                        </td>
                       <td style="width:70%; text-align:left;">
                            <asp:Button ID="btnCalculate" runat="server" Font-Size="Large" Text="Calculate" OnClick="btnCalculate_Click" OnClientClick="return IsNumberEmpty()" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
        </tr>
        <tr>
            
            <td>
                <table style="width:100%; table-layout:fixed;">
                    <tr>
                        <td style="width:15%;">
                            <asp:Label ID="lblResult" runat="server" Text="Result : " Font-Size="Large"></asp:Label>
                        </td>
                        <td style="width:85%;">
                            <asp:TextBox ID="txtResult" runat="server" ReadOnly="true" TextMode="MultiLine"  Font-Size="Large" Height="200" Width="90%"></asp:TextBox>
                        </td>
                    </tr>
                </table>
                
            </td>
        </tr>
    </table>
    
        
    
        
    </asp:Panel>
        
    </center>
    
    </form>
</body>
</html>
