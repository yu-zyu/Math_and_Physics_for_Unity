#pragma once
#ifdef NATIVEPLUGINSAMPLE_EXPORTS
#define SAMPLE_API __declspec(dllexport)
#else
#define SAMPLE_API __declspec(dllimport)
#endif

extern "C" {
	// ílìnÇµ
	SAMPLE_API int SampleAPIInt(int i);
	SAMPLE_API float SampleAPIFloat(float f);
	SAMPLE_API double SampleAPIDouble(double d);

	// éQè∆ìnÇµ
	SAMPLE_API void SampleAPIInt2(int& i);
	SAMPLE_API void SampleAPIFloat2(float& f);
	SAMPLE_API void SampleAPIDouble2(double& d);

	// îzóÒÇÃéQè∆ìnÇµ
	SAMPLE_API void SampleAPIIntArray(int intArray[], int intArraySize);
	SAMPLE_API void SampleAPILongArray(long longArray[], int longArraySize);
	SAMPLE_API void SampleAPIFloatArray(float floatArray[], int floatArraySize);
	SAMPLE_API void SampleAPIDoubleArray(double doubleArray[], int doubleArraySize);

	// ï∂éöóÒ
	SAMPLE_API const char* SampleAPIString1();
	SAMPLE_API const char* SampleAPIString2(const char* str);
}
