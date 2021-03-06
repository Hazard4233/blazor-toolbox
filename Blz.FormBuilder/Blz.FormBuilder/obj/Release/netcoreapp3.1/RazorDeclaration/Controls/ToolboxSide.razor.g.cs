#pragma checksum "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\ToolboxSide.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87529fbe29996efb134eb87201c8e87314ae0cbe"
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
#nullable restore
#line 1 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\ToolboxSide.razor"
using Blz.FormBuilder.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\ToolboxSide.razor"
using Blz.FormBuilder.Controls;

#line default
#line hidden
#nullable disable
    public partial class ToolboxSide : BaseEditorControl
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Hazard\source\repos\Blz.FormBuilder\Blz.FormBuilder\Controls\ToolboxSide.razor"
       
    public List<BaseEditorControl> AllControls { get; set; }
    public BaseEditorControl NewControl { get; set; }
    [Parameter]
    public EventCallback<BaseEditorControl> CreateNewControl { get; set; }
    public ToolboxSide() { }
    [Parameter]
    public EventCallback OnNewHeaderDragEndEvent { get; set; }
    [Parameter]
    public EventCallback OnNewEntryDragEndEvent { get; set; }

    public void OnNewHeaderDragStart()
    {
        HeaderFormControl newHeaderControl = new HeaderFormControl("New Header Control");
        this.NewControl = newHeaderControl;
        Console.WriteLine("New HeaderControl Drag Start");
    }
    public void OnNewEntryDragStart()
    {
        TextEntryFormControl newTextEntryControl = new TextEntryFormControl("New TextEntry Control");
        Console.WriteLine("New TextEntryControl Drag Start");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
