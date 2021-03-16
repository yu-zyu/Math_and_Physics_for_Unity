#include "pch.h"
#include "stdlib.h"
#include "Math_and_Physics.h"

/// <summary>
///2“_‚ğ—^‚¦‚ç‚ê‚½’¼ü‚ÌŒX‚«‚ğŒvZ 
/// </summary>
/// <param name="P1">“_1‚ğ•\‚·—v‘f”2‚Ìfloat”z—ñ</param>
/// <param name="P2">“_1‚ğ•\‚·—v‘f”2‚Ìfloat”z—ñ</param>
/// <returns>2“_ŠÔ‚Ì’¼ü‚ÌŒX‚«</returns>
MathPhysicsAPI float slopeBetweenPoints(float *P1, float *P2)
{
	return (P2[1] - P1[1]) /
		(P2[0] - P1[0]);
}


/// <summary>
/// —^‚¦‚ç‚ê‚½’¼ü‚É‚’¼‚È’¼ü‚ÌŒX‚«
/// </summary>
/// <param name="slope">—^‚¦‚ç‚ê‚½’¼ü‚ÌŒX‚«</param>
/// <returns>—^‚¦‚ç‚ê‚½’¼ü‚É‚’¼‚È’¼ü‚ÌŒX‚«</returns>
MathPhysicsAPI float perpSlope(float slope)
{
	return -1 / slope;
}

/// <summary>
/// 2‚Â‚Ì’¼ü‚ª‚’¼‚©‚Ç‚¤‚©‚ğ’²‚×‚é
/// </summary>
/// <param name="slope1">‘æ1‚Ì’¼ü‚ÌŒX‚«</param>
/// <param name="slope2">‘æ2‚Ì’¼ü‚ÌŒX‚«</param>
/// <returns>2‚Â‚Ì’¼ü‚ª‚’¼‚È‚ç‚ÎtrueA
/// ‚»‚¤‚Å‚È‚¯‚ê‚Îfalse</returns>
MathPhysicsAPI bool arePerp(float slope1, float slope2)
{
	if (slope1 * slope2 == -1)
		return true;

	return false;
}
