#pragma checksum "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a43e8526b7e30786a1d50a4c9635b1eb09f01ff0"
// <auto-generated/>
#pragma warning disable 1591
namespace Blz.FormBuilder.Controls
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder.Shared;

#line default
#line hidden
#nullable disable
    public partial class HeaderFormControl : BaseEditorControl
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row control-div");
            __builder.AddAttribute(2, "style", "cursor:move");
            __builder.AddAttribute(3, "draggable", "true");
            __builder.AddAttribute(4, "ondragstart", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor"
                                                                                OnDragStart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 4 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor"
                                                                                                         e=>clickHeaderControl(HeaderText, HeaderInputBg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "label");
            __builder.AddAttribute(8, "style", "cursor:move");
            __builder.AddContent(9, 
#nullable restore
#line 5 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor"
                                HeaderText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "HeaderControl");
            __builder.AddAttribute(13, "style", "background-color:" + (
#nullable restore
#line 8 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor"
                                 HeaderInputBg

#line default
#line hidden
#nullable disable
            ) + ";" + " color:" + " white;");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "value", 
#nullable restore
#line 10 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor"
                HeaderText

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor"
                    () => ClickHeaderText(HeaderText, HeaderInputBg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor"
                     e=>changeHeaderText(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor"
                  OnHeaderTextChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\HeaderFormControl.razor"
      
    [Parameter]
    public string HeaderText { get; set; }
    [Parameter]
    public string HeaderInputBg { get; set; }
    [Parameter]
    public string ControlNameFromProperty { get; set; }
    [Parameter]
    public string ControlBgFromProperty { get; set; }

    public HeaderFormControl() { }

    public HeaderFormControl(string headertext, string headerbg)
    {
        this.HeaderText = headertext;
        if(headerbg == "default")
        {
            this.HeaderInputBg = "#8a2be2";
        }else
        {
            this.HeaderInputBg = headerbg;
        }
    }

    private async void ClickHeaderText(string name, string bgcolor)
    {
        await JSRuntime.InvokeVoidAsync("FormDesignerJs.removeHighlightCss", this.Index);
        await JSRuntime.InvokeVoidAsync("FormDesignerJs.setControlProperty", this.Index);
    }
    private void OnHeaderTextChanged(ChangeEventArgs e)
    {
        this.HeaderText = e.Value.ToString();
    }

    private async void changeHeaderText(ChangeEventArgs args)
    {
        this.HeaderText = args.Value.ToString();
        HeaderFormControl current_HeaderForm = CurrentForm.AllControls[this.Index] as HeaderFormControl;
        current_HeaderForm.HeaderText = this.HeaderText ;
        await JSRuntime.InvokeVoidAsync("FormDesignerJs.setControlProperty", this.Index);
    }

    public async void clickHeaderControl(string name, string bgcolor)
    {
        await JSRuntime.InvokeVoidAsync("FormDesignerJs.removeHighlightCss", this.Index);
        await JSRuntime.InvokeVoidAsync("FormDesignerJs.setControlProperty", this.Index);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
