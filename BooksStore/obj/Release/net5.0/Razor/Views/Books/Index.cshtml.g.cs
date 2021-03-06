#pragma checksum "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e85751e3968e19519bb5b4f451e93cf08bcbaa25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
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
#line 1 "/Users/sami/projects/BooksStore/BooksStore/Views/_ViewImports.cshtml"
using BooksStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/sami/projects/BooksStore/BooksStore/Views/_ViewImports.cshtml"
using BooksStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e85751e3968e19519bb5b4f451e93cf08bcbaa25", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b9992f57d46cd50ddd584ad24c470eca29d443", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
  
    var books = (List<BookModel>)ViewData["Books"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Title</th>
            <th scope=""col"">Author</th>
            <th scope=""col"">Price</th>
            <th scope=""col"">Image</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 19 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
         foreach (var book in books)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th scope=\"row\">");
#nullable restore
#line 22 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
                       Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <td>");
#nullable restore
#line 23 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
           Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 24 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
           Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
           Write(book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td><img style=\"width:200px;height:200px\"");
            BeginWriteAttribute("src", " src=\"", 595, "\"", 612, 1);
#nullable restore
#line 26 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
WriteAttributeValue("", 601, book.Image, 601, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 613, "\"", 630, 1);
#nullable restore
#line 26 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
WriteAttributeValue("", 619, book.Image, 619, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></td>\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 658, "\"", 688, 2);
            WriteAttributeValue("", 665, "/books/details/", 665, 15, true);
#nullable restore
#line 27 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
WriteAttributeValue("", 680, book.Id, 680, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button type=\"button\" class=\"btn btn-primary\">Show</button></a></td>\n        </tr>\n");
#nullable restore
#line 29 "/Users/sami/projects/BooksStore/BooksStore/Views/Books/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </tbody>\n</table>\n");
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
