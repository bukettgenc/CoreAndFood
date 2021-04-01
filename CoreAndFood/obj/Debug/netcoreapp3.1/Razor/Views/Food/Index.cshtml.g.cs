#pragma checksum "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ec660f9416cff87602e9cb07f4516bfb7d4ea9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Food/Index.cshtml", typeof(AspNetCore.Views_Food_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79ec660f9416cff87602e9cb07f4516bfb7d4ea9", @"/Views/Food/Index.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(131, 294, true);
            WriteLiteral(@"
<h1>Food List</h1>
<br />
<table class=""table table-bordered"">
    <tr>
        <th>Id</th>
        <th>Food Name</th>
        <th>Price</th>
        <th>Stock</th>
        <th>Category Name</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Details</th>
    </tr>
");
            EndContext();
#line 20 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
     foreach (var x in Model)   
    {

#line default
#line hidden
            BeginContext(466, 24, true);
            WriteLiteral("<tr>\r\n    <th>\r\n        ");
            EndContext();
            BeginContext(491, 8, false);
#line 24 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.FoodId);

#line default
#line hidden
            EndContext();
            BeginContext(499, 31, true);
            WriteLiteral("\r\n    </th>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(531, 6, false);
#line 27 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Name);

#line default
#line hidden
            EndContext();
            BeginContext(537, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(569, 7, false);
#line 30 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Price);

#line default
#line hidden
            EndContext();
            BeginContext(576, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(608, 7, false);
#line 33 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Stock);

#line default
#line hidden
            EndContext();
            BeginContext(615, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(647, 23, false);
#line 36 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
   Write(x.Category.CategoryName);

#line default
#line hidden
            EndContext();
            BeginContext(670, 33, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 703, "\"", 736, 2);
            WriteAttributeValue("", 710, "/Food/DeleteFood/", 710, 17, true);
#line 39 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 727, x.FoodId, 727, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(737, 69, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n    </td>\r\n\r\n    <td>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 806, "\"", 836, 2);
            WriteAttributeValue("", 813, "/Food/GetFood/", 813, 14, true);
#line 43 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
WriteAttributeValue("", 827, x.FoodId, 827, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(837, 132, true);
            WriteLiteral(" class=\"btn btn-success\">Update</a>\r\n    </td>\r\n    <td>\r\n        <a href=\"#\" class=\"btn btn-info\">Details</a>\r\n    </td>\r\n\r\n</tr>\r\n");
            EndContext();
#line 50 "C:\Users\GENC\source\repos\CoreAndFood\CoreAndFood\Views\Food\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(976, 76, true);
            WriteLiteral("</table>\r\n<a href=\"/Food/AddFood\" class=\"btn btn-primary\">New Food</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591