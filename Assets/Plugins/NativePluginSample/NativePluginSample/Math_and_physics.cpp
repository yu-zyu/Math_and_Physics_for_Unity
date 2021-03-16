#include "pch.h"
#include "stdlib.h"
#include "Math_and_Physics.h"

/// <summary>
///2点を与えられた直線の傾きを計算 
/// </summary>
/// <param name="P1">点1を表す要素数2のfloat配列</param>
/// <param name="P2">点1を表す要素数2のfloat配列</param>
/// <returns>2点間の直線の傾き</returns>
MathPhysicsAPI float slopeBetweenPoints(float *P1, float *P2)
{
	return (P2[1] - P1[1]) /
		(P2[0] - P1[0]);
}


/// <summary>
/// 与えられた直線に垂直な直線の傾き
/// </summary>
/// <param name="slope">与えられた直線の傾き</param>
/// <returns>与えられた直線に垂直な直線の傾き</returns>
MathPhysicsAPI float perpSlope(float slope)
{
	return -1 / slope;
}

/// <summary>
/// 2つの直線が垂直かどうかを調べる
/// </summary>
/// <param name="slope1">第1の直線の傾き</param>
/// <param name="slope2">第2の直線の傾き</param>
/// <returns>2つの直線が垂直ならばtrue、
/// そうでなければfalse</returns>
MathPhysicsAPI bool arePerp(float slope1, float slope2)
{
	if (slope1 * slope2 == -1)
		return true;

	return false;
}

/// <summary>
/// ２つの直線の交点を求める 
/// </summary>
/// <param name="L1Point">第1の直線上の2Dの点</param>
/// <param name="L1Slope">第1の直線の傾き</param>
/// <param name="L2Point">第2の直線上の2Dの点</param>
/// <param name="L2Slope">第2の直線の傾き</param>
/// <returns>求める点の座標を格納したfloat配列</returns>
MathPhysicsAPI float *lineIntersect(
	float *L1Point, float L1Slope, float *L2Point, float L2Slope)
{
	// 答えを格納するための配列 temp
	float temp[2] = { 0, 0 };
	// xについて解く
	temp[0] = (L1Slope * L1Point[0] - L2Slope * L2Point[0] + L2Point[1] - L1Point[1]) /
		 (L1Slope - L2Slope);
	// 得られたxの値を代入して、yの値を求める
	temp[1] = L1Slope * (temp[0] - L1Point[0]) + L1Point[1];

	return temp;
}
