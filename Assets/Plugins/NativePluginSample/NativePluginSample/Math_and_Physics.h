#pragma once
#ifdef NATIVEPLUGINSAMPLE_EXPORTS
#define MathPhysicsAPI __declspec(dllexport)
#else
#define MathPhysicsAPI __declspec(dllimport)
#endif

extern "C" {
	//ëÊ1èÕ
	MathPhysicsAPI float slopeBetweenPoints(float *P1, float *P2);
	MathPhysicsAPI float perpSlope(float slope);
	MathPhysicsAPI bool arePerp(float slope1, float slope2);
	MathPhysicsAPI float *lineIntersect(float *L1Point, float L1Slope, float *L2Point, float L2Slope);

	//ëÊ2èÕ
	MathPhysicsAPI float distance2D(float* P1, float* P2);
	MathPhysicsAPI float distance3D(float* P1, float* P2);
	MathPhysicsAPI float* find2DMidPoint(float* P1, float* P2);
	MathPhysicsAPI float* find3DMidPoint(float* P1, float* P2);
	MathPhysicsAPI struct sphere;
	MathPhysicsAPI bool ColBetweenSpheres(sphere& S1, sphere& S2);
}
