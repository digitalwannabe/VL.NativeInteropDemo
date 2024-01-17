#ifdef MYNATIVEDLL_EXPORTS
#define MYNATIVEDLLAPI extern "C" __declspec(dllexport)
#else
#define MYNATIVEDLLAPI extern "C" __declspec(dllimport)
#endif

// Declare a function that takes an int and returns an int
MYNATIVEDLLAPI int MyFunc(int x);
MYNATIVEDLLAPI int* MyUnsafeFunc(int x);