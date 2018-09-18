using Learn.Blazor.Client.Shared;
using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.AspNetCore.Blazor.Layouts;
using Microsoft.AspNetCore.Blazor.RenderTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn.Blazor.Client.Pages.Components
{
    [Route("/classonly")]
    [Layout(typeof(MainLayout))]
    public class ClassOnlyComponent : BlazorComponent
    {
        public const string title = "Class Only Component";

        public const string body = "The BlazorComponent class contains all the base functionality for components. One of the methods it contains is BuildRenderTree() which I have overridden in the code above. I have then used the RenderTreeBuilder instance to programmatically define my components view. At runtime the component will output the following html.";

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(1, "h1");
            builder.AddContent(2, title);
            builder.CloseElement();

            builder.OpenElement(1, "p");
            builder.AddContent(2, body);
            builder.CloseElement();
        }
    }
}
