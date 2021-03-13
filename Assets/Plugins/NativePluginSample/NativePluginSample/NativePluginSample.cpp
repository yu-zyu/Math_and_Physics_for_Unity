#include "pch.h"
#include "stdlib.h"
#include "NativePluginSample.h"

SAMPLE_API int SampleAPIInt(int i)
{
	return 123 + i;
}

SAMPLE_API float SampleAPIFloat(float f)
{
	return 123.456f + f;
}

SAMPLE_API double SampleAPIDouble(double d)
{
	return 123.456 + d;
}

SAMPLE_API void SampleAPIInt2(int& i)
{
	i = 123 + i;
}

SAMPLE_API void SampleAPIFloat2(float& f)
{
	f = 123.456f + f;
}

SAMPLE_API void SampleAPIDouble2(double& d)
{
	d = 123.456 + d;
}

SAMPLE_API void SampleAPIIntArray(int intArray[], int intArraySize)
{
	for (int i = 0; i < intArraySize; i++)
	{
		intArray[i] = i;
	}
}

SAMPLE_API void SampleAPILongArray(long longArray[], int longArraySize)
{
	for (int i = 0; i < longArraySize; i++)
	{
		longArray[i] = i;
	}
}

SAMPLE_API void SampleAPIFloatArray(float floatArray[], int floatArraySize)
{
	for (int i = 0; i < floatArraySize; i++)
	{
		floatArray[i] = 0.5f + i;
	}
}

SAMPLE_API void SampleAPIDoubleArray(double doubleArray[], int doubleArraySize)
{
	for (int i = 0; i < doubleArraySize; i++)
	{
		doubleArray[i] = 0.5 + i;
	}
}

SAMPLE_API char* MallocString(const char* str)
{
	size_t bufSize = strlen(str) + 1;
	char* buf = (char*)malloc(bufSize);
	strcpy_s(buf, bufSize, str);
	return buf;
}

SAMPLE_API const char* SampleAPIString1()
{
	return MallocString("Hello!");
}

SAMPLE_API const char* SampleAPIString2(const char* str)
{
	// •¶Žš—ñ‚ÌŒã‚ë‚É"Hello!"‚ð‚­‚Á•t‚¯‚Ä•Ô‚·
	const int bufferSize = 256;
	static char buffer[bufferSize];
	const char hello[] = "Hello!";

	strcpy_s(buffer, bufferSize, str);
	size_t n = strnlen(buffer, bufferSize);
	strcpy_s(buffer + n, bufferSize - 7, hello);
	return MallocString(buffer);
}