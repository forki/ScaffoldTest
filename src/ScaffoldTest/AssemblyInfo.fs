namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("ScaffoldTest")>]
[<assembly: AssemblyProductAttribute("ScaffoldTest")>]
[<assembly: AssemblyDescriptionAttribute("test")>]
[<assembly: AssemblyVersionAttribute("1.0")>]
[<assembly: AssemblyFileVersionAttribute("1.0")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.0"
