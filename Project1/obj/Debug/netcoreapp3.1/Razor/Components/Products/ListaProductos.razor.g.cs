#pragma checksum "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89c2894a8ddf3be8bbece6aecaab70bd9a0f77b1"
// <auto-generated/>
#pragma warning disable 1591
namespace Project1.Components.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using Project1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using Project1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\_Imports.razor"
using Project1.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
using Bussiness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
using DevExpress.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    public partial class ListaProductos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<DevExpress.Blazor.DxDataGrid<CategoryEntity>>(0);
            __builder.AddAttribute(1, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<CategoryEntity>>(
#nullable restore
#line 6 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
                                           categories

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ShowFilterRow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 6 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "RowUpdating", new System.Action<CategoryEntity, System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 8 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
                              (row, newValues) => OnRowUpdating(row as CategoryEntity, newValues)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "RowInserting", new System.Action<System.Collections.Generic.Dictionary<System.String, System.Object>>(
#nullable restore
#line 9 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
                               (row) => OnRowInserting(row)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "RowRemoving", new System.Action<CategoryEntity>(
#nullable restore
#line 10 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
                               (row) => Delete(row as CategoryEntity)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n                \r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridCommandColumn>(8);
                __builder2.AddAttribute(9, "Width", "20%");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n        ");
                __builder2.OpenComponent<DevExpress.Blazor.DxDataGridColumn>(11);
                __builder2.AddAttribute(12, "Caption", "Nombre");
                __builder2.AddAttribute(13, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
                                                   nameof(CategoryEntity.Name)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(15, (__value) => {
#nullable restore
#line 6 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
                                                                                DataGridProducts = (DevExpress.Blazor.DxDataGrid<CategoryEntity>)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Usuario\OneDrive\Portafolio\Project1\Project1\Components\Products\ListaProductos.razor"
       
    List<CategoryEntity> categories = new List<CategoryEntity>();
    DxDataGrid<CategoryEntity> DataGridProducts;
    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.CategoryList();
    }

    async void OnRowUpdating(CategoryEntity dataItem, Dictionary<string, object> newValue) {
        string values = JsonConvert.SerializeObject(newValue);
        JsonConvert.PopulateObject(values, dataItem);
        B_Category.UpdateCategory(dataItem);
    }


    async void OnRowInserting(Dictionary<string, object> newValue) {
        CategoryEntity categoryEntitynew = new CategoryEntity();

        string values = JsonConvert.SerializeObject(newValue);
        JsonConvert.PopulateObject(values, categoryEntitynew);
        B_Category.CreateCategory(categoryEntitynew);
        
    }


    async void Delete(CategoryEntity item) {
        if (item != null) {
            B_Category.DeleteCategory(item);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
