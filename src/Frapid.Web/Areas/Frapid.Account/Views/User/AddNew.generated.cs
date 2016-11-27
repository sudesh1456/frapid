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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/AddNew.cshtml")]
    public partial class _Views_User_AddNew_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_User_AddNew_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\User\AddNew.cshtml"
  
    ViewBag.Title = "User Management";
    Layout = ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/validator.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/form.js\"");

WriteLiteral("></script>\r\n<div");

WriteLiteral(" class=\"ui segment\"");

WriteLiteral(" style=\"padding: 48px;\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Create a New User</div>\r\n        <div");

WriteLiteral(" class=\"ui stackable grid\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"six wide column\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui big form\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Email</label>\r\n                        <input");

WriteLiteral(" type=\"email\"");

WriteLiteral(" id=\"EmailInputEmail\"");

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Name</label>\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"NameInputText\"");

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Password</label>\r\n                        <inpu" +
"t");

WriteLiteral(" type=\"password\"");

WriteLiteral(" id=\"PasswordInputPassword\"");

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Confirm Password</label>\r\n                     " +
"   <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" id=\"ConfirmPasswordInputPassword\"");

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Office</label>\r\n                        <select" +
"");

WriteLiteral(" id=\"OfficeIdSelect\"");

WriteLiteral(" class=\"ui search dropdown\"");

WriteLiteral(" required=\"\"");

WriteLiteral("></select>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Role</label>\r\n                        <select");

WriteLiteral(" id=\"RoleIdSelect\"");

WriteLiteral(" class=\"ui search dropdown\"");

WriteLiteral(" required=\"\"");

WriteLiteral("></select>\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label>Phone</label>\r\n                        <input");

WriteLiteral(" type=\"tel\"");

WriteLiteral(" id=\"PhoneInputTel\"");

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n                    </div>\r\n\r\n                    <button");

WriteLiteral(" class=\"ui green big button\"");

WriteLiteral(" id=\"CreateButton\"");

WriteLiteral(">Create</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n   " +
" </div>    \r\n</div>\r\n\r\n<script>\r\n    $(\".form\").addClass(\"loading\");\r\n    //$(\"." +
"dropdown\").dropdown();\r\n    window.validator.initialize($(\".ui.form\"));\r\n\r\n    f" +
"unction bindOffices() {\r\n        function request() {\r\n            var url = \"/a" +
"pi/views/core/offices/display-fields\";\r\n            return window.getAjaxRequest" +
"(url);\r\n        };\r\n\r\n        var ajax = request();\r\n\r\n        ajax.success(func" +
"tion (response) {\r\n            var select = $(\"#OfficeIdSelect\");\r\n            v" +
"ar options = \"\";\r\n\r\n            $.each(response, function () {\r\n                " +
"var option = \"<option value=\'{key}\'>{value}</option>\";\r\n                option =" +
" option.replace(\"{key}\", this.Key);\r\n                option = option.replace(\"{v" +
"alue}\", this.Value);\r\n\r\n                options += option;\r\n            });\r\n\r\n " +
"           select.html(options);\r\n            $(\".form\").removeClass(\"loading\");" +
"\r\n        });\r\n\r\n        ajax.fail(function() {\r\n            $(\".form\").removeCl" +
"ass(\"loading\");\r\n        });\r\n    };\r\n\r\n    function bindRoles() {\r\n        func" +
"tion request() {\r\n            var url = \"/api/views/account/roles/display-fields" +
"\";\r\n            return window.getAjaxRequest(url);\r\n        };\r\n\r\n        var aj" +
"ax = request();\r\n\r\n        ajax.success(function (response) {\r\n            var s" +
"elect = $(\"#RoleIdSelect\");\r\n            var options = \"\";\r\n\r\n            $.each" +
"(response, function () {\r\n                var option = \"<option value=\'{key}\'>{v" +
"alue}</option>\";\r\n                option = option.replace(\"{key}\", this.Key);\r\n " +
"               option = option.replace(\"{value}\", this.Value);\r\n\r\n              " +
"  options += option;\r\n            });\r\n\r\n            select.html(options);\r\n    " +
"    });\r\n    };\r\n\r\n    bindRoles();\r\n    bindOffices();\r\n\r\n    $(\"#CreateButton\"" +
").unbind(\"click\").bind(\"click\", function() {\r\n        function request(model) {\r" +
"\n            var url = \"/dashboard/account/user/add\";\r\n            var data = JS" +
"ON.stringify(model);\r\n\r\n            return window.getAjaxRequest(url, \"POST\", da" +
"ta);\r\n        };\r\n\r\n        var form = $(\".ui.form\");\r\n        form.addClass(\"lo" +
"ading\");\r\n\r\n        var model = window.serializeForm(form);\r\n        if (model.P" +
"assword !== model.ConfirmPassword) {\r\n            alert(\"Confirm password does n" +
"ot match with supplied password.\");\r\n            return;\r\n        };\r\n\r\n        " +
"var ajax = request(model);\r\n\r\n        ajax.success(function () {\r\n            fo" +
"rm.removeClass(\"loading\");\r\n            $(\".ui.form input\").val(\"\");\r\n          " +
"  window.displaySuccess();\r\n        });\r\n\r\n        ajax.fail(function (xhr) {\r\n " +
"           form.removeClass(\"loading\");\r\n            alert(JSON.stringify(xhr));" +
"\r\n        });\r\n    });\r\n</script>");

        }
    }
}
#pragma warning restore 1591