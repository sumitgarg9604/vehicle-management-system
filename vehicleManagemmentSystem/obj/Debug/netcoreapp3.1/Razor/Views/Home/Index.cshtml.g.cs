#pragma checksum "D:\Education\github directories\vehicle-management-system - backuo1150\vehicleManagemmentSystem\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c77b3082bf19ed98dfaa2fa5317391e50ea81b75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Education\github directories\vehicle-management-system - backuo1150\vehicleManagemmentSystem\Views\_ViewImports.cshtml"
using vehicleManagemmentSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Education\github directories\vehicle-management-system - backuo1150\vehicleManagemmentSystem\Views\_ViewImports.cshtml"
using vehicleManagemmentSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Education\github directories\vehicle-management-system - backuo1150\vehicleManagemmentSystem\Views\_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c77b3082bf19ed98dfaa2fa5317391e50ea81b75", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f472a680116cc10b380e29546039e08f13354917", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<! -- Index.cshtml -->\r\n<! -- View Existing Vehicles by Type such as Boat or Car -->\r\n<! -- To Add a Vehicle By Type to the Database -->\r\n\r\n");
#nullable restore
#line 5 "D:\Education\github directories\vehicle-management-system - backuo1150\vehicleManagemmentSystem\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Vehicle Management System";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c77b3082bf19ed98dfaa2fa5317391e50ea81b753893", async() => {
                WriteLiteral("\r\n    <div id=\"content\"");
                BeginWriteAttribute("class", " class=\"", 240, "\"", 248, 0);
                EndWriteAttribute();
                WriteLiteral(@"></div>

    <! -- JS to import React -->
    <script crossorigin src=""https://cdnjs.cloudflare.com/ajax/libs/react/16.13.0/umd/react.development.js""></script>
    <script crossorigin src=""https://cdnjs.cloudflare.com/ajax/libs/react-dom/16.13.0/umd/react-dom.development.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/remarkable/1.7.1/remarkable.min.js""></script>

    <! -- Axios library to performs operations via API Data -->
    <script src=""https://unpkg.com/axios/dist/axios.min.js""></script>

    <! -- JS script for customized alert box -->
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@10""></script>


    <script");
                BeginWriteAttribute("src", " src=\"", 921, "\"", 967, 1);
#nullable restore
#line 25 "D:\Education\github directories\vehicle-management-system - backuo1150\vehicleManagemmentSystem\Views\Home\Index.cshtml"
WriteAttributeValue("", 927, Url.Content("~/js/viewListingForm.jsx"), 927, 40, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    <script");
                BeginWriteAttribute("src", " src=\"", 991, "\"", 1044, 1);
#nullable restore
#line 26 "D:\Education\github directories\vehicle-management-system - backuo1150\vehicleManagemmentSystem\Views\Home\Index.cshtml"
WriteAttributeValue("", 997, Url.Content("~/js/selectAndCreateVehicle.jsx"), 997, 47, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
