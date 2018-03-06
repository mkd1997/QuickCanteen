<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Stu_Profile.aspx.cs" Inherits="QuickCanteen.View_Stu_Profile" MasterPageFile="~/QCMaster1.master" Title="Your Profile"%>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div style="display:flex;justify-content:center;align-items:center; margin-left: 100px">
    <div>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataKeyNames="id,uname" DataSourceID="SqlDataSource1" Height="50px" Width="376px">
                        <Fields>
                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                            <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                            <asp:BoundField DataField="college" HeaderText="college" SortExpression="college" />
                            <asp:BoundField DataField="uname" HeaderText="uname" ReadOnly="True" SortExpression="uname" />
                            <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                            <asp:BoundField DataField="wallet" HeaderText="wallet" SortExpression="wallet" />
                            <asp:BoundField DataField="bdate" HeaderText="bdate" SortExpression="bdate" />
                            <asp:BoundField DataField="ph_no" HeaderText="ph_no" SortExpression="ph_no" />
                            <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                        </Fields>
                    </asp:DetailsView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT * FROM [student_master] WHERE ([id] = @id)">
                        <SelectParameters>
                            <asp:SessionParameter DefaultValue="-1" Name="id" SessionField="id" Type="Int32" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">Add money to your wallet</td>
                <td>Remove money from wallet</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Remove" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>