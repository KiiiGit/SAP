#pragma once
/**
* @file MessageWarningLevel.h
* @brief ~
*/

#ifndef MESSAGE_WARNING_LEVEL_H
#define MESSAGE_WARNING_LEVEL_H

enum WarningLevel
{
	OO_UNDEFINED = '-', // Undefined
	OO_ERROR = 'E', // Error
	OO_NOTE = 'N', // Info
	OO_WARNING = 'W', // Warning
	OO_SUCCESS = 'S', // Success
	OO_CLEAR = 'X', // Clear - Used only in UTL6 Form
	OO_NONE = 'O'  // None
};
	
#endif