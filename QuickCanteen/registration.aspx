<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="QuickCanteen.registration" MasterPageFile="~/QCMaster.master" Title="Registration"%>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <script type="text/javascript">
        function verifyDate(sender,args){
            var d = new Date();
            d.setDate(d.getDate() - 1);
            if (sender._selectedDate >= d)
            {
                alert("Date should be lesser than Today");
                sender._textbox.set_Value('')
            }
        }
    </script>
    <div style="display:flex;justify-content:center;align-items:center; margin-left: 100px">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
                <td>
                    <asp:Panel ID="Panel1" runat="server" Height="540px">
                        First Name:
                        <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator11" runat="server" ControlToValidate="TextBox1" ErrorMessage="Invalid Name" ForeColor="Red" ValidationExpression="^([^0-9]*)$"></asp:RegularExpressionValidator>
                        <br />
                        Last Name:
                        <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator12" runat="server" ControlToValidate="TextBox2" ErrorMessage="Invalid Name" ForeColor="Red" ValidationExpression="^([^0-9]*)$"></asp:RegularExpressionValidator>
                        <br />
                        Username:
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        Password:
                        <asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter proper password" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9\s]{4,10}$" ControlToValidate="TextBox4"></asp:RegularExpressionValidator>
                        <br />
                        Re-enter Password:
                        <asp:TextBox ID="TextBox9" runat="server" TextMode="Password" OnTextChanged="TextBox9_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Doesn't Match" ControlToCompare="TextBox4" ControlToValidate="TextBox9" ForeColor="Red"></asp:CompareValidator>
                        <br />
                        Email Id:
                        <asp:TextBox ID="TextBox5" runat="server" ForeColor="Red"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox5" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Enter Proper Email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <br />
                        Birthday:
                        <asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox6" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/CalendarIcon.png" Height="16px" Width="16px"/>
                        &nbsp;<br /> 
                        <ajaxToolkit:CalendarExtender ID="BdayCal" runat="server" Format="yyyy-MM-dd" PopupButtonID="Image1" TargetControlID="TextBox6" OnClientDateSelectionChanged="verifyDate"/>
                        Phone No.:
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox7" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox7" ErrorMessage="Enter valid number" ForeColor="Red" ValidationExpression="^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$"></asp:RegularExpressionValidator>
                        <br />
                        Initial Wallet Amount:
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox8" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator14" runat="server" ControlToValidate="TextBox8" ErrorMessage="Invalid Value" ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
                        <br />
                        College:
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="TextBox10" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator15" runat="server" ControlToValidate="TextBox10" ErrorMessage="Invalid Value" ForeColor="Red" ValidationExpression="^([^0-9]*)$"></asp:RegularExpressionValidator>
                        <br />
                        <br />
                        <asp:Button ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" Height="26px" />
                        &nbsp;&nbsp;&nbsp;
                        <input id="ResetBtn" type="reset" value="Reset" />
                        <br />
                        <br />
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
                        <asp:ListItem Value="student">Student</asp:ListItem>
                        <asp:ListItem Value="manager">Canteen</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator22" runat="server" ControlToValidate="RadioButtonList1" ErrorMessage="Please make a selection" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                    <td>
                    <asp:Panel ID="Panel2" runat="server" Height="540px">
                        Canteen Name:
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="TextBox11" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator16" runat="server" ControlToValidate="TextBox11" ErrorMessage="Invalid Value" ForeColor="Red" ValidationExpression="^([^0-9]*)$"></asp:RegularExpressionValidator>
                        <br />
                        Open Time:
                        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="TextBox12" ErrorMessage="Pelase fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ControlToValidate="TextBox12" ErrorMessage="Invalid Time" ForeColor="Red" ValidationExpression="^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$"></asp:RegularExpressionValidator>
                        <br />
                        Close Time:
                        <asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="TextBox13" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ErrorMessage="Invalid Time" ForeColor="Red" ValidationExpression="^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$" ControlToValidate="TextBox13"></asp:RegularExpressionValidator>
                        <br />
                        Username:
                        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="TextBox14" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                        Password:
                        <asp:TextBox ID="TextBox15" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="TextBox15" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox15" ErrorMessage="Enter proper password" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9\s]{4,10}$"></asp:RegularExpressionValidator>
                        <br />
                        Re-enter Password:
                        <asp:TextBox ID="TextBox16" runat="server" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator17" runat="server" ControlToValidate="TextBox16" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TextBox15" ControlToValidate="TextBox16" ErrorMessage="Password doesn't match" ForeColor="Red"></asp:CompareValidator>
                        <br />
                        Order Limit:
                        <asp:TextBox ID="TextBox17" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator18" runat="server" ControlToValidate="TextBox17" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox17" ErrorMessage="Enter  value in limit" ForeColor="Red" MaximumValue="50" MinimumValue="1" Type="Integer"></asp:RangeValidator>
                        <br />                         
                        Phone No.:
                        <asp:TextBox ID="TextBox18" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator19" runat="server" ControlToValidate="TextBox18" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server" ControlToValidate="TextBox18" ErrorMessage="Enter valid number" ForeColor="Red" ValidationExpression="^(\+91[\-\s]?)?[0]?(91)?[789]\d{9}$"></asp:RegularExpressionValidator>
                        <br />
                        Email ID:
                        <asp:TextBox ID="TextBox19" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator20" runat="server" ControlToValidate="TextBox19" ErrorMessage="Please fill the data" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ControlToValidate="TextBox19" ErrorMessage="Enter proper email" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                        <br />
                        Initial Wallet Amount:
                        <asp:TextBox ID="TextBox20" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator21" runat="server" ErrorMessage="Please fill the data" ForeColor="Red" ControlToValidate="TextBox20"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator17" runat="server" ControlToValidate="TextBox20" ErrorMessage="Invalid Value" ForeColor="Red" ValidationExpression="^[0-9]*$"></asp:RegularExpressionValidator>
                        <br />
                        <br />
                        <asp:Button ID="Button2" runat="server" Text="Sign Up" OnClick="Button2_Click" Height="26px" />
                        &nbsp;
                        <input id="ResetBtn0" type="reset" value="Reset" />
                        <br />
                        <br />
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </div>
</div>
    <div>
    </div>
</asp:Content>
