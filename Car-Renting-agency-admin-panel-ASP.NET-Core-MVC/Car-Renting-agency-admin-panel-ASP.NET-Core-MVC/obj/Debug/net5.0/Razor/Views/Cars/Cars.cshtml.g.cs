#pragma checksum "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83dc77a88b7ec93e35f63cd7bcf0d08df7455693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cars_Cars), @"mvc.1.0.view", @"/Views/Cars/Cars.cshtml")]
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
#line 1 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/_ViewImports.cshtml"
using Car_Renting_agency_admin_panel_ASP.NET_Core_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/_ViewImports.cshtml"
using Car_Renting_agency_admin_panel_ASP.NET_Core_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83dc77a88b7ec93e35f63cd7bcf0d08df7455693", @"/Views/Cars/Cars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0ba397d30efc0b2effc5e86e859d3bbbd374fe2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cars_Cars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cars>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cars", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetCreateView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary rounded-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetEditView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger rounded-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetDeleteView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"row\" style=\"padding-top:20px;padding-bottom:70px\">\n    <div class=\"col-md-3\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83dc77a88b7ec93e35f63cd7bcf0d08df74556935814", async() => {
                WriteLiteral("Add Car");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n    <div class=\"col-md-6\">\n        <h1 class=\"text-center\">Cars</h1>\n    </div>\n   \n    \n\n\n</div>\n");
#nullable restore
#line 16 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
 if (Model.ToList().Count == 0)
{
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center\" style=\"color:maroon\">No cars to show </h1>");
#nullable restore
#line 18 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
                                                                       }
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\" style=\"padding-bottom:40px\">\n            <div class=\"col-md-1\"></div>\n            <div class=\"col-md-5\">\n                <img");
            BeginWriteAttribute("src", " src=\"", 639, "\"", 659, 1);
#nullable restore
#line 28 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
WriteAttributeValue("", 645, item.ImageUrl, 645, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:300px\" ; />\n            </div>\n            <div class=\"col-md-2\"></div>\n            <div class=\"col-md-4\" style=\"padding-bottom:20px\">\n                <h5>");
#nullable restore
#line 32 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
               Write(item.MarkName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n");
#nullable restore
#line 33 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
                 if (item.isCarRented)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <i style=\"color:green\" class= \"bi bi-check\">RENTED</i>\n");
#nullable restore
#line 36 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h8>");
#nullable restore
#line 37 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
               Write(item.ManYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h8>\n                <div class=\"card \"");
            BeginWriteAttribute("style", " style=\"", 1072, "\"", 1131, 4);
            WriteAttributeValue("", 1080, "background-color:", 1080, 17, true);
#nullable restore
#line 38 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
WriteAttributeValue("", 1097, item.Color, 1097, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1108, ";width:30px;", 1108, 12, true);
            WriteAttributeValue(" ", 1120, "height:4px", 1121, 11, true);
            EndWriteAttribute();
            WriteLiteral("></div>\n                <h8>$");
#nullable restore
#line 39 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
                Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h8>\n                <div class=\"row\">\n                    <div style=\"padding-top:10px\" class=\"col-md-2\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83dc77a88b7ec93e35f63cd7bcf0d08df745569311887", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 42 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
                                                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                    <div style=\"padding-top:10px;padding-left:25px\" class=\"col-md-2\">\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83dc77a88b7ec93e35f63cd7bcf0d08df745569314711", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
                                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    </div>\n                </div>\n            </div>\n\n            <hr />\n        </div>\n");
#nullable restore
#line 52 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/me-mac/Work/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Car-Renting-agency-admin-panel-ASP.NET-Core-MVC/Views/Cars/Cars.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cars>> Html { get; private set; }
    }
}
#pragma warning restore 1591
