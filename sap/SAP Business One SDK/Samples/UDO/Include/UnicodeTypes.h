#pragma once

#include <cstdint>

typedef unsigned char					UTF8;			// TODO Do we need to specify unsigned here?

#ifdef _WINDOWS

typedef wchar_t							UTF16;
typedef char32_t						UTF32;

#elif _LINUX

typedef char16_t						UTF16;
typedef wchar_t							UTF32;

#else

#	error Unsupported platform.

#endif
