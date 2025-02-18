#pragma once

// B1INT was removed, please use intptr_t instead.
// B1UINT was removed, please use uintptr_t instead.

#include "UnicodeTypes.h"

typedef void* Ptr;
typedef unsigned char* CORE_Ptr;
typedef const unsigned char* CORE_CPtr;
typedef void* CORE_Instance;
typedef void* CORE_Window;
typedef CORE_Window* PCORE_Window;

enum XBool
{
	xb_false,
	xb_true,
	xb_default
};

#define Bool2XBool(b)			((b) ? xb_true : xb_false)

typedef long					SBOErr;
#define noErr					0

#define EMPTY_STR				_T("")