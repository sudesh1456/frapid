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
    using DevTrends.MvcDonutCaching;
    using Frapid.Web;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Menu/Index.cshtml")]
    public partial class _Views_Menu_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Menu_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Menu\Index.cshtml"
  
    ViewBag.Title = "Menus";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"M" +
"enus\";\r\n\r\n    scrudFactory.viewAPI = \"/api/forms/website/menus\";\r\n    scrudFacto" +
"ry.viewTableName = \"website.menus\";\r\n\r\n    scrudFactory.formAPI = \"/api/forms/we" +
"bsite/menus\";\r\n    scrudFactory.formTableName = \"website.menus\";\r\n\r\n    scrudFac" +
"tory.excludedColumns = [\"audit_user_id\", \"audit_ts\"];\r\n\r\n    scrudFactory.allowD" +
"elete = true;\r\n    scrudFactory.allowEdit = true;\r\n\r\n    scrudFactory.live = \"Me" +
"nuName\";\r\n\r\n    scrudFactory.layout = [\r\n        {\r\n            tab: \"\",\r\n      " +
"      fields: [\r\n                [\"MenuId\", \"\"],\r\n                [\"MenuName\", \"" +
"\"],\r\n                [\"Description\", \"\"]\r\n            ]\r\n        }\r\n    ];\r\n\r\n  " +
"  scrudFactory.card = {\r\n        header: \"menu_name\",\r\n        description: \"des" +
"cription\"\r\n    };\r\n\r\n    scrudFactory.customActions = [\r\n        {\r\n\r\n          " +
"  title: \"Menu Items\",\r\n            href: \"/dashboard/website/menus/items?MenuId" +
"={id}&TitleSuffix={col:4}\",\r\n            icon: \"list icon\",\r\n            positio" +
"n: \"before\"\r\n        }\r\n    ];\r\n\r\n    $.get(\'/ScrudFactory/View.html\', function " +
"(view) {\r\n        $.get(\'/ScrudFactory/Form.html\', function (form) {\r\n          " +
"  $(\"#ScrudFactoryView\").html(view);\r\n            $(\"#ScrudFactoryForm\").html(fo" +
"rm);\r\n            $.cachedScript(\"/assets/js/scrudfactory-view.js\");\r\n          " +
"  $.cachedScript(\"/assets/js/scrudfactory-form.js\");\r\n        });\r\n    });\r\n</sc" +
"ript>\r\n<script>\r\n    $(document).on(\"formready\", function() {\r\n        $(\"#categ" +
"ory_name\").keyup(function() {\r\n            function getAlias(title) {\r\n         " +
"       return title.toLowerCase().replace(/ +(?= )/g, \'\').replace(/ /g, \'-\').rep" +
"lace(/[^\\w-]+/g, \'\');\r\n            };\r\n\r\n            var category = $(this).val(" +
");\r\n            var alias = getAlias(category);\r\n\r\n            $(\"#alias\").val(a" +
"lias);\r\n\r\n        });\r\n    });\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
