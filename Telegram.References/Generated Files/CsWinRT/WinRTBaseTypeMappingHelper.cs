//------------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by cswinrt.exe version 2.1.3.240909.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace WinRT
{
    internal static class ProjectionTypesInitializer
    {
        internal static readonly System.Collections.Generic.Dictionary<string, string> TypeNameToBaseTypeNameMapping = new System.Collections.Generic.Dictionary<string, string>(4, System.StringComparer.Ordinal)
        {
            ["Telegram.Native.Calls.VoipScreenCapture"] = "Telegram.Native.Calls.VoipCaptureBase",
            ["Telegram.Native.Highlight.SyntaxToken"] = "Telegram.Native.Highlight.Token",
            ["Telegram.Native.Calls.VoipVideoCapture"] = "Telegram.Native.Calls.VoipCaptureBase",
            ["Telegram.Native.Highlight.TextToken"] = "Telegram.Native.Highlight.Token",

        };

        [System.Runtime.CompilerServices.ModuleInitializer]
        internal static void InitalizeProjectionTypes()
        {
            ComWrappersSupport.RegisterProjectionTypeBaseTypeMapping(TypeNameToBaseTypeNameMapping);
        }
    }
}