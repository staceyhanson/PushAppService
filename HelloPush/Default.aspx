<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HelloPush._Default" %>


<asp:Content ID="MainContent" runat="server" ContentPlaceHolderID="MainContent">
   <br/>
    <p>
        <strong>Enter your Channel URI (retrieved from an instance of HttpNotificationChannel in your Windows Phone app):</strong><br />
        <asp:TextBox ID="txtUri" runat="server" Width="756px"></asp:TextBox>
        <br />
        <asp:RegularExpressionValidator runat="server"
            ControlToValidate="txtUri"
            ErrorMessage="Please enter a valid URL" ForeColor="Maroon"
            ValidationExpression="http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?" />
    </p>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server"
        OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
        AutoPostBack="true" Height="29px" Width="141px">
        <asp:ListItem>StandardTile</asp:ListItem>
        <asp:ListItem>FlipTile</asp:ListItem>
        <asp:ListItem>IconicTile</asp:ListItem>
        <asp:ListItem>CycleTile</asp:ListItem>
    </asp:DropDownList>
    <br />
    <table>
        <tbody>
            <tr>
                <td class="style13">
                    <div runat="server" id="divStandardTile">
                        <table class="style1">
                            <tr>
                                <td class="style5">
                                    <strong>Standard Tile Push</strong>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Tile ID&nbsp;<br />
                                    </span>
                                    <asp:TextBox ID="txtStandardTileId" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Count<br />
                                    </span>
                                    <asp:TextBox ID="txtStandardTileCount" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbStandardCount" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Front Title<br />
                                    </span>
                                    <asp:TextBox ID="txtStandardTileTitle" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbStandardTitle" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Front Image<br />
                                    </span>
                                    <asp:TextBox ID="txtStandardTileImage" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbStandardTileImage" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Back Title<br />
                                    </span>
                                    <asp:TextBox ID="txtStandardTileBackTitle" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbStandardBackTitle" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Back Content<br />
                                    </span>
                                    <asp:TextBox ID="txtStandardTileBackContent" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbStandardBackContent" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Back Image<br />
                                    </span>
                                    <asp:TextBox ID="txtStandardTileBackImage" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbStandardBackBackgroundImage" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <asp:Button ID="btnStandardTile" runat="server" OnClick="btnStandardTile_Click" Text="Send Tile"
                                        CssClass="style4" />
                                    &nbsp;
                                    <asp:Button ID="btnStandardTilePreview" runat="server"
                                        OnClick="btnStandardTilePreview_Click" Text="Preview"
                                        CssClass="style4" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div runat="server" id="divFlipTile" visible="false">
                        <table class="style1">
                            <tr>
                                <td class="style5">
                                    <strong>Flip Tile Push</strong>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Tile ID&nbsp;<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileId" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Count<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileCount" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipCount" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Front Title<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileTitle" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipTitle" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Small Image<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileSmallImage" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipSmallImage" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Front Image<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileImage" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipImage" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Back Title<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileBackTitle" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipBackTitle" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Back Content<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileBackContent" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipBackContent" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Back Image<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileBackImage" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipBackBackgroundImage" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Wide Image<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileWideImage" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipWideImage" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Wide Back Image<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileWideBackImage" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipWideBackBackgroundImage" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <span class="style4">Enter Wide Back Content<br />
                                    </span>
                                    <asp:TextBox ID="txtFlipTileWideBackContent" runat="server" Width="190px"
                                        CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbFlipWideBackContent" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style2">
                                    <asp:Button ID="btnFlipTile" runat="server" OnClick="btnFlipTile_Click"
                                        Text="Send Tile" CssClass="style4" />
                                    &nbsp;
                                    <asp:Button ID="btnFlipTilePreview" runat="server"
                                        OnClick="btnFlipTilePreview_Click" Text="Preview"
                                        CssClass="style4" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div runat="server" id="divIconicTile" visible="false">
                        <table class="style1">
                            <tr>
                                <td class="style3">
                                    <strong>Iconic Tile Push</strong>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Tile ID<br />
                                    </span>
                                    <asp:TextBox ID="txtIconicTileId" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Count<br />
                                    </span>
                                    <asp:TextBox ID="txtIconicTileCount" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <asp:CheckBox ID="cbIconicCount" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Title<br />
                                    </span>
                                    <asp:TextBox ID="txtIconicTileTitle" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <asp:CheckBox ID="cbIconicTitle" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Small Icon<br />
                                    </span>
                                    <asp:TextBox ID="txtIconicTileSmallIcon" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <br />
                                            <asp:CheckBox ID="cbIconicSmallIcon" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Medium/Large Icon<br />
                                    </span>
                                    <asp:TextBox ID="txtIconicTileIcon" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <br />
                                            <asp:CheckBox ID="cbIconicIcon" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Content 1<br />
                                    </span>
                                    <asp:TextBox ID="txtIconicTileContent1" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <asp:CheckBox ID="cbIconicContent1" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Content 2<br />
                                    </span>
                                    <asp:TextBox ID="txtIconicTileContent2" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <asp:CheckBox ID="cbIconicContent2" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Content 3<br />
                                    </span>
                                    <asp:TextBox ID="txtIconicTileContent3" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <asp:CheckBox ID="cbIconicContent3" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter background color
                                        <br />
                                        Like #FF524742
                                    </span>
                                    <asp:TextBox ID="txtIconicTileBackgroundColor" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <asp:CheckBox ID="cbIconicBackgroundColor" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:Button ID="btnIconicTile" runat="server" OnClick="btnIconicTile_Click" Text="Send Tile"
                                        CssClass="style4" />
                                    &nbsp;
                                    <asp:Button ID="btnIconicTilePreview" runat="server"
                                        OnClick="btnIconicTilePreview_Click" Text="Preview"
                                        CssClass="style4" />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div runat="server" id="divCycleTile" visible="false">
                        <table class="style1">
                            <tr>
                                <td class="style3">
                                    <strong>Iconic Tile Push</strong>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Tile ID<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileId" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Count<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCount" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <asp:CheckBox ID="CheckBox2" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Title<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileTitle" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style15">
                                        <br />
                                        <span class="style4">
                                            <asp:CheckBox ID="cbCycleTitle" runat="server" Text="Clear?" />
                                        </span>
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Small Image<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileSmallImage" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <span class="style4">
                                        <br />
                                        <asp:CheckBox ID="cbCycleSmallImage" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Cycle Image 1<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCycleImage1" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <br />
                                    <span class="style4">
                                        <asp:CheckBox ID="cbCycleImage1" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Cycle Image 2<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCycleImage2" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <br />
                                    <span class="style4">
                                        <asp:CheckBox ID="cbCycleImage2" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Cycle Image 3<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCycleImage3" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <br />
                                    <span class="style4">
                                        <asp:CheckBox ID="cbCycleImage3" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Cycle Image 4<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCycleImage4" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <br />
                                    <span class="style4">
                                        <asp:CheckBox ID="cbCycleImage4" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Cycle Image 5<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCycleImage5" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <br />
                                    <span class="style4">
                                        <asp:CheckBox ID="cbCycleImage5" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Cycle Image 6<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCycleImage6" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <br />
                                    <span class="style4">
                                        <asp:CheckBox ID="cbCycleImage6" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Cycle Image 7<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCycleImage7" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <br />
                                    <span class="style4">
                                        <asp:CheckBox ID="cbCycleImage7" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Cycle Image 8<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCycleImage8" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <br />
                                    <span class="style4">
                                        <asp:CheckBox ID="cbCycleImage8" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <span class="style15">Enter Cycle Image 9<br />
                                    </span>
                                    <asp:TextBox ID="txtCycleTileCycleImage9" runat="server" Width="190px" CssClass="style4"></asp:TextBox>
                                    <br />
                                    <span class="style4">
                                        <asp:CheckBox ID="cbCycleImage9" runat="server" Text="Clear?" />
                                    </span>
                                </td>
                            </tr>
                            <tr>
                                <td class="style3">
                                    <asp:Button ID="btnCycleTile" runat="server" OnClick="btnCycleTile_Click" Text="Send Tile"
                                        CssClass="style4" />
                                    &nbsp;
                                    <asp:Button ID="btnCycleTilePreview" runat="server"
                                        OnClick="btnCycleTilePreview_Click" Text="Preview"
                                        CssClass="style4" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </td>
                <td class="style16" valign="top">
                    <div id="divToast">
                        <table class="style1">
                            <tr>
                                <td class="style10">
                                    <strong>Toast Push</strong>
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    <span class="style6">Enter text 1:<br />
                                    </span>
                                    <asp:TextBox ID="txtToastText1" runat="server" Width="190px" CssClass="style6"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    <span class="style6">Enter text 2:<br />
                                    </span>
                                    <asp:TextBox ID="txtToastText2" runat="server" Width="190px" CssClass="style6"></asp:TextBox>
                                    <br class="style6" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    <span class="style6">Enter parameters:<br />
                                    </span>
                                    <asp:TextBox ID="txtToastParam" runat="server" Width="190px" CssClass="style6"></asp:TextBox>
                                    <br class="style6" />
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    <asp:Button ID="btnToast" runat="server" Text="Send Toast" OnClick="btnToast_Click"
                                        CssClass="style6" />
                                    &nbsp;
                                    <asp:Button ID="btnToastPreview" runat="server" Text="Preview" OnClick="btnToastPreview_Click"
                                        CssClass="style6" />
                                </td>
                            </tr>
                        </table>
                        <br />
                    </div>
                    <div id="divRaw">
                        <table class="style1">
                            <tr>
                                <td class="style12">
                                    <strong>Raw Push</strong>
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    <asp:TextBox ID="txtRawPayload" runat="server" Height="77px" Width="309px" TextMode="MultiLine"
                                        CssClass="style8"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style12">Raw Type:<asp:RadioButton Text="3" ID="Class3" runat="server" GroupName="RawClass"
                                    Checked="True" />
                                    (RAW)<asp:RadioButton Text="4" ID="Class4" runat="server" GroupName="RawClass" />
                                    (VOIP)
                                </td>
                            </tr>
                            <tr>
                                <td class="style11">
                                    <asp:Button ID="btnRaw" runat="server" Text="Send Raw" OnClick="btnRaw_Click" CssClass="style8" />
                                    <br />
                                    <br />
                                </td>
                            </tr>
                        </table>
                    </div>
                    <div id="divDIY">
                        <table class="style1">
                            <tr>
                                <td class="style18">
                                    <strong>DIY Push</strong>
                                </td>
                            </tr>
                            <tr>
                                <td>Enter your own fully formatted push XML - remember your XML escapes, etc!
                                    <asp:TextBox ID="txtDiyPayload" runat="server" Height="182px" Width="519px" TextMode="MultiLine"
                                        CssClass="style17"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="style17" colspan="1">
                                    <label>Push Type:</label>
                                    <br />
                                    <asp:RadioButton Text="1" ID="Tile" runat="server" GroupName="DiyTypes"
                                        Checked="True" />
                                    (TILE)<asp:RadioButton Text="2" ID="Toast" runat="server"
                                        GroupName="DiyTypes" />
                                    (TOAST)<asp:RadioButton Text="3" ID="Raw" runat="server"
                                        GroupName="DiyTypes" />
                                    (RAW)<asp:RadioButton Text="4" ID="Voip" runat="server"
                                        GroupName="DiyTypes" />
                                    (VOIP)
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


