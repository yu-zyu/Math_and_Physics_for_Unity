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

MathPhysicsAPI struct sphere {
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

//---------------------------------------------------------------------
// 第4章
//---------------------------------------------------------------------

 //ベクトルを成分で格納する構造体
 MathPhysicsAPI struct Vector2D_comp{

	 float x, y;
 };

 //ベクトルを大きさと向きを使った表示で格納する構造体
 MathPhysicsAPI struct Vector2D_polar
 {
	 float mag, dir;
 };

#define PI 3.14159265359

 /// <summary>
 /// ベクトルを大きさと向きを使った表示から成分表示に変換
 /// </summary>
 /// <param name="vec">大きさと向きを使って表したベクトル</param>
 /// <returns>変換後のベクトル</returns>
 MathPhysicsAPI void PolarToCompConversion(Vector2D_polar vec, Vector2D_comp& temp){
	 //答えを格納する一時的変数
	 //値を代入
	 temp.x = vec.mag * cos(vec.dir * PI / 180);
	 temp.y = vec.mag * sin(vec.dir * PI / 180);
	 //答えを返す
	 //return temp;
 };

  /// <summary>
 /// ベクトルを大きさと向きを使った表示から成分表示に変換
 /// </summary>
 /// <param name="vec">大きさと向きを使って表したベクトル</param>
 /// <returns>変換後のベクトル</returns>
 MathPhysicsAPI void CompToPolarConversion(Vector2D_comp vec, Vector2D_polar& temp){
	 //答えを格納する一時的変数
	 //Vector2D_polar temp = { 0, 0 };
	 temp = { 0, 0 };
	 //ピタゴラスの定理を使って求める大きさを計算
	 temp.mag = sqrt(vec.x * vec.x + vec.y * vec.y);
	 //次の部分でゼロで割るという問題が生じないようにチェック
	 if (temp.mag == 0) {
		 // return temp;
	 }
	 //求める角を計算。第1または第4象限の角を返すasin()を使う
	 temp.dir = (180 / PI) * asin(vec.y / temp.mag);
	 //角が第2または第3象限にあるときは調整
	 if (vec.x < 0) {
		 temp.dir = 180 - temp.dir;
	 }
	 //角が第4象限にあるときは調整
	 else if (vec.x > 0 && vec.y < 0) {
		 temp.dir += 360;
	 }
	 //新しいベクトルを返す
	 //return temp;
 };
#ifndef _3DVECTOR_H_
#define _3DVECTOR_H_
#endif

// MathPhysicsAPI class Vector3D 
// {
//     private:
//	     float x, y, z;
//     public:
//	
//		 /// <summary>
//		 /// コンストラクタ
//		 /// </summary>
//		 /// <param name="ex">ベクトルのi成分</param>
//		 /// <param name="why">ベクトルのj成分</param>
//		 /// <param name="zee">ベクトルのk成分</param>
//		 /// 出力　なし
//		 Vector3D(float ex = 0, float why = 0, float zee = 0) {
//			 x = ex; y = why; z = zee;
//		 }
//
//		 /// <summary>
//		 /// デストラクタ
//		 /// </summary>
//		 /// <returns>なし</returns>
//		 ~Vector3D(){}
//
//		 /// <summary>
//		 /// 呼び出しベクトルの大きさを計算
//		 /// </summary>
//		 /// <returns></returns>
//		 float getMagnitude() {
//			 return sqrtf(x * x + y * y + z * z);
//		 }
//
//		 /// <summary>
//		 /// ベクトルにスカラー値を掛ける
//		 /// </summary>
//		 /// <param name="num">ベクトルに掛けるスカラー値</param>
//		 /// <returns>新しくできたベクトル</returns>
//		 Vector3D operator*(float num) const {
//			 return Vector3D(x * num, y * num, z * num);
//		 }
//
//		 /// <summary>
//		 /// ベクトルにスカラー値を掛ける
//		 /// </summary>
//		 /// <param name="num">ベクトルに掛けるスカラー値</param>
//		 /// <param name="vec">スカラー値を掛けるベクトル</param>
//		 /// <returns>新しくべきたベクトル</returns>
//		 friend Vector3D operator*(float num, const Vector3D& vec) {
//			 return Vector3D(vec.x * num, vec.y * num, vec.z * num);
//		 }
//
//		 /// <summary>
//		 /// ２つのベクトルの足し算
//		 /// </summary>
//		 /// <param name="vec">呼び出しオブジェクトに加えるベクトル</param>
//		 /// <returns>２つのベクトルの和</returns>
//		 Vector3D operator+(const Vector3D& vec) const {
//			 return Vector3D(x + vec.x, y + vec.y, z + vec.z);
//		 }
//
//		 /// <summary>
//		 /// ２つのベクトルの引き算
//		 /// </summary>
//		 /// <param name="vec">呼び出しオブジェクトから引くベクトル</param>
//		 /// <returns>２つのベクトルの差</returns>
//		 Vector3D operator-(const Vector3D& vec) const {
//			 return Vector3D(x - vec.x, y - vec.y, z - vec.z);
//		 }
//
//		 /// <summary>
//		 /// 呼び出しベクトルの正規化。これによって呼び出しベクトルが変わる
//		 /// </summary>
//		 /// <param name="">なし</param>
//		 /// <returns>なし</returns>
//		 void normalizeVector3D(void) {
//			 float mag = sqrtf(x * x + y * y + z * z);
//			 x /= mag; y /= mag; z /= mag;
//		 }
//
//		 /// <summary>
//		 /// ２つのベクトルの内積
//		 /// </summary>
//		 /// <param name="vec">呼び出しオブジェクトと内積するベクトル</param>
//		 /// <returns>2つのベクトルを内積した値</returns>
//		 float dotVector3D(const Vector3D& vec) const {
//			 return x * vec.x + y * vec.y + z * vec.z;
//		 }
//
//		 /// <summary>
//		 /// ２つのベクトルの外積
//		 /// </summary>
//		 /// <param name="vec">呼び出しオブジェクトと外積するベクトル</param>
//		 /// <returns>新しくできたベクトル</returns>
//		 Vector3D crossVector3D(const Vector3D& vec) const {
//			 return Vector3D(
//				 y * vec.z - z * vec.y, z * vec.x - x * vec.z, x * vec.y - y * vec.x
//			 );
//		 }
//
//		 //const がつくとエラーになる
//		 float angleBetween3DVectors( Vector3D& vec)  {
//			 return (acos(dotVector3D(vec) / (getMagnitude() * vec.getMagnitude())) * (180 / PI));
//		 }
// };


//---------------------------------------------------------------------
// 第5章
//---------------------------------------------------------------------

MathPhysicsAPI struct Matrix3X3 {
	float index[3][3];
};

MathPhysicsAPI bool areMatricesEqual(Matrix3X3& a, Matrix3X3& b) {
	int errorFlag = 0;
	for (int i = 0; i < 3; i++) {
		for (int j = 0; j < 3; j++) {
			if ((a.index[i][j]) != (b.index[i][j])) {
				errorFlag = 1;
			}
		}
	}

	//行列が等しいかどうかのチェックをする
	if (errorFlag == 1) {
		return false;
	}
	else {
		return true;
	}
}
