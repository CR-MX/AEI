#pragma checksum "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0ac977cbef80f1c7760d07e337604274c13e468"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customer/Index.cshtml", typeof(AspNetCore.Views_Customer_Index))]
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
#line 1 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\_ViewImports.cshtml"
using ResHotel;

#line default
#line hidden
#line 2 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\_ViewImports.cshtml"
using ResHotel.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0ac977cbef80f1c7760d07e337604274c13e468", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6a2b56a1ea4d0ea5deb768faa449ec43bce6cc7", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ResHotel.Models.Customer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Clientes";

#line default
#line hidden
            BeginContext(92, 32, true);
            WriteLiteral("\r\n<h1>Clientes</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(124, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0ac977cbef80f1c7760d07e337604274c13e4684692", async() => {
                BeginContext(147, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(161, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(254, 49, false);
#line 16 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerTitle));

#line default
#line hidden
            EndContext();
            BeginContext(303, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(359, 53, false);
#line 19 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(412, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(468, 52, false);
#line 22 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(520, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(576, 47, false);
#line 25 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(623, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(679, 57, false);
#line 28 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(736, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(792, 55, false);
#line 31 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(847, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(903, 58, false);
#line 34 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(961, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1017, 61, false);
#line 37 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1134, 53, false);
#line 40 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1243, 53, false);
#line 43 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1296, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1352, 54, false);
#line 46 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerMobilPhone));

#line default
#line hidden
            EndContext();
            BeginContext(1406, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1462, 55, false);
#line 49 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CustomerCustomEmail));

#line default
#line hidden
            EndContext();
            BeginContext(1517, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 55 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1635, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1684, 48, false);
#line 58 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerTitle));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1788, 52, false);
#line 61 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerForenames));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1896, 51, false);
#line 64 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerSurnames));

#line default
#line hidden
            EndContext();
            BeginContext(1947, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2003, 46, false);
#line 67 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerDOB));

#line default
#line hidden
            EndContext();
            BeginContext(2049, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2105, 56, false);
#line 70 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAddressStreet));

#line default
#line hidden
            EndContext();
            BeginContext(2161, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2217, 54, false);
#line 73 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAddressTown));

#line default
#line hidden
            EndContext();
            BeginContext(2271, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2327, 57, false);
#line 76 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAddressCountry));

#line default
#line hidden
            EndContext();
            BeginContext(2384, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2440, 60, false);
#line 79 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerAddressPostalCode));

#line default
#line hidden
            EndContext();
            BeginContext(2500, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2556, 52, false);
#line 82 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerHomePhone));

#line default
#line hidden
            EndContext();
            BeginContext(2608, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2664, 52, false);
#line 85 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerWorkPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2716, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2772, 53, false);
#line 88 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerMobilPhone));

#line default
#line hidden
            EndContext();
            BeginContext(2825, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2881, 54, false);
#line 91 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CustomerCustomEmail));

#line default
#line hidden
            EndContext();
            BeginContext(2935, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2990, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0ac977cbef80f1c7760d07e337604274c13e46816656", async() => {
                BeginContext(3043, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
                                       WriteLiteral(item.CustomerID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3051, 19, true);
            WriteLiteral(" \r\n                ");
            EndContext();
            BeginContext(3070, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0ac977cbef80f1c7760d07e337604274c13e46819002", async() => {
                BeginContext(3126, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
                                          WriteLiteral(item.CustomerID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3137, 19, true);
            WriteLiteral(" \r\n                ");
            EndContext();
            BeginContext(3156, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0ac977cbef80f1c7760d07e337604274c13e46821354", async() => {
                BeginContext(3211, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 96 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
                                         WriteLiteral(item.CustomerID);

#line default
#line hidden
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
            EndContext();
            BeginContext(3221, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 99 "d:\todo\Uni\7B\Aplicaciones\git\AEI\ResHotel\Views\Customer\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3260, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ResHotel.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591