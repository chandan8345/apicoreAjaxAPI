#pragma checksum "C:\Users\Admin\Source\Repos\chandan8345\apicore\Mafia\Mafia\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc6a785097851b250bb7354d1d65e13554c7ebf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Admin\Source\Repos\chandan8345\apicore\Mafia\Mafia\Views\_ViewImports.cshtml"
using Mafia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\Source\Repos\chandan8345\apicore\Mafia\Mafia\Views\_ViewImports.cshtml"
using Mafia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc6a785097851b250bb7354d1d65e13554c7ebf", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db6fc1755ebbc5458c68711af2494ecbd0aacf6e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("employee-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Admin\Source\Repos\chandan8345\apicore\Mafia\Mafia\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .loader {
        margin: auto;
        left: 0;
        right: 0;
        top: 0;
        bottom: 0;
        position: absolute;
    }
</style>


<div id=""div_Loader"">
    <img src=""https://www.boasnotas.com/img/loading2.gif"" width=""100px"" height=""100px"" alt=""loader"" class=""loader"" />
</div>
<div class=""container-fluid"">
    <div class=""container"">
        <div class=""card"">
            <div class=""card-header"">
                Featured
            </div>
            <div class=""card-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dc6a785097851b250bb7354d1d65e13554c7ebf4764", async() => {
                WriteLiteral("\r\n                    <div class=\"form-row\">\r\n                        <div class=\"form-group col-md-3\">\r\n                            <label for=\"inputEmail4\">Name</label>\r\n                            <input type=\"text\" class=\"form-control\" id=\"name\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 866, "\"", 880, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group col-md-3\">\r\n                            <label for=\"inputPassword4\">Email</label>\r\n                            <input type=\"email\" class=\"form-control\" id=\"email\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1125, "\"", 1139, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"form-group col-md-3\">\r\n                            <label for=\"inputPassword4\">Age</label>\r\n                            <input type=\"number\" class=\"form-control\" id=\"age\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1381, "\"", 1395, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""form-group col-md-3"">
                            <label for=""inputState"">Designation</label>
                            <select id=""designation"" class=""form-control"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dc6a785097851b250bb7354d1d65e13554c7ebf6588", async() => {
                    WriteLiteral("Select One");
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
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <div class=""form-row"">

                        <div class=""form-group col-md-2"">
                            <label for=""inputState""></label>
                            <button type=""submit"" class=""btn btn-primary form-control"" style=""margin-top:8px;"">Submit</button>
                        </div>
                    </div>

                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
        </div>
        <br />
        <table id=""example"" class=""table table-striped table-bordered"">
            <thead class=""thead-primary"">
                <tr>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Age</th>
                    <th scope=""col"">Designation</th>
                    <th scope=""col"">Action</th>
                </tr>
            </thead>
            <tbody>
            </tbody>
        </table>
    </div>
</div>
<script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
<script type=""text/javascript"" src=""https://code.jquery.com/jquery-3.5.1.js""></script>
<script src=""https://cdn.datatables.net/1.13.1/js/jquery.dataTables.min.js""></script>
<script src=""https://cdn.datatables.net/1.13.1/js/dataTables.bootstrap4.min.js""></script>
<script type=""text/javascript"">
    jQuery(document).ready(function ($) {
        $(function () {
            $('#ex");
            WriteLiteral(@"ample').DataTable({});

            $('#employee-form').on('submit', function (e) {
                e.preventDefault();
                var postData = {
                    ""name"": $(""#name"").val(),
                    ""email"": $(""#email"").val(),
                    ""age"": $(""#age"").val(),
                    ""designation"": $(""#designation"").val()
                }
                swal({
                    title: 'Do you want to Save ?',
                    showCancelButton: true,
                    showConfirmButton: true,
                    confirmButtonText: 'Yes',
                    cancelButtonText: 'No',
                    confirmButtonClass: 'btn btn-primary',
                    cancelButtonClass: 'btn btn-danger',
                    icon: 'warning',
                    buttonsStyling: true,
                    buttons: true,
                    buttons: [""No"", ""Yes""]
                }).then(function (yes) {
                    if (yes) {
                        $.ajax({");
            WriteLiteral(@"
                            type: ""POST"",
                            url: '/api/test/employeeInsert',
                            contentType: 'application/json',
                            data: JSON.stringify(postData),
                            beforeSend: function () {
                                Show();
                            },
                            success: function (data) {
                                console.log(data);
                                Hide();
                                $.ajax({
                                    type: 'GET',
                                    url: '/api/test',
                                    dataType: 'JSON',
                                    success: function (data) {
                                        $('#example').dataTable().fnClearTable();
                                        $('#example').dataTable().fnDestroy();
                                        
                                        $.each(");
            WriteLiteral(@"data, function (index) {
                                            $('#example tbody').append('<tr><td>' + data[index][""name""] + '</td><td>' + data[index][""email""] + '</td><td>' + data[index][""age""] + '</td><td>' + data[index][""designation""] + '</td><td> <a href="""" class=""btn btn-primary btn-sm"" type=""button"">Edit</a>  <button type=""button"" onclick=""deleteEmployee(' + data[index][""id""] + ')"" class=""btn btn-danger btn-sm"">Delete</button></td></tr>');
                                        });
                                        $('#example').DataTable({
                                            ""destroy"": true,
                                        });
                                        // remove previously loaded options

                                    }
                                });
                                swal(""Message"", ""Data Saved Successfully!"", ""success"");
                            },
                            error: function () {
                     ");
            WriteLiteral(@"           swal(""Message"", ""Something went wrong!"", ""error"");
                            }
                        });
                    }
                });
            });

            $.ajax({
                type: 'GET',
                url: '/api/test/Designation',
                dataType: 'JSON',
                success: function (data) {
                    console.log(data);
                    // remove previously loaded options
                    for (i in data) {
                        $('#designation').append('<option value = ' + data[i].id + '>' + data[i].name + '</option>');
                    }
                }
            });

            $.ajax({
                type: 'GET',
                url: '/api/test',
                dataType: 'JSON',
                success: function (data) {
                    $('#example').dataTable().fnClearTable();
                    $('#example').dataTable().fnDestroy();
                    $.each(data, function (index) {
  ");
            WriteLiteral(@"                      $('#example tbody').append('<tr><td>' + data[index][""name""] + '</td><td>' + data[index][""email""] + '</td><td>' + data[index][""age""] + '</td><td>' + data[index][""designation""] + '</td><td> <a href="""" class=""btn btn-primary btn-sm"" type=""button"">Edit</a>  <button type=""button"" onclick=""deleteEmployee(' + data[index][""id""] +')"" class=""btn btn-danger btn-sm"">Delete</button></td></tr>');
                    });
                    $('#example').DataTable({
                        ""destroy"": true,
                    });

                    // remove previously loaded options

                }
            });

            $(document).ready(function () {
                $(""#div_Loader"").hide();
            });

            function Show() {
                $('#div_Loader').show();
            }

            function Hide() {
                $('#div_Loader').hide();
            }
        });
    });
</script>

<script type=""text/javascript"">
    function deleteEmploy");
            WriteLiteral(@"ee(id) {
            $.ajax({
                type: 'DELETE',
                url: '/api/test/'+id,
                success: function (data) {
                    console.log(data);
                    alert('Delete Successfully');
                     window.location.reload();
                }
            });
    }
</script>");
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
