#pragma checksum "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48da9a8e431409c13e3f457caece57caf1828459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\herri\source\repos\Lab22-Sessions\Views\_ViewImports.cshtml"
using Lab21_MovieRegisteration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\herri\source\repos\Lab22-Sessions\Views\_ViewImports.cshtml"
using Lab21_MovieRegisteration.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48da9a8e431409c13e3f457caece57caf1828459", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3a54cf2a2455759c92c418f96273e25c372ed6a", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Scifi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Action", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Drama", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Animated", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../Movie/MovieResult"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("myFunction()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
  
    ViewData["Title"] = "Movie Registration";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48da9a8e431409c13e3f457caece57caf18284595774", async() => {
                WriteLiteral("\r\n\r\n\r\n    <div class=\"container\">\r\n        <div class=row>\r\n            <div class=\"col-md-2\">\r\n                <label for=\"number\">ID:</label>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n\r\n                ");
#nullable restore
#line 18 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input id=\"Demo\" type=\"number\"");
                BeginWriteAttribute("max", " max=\"", 452, "\"", 471, 1);
#nullable restore
#line 19 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
WriteAttributeValue("", 458, int.MaxValue, 458, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ID\"");
                BeginWriteAttribute("value", " value=\"", 482, "\"", 499, 1);
#nullable restore
#line 19 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
WriteAttributeValue("", 490, Model.ID, 490, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required />\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=row>\r\n            <div class=\"col-md-2\">\r\n                <label for=\"text\">Title:</label>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n\r\n                ");
#nullable restore
#line 30 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input id=\"Demo2\" type=\"text\" maxlength=\"50\" name=\"Title\"");
                BeginWriteAttribute("value", " value=\"", 854, "\"", 874, 1);
#nullable restore
#line 31 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
WriteAttributeValue("", 862, Model.Title, 862, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />
            </div>
        </div>


        <div class=row>
            <div class=""col-md-2"">
                <label for=""genres"">Choose a genre:</label>
            </div>
            <div class=""col-md-4"">
                <select id=""Demo3"" name=""Genre"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48da9a8e431409c13e3f457caece57caf18284598567", async() => {
                    WriteLiteral("Scifi");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48da9a8e431409c13e3f457caece57caf18284599809", async() => {
                    WriteLiteral("Action");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48da9a8e431409c13e3f457caece57caf182845911052", async() => {
                    WriteLiteral("Drama");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48da9a8e431409c13e3f457caece57caf182845912295", async() => {
                    WriteLiteral("Animated");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </select>\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=row>\r\n            <div class=\"col-md-2\">\r\n                <label for=\"number\">Year</label>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n\r\n                ");
#nullable restore
#line 57 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Year));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input id=\"Demo4\" type=\"number\" min=\"1880\" max=\"2020\" name=\"Year\"");
                BeginWriteAttribute("value", " value=\"", 1771, "\"", 1790, 1);
#nullable restore
#line 58 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
WriteAttributeValue("", 1779, Model.Year, 1779, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" required /><br />\r\n            </div>\r\n        </div>\r\n\r\n\r\n        <div class=row>\r\n            <div class=\"col-md-2\">\r\n                <label for=\"text\">Actors:</label>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n\r\n                ");
#nullable restore
#line 69 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Actors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input id=\"Demo5\" type=\"text\" maxlength=\"50\" name=\"Actors\"");
                BeginWriteAttribute("value", " value=\"", 2154, "\"", 2175, 1);
#nullable restore
#line 70 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
WriteAttributeValue("", 2162, Model.Actors, 2162, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <div class=row>\r\n            <div class=\"col-md-2\">\r\n                <label for=\"text\">Directors:</label>\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n\r\n                ");
#nullable restore
#line 82 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
           Write(Html.ValidationMessageFor(m => m.Directors));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <input id =\"Demo6\"type=\"text\" maxlength=\"50\" name=\"Directors\"");
                BeginWriteAttribute("value", " value=\"", 2541, "\"", 2565, 1);
#nullable restore
#line 83 "C:\Users\herri\source\repos\Lab22-Sessions\Views\Movie\Index.cshtml"
WriteAttributeValue("", 2549, Model.Directors, 2549, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n            </div>\r\n        </div>\r\n\r\n\r\n\r\n        <input class=\"btn btn-primary stretched-link\" type=\"submit\" value=\"Register Movie\" />\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script>

    function myFunction() {


        var txtOne = document.getElementById(""Demo"").value;
        var txttwo = document.getElementById(""Demo2"").value;
        var txtthree = document.getElementById(""Demo3"").value;
        var txtfour = document.getElementById(""Demo4"").value;
        var txtfive = document.getElementById(""Demo5"").value;
        var txtsix = document.getElementById(""Demo6"").value;

        window.alert(""Are you sure you want to register this movie?\n""+""ID: ""+txtOne+""\n""+""Title: ""+txttwo+""\n""+""Genre: ""+txtthree+""\n""+""Year: ""+txtfour+""\n""+""Actor: ""+txtfive+""\n""+""Director: ""+txtsix);

     
}
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
