#pragma checksum "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cfd45af174959c5e22cbfa81dd6f7aa96cd6b37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_AddCategory), @"mvc.1.0.view", @"/Views/Category/AddCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Category/AddCategory.cshtml", typeof(AspNetCore.Views_Category_AddCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cfd45af174959c5e22cbfa81dd6f7aa96cd6b37", @"/Views/Category/AddCategory.cshtml")]
    public class Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Category\AddCategory.cshtml"
  
    ViewData["Title"] = "AddCategory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 30, true);
            WriteLiteral("\r\n<h1>Category Add Page</h1>\r\n");
            EndContext();
#line 8 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Category\AddCategory.cshtml"
 using (Html.BeginForm("AddCategory", "Category", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(242, 34, false);
#line 10 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Category\AddCategory.cshtml"
Write(Html.LabelFor(x => x.CategoryName));

#line default
#line hidden
            EndContext();
            BeginContext(283, 69, false);
#line 11 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Category\AddCategory.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(359, 73, false);
#line 12 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Category\AddCategory.cshtml"
Write(Html.ValidationMessageFor( x=>x.CategoryName,"",new {@style="color:red"}));

#line default
#line hidden
            EndContext();
            BeginContext(434, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(453, 41, false);
#line 15 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Category\AddCategory.cshtml"
Write(Html.LabelFor(x => x.CategoryDescription));

#line default
#line hidden
            EndContext();
            BeginContext(501, 76, false);
#line 16 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Category\AddCategory.cshtml"
Write(Html.TextBoxFor(x => x.CategoryDescription, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(579, 60, true);
            WriteLiteral("    <br/>\r\n    <button class=\"btn btn-info\">Kayıt</button>\r\n");
            EndContext();
#line 19 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Category\AddCategory.cshtml"
}

#line default
#line hidden
            BeginContext(642, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
