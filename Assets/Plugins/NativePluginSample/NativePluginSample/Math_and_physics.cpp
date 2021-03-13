#include "pch.h"
#include "stdlib.h"
#include "Math_and_Physics.h"

MathPhysicsAPI float slopeBetweenPoints(float *P1, float *P2)
{
	return (P2[1] - P1[1]) /
		(P2[0] - P1[0]);
}
