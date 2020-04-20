#pragma checksum "C:\Users\kusta\Documents\CGIpraktika\Movies\Views\Movies\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f69c32eea956690a0fdddda5eae641f9f7f444b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_index), @"mvc.1.0.view", @"/Views/Movies/index.cshtml")]
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
#line 1 "C:\Users\kusta\Documents\CGIpraktika\Movies\Views\_ViewImports.cshtml"
using Movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kusta\Documents\CGIpraktika\Movies\Views\_ViewImports.cshtml"
using Movies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f69c32eea956690a0fdddda5eae641f9f7f444b7", @"/Views/Movies/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40a18b89cee963ad76943c7d00438584920fea09", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\kusta\Documents\CGIpraktika\Movies\Views\Movies\index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""app"">
    <ul class=""list-group"">
        <li class=""list-group-item"" v-for=""movie in info"">
            <div>
                <p class=""text-primary font-weight-bold"" style=""display: inline;"">Title:</p> {{ movie.title }}<br>
                <p v-for=""cat in cats"" v-if=""movie.categoryId == cat.id"" style=""display: inline;""> <label class=""text-primary font-weight-bold"" style=""display: inline;"">Category:</label> {{ cat.name }}</p> <br>
                <p class=""text-primary font-weight-bold"" style=""display: inline;"">Year:</p> {{ movie.year }}<br>
                <p class=""text-primary font-weight-bold"" style=""display: inline;"">Rating:</p> {{ movie.rating }}/10<br>
            </div>
            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#exampleModal"" v-bind:data-id=""movie.id"">
              Show more
            </button>
        </li>
        </div>
        <li id=""notfound"" class=""list-group-item"" v-if=""show"">
            <div class=""text-center"">");
            WriteLiteral(@"
                <h2 class=""text-danger"">No movie found with that name</h2>
                <button type=""button"" class=""btn btn-primary"" v-on:click=""showall"">Show all</button>
            </div>
        </li>
    </ul>
  <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""title"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
      <div class=""modal-content"">
        <div class=""modal-header"">
          <h5 class=""modal-title"" id=""title"">Movie</h5>
          <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
          </button>
        </div>
        <div class=""modal-body"">
            <p id=""desc""></p>
            <label class=""text-primary font-weight-bold"">Rating: </label><p id=""rating""></p>
            <label class=""text-primary font-weight-bold"">Year: </label><p id=""year""></p>
        </div>
        <div class=""modal-footer"">
          <button type=""but");
            WriteLiteral("ton\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n");
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
