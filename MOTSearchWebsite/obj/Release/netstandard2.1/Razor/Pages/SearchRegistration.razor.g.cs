#pragma checksum "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c6f010564abc52faab3c2c4722fc784d3a975cf"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
using SharedLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/SearchRegistration")]
    public partial class SearchRegistration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 font-size:25px\">Please enter registration number.</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                  _model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                          SearchRegistrationNumber

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "form-inline");
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(11);
                __builder2.AddAttribute(12, "class", "form-control mr-1");
                __builder2.AddAttribute(13, "style", "border:1px solid");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 11 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                                                                   _model.RegistrationNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _model.RegistrationNumber = __value, _model.RegistrationNumber))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _model.RegistrationNumber));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        <input class=\"btn btn-primary client-btn\" type=\"submit\" value=\"Search Registration\">\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col-md-5");
                __Blazor.MOTSearchWebsite.Pages.SearchRegistration.TypeInference.CreateValidationMessage_0(__builder2, 21, 22, 
#nullable restore
#line 14 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                                    () => _model.RegistrationNumber

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(23, " ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n\r\n\r\n");
#nullable restore
#line 18 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
 if (_isRetrieved)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "    ");
            __builder.AddMarkupContent(27, "<h3 style=\"padding: 10px\">Your MOT Details:</h3>\r\n");
            __builder.AddContent(28, "    ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "row");
            __builder.AddAttribute(31, "style", "padding: 10px");
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.AddMarkupContent(33, "<div class=\"col-6 col-md-2\" style=\"font-weight: bold\">\r\n            <label>Registration Number: </label>\r\n        </div>\r\n\r\n        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-10");
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "label");
            __builder.AddAttribute(38, "class", "col-2");
            __builder.AddAttribute(39, "style", "text-decoration: underline");
            __builder.AddContent(40, 
#nullable restore
#line 28 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                                                     _vehicleDetails.RegistrationNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.AddContent(44, "    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "row");
            __builder.AddAttribute(47, "style", "padding: 10px");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.AddMarkupContent(49, "<div class=\"col\" style=\"font-weight: bold\">\r\n            <label>Make: </label>\r\n        </div>\r\n\r\n        ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-10");
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenElement(53, "label");
            __builder.AddAttribute(54, "class", "col-2");
            __builder.AddAttribute(55, "style", "text-decoration: underline");
            __builder.AddContent(56, 
#nullable restore
#line 40 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                                                     _vehicleDetails.Make

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n");
            __builder.AddContent(60, "    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.AddAttribute(63, "style", "padding: 10px");
            __builder.AddMarkupContent(64, "\r\n        ");
            __builder.AddMarkupContent(65, "<div class=\"col\" style=\"font-weight: bold\">\r\n            <label>Model: </label>\r\n        </div>\r\n\r\n        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "col-10");
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "label");
            __builder.AddAttribute(70, "class", "col-2");
            __builder.AddAttribute(71, "style", "text-decoration: underline");
            __builder.AddContent(72, 
#nullable restore
#line 52 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                                                     _vehicleDetails.Model

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.AddContent(76, "    ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row");
            __builder.AddAttribute(79, "style", "padding: 10px");
            __builder.AddMarkupContent(80, "\r\n        ");
            __builder.AddMarkupContent(81, "<div class=\"col\" style=\"font-weight: bold\">\r\n            <label>Color: </label>\r\n        </div>\r\n\r\n        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "col-10");
            __builder.AddMarkupContent(84, "\r\n            ");
            __builder.OpenElement(85, "label");
            __builder.AddAttribute(86, "class", "col-2");
            __builder.AddAttribute(87, "style", "text-decoration: underline");
            __builder.AddContent(88, 
#nullable restore
#line 64 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                                                     _vehicleDetails.Colour

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n");
            __builder.AddContent(92, "    ");
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "row");
            __builder.AddAttribute(95, "style", "padding: 10px");
            __builder.AddMarkupContent(96, "\r\n\r\n        ");
            __builder.AddMarkupContent(97, "<div class=\"col\" style=\"font-weight: bold\">\r\n            <label>Expiry Date: </label>\r\n        </div>\r\n\r\n        ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-10");
            __builder.AddMarkupContent(100, "\r\n            ");
            __builder.OpenElement(101, "label");
            __builder.AddAttribute(102, "class", "col-2");
            __builder.AddAttribute(103, "style", "text-decoration: underline");
            __builder.AddContent(104, 
#nullable restore
#line 78 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                                                     _vehicleDetails.ExpiryDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n");
            __builder.AddContent(108, "    ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "row");
            __builder.AddAttribute(111, "style", "padding: 10px");
            __builder.AddMarkupContent(112, "\r\n        ");
            __builder.AddMarkupContent(113, "<div class=\"col\" style=\"font-weight: bold\">\r\n            <label>Milage at Last MOT: </label>\r\n        </div>\r\n\r\n        ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "col-10");
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.OpenElement(117, "label");
            __builder.AddAttribute(118, "class", "col-2");
            __builder.AddAttribute(119, "style", "text-decoration: underline");
            __builder.AddContent(120, 
#nullable restore
#line 90 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                                                     _vehicleDetails.Milage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(121, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n");
#nullable restore
#line 95 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 97 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
 if (_unsuccesful)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "    ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col-md-5");
            __builder.AddMarkupContent(128, "\r\n\r\n        ");
            __builder.OpenElement(129, "label");
            __builder.AddAttribute(130, "style", "color: red; font-size: 20px");
            __builder.AddContent(131, 
#nullable restore
#line 101 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
                                                    _unsuccesfulMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(132, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(133, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n");
#nullable restore
#line 103 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Repositories\MOTSearchWebsite\MOTSearchWebsite\Pages\SearchRegistration.razor"
       

    private string _registrarionNumber { get; set; }
    MOTDetailModel _vehicleDetails;
    // This is a helper instance object so I can validate if a user has entered too many characters or entered nothing at all.
    RegistrationNumberModel _model = new RegistrationNumberModel();
    private bool _isRetrieved = false;
    private bool _unsuccesful = false;
    private string _unsuccesfulMessage = "Oops! there was an error retrieving your details please check if the registration number is correct";

    /// <summary>
    /// Perform a get request to retrieve vehicle details based on the registration number.
    /// </summary>
    /// <returns></returns>
    private async Task SearchRegistrationNumber()
    {
        var response = await http.GetAsync($"http://localhost:7071/api/SearchRegistration?Registration={_model.RegistrationNumber}");

        if (response.IsSuccessStatusCode)
        {
            // Read the json data.
            var something = response.Content.ReadAsStringAsync().Result;

            // Deserialize the data as vehicle detail model.
            _vehicleDetails = JsonConvert.DeserializeObject<MOTDetailModel>(something);
            _isRetrieved = true;
        }
        else
        {
            // If there was an error on the api to retrieve the details display a meaningful message.
            _unsuccesful = true;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.MOTSearchWebsite.Pages.SearchRegistration
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
