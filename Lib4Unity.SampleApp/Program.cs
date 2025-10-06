using Lib.Core.Utilities;
using Lib4Unity.Core.Utilities;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine($"IsDefault => {ObjectUtils.IsDefault(0)}");
Console.WriteLine($"Version => {StringUtils.GetVersion()}");
Console.WriteLine($"Organization => {StringUtils.GetOrganization()}");