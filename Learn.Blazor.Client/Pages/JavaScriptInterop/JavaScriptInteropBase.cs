using Microsoft.AspNetCore.Blazor.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn.Blazor.Client.Pages.JavaScriptInterop
{
    public class JavaScriptInteropBase : BlazorComponent
    {
        protected static string CSCallBackSuccessMessage { get; set; }

        public void CallJSMethod()
        {
            JSRuntime.Current.InvokeAsync<bool>("JSMethod");
        }

        #region
        public string homeWorkMessage { get; set; }

        public void homeWork()
        {
            homeWorkMessage = "Somethiong for you to Research and do.";
        }

#endregion

    }
}
