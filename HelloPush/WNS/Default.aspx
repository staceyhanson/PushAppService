<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" MasterPageFile="~/Site.Master" CodeBehind="Default.aspx.cs" Inherits="WebRole1.WNS.WebForm1" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Hello Push - WNS Edition!
    </h2>
        <p>
        <strong>Channel URI:</strong><br />
        <asp:TextBox ID="txtUri" runat="server" Width="756px"></asp:TextBox>
    </p>

    <p>
        <strong>Package Security Identifier (SID):</strong><br />
        <asp:TextBox ID="txtSid" runat="server" Width="756px"></asp:TextBox>
    </p>

    <p><strong>Client Secret:</strong><br />
        <asp:TextBox ID="txtSecret" runat="server" Width="756px"></asp:TextBox>
    </p>
    <br />

        <br />
    <table>
        <tbody valign="top">
        <tr valign="top">
            <td valign="top" class="style16">
                <div id="divDIY">
                    <table class="style1">
                        <tr>
                            <td class="style18">
                                <strong>DIY Push</strong>
                            </td>
                        </tr>
                        
                        <tr>
                            
                            <td>
                                <div runat="server" id="divXML">
                                Enter your own fully formatted push XML - remember your XML escapes, etc!
                                <asp:TextBox ID="txtDiyPayload" runat="server" Height="182px" Width="519px" TextMode="MultiLine"
                                    CssClass="style17">&lt;tile&gt; 
&lt;visual version=&quot;2&quot;&gt; 
&lt;binding template=&quot;TileSquare150x150Text02&quot; fallback=&quot;TileSquareText02&quot;&gt; 
&lt;text id=&quot;1&quot;&gt;Text Field 1 (larger text)&lt;/text&gt; 
&lt;text id=&quot;2&quot;&gt;Text Field 2&lt;/text&gt; 
&lt;/binding&gt; 
&lt;/visual&gt; 
&lt;/tile&gt;
</asp:TextBox>
                                                                    <br />
                                <asp:HyperLink ID="TileTemplateCatalog" runat="server" NavigateUrl="http://msdn.microsoft.com/en-us/library/windows/apps/Hh761491.aspx" Target="_blank">Tile Template Catalog</asp:HyperLink>
                                |
                                <asp:HyperLink ID="ToastTemplateCatalog" runat="server" NavigateUrl="http://msdn.microsoft.com/en-us/library/windows/apps/hh761494.aspx" Target="_blank">Toast Template Catalog</asp:HyperLink>
                                |
                                <asp:HyperLink ID="BadgeSchema" runat="server" NavigateUrl="http://msdn.microsoft.com/en-us/library/windows/apps/br212849.aspx" Target="_blank">Badge Schema</asp:HyperLink>
                                    </div>
                            </td>
                            
                        </tr>
                        <tr>
                            <td colspan="1">
                                Push Type:<br />
                                <asp:DropDownList ID="PushTypeList" runat="server"
                                    OnSelectedIndexChanged="PushTypeList_SelectedIndexChanged"
                                    AutoPostBack="true" Height="29px" Width="141px">
                                    <asp:ListItem Selected="True">Tile</asp:ListItem>
                                    <asp:ListItem>Toast</asp:ListItem>
                                    <asp:ListItem>Ghost Toast</asp:ListItem>
                                    <asp:ListItem>Toast Delete</asp:ListItem>
                                    <asp:ListItem>Badge</asp:ListItem>
                                    <asp:ListItem>Raw</asp:ListItem>
                                </asp:DropDownList>

                                <br />
                                Expiration in seconds<br />
                                (don&#39;t use 0.&nbsp; Use &quot;1&quot; for instant, leave blank for none):<br />
                                    <asp:TextBox ID="txtTTL" runat="server" Width="135px"></asp:TextBox>

                                <div runat="server" id="divGroupAndTagList" visible="False">
                                    X-WNS-MATCH (toast delete) options:<br />
                                    <asp:DropDownList ID="GroupAndTagList" runat="server"
                                        OnSelectedIndexChanged="GroupAndTagList_SelectedIndexChanged"
                                        AutoPostBack="true" Height="29px" Width="141px">
                                        <asp:ListItem>Group+Tag</asp:ListItem>
                                        <asp:ListItem>Group</asp:ListItem>
                                        <asp:ListItem>Tag</asp:ListItem>
                                        <asp:ListItem>All</asp:ListItem>
                                    </asp:DropDownList>
                                

                                <div runat="server" id="divGroupAndTag">

                                    Group<br />
                                    <asp:TextBox ID="txtGroup" runat="server" Width="135px"></asp:TextBox>
                                    <br />
                                    Tag<br />
                                    <asp:TextBox ID="txtTag" runat="server"></asp:TextBox>

                                </div>
                                <div runat="server" id="divGroup" visible="False">

                                    Group<br />
                                    <asp:TextBox ID="txtGroupOnly" runat="server"></asp:TextBox>

                                </div>
                                <div runat="server" id="divTag" visible="False">

                                    Tag<br />
                                    <asp:TextBox ID="txtTagOnly" runat="server"></asp:TextBox>

                                </div>
                                </div>

                            </td>
                        </tr>
                        <tr>
                            <td class="style11">
                                <asp:Button ID="btnDiyPush" runat="server" Text="Send Push" 
                                    OnClick="btnDiyPush_Click" CssClass="style17" />
                            &nbsp;
                                <asp:Button ID="btnDiyPushPreview" runat="server" Text="Preview" 
                                    OnClick="btnDiyPushPreview_Click" CssClass="style17" />
                            </td>
                        </tr>
                    </table>
                </div>
            </td>
        </tr>
            </tbody>
    </table>
    <p>
        <span class="style19"><strong>Output:</strong><br />
        </span>
        <asp:TextBox ID="txtResponse" runat="server" Height="182px" Width="550px" 
            TextMode="MultiLine" CssClass="style19"></asp:TextBox>
    </p>

</asp:Content>

