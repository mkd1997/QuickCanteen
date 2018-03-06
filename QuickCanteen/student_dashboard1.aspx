<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_dashboard1.aspx.cs" Inherits="QuickCanteen.student_dashboard1" MasterPageFile="~/QCMaster1.Master" Title="Dashboard" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View Menu/Place Order" />
                    <br />
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT [canteen_name] FROM [canteen_master]"></asp:SqlDataSource>
                </td>
                <td>
                    <asp:Panel ID="Panel1" runat="server" Height="272px">
                        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" ShowHeaderWhenEmpty="True">
                            <Columns>
                                <asp:CommandField HeaderText="select" ShowHeader="True" ShowSelectButton="True" />
                            </Columns>
                        </asp:GridView>
                        <br />
                        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="Label5" runat="server"></asp:Label>
                        <br />
                        Name:
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                        <br />
                        Quantity:
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                        <br />
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Add" />
                        <br />
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                        <br />
                    </asp:Panel>
                </td>
                <td>
                    <asp:Panel ID="Panel2" runat="server" Height="275px" Width="300px">
                        <asp:GridView ID="GridView2" runat="server" OnRowDeleting="GridView2_RowDeleting" ShowHeaderWhenEmpty="True">
                            <Columns>
                                <asp:CommandField HeaderText="delete" ShowDeleteButton="True" ShowHeader="True" />
                            </Columns>
                        </asp:GridView>
                        <br />
                        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Generate Bill" />
                        <br />
                        <asp:Label ID="Label3" runat="server"></asp:Label>
                        <br />
                        <br />
                        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Pay and Place Order" />
                        <br />
                        <asp:Label ID="Label4" runat="server"></asp:Label>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button2" runat="server" Text="Rate Canteen" OnClick="Button2_Click" />
                </td>
                <td>
                    <asp:Panel ID="Panel3" runat="server" Height="163px" Width="356px">
                        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource3" DataTextField="canteen_name" DataValueField="canteen_name">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT [canteen_name] FROM [canteen_master]"></asp:SqlDataSource>
                        <br />
                        <br />
                        <asp:DropDownList ID="DropDownList3" runat="server">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Rate" />
                    </asp:Panel>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button3" runat="server" Text="Cancel Order" OnClick="Button3_Click" />
                </td>
                <td>
                    <asp:Panel ID="Panel4" runat="server">
                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="order_id" DataSourceID="SqlDataSource5" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" ShowHeaderWhenEmpty="True">
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" SelectText="Request Cancellation" />
                                <asp:BoundField DataField="canteen_name" HeaderText="canteen_name" SortExpression="canteen_name" />
                                <asp:BoundField DataField="order_id" HeaderText="order_id" InsertVisible="False" ReadOnly="True" SortExpression="order_id" />
                                <asp:BoundField DataField="order_date" HeaderText="order_date" SortExpression="order_date" />
                                <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT canteen_master.canteen_name, order_header.order_id, order_header.order_date, order_header.amount FROM canteen_master INNER JOIN order_header ON canteen_master.canteen_id = order_header.canteen_id where stu_id = @s_id and status = 'placed';">
                            <SelectParameters>
                                <asp:SessionParameter Name="s_id" SessionField="id" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <br />
                        <br />

                    </asp:Panel>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button8" runat="server" Text="Search Food Items" OnClick="Button8_Click" />
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT DISTINCT [name] FROM [food_master]"></asp:SqlDataSource>
                </td>
                <td class="auto-style2">
                    <asp:Panel ID="Panel5" runat="server" Height="213px" Width="402px">
                        <asp:DropDownList ID="DropDownList4" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="name" Visible="False">
                        </asp:DropDownList>
                        <br />
                        <asp:GridView ID="GridView4" runat="server" DataSourceID="SqlDataSource4" Visible="False" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="canteen_name" HeaderText="canteen_name" SortExpression="canteen_name" />
                                <asp:BoundField DataField="rate" HeaderText="rate" SortExpression="rate" />
                            </Columns>
                        </asp:GridView>
                        <br />
                        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT canteen_master.canteen_name, menu_master.rate FROM food_master INNER JOIN menu_master ON food_master.food_item_id = menu_master.food_item_id INNER JOIN canteen_master ON menu_master.canteen_id = canteen_master.canteen_id WHERE (food_master.name = @food_id)">
                            <SelectParameters>
                                <asp:ControlParameter ControlID="DropDownList4" DefaultValue="Pani Puri" Name="food_id" PropertyName="SelectedValue" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </asp:Panel>
                </td>
                <td></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="View Profile" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </div>
</asp:Content>
