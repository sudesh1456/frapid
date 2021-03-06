﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Frapid.Authorization;
    using Frapid.Configuration;
    using Frapid.Dashboard;
    using Frapid.DataAccess;
    using Frapid.DbPolicy;
    using Frapid.Framework;
    using Frapid.i18n;
    using Frapid.Messaging;
    using Frapid.WebsiteBuilder;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MenuPolicy/GroupPolicy.cshtml")]
    public partial class _Views_MenuPolicy_GroupPolicy_cshtml : System.Web.Mvc.WebViewPage<Frapid.Authorization.ViewModels.GroupMenuPolicy>
    {
        public _Views_MenuPolicy_GroupPolicy_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
  
    ViewBag.Title = "Group Menu Policy";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n<style>\r\n    .selector.table tr {\r\n        cursor: pointer;\r\n    }\r\n</style>\r\n<" +
"div");

WriteLiteral(" class=\"ui container\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui attached padded segment\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Menu Access - Group Policy</div>\r\n        <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n        <div");

WriteLiteral(" class=\"ui vpad8 form\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"three fields\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label>Select a Role</label>\r\n                    <select");

WriteLiteral(" id=\"RoleDropdown\"");

WriteLiteral(" class=\"ui search dropdown\"");

WriteLiteral(">\r\n                        <option>Select</option>\r\n");

            
            #line 22 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 22 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                         foreach (var item in Model.Roles)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 809), Tuple.Create("\"", 829)
            
            #line 24 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
, Tuple.Create(Tuple.Create("", 817), Tuple.Create<System.Object, System.Int32>(item.RoleId
            
            #line default
            #line hidden
, 817), false)
);

WriteLiteral(">");

            
            #line 24 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                                                    Write(item.RoleName);

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 25 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label>Select an Office</label>\r\n                    <sele" +
"ct");

WriteLiteral(" id=\"OfficeDropdown\"");

WriteLiteral(" class=\"ui search dropdown\"");

WriteLiteral(">\r\n                        <option>Select</option>\r\n");

            
            #line 32 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                         foreach (var item in Model.Offices)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 1278), Tuple.Create("\"", 1300)
            
            #line 34 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
, Tuple.Create(Tuple.Create("", 1286), Tuple.Create<System.Object, System.Int32>(item.OfficeId
            
            #line default
            #line hidden
, 1286), false)
);

WriteLiteral(">");

            
            #line 34 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                                                      Write(item.OfficeCode);

            
            #line default
            #line hidden
WriteLiteral(" (");

            
            #line 34 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                                                                        Write(item.OfficeName);

            
            #line default
            #line hidden
WriteLiteral(")</option>\r\n");

            
            #line 35 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n                <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                    <label>&nbsp;</label>\r\n                    <button data-ge" +
"t-menu-policy-button");

WriteLiteral(" class=\"ui positive button\"");

WriteLiteral(">Load</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n   " +
"     <table");

WriteLiteral(" class=\"ui attached selector table\"");

WriteLiteral(">\r\n            <thead>\r\n            <tr>\r\n                <th>\r\n                 " +
"   <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(@" data-toggle-all/>
                </th>
                <th>
                    App
                </th>
                <th>
                    Menu Id
                </th>
                <th>
                    Menu Text
                </th>
                <th>
                    Url
                </th>
            </tr>
            </thead>
            <tbody>
");

            
            #line 66 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
            
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
             foreach (var item in Model.Menus)
            {

            
            #line default
            #line hidden
WriteLiteral("                <tr>\r\n                    <td>\r\n                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" data-menu-id=\"");

            
            #line 70 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                                                        Write(item.MenuId);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral("/>\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 73 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                   Write(item.AppName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 76 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                   Write(item.MenuId);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 79 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                   Write(item.MenuName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");

WriteLiteral("                        ");

            
            #line 82 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
                   Write(item.Url);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");

            
            #line 85 "..\..\Views\MenuPolicy\GroupPolicy.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n        <div");

WriteLiteral(" class=\"vpad8\"");

WriteLiteral("></div>\r\n        <button data-save-button");

WriteLiteral(" class=\"ui positive button\"");

WriteLiteral(">Save</button>\r\n    </div>\r\n</div>\r\n<script");

WriteLiteral(" src=\"/Areas/Frapid.Authorization/Scripts/MenuPolicy/group-policy.js\"");

WriteLiteral("></script>");

        }
    }
}
#pragma warning restore 1591
