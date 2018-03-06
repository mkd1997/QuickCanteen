<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="canteen_dashboard.aspx.cs" Inherits="QuickCanteen.canteen_dashboard" MasterPageFile="~/QCMaster1.master" Title="Dashboard"%>

<asp:Content runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div style="display:flex;justify-content:center;align-items:center; margin-left: 100px">
    <div>
        
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View/Update Menu" />
                </td>
                <td class="auto-style5">
                    <asp:Panel ID="Panel1" runat="server" Height="363px">
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="83px" Width="212px" OnRowEditing="GridView1_RowEditing" OnRowDeleting="GridView1_RowDeleting" AllowPaging="True" ShowHeaderWhenEmpty="True">
                            <Columns>
                                <asp:CommandField ShowEditButton="True" ShowDeleteButton="True" />
                                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                <asp:BoundField DataField="rate" HeaderText="rate" SortExpression="rate" />
                                <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                            </Columns>
                        </asp:GridView>
                        <br />
                        <asp:Button ID="Button4" runat="server" Text="Insert a New Item" />
                    </asp:Panel>
                </td>
                <td class="auto-style7">
                    <asp:Panel ID="Panel4" runat="server" Height="361px">
                        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" OnSelectedIndexChanged="GridView2_SelectedIndexChanged" DataKeyNames="food_item_id" AllowPaging="True" ShowHeaderWhenEmpty="True">
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                                <asp:BoundField DataField="food_item_id" HeaderText="food_item_id" SortExpression="food_item_id" InsertVisible="False" ReadOnly="True" />
                                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                            </Columns>
                        </asp:GridView>
                        <br />
                        To add a new item to our catalogue, fill in the details here:<br />
                        <br />
                        Name:
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        
                        <br />
                        <asp:Button ID="Button5" runat="server" Text="Add" OnClick="Button5_Click" />
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT food_master.name, menu_master.rate, menu_master.qty FROM food_master INNER JOIN menu_master ON food_master.food_item_id = menu_master.food_item_id WHERE (canteen_id = @C_Id)" UpdateCommand="UPDATE menu_master SET qty = @Qty, rate = @Rate WHERE (canteen_id = @C_Id AND food_item_id = @Food_Id)" DeleteCommand="DELETE FROM menu_master WHERE (canteen_id = @cid AND food_item_id = @fid)">
                        <DeleteParameters>                            
                            <asp:SessionParameter Name="cid" SessionField="id" />
                            <asp:SessionParameter Name="fid" SessionField="food_id" />
                        </DeleteParameters>
                        <SelectParameters>
                            <asp:SessionParameter Name="C_Id" SessionField="id" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="Qty" />
                            <asp:Parameter Name="Rate" />
                            <asp:SessionParameter Name="C_Id" SessionField="id" />
                            <asp:SessionParameter Name="Food_Id" SessionField="food_id" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="auto-style6"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT * FROM [food_master]"></asp:SqlDataSource>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="View Pending Orders" />
                </td>
                <td class="auto-style5">
                    <asp:Panel ID="Panel2" runat="server" Height="363px">
                        <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="order_id" DataSourceID="SqlDataSource3" OnSelectedIndexChanged="GridView3_SelectedIndexChanged" ShowHeaderWhenEmpty="True">
                            <Columns>
                                <asp:CommandField ShowSelectButton="True" />
                                <asp:BoundField DataField="order_id" HeaderText="order_id" InsertVisible="False" ReadOnly="True" SortExpression="order_id" />
                                <asp:BoundField DataField="stu_id" HeaderText="stu_id" SortExpression="stu_id" />
                                <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />
                                <asp:TemplateField HeaderText="select">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                        <br />
                        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataSourceID="SqlDataSource4" Height="50px" Width="125px">
                            <Fields>
                                <asp:BoundField DataField="order_id" HeaderText="order_id" SortExpression="order_id" />
                                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                                <asp:BoundField DataField="qty" HeaderText="qty" SortExpression="qty" />
                            </Fields>                            
                        </asp:DetailsView>
                        <br />
                        <asp:Button ID="Button8" runat="server" Text="Prepared" OnClick="Button8_Click" />
                    </asp:Panel>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT [order_id], [stu_id], [amount] FROM [order_header] WHERE (([canteen_id] = @canteen_id) AND ([status] = @status)) ORDER BY [order_date]" ConflictDetection="CompareAllValues" DeleteCommand="DELETE FROM [order_header] WHERE [order_id] = @original_order_id AND [stu_id] = @original_stu_id AND [amount] = @original_amount" InsertCommand="INSERT INTO [order_header] ([stu_id], [amount]) VALUES (@stu_id, @amount)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [order_header] SET [stu_id] = @stu_id, [amount] = @amount WHERE [order_id] = @original_order_id AND [stu_id] = @original_stu_id AND [amount] = @original_amount">
                        <DeleteParameters>
                            <asp:Parameter Name="original_order_id" Type="Int32" />
                            <asp:Parameter Name="original_stu_id" Type="Int32" />
                            <asp:Parameter Name="original_amount" Type="Decimal" />
                        </DeleteParameters>
                        <InsertParameters>
                            <asp:Parameter Name="stu_id" Type="Int32" />
                            <asp:Parameter Name="amount" Type="Decimal" />
                        </InsertParameters>
                        <SelectParameters>
                            <asp:SessionParameter Name="canteen_id" SessionField="id" Type="Int32" />
                            <asp:Parameter DefaultValue="placed" Name="status" Type="String" />
                        </SelectParameters>
                        <UpdateParameters>
                            <asp:Parameter Name="stu_id" Type="Int32" />
                            <asp:Parameter Name="amount" Type="Decimal" />
                            <asp:Parameter Name="original_order_id" Type="Int32" />
                            <asp:Parameter Name="original_stu_id" Type="Int32" />
                            <asp:Parameter Name="original_amount" Type="Decimal" />
                        </UpdateParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT order_detail.order_id, food_master.name, order_detail.qty FROM food_master INNER JOIN order_detail ON food_master.food_item_id = order_detail.food_item_id WHERE (order_detail.order_id = @O_Id)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="GridView3" Name="O_Id" PropertyName="SelectedValue" DefaultValue="1" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Approve/Deny Cancellation Requests" />
                </td>
                <td class="auto-style5">
                    <asp:Panel ID="Panel3" runat="server" Height="302px">
                        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="order_id" DataSourceID="SqlDataSource5" ShowHeaderWhenEmpty="True">
                            <Columns>
                                <asp:TemplateField HeaderText="select">
                                    <EditItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </EditItemTemplate>
                                    <ItemTemplate>
                                        <asp:CheckBox ID="CheckBox1" runat="server" />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="order_id" HeaderText="order_id" InsertVisible="False" ReadOnly="True" SortExpression="order_id" />
                                <asp:BoundField DataField="stu_id" HeaderText="stu_id" SortExpression="stu_id" />
                                <asp:BoundField DataField="order_date" HeaderText="order_date" SortExpression="order_date" />
                                <asp:BoundField DataField="amount" HeaderText="amount" SortExpression="amount" />                                
                            </Columns>
                        </asp:GridView>
                        <asp:SqlDataSource ID="SqlDataSource5" runat="server" ConnectionString="<%$ ConnectionStrings:SQLDS1ConStr %>" SelectCommand="SELECT [order_id], [stu_id], [order_date], [amount] FROM [order_header] WHERE (([status] = @status) AND ([canteen_id] = @canteen_id))">
                            <SelectParameters>                                
                                <asp:Parameter DefaultValue="can_request" Name="status" Type="String" />
                                <asp:SessionParameter Name="canteen_id" SessionField="id" Type="Int32" />
                            </SelectParameters>
                        </asp:SqlDataSource>
                        <br />
                        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Approve" />
                        &nbsp;
                        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Deny" />
                    </asp:Panel>
                </td>
                <td class="auto-style7">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style1"></td>
                <td class="auto-style1"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="View Profile" />
                </td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
            </tr>
        </table>
              </div>
</div>
    <div>
    </div>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
    .auto-style1 {
        height: 23px;
    }
</style>
</asp:Content>
