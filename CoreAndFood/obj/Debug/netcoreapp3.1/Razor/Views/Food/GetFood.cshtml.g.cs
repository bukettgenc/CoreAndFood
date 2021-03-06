#pragma checksum "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "422989e06be7e0de2d11fcb8fd3cf3ce9587962f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_GetFood), @"mvc.1.0.view", @"/Views/Food/GetFood.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Food/GetFood.cshtml", typeof(AspNetCore.Views_Food_GetFood))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"422989e06be7e0de2d11fcb8fd3cf3ce9587962f", @"/Views/Food/GetFood.cshtml")]
    public class Views_Food_GetFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Data.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
  
    ViewData["Title"] = "GetFood";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 26, true);
            WriteLiteral("\r\n<h1>Food Add Page</h1>\r\n");
            EndContext();
#line 8 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
 using (Html.BeginForm("FoodUpdate", "Food", FormMethod.Post))
{
    

#line default
#line hidden
            BeginContext(225, 27, false);
#line 10 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.HiddenFor(x=>x.FoodId));

#line default
#line hidden
            EndContext();
            BeginContext(261, 23, false);
#line 12 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.Label("Food Name"));

#line default
#line hidden
            EndContext();
            BeginContext(291, 61, false);
#line 13 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(354, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(373, 19, false);
#line 16 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.Label("Stock"));

#line default
#line hidden
            EndContext();
            BeginContext(399, 62, false);
#line 17 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextBoxFor(x => x.Stock, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(463, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(482, 19, false);
#line 20 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.Label("Price"));

#line default
#line hidden
            EndContext();
            BeginContext(508, 62, false);
#line 21 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextBoxFor(x => x.Price, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(572, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(589, 19, false);
#line 23 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.Label("Image"));

#line default
#line hidden
            EndContext();
            BeginContext(615, 65, false);
#line 24 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(682, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
            BeginContext(699, 22, false);
#line 26 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.Label("Category"));

#line default
#line hidden
            EndContext();
            BeginContext(728, 110, false);
#line 27 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.DropDownListFor(x => x.CategoryId, (List<SelectListItem>)ViewBag.values, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(840, 13, true);
            WriteLiteral("    <br /> \r\n");
            EndContext();
            BeginContext(858, 25, false);
#line 29 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.Label("Description"));

#line default
#line hidden
            EndContext();
            BeginContext(890, 69, false);
#line 30 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
Write(Html.TextAreaFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(961, 64, true);
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-primary\">Kay??t</button>\r\n");
            EndContext();
#line 33 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
}

#line default
#line hidden
            BeginContext(1028, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Data.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
