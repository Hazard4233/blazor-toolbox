#pragma checksum "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\TextEntryFormControl.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f99b1a95dda8fefae998bcbcdf6527359bb6eb43"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class TextEntryFormControl : BaseEditorControl
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\TextEntryFormControl.razor"
       
    [Parameter]
    public string EntryText { get; set; }
    [Parameter]
    public string EntryBg { get; set; }
    [Parameter]
    public EventCallback<string> EntryTextChanged { get; set; }

    public TextEntryFormControl() { }

    public TextEntryFormControl(string textEntry, string bg)
    {
        this.EntryText = textEntry;
        if (bg == "default")
        {
            this.EntryBg = "#5f9ea0";
        }else
        {
            this.EntryBg = bg;
        }
    }

    private async void ClickTextEntryText(string name, string bgcolor)
    {
        await JSRuntime.InvokeVoidAsync("FormDesignerJs.setControlProperty", this.Index);
    }
    private void OnEntryTextChanged(ChangeEventArgs e)
    {
        this.EntryText = e.Value.ToString();
    }

    public async void EntryControlClick(string name, string bgcolor) {

        await JSRuntime.InvokeVoidAsync("FormDesignerJs.removeHighlightCss", this.Index);
        await JSRuntime.InvokeVoidAsync("FormDesignerJs.setControlProperty", this.Index);

    }
    public async void changeEntryText(ChangeEventArgs args)
    {
        this.EntryText = args.Value.ToString();
        TextEntryFormControl current_entryForm = CurrentForm.AllControls[this.Index] as TextEntryFormControl;
        current_entryForm.EntryText = this.EntryText;
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
