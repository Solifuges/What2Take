#pragma checksum "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\Review.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5984ad3a624bb62d7072162f650f33a220d5ce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(What2Take.Pages.Pages_Review), @"mvc.1.0.razor-page", @"/Pages/Review.cshtml")]
namespace What2Take.Pages
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
#line 1 "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\_ViewImports.cshtml"
using What2Take;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5984ad3a624bb62d7072162f650f33a220d5ce9", @"/Pages/Review.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"989899d41cfb710b24d6c3475d03893343c19989", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Review : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\Review.cshtml"
  
    ViewData["Title"] = "Reviews";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5984ad3a624bb62d7072162f650f33a220d5ce93126", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"css\\review.css\" type=\"text/css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<h1>");
#nullable restore
#line 11 "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\Review.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"leftcolumn\">\r\n");
#nullable restore
#line 16 "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\Review.cshtml"
         foreach (var crs in Model.Courses)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\r\n                <h2>");
#nullable restore
#line 19 "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\Review.cshtml"
               Write(crs.code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <div>\r\n                    <p><b>Grade Received</b>\r\n                        ");
#nullable restore
#line 22 "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\Review.cshtml"
                   Write(crs.grade);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p><b>Class Difficulty:</b>\r\n                        ");
#nullable restore
#line 25 "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\Review.cshtml"
                   Write(crs.difficulty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <p><b>Comment:</b>\r\n                        ");
#nullable restore
#line 28 "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\Review.cshtml"
                   Write(crs.comments);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 32 "C:\Users\Administrator\Documents\Work Projects\ADM4379\What2Take\What2Take\Pages\Review.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ReviewModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ReviewModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ReviewModel>)PageContext?.ViewData;
        public ReviewModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
