<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Can_Profile.aspx.cs" Inherits="QuickCanteen.View_Can_Profile" MasterPageFile="~/QCMaster1.master" Title="Your Profile" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div style="display: flex; justify-content: center; align-items: center; margin-left: 100px">
        <div>

            <div>

                <table class="auto-style1">
                    <tr>
                        <td class="auto-style3">
                            <asp:DetailsView ID="DetailsView2" runat="server" AutoGenerateRows="False" DataKeyNames="canteen_id,uname" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
                                <Fields>
                                    <asp:BoundField DataField="canteen_id" HeaderText="canteen_id" InsertVisible="False" ReadOnly="True" SortExpression="canteen_id" />
                                    <asp:BoundField DataField="wallet" HeaderText="wallet" SortExpression="wallet" />
                                    <asp:BoundField DataField="open_time" HeaderText="open_time" SortExpression="open_time" />
                                    <asp:BoundField DataField="close_time" HeaderText="close_time" SortExpression="close_time" />
                                    <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                                    <asp:BoundField DataField="order_limit" HeaderText="order_limit" SortExpression="order_limit" />
                                    <asp:BoundField DataField="ph_no" HeaderText="ph_no" SortExpression="ph_no" />
                                    <asp:BoundField DataField="uname" HeaderText="uname" ReadOnly="True" SortExpression="uname" />
                                    <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                                    <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                                    <asp:BoundField DataField="canteen_name" HeaderText="canteen_name" SortExpression="canteen_name" />
                                    <asp:BoundField DataField="feedback_count" HeaderText="feedback_count" SortExpression="feedback_count" />
                                </Fields>
                            </asp:DetailsView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT * FROM [canteen_master] WHERE ([canteen_id] = @canteen_id)">
                                <SelectParameters>
                                    <asp:SessionParameter DefaultValue="-1" Name="canteen_id" SessionField="id" Type="Int32" />
                                </SelectParameters>
                            </asp:SqlDataSource>
                        </td>
                        <td class="auto-style2">
                            <br />
                        </td>
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
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td class="auto-style2">&nbsp;</td>
                    </tr>
                </table>

            </div>
        </div>
</asp:Content>
