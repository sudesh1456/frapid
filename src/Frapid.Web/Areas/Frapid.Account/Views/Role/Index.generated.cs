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
    using Frapid.Account;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Role/Index.cshtml")]
    public partial class _Views_Role_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Role_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Role\Index.cshtml"
  
    ViewBag.Title = "Role Management";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral(@"
<script>
    var scrudFactory = new Object();

    scrudFactory.title = ""Role Management"";

    scrudFactory.viewAPI = ""/api/forms/account/roles"";
    scrudFactory.viewTableName = ""account.roles"";

    scrudFactory.formAPI = ""/api/forms/account/roles"";
    scrudFactory.formTableName = ""account.roles"";

    scrudFactory.excludedColumns = [""audit_user_id"", ""audit_ts""];

    scrudFactory.allowDelete = true;
    scrudFactory.allowEdit = true;

    scrudFactory.live = ""RoleName"";
    
    $.get('/ScrudFactory/View.html', function (view) {
        $.get('/ScrudFactory/Form.html', function (form) {
            $(""#ScrudFactoryView"").html(view);
            $(""#ScrudFactoryForm"").html(form);
            $.cachedScript(""/assets/js/scrudfactory-view.js"");
            $.cachedScript(""/assets/js/scrudfactory-form.js"");
        });
    });

    scrudFactory.card = {
        header: ""role_name""
    };


</script>

<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
