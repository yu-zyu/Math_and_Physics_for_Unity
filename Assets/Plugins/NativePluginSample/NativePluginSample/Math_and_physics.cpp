#include "pch.h"
#include "stdlib.h"
#include "Math_and_Physics.h"
#include "cmath"

//---------------------------------------------------------------------
// 第1章
//---------------------------------------------------------------------

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


// 答えを格納するための配列 temp
float temp[2] = { 0, 0 };
/// <summary>
/// ２つの直線の交点を求める 
/// </summary>
/// <param name="l1point">第1の直線上の2dの点</param>
/// <param name="L1Slope">第1の直線の傾き</param>
/// <param name="L2Point">第2の直線上の2Dの点</param>
/// <param name="L2Slope">第2の直線の傾き</param>
/// <returns>求める点の座標を格納したfloat配列</returns>
MathPhysicsAPI float *lineIntersect(
	float *L1Point, float L1Slope, float *L2Point, float L2Slope)
{
//	temp[0] = 3;
//	temp[1] = 3;
	// xについて解く
	temp[0] = (L1Slope * L1Point[0] - L2Slope * L2Point[0] + L2Point[1] - L1Point[1]) /
		 (L1Slope - L2Slope);
	// 得られたxの値を代入して、yの値を求める
	temp[1] = L1Slope * (temp[0] - L1Point[0]) + L1Point[1];

	return temp;
}


//---------------------------------------------------------------------
// 第2章
//---------------------------------------------------------------------

/// <summary>
/// 2点間の距離の計算 
/// </summary>
/// <param name="P1">点1を表す要素数２のfloat配列</param>
/// <param name="P2">点2を表す要素数２のfloat配列</param>
/// <returns>2点間の距離</returns>
MathPhysicsAPI float distance2D(float* P1, float* P2) {
    	
	//求める距離を計算して、その値を返す
	return (float)sqrt(
		pow(P2[0] - P1[0], 2) +
		pow(P2[1] - P1[1], 2)
	);
}

/// <summary>
/// 2点間の距離の計算 
/// </summary>
/// <param name="P1">点1を表す要素数２のfloat配列</param>
/// <param name="P2">点2を表す要素数２のfloat配列</param>
/// <returns>2点間の距離</returns>
MathPhysicsAPI float distance3D(float* P1, float* P2) {
    	
	//求める距離を計算して、その値を返す
	return (float)sqrt(
		pow(P2[0] - P1[0], 2) +
		pow(P2[1] - P1[1], 2) +
		pow(P2[2] - P1[2], 2)
	);
}


// 答えを格納するための配列 temp
 MathPhysicsAPI float find2DMidPoint_temp[2] = { 0, 0 };
/// <summary>
/// 線分の中心の計算
/// </summary>
/// <param name="P1">点1を表す要素数２のfloat配列</param>
/// <param name="P2">点2を表す要素数２のfloat配列</param>
/// <returns>2点間の中心</returns>
 MathPhysicsAPI float* find2DMidPoint(float* P1, float* P2) {
	find2DMidPoint_temp[0] = (P1[0] + P2[0]) / 2.0f;
	find2DMidPoint_temp[1] = (P1[1] + P2[1]) / 2.0f;
	//答えを返す
	return find2DMidPoint_temp;
}


// 答えを格納するための配列 temp
 MathPhysicsAPI float find3DMidPoint_temp[3] = { 0, 0, 0 };
/// <summary>
/// 3Dにおける線分の中心の計算
/// </summary>
/// <param name="P1">点1を表す要素数3のfloat配列</param>
/// <param name="P2">点2を表す要素数3のfloat配列</param>
/// <returns>2点間の中点</returns>
 MathPhysicsAPI float* find3DMidPoint(float* P1, float* P2) {
	find3DMidPoint_temp[0] = (P1[0] + P2[0]) / 2.0f;
	find3DMidPoint_temp[1] = (P1[1] + P2[1]) / 2.0f;
	find3DMidPoint_temp[2] = (P1[2] + P2[2]) / 2.0f;
	return find3DMidPoint_temp;
}

struct sphere {
	float center[3];
	float radius;
};

/// <summary>
/// 2つの球の衝突検知
/// </summary>
/// <param name="S1">第1の球、参照渡し</param>
/// <param name="S2">第2の球、参照渡し</param>
/// <returns>衝突する場合はtrue、しない場合はfalse</returns>
 MathPhysicsAPI bool ColBetweenSpheres(sphere& S1, sphere& S2) {
	return (pow(S2.center[0] - S1.center[0], 2) +
		    pow(S2.center[1] - S1.center[1], 2) +
	        pow(S2.center[2] - S1.center[2], 2)) < pow(S1.radius + S2.radius, 2);
}

//---------------------------------------------------------------------
// 第3章
//---------------------------------------------------------------------

#define RadToDeg 57.29577951f
#define DegToRad 0.017453293f

//
////入力する値を格納
//float sin_table[360];
////表を数値で埋める
//for(int i = 0; i < 360; ++i) {
//	//前出のDegToRad #defineの定義を確認。 P1/180
//	sin_table[i] = sin(i * DegToRad);
//
//}


/// <summary>
/// 2D空間における2つの物体のなす角を計算
/// </summary>
/// <param name="P1">第1の物体の位置</param>
/// <param name="P2">第2の物体の位置</param>
/// <returns>度で表した物体のなす角</returns>
 MathPhysicsAPI float calcAngle2D(float* P1, float* P2) {
	
	//角の計算
	float ang = (float)atan((P2[1] - P1[1]) / (P2[0] - P1[0])) * RadToDeg;
	//角が第1象限にあるとき
	if (P2[1] < P1[1] && P2[0] > P1[0]) {
		return ang;
	}
	//角が第2または第3象限にあるとき
	else if ((P2[1] < P1[1] && P2[0] < P1[0]) || (P2[1] > P1[1] && P2[0] < P1[0])) {
		return ang + 180;
	}
	else {
		return ang + 360;
	}

}

