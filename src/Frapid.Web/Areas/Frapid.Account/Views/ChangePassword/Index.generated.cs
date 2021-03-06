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
    
    #line 1 "..\..\Views\ChangePassword\Index.cshtml"
    using Frapid.ApplicationState.Cache;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\ChangePassword\Index.cshtml"
    using Frapid.i18n;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangePassword/Index.cshtml")]
    public partial class _Views_ChangePassword_Index_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_ChangePassword_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\ChangePassword\Index.cshtml"
  
    ViewBag.Title = "Change Password";
    Layout = ViewBag.LayoutPath + ViewBag.Layout;

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\ChangePassword\Index.cshtml"
 if (CultureManager.IsRtl())
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"Stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 215), Tuple.Create("\"", 263)
            
            #line 9 "..\..\Views\ChangePassword\Index.cshtml"
, Tuple.Create(Tuple.Create("", 222), Tuple.Create<System.Object, System.Int32>(Href("~/assets/css/master-page-rtl.css")
            
            #line default
            #line hidden
, 222), false)
);

WriteLiteral(" />\r\n");

            
            #line 10 "..\..\Views\ChangePassword\Index.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"Stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 307), Tuple.Create("\"", 351)
            
            #line 13 "..\..\Views\ChangePassword\Index.cshtml"
, Tuple.Create(Tuple.Create("", 314), Tuple.Create<System.Object, System.Int32>(Href("~/assets/css/master-page.css")
            
            #line default
            #line hidden
, 314), false)
);

WriteLiteral(" />\r\n");

            
            #line 14 "..\..\Views\ChangePassword\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"ui attached padded change password left aligned segment\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui stackable very relaxed padded grid\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"ten wide column\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui stackable form\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Change Password</div>\r\n                    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n                    <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"UserNameInputText\"");

WriteLiteral(">Username</label>\r\n                        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"UserNameInputText\"");

WriteLiteral(" maxlength=\"100\"");

WriteLiteral(" required=\"\"");

WriteLiteral(" disabled=\"disabled\"");

WriteLiteral(" readonly=\"readonly\"");

WriteAttribute("value", Tuple.Create(" value=\"", 988), Tuple.Create("\"", 1023)
            
            #line 25 "..\..\Views\ChangePassword\Index.cshtml"
                                                              , Tuple.Create(Tuple.Create("", 996), Tuple.Create<System.Object, System.Int32>(AppUsers.GetCurrent().Name
            
            #line default
            #line hidden
, 996), false)
);

WriteLiteral(" />\r\n                    </div>\r\n                    <div");

WriteLiteral(" class=\"two fields\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"OldPasswordInputPassword\"");

WriteLiteral(">Old Password</label>\r\n                            <input");

WriteLiteral(" type=\"password\"");

WriteLiteral("\r\n                                   id=\"OldPasswordInputPassword\"");

WriteLiteral("\r\n                                   required=\"\"");

WriteLiteral("\r\n                                   maxlength=\"32\"");

WriteLiteral("\r\n                                   data-validation-target=\".big.error\"");

WriteLiteral(" />\r\n                        </div>\r\n                    </div>\r\n                " +
"    <div");

WriteLiteral(" class=\"two fields\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"PasswordInputPassword\"");

WriteLiteral(">New Password</label>\r\n                            <input");

WriteLiteral(" type=\"password\"");

WriteLiteral("\r\n                                   id=\"PasswordInputPassword\"");

WriteLiteral("\r\n                                   required=\"\"");

WriteLiteral("\r\n                                   maxlength=\"32\"");

WriteLiteral("\r\n                                   data-validation-expression=\"^(?=.*\\d)(?=.*[a" +
"-z])(?=.*[A-Z]).{6,32}$\"");

WriteLiteral("\r\n                                   data-validation-message=\"Password should con" +
"tain at least 6 characters with one uppercase, lowercase, and a number.\"");

WriteLiteral("\r\n                                   data-validation-target=\".big.error\"");

WriteLiteral("/>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                            <label");

WriteLiteral(" for=\"ConfirmPasswordInputPassword\"");

WriteLiteral(">Confirm Password</label>\r\n                            <input");

WriteLiteral(" type=\"password\"");

WriteLiteral(" id=\"ConfirmPasswordInputPassword\"");

WriteLiteral(" \r\n                                   data-match-target=\"PasswordInputPassword\"");

WriteLiteral(" required=\"\"");

WriteLiteral("/>\r\n                        </div>\r\n                    </div>\r\n\r\n\r\n             " +
"       <div");

WriteLiteral(" class=\"email address field\"");

WriteLiteral(">\r\n                        <label");

WriteLiteral(" for=\"EmailAddressInput\"");

WriteLiteral(">Email</label>\r\n                        <input");

WriteLiteral(" type=\"email\"");

WriteLiteral(" id=\"EmailAddressInput\"");

WriteLiteral(" required=\"\"");

WriteLiteral("/>\r\n                        <div");

WriteLiteral(" class=\"ui pointing label\"");

WriteLiteral(">Please leave this field empty</div>\r\n                    </div>\r\n\r\n             " +
"       <div");

WriteLiteral(" class=\"big error vpad8\"");

WriteLiteral("></div>\r\n                    <div");

WriteLiteral(" class=\"ui blue button\"");

WriteLiteral(" id=\"ChangePasswordButton\"");

WriteLiteral(">Change My Password</div>\r\n                    <a");

WriteLiteral(" class=\"ui negative button\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">Cancel</a>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"six wide column\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"ui positive message\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"ui header\"");

WriteLiteral(">Please Note</div>\r\n                    <div");

WriteLiteral(" class=\"ui divider\"");

WriteLiteral("></div>\r\n                    We use cookies in our website.\r\n                    " +
"Please read the <a");

WriteLiteral(" href=\"/site/legal/terms-of-service\"");

WriteLiteral(">terms of service</a>\r\n                    before you create an account.\r\n       " +
"         </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n\r\n<sc" +
"ript");

WriteLiteral(" src=\"/i18n/resources.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/assets/js/backend.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/jssha1.5/src/sha.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/form.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/validator.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Areas/Frapid.Account/Scripts/Account/ChangePassword/index.js\"");

WriteLiteral("></script>\r\n<script>\r\n    var bigError = $(\".big.error\");\r\n    $(\".email.address." +
"field\").hide();\r\n\r\n    $(document).ready(function () {\r\n        window.validator" +
".initialize($(\".change.password.segment\"));\r\n    });\r\n\r\n    $(\"#ChangePasswordBu" +
"tton\").click(function () {\r\n        function request(model) {\r\n            var u" +
"rl = \"/account/change-password\";\r\n            var data = JSON.stringify(model);\r" +
"\n            return window.getAjaxRequest(url, \"POST\", data);\r\n        };\r\n\r\n   " +
"     function validate() {\r\n            bigError.html(\"\");\r\n            var form" +
"El = $(\".change.password.segment\");\r\n\r\n            var isValid = window.validato" +
"r.validate(formEl);\r\n\r\n            var hp = $(\"#EmailAddressInput\").val();\r\n\r\n  " +
"          if (hp) {\r\n                isValid = false;\r\n            };\r\n\r\n       " +
"     return isValid;\r\n        };\r\n\r\n        bigError.html(\"\");\r\n\r\n        var is" +
"Valid = validate();\r\n        if (!isValid) {\r\n            return;\r\n        };\r\n\r" +
"\n\r\n        var formEl = $(\".change.password.segment\");\r\n        formEl.addClass(" +
"\"loading\");\r\n        var model = window.serializeForm(formEl);\r\n\r\n\r\n        var " +
"ajax = request(model);\r\n        ajax.success(function (response) {\r\n            " +
"if (response) {\r\n                window.location = \"/account/change-password/suc" +
"cess\";\r\n            }else{\r\n                alert(\"Sorry, we could not change yo" +
"ur password. Could you please  check your existing password and try again?\")\r\n  " +
"              formEl.removeClass(\"loading\");\r\n            };\r\n        });\r\n    }" +
");\r\n\r\n</script>");

        }
    }
}
#pragma warning restore 1591
