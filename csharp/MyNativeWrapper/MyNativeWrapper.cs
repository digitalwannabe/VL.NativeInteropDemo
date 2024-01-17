// For examples, see:
// https://thegraybook.vvvv.org/reference/extending/writing-nodes.html#examples

namespace MyNativeDLL;

using System;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

public static class MyNativeWrapper
{


    // Import the DLL and the function
    [DllImport("MyNativeDLL.dll")]
    public static extern int MyFunc(int x);

    public static float DemoNode(int a)
    {
        return MyFunc(a);
    }
}

public unsafe static class MyUnsafeNativeWrapper
{


    // Import the DLL and the function
    [DllImport("MyNativeDLL.dll")]
    public static extern IntPtr MyUnsafeFunc(int x);

    public static int[] UnsafeDemoNode(int a)
    {
        int size = 2;
        int[] tetArr = new int[size];
        Marshal.Copy(MyUnsafeFunc(a), tetArr, 0, size);
        return tetArr;
    }
}