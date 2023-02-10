﻿using DotNetForHtml5;
using Microsoft.JSInterop;
using Microsoft.JSInterop.WebAssembly;

namespace OpenSilverBase64Image.Browser.Interop
{
    public class UnmarshalledJavaScriptExecutionHandler : IJavaScriptExecutionHandler2
    {
        private const string MethodName = "callJSUnmarshalled";
        private readonly WebAssemblyJSRuntime _runtime;

        public UnmarshalledJavaScriptExecutionHandler(IJSRuntime runtime)
        {
            _runtime = runtime as WebAssemblyJSRuntime;
        }

        public void ExecuteJavaScript(string javaScriptToExecute)
        {
            _runtime.InvokeUnmarshalled<string, object>(MethodName, javaScriptToExecute);
        }

        public object ExecuteJavaScriptWithResult(string javaScriptToExecute)
        {
            return _runtime.InvokeUnmarshalled<string, object>(MethodName, javaScriptToExecute);
        }

        public TResult InvokeUnmarshalled<T0, TResult>(string identifier, T0 arg0)
        {
            return _runtime.InvokeUnmarshalled<T0, TResult>(identifier, arg0);
        }
    }
}