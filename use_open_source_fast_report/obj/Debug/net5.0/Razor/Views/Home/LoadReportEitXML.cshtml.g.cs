#pragma checksum "D:\Tai_Lieu\Test_open_fast_report\use_open_source_fast_report\Views\Home\LoadReportEitXML.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "33a14851bfca1cadfa0c7bfa646ea7b2e8f96744afdfbb3d5cd989ec628c6544"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LoadReportEitXML), @"mvc.1.0.view", @"/Views/Home/LoadReportEitXML.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Tai_Lieu\Test_open_fast_report\use_open_source_fast_report\Views\_ViewImports.cshtml"
using use_open_source_fast_report;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tai_Lieu\Test_open_fast_report\use_open_source_fast_report\Views\_ViewImports.cshtml"
using use_open_source_fast_report.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"33a14851bfca1cadfa0c7bfa646ea7b2e8f96744afdfbb3d5cd989ec628c6544", @"/Views/Home/LoadReportEitXML.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d955af4a3dd8abf435b119cbe3a58527c6ca000dcc0872ade2e72a7e82c4f29f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_LoadReportEitXML : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tai_Lieu\Test_open_fast_report\use_open_source_fast_report\Views\Home\LoadReportEitXML.cshtml"
  
    ViewData["Title"] = "Report từ sửa XML";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row mt-2\">\r\n    ");
#nullable restore
#line 5 "D:\Tai_Lieu\Test_open_fast_report\use_open_source_fast_report\Views\Home\LoadReportEitXML.cshtml"
Write(await ViewBag.WebReport.Render());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</div>
<hr />
<div class=""row"">
    <button class=""btn btn-dark"" data-bs-toggle=""modal"" data-bs-target=""#myModal"" onclick=""clearTextBox();"">Sửa XML</button><br /><br />
</div>
<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog modal-xl"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-bs-dismiss=""modal"">×</button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33a14851bfca1cadfa0c7bfa646ea7b2e8f96744afdfbb3d5cd989ec628c65444624", async() => {
                WriteLiteral("\r\n                    <textarea style=\"height:800px; width:1100px\" id=\"content\">");
#nullable restore
#line 19 "D:\Tai_Lieu\Test_open_fast_report\use_open_source_fast_report\Views\Home\LoadReportEitXML.cshtml"
                                                                         Write(ViewBag.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-primary"" id=""btnAdd"" onclick=""Update();"">Sửa</button>
                <button type=""button"" class=""btn btn-default"" data-bs-dismiss=""modal"">Đóng</button>
            </div>
        </div>
    </div>
</div>
<script>
    function Update() {

        var content = $('#content').val();

        var data = new FormData();
        data.append(""content"", content);
        $.ajax({
            url: ""/Home/GetContenFromXML"",
            type: ""POST"",
            data: data,
            contentType: false,
            processData: false,
            success: function (result) {
                console.log(result)
                $('#myModal').modal('hide');
            },
            error: function (errormessage) {
                alert(errormessage.responseText);
            }
        });

        window.location = ""/Home/LoadReportEitXML""
    }
</script>



");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591