using Microsoft.JSInterop;

namespace YumBlazor.Services.Extensions
{
    public static class JSRuntimeExtensions
    {
        // We need to create two end-points:
        public static async Task ToastrSuccess(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "success", message);
        }
        public static async Task ToastrError(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "error", message);
        }

    }
}
