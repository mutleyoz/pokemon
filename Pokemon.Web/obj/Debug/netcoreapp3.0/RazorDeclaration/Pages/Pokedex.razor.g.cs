#pragma checksum "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\Pages\Pokedex.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0362e96ab371bbc9402d01ebaf56692632aaaa5f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Pokemon.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\_Imports.razor"
using Pokemon.Web;

#line default
#line hidden
#line 7 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\_Imports.razor"
using Pokemon.Web.Shared;

#line default
#line hidden
#line 1 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\Pages\Pokedex.razor"
using Pokemon.Models;

#line default
#line hidden
#line 2 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\Pages\Pokedex.razor"
using Pokemon.Services;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/pokedex")]
    public class Pokedex : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
        }
        #pragma warning restore 1998
#line 27 "D:\Development\aspnetcore\blazor\pokemon\Pokemon.Web\Pages\Pokedex.razor"
       
private string pokemonName { get; set; }
private PokemonAttributes pokemon { get; set; }

protected async void FetchPokemonAsync()
{
    if (!string.IsNullOrEmpty(pokemonName))
    {
        pokemon = await pokemonService.GetPokemonAsync(pokemonName);
        this.StateHasChanged();
    }
}

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private PokemonService pokemonService { get; set; }
    }
}
#pragma warning restore 1591
