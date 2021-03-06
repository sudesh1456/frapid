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
    
    #line 2 "..\..\Views\Reset\Index.cshtml"
    using Frapid.i18n;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Reset/Index.cshtml")]
    public partial class _Views_Reset_Index_cshtml : System.Web.Mvc.WebViewPage<Frapid.Account.ViewModels.Reset>
    {
        public _Views_Reset_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Reset\Index.cshtml"
  
    ViewBag.Title = "Reset Your Account";
    Layout = ViewBag.LayoutPath + ViewBag.Layout;
    ViewBag.Description = "To reset your password, enter the email address which is registered in our website. We will send you an email on your email address with instructions to help you reset your password.";

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 8 "..\..\Views\Reset\Index.cshtml"
 if (CultureManager.IsRtl())
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"Stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 433), Tuple.Create("\"", 481)
            
            #line 10 "..\..\Views\Reset\Index.cshtml"
, Tuple.Create(Tuple.Create("", 440), Tuple.Create<System.Object, System.Int32>(Href("~/assets/css/master-page-rtl.css")
            
            #line default
            #line hidden
, 440), false)
);

WriteLiteral(" />\r\n");

            
            #line 11 "..\..\Views\Reset\Index.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <link");

WriteLiteral(" rel=\"Stylesheet\"");

WriteAttribute("href", Tuple.Create(" href=\"", 525), Tuple.Create("\"", 569)
            
            #line 14 "..\..\Views\Reset\Index.cshtml"
, Tuple.Create(Tuple.Create("", 532), Tuple.Create<System.Object, System.Int32>(Href("~/assets/css/master-page.css")
            
            #line default
            #line hidden
, 532), false)
);

WriteLiteral(" />\r\n");

            
            #line 15 "..\..\Views\Reset\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"ui attached padded reset password left aligned segment\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" class=\"ui container\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"ui huge header\"");

WriteLiteral(">Forgot Your Password?</div>\r\n        <div");

WriteLiteral(" class=\"ui positive message\"");

WriteLiteral(@">
            To reset your plainPassword, enter the email address which is registered in our website.
            We will send you an email on your email address with instructions to help you
            reset your plainPassword.
        </div>
        <div");

WriteLiteral(" class=\"ui stackable form\"");

WriteLiteral(" style=\"max-width: 400px;\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"field\"");

WriteLiteral(">\r\n                <label>Enter Your Email Address</label>\r\n                <inpu" +
"t");

WriteLiteral(" type=\"email\"");

WriteLiteral(" id=\"EmailInputEmail\"");

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"hidden field\"");

WriteLiteral(">\r\n                <label>Enter Your Email Address Again</label>\r\n               " +
" <input");

WriteLiteral(" type=\"email\"");

WriteLiteral(" id=\"ConfirmEmailInputEmail\"");

WriteLiteral(" required=\"\"");

WriteLiteral(" />\r\n            </div>\r\n\r\n            <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" id=\"TokenInputHidden\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1549), Tuple.Create("\"", 1569)
            
            #line 36 "..\..\Views\Reset\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1557), Tuple.Create<System.Object, System.Int32>(Model.Token
            
            #line default
            #line hidden
, 1557), false)
);

WriteLiteral("/>\r\n\r\n        </div>\r\n        <div");

WriteLiteral(" class=\"big error vpad8\"");

WriteLiteral("></div>\r\n        <button");

WriteLiteral(" class=\"ui positive button\"");

WriteLiteral(" id=\"ResetButton\"");

WriteLiteral(">Reset My Account</button>\r\n        <a");

WriteLiteral(" class=\"ui negative button\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">Cancel</a>\r\n    </div>\r\n</div>\r\n<script");

WriteLiteral(" src=\"/i18n/resources.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/assets/js/backend.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/form.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Scripts/frapid/utilities/validator.js\"");

WriteLiteral("></script>\r\n<script");

WriteLiteral(" src=\"/Areas/Frapid.Account/Scripts/Account/Reset/index.js\"");

WriteLiteral("></script>\r\n");

        }
    }
}
#pragma warning restore 1591
