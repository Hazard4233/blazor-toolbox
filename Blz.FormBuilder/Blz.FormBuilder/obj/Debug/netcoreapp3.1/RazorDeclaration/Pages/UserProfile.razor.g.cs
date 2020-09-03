#pragma checksum "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a63f1283e2e89a8333555e26de4ccb56d323fc5"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blz.FormBuilder.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\_Imports.razor"
using Blz.FormBuilder.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
using Blz.FormBuilder.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmailVerifyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/profile")]
    public partial class UserProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "D:\GIT\blazor-toolbox\Blz.FormBuilder\Blz.FormBuilder\Pages\UserProfile.razor"
       
    public User currentUser;
    public string registerType { get; set; }
    public string currentPassword { get; set; }
    public string newPassword { get; set; }
    public string confirmPassword { get; set; }

    protected override async Task OnInitializedAsync()
    {
        currentUser = new User();
        currentUser = await SessionStorage.GetItemAsync<User>("createdUser");
        if (currentUser.RegisterTypeId == 1)
        {
            registerType = "Register with User Email";
        }
    }

    public async Task ChangePassword()
    {
        Console.WriteLine("change password modal");
        await JSRuntime.InvokeVoidAsync("CloseChangePasswordModal");
    }
    public void GoToHome()
    {
        navigationManager.NavigateTo("/home");
    }
    public void GoToUserLogin()
    {
        ((CustomAuthenticationStateProvider)AuthenticationStateProvider).MarkUserAsLoggedOut();
    }
    public void GoToFBLogin()
    {

    }
    public void GoToGoogleLogin()
    {

    }
    public void GoToTwitterLogin()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService SessionStorage { get; set; }
    }
}
#pragma warning restore 1591
