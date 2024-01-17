#include "pch.h"
#include "MyNativeDLL.h"

// Define the function
MYNATIVEDLLAPI int MyFunc(int x)
{
    // Return the square of x
    return x * x;
}

MYNATIVEDLLAPI int* MyUnsafeFunc(int x)
{
    int* retArr = new int[2];

    retArr[0] = x*x;
    retArr[1] = x*x*x;

    return retArr;
    delete[] retArr;
}