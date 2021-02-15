#pragma once

#define QMATH_UNITY_API __declspec(dllexport)

extern "C"
{
	/*
	** float q_rsqrt( float number )
	*/
	QMATH_UNITY_API float Q_rsqrt(float number);
}
