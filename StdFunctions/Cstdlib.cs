namespace Std;

using System.Runtime.InteropServices;

public static partial class Cstdlib
{
    [LibraryImport("msvcrt.dll", StringMarshalling = StringMarshalling.Utf16)]
    internal static partial int System(string? command);
}
