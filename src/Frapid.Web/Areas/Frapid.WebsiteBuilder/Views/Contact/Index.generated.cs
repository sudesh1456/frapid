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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact/Index.cshtml")]
    public partial class _Views_Contact_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Contact_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Contact\Index.cshtml"
  
    ViewBag.Title = "Contacts";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script>\r\n    var scrudFactory = new Object();\r\n\r\n    scrudFactory.title = \"C" +
"ontacts\";\r\n\r\n    scrudFactory.viewAPI = \"/api/views/website/contact-scrud-view\";" +
"\r\n    scrudFactory.viewTableName = \"website.contact_scrud_view\";\r\n\r\n    scrudFac" +
"tory.formAPI = \"/api/forms/website/contacts\";\r\n    scrudFactory.formTableName = " +
"\"website.contacts\";\r\n\r\n    scrudFactory.excludedColumns = [\"audit_user_id\", \"aud" +
"it_ts\"];\r\n\r\n    scrudFactory.allowDelete = true;\r\n    scrudFactory.allowEdit = t" +
"rue;\r\n\r\n    scrudFactory.live = \"Title\";\r\n\r\n    scrudFactory.layout = [\r\n       " +
" {\r\n            tab: \"\",\r\n            fields: [\r\n                [\"ContactId\", \"" +
"\"],\r\n                [\"Title\", \"Name\"],\r\n                [\"Position\", \"Email\"],\r" +
"\n                [\"Recipients\"],\r\n                [\"Address\"],\r\n                " +
"[\"City\", \"State\"],\r\n                [\"Country\", \"PostalCode\"],\r\n                " +
"[\"Telephone\", \"\"],\r\n                [\"Details\"]\r\n            ]\r\n        }\r\n    ]" +
";\r\n\r\n    scrudFactory.card = {\r\n        header: \"title\",\r\n        meta: \"name\",\r" +
"\n        description: \"description\"\r\n    };\r\n\r\n\r\n    $.get(\'/ScrudFactory/View.h" +
"tml\', function (view) {\r\n        $.get(\'/ScrudFactory/Form.html\', function (form" +
") {\r\n            $(\"#ScrudFactoryView\").html(view);\r\n            $(\"#ScrudFactor" +
"yForm\").html(form);\r\n            $.cachedScript(\"/assets/js/scrudfactory-view.js" +
"\");\r\n            $.cachedScript(\"/assets/js/scrudfactory-form.js\");\r\n        });" +
"\r\n    });\r\n</script>\r\n\r\n<script>\r\n    $(document).on(\"formready\", function() {\r\n" +
"        $(\"#category_name\").keyup(function() {\r\n            function getAlias(ti" +
"tle) {\r\n                return title.toLowerCase().replace(/ +(?= )/g, \'\').repla" +
"ce(/ /g, \'-\').replace(/[^\\w-]+/g, \'\');\r\n            };\r\n\r\n            var catego" +
"ry = $(this).val();\r\n            var alias = getAlias(category);\r\n\r\n            " +
"$(\"#alias\").val(alias);\r\n\r\n        });\r\n    });\r\n</script>\r\n\r\n<div");

WriteLiteral(" id=\"ScrudFactoryForm\"");

WriteLiteral("></div>\r\n<div");

WriteLiteral(" id=\"ScrudFactoryView\"");

WriteLiteral("></div>");

        }
    }
}
#pragma warning restore 1591
