#pragma checksum "D:\TCS\DotNet\DotNet Projects\UserCreation\User_Creation\UserCreation\UserCreation.project\Views\User\GetAllUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76650d12e9f327177ddf8071edcce903d9223c1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetAllUsers), @"mvc.1.0.view", @"/Views/User/GetAllUsers.cshtml")]
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
#line 1 "D:\TCS\DotNet\DotNet Projects\UserCreation\User_Creation\UserCreation\UserCreation.project\Views\_ViewImports.cshtml"
using UserCreation.project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TCS\DotNet\DotNet Projects\UserCreation\User_Creation\UserCreation\UserCreation.project\Views\_ViewImports.cshtml"
using UserCreation.project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76650d12e9f327177ddf8071edcce903d9223c1b", @"/Views/User/GetAllUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5975438931573db69ea0d9a3c71c0b1ba9f28c4", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetAllUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UserCreation.project.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\TCS\DotNet\DotNet Projects\UserCreation\User_Creation\UserCreation\UserCreation.project\Views\User\GetAllUsers.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.22/css/jquery.dataTables.css"">

<script type=""text/javascript"" charset=""utf8"" src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.js""></script>

<h1>User details</h1>

<p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76650d12e9f327177ddf8071edcce903d9223c1b5145", async() => {
                WriteLiteral("<i class=\"far fa-plus-square\"></i>Create new");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <input type=""text"" id=""input"" placeholder=""Search""/> <button onclick=""return search()"">Search</button>
</p>
<table class=""table"" id=""Mytable"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Address
            </th>
            <th>
                Email
            </th>
            <th>
                Phone
            </th>
            <th>
                State
            </th>
            <th>
                City
            </th>
            <th>
                Pincode
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 44 "D:\TCS\DotNet\DotNet Projects\UserCreation\User_Creation\UserCreation\UserCreation.project\Views\User\GetAllUsers.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n               \r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76650d12e9f327177ddf8071edcce903d9223c1b7463", async() => {
                WriteLiteral("<i class=\"fa fa-marker fa-lg\"></i>Edit");
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
#nullable restore
#line 49 "D:\TCS\DotNet\DotNet Projects\UserCreation\User_Creation\UserCreation\UserCreation.project\Views\User\GetAllUsers.cshtml"
                                                 WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                    <input type=\"button\" value=\"Delete\" id=\"Del\" class=\"btn btn-primary\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1479, "\"", 1505, 3);
            WriteAttributeValue("", 1489, "Delete(", 1489, 7, true);
#nullable restore
#line 51 "D:\TCS\DotNet\DotNet Projects\UserCreation\User_Creation\UserCreation\UserCreation.project\Views\User\GetAllUsers.cshtml"
WriteAttributeValue("", 1496, item.ID, 1496, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1504, ")", 1504, 1, true);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 54 "D:\TCS\DotNet\DotNet Projects\UserCreation\User_Creation\UserCreation\UserCreation.project\Views\User\GetAllUsers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script type=""text/javascript"">

    $(document).ready(function () {
        $('#Mytable').DataTable({
            ""ajax"": {
                ""url"": ""https://localhost:5001/api/User"",
                ""type"": ""GET""
            },
            ""columns"": [
                { ""data"": ""Name"" },
                { ""data"": ""Address"" },
                { ""data"": ""Email"" },
                { ""data"": ""Phone"" },
                { ""data"": ""State"" },
                { ""data"": ""City"" }
            ]

        });

        function search() {
            var table = $(""#Mytable"").DataTable();
            $('#input').on('keyup', function () {
                table.search(this.value).draw();
            });
        }
        
    });
    

    

    function Delete(id) {

        if (confirm(""Are you sure you want to delete?"")) {
            var userid = id;
            $.ajax({
                url: 'https://localhost:5001/api/User/DeleteUser?id='+ userid,
           ");
            WriteLiteral(@"     type: 'POST',
                data: userid,
                success: function (data, textstatus, xhr) {
                    alert(""Record inserted successfully....."");
                },
                error: function (xhr, textstatus, errorThrown) {
                    console.log('Error in operation');
                }
            });
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UserCreation.project.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
