#pragma once
#ifdef NATIVEPLUGINSAMPLE_EXPORTS
#define MathPhysicsAPI __declspec(dllexport)
#else
#define MathPhysicsAPI __declspec(dllimport)
#endif

extern "C" {
	MathPhysicsAPI float slopeBetweenPoints(float *P1, float *P2);
	MathPhysicsAPI float perpSlope(float slope);
	MathPhysicsAPI bool arePerp(float slope1, float slope2);
	MathPhysicsAPI float *lineIntersect(float *L1Point, float L1Slope, float *L2Point, float L2Slope);

}
