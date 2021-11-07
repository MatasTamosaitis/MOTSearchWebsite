// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace MOTSearchWebsite.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\_Imports.razor"
using MOTSearchWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\_Imports.razor"
using MOTSearchWebsite.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\AddRegistration.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\AddRegistration.razor"
using SharedLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegisterDetails")]
    public partial class AddRegistration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\AddRegistration.razor"
       

    MOTDetailModel _model = new MOTDetailModel();
    private bool _isSuccesful = false;
    private bool _unsuccesful = false;
    private string _succesfulMessage = "Details succesfully registered!";
    private string _unsuccesfulMessage = "Oops! there was an error registering your details please try again";

    /// <summary>
    /// Post the data to the api to create the registration details.
    /// </summary>
    /// <returns></returns>
    private async Task RegisterMOTDetails()
    {

        // Serialize the data into a json object.
        var content = new StringContent(JsonConvert.SerializeObject(_model), System.Text.Encoding.UTF8, "application/json");

        // Send a post request to insert the details into the database.
        var response = await Http.PostAsync("http://localhost:7071/api/AddMOTRegistration", content);

        // Check if the response has a succesful status.
        if (response.IsSuccessStatusCode)
        {
            _isSuccesful = true;

        }
        else
        {
            _unsuccesful = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
