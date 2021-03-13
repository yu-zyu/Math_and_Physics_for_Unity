#pragma once
#ifdef NATIVEPLUGINSAMPLE_EXPORTS
#define MathPhysicsAPI __declspec(dllexport)
#else
#define MathPhysicsAPI __declspec(dllimport)
#endif

extern "C" {
	MathPhysicsAPI float slopeBetweenPoints(float *P1, float *P2);
}
