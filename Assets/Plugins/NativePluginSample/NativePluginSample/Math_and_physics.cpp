#include "pch.h"
#include "stdlib.h"
#include "Math_and_Physics.h"
#include "cmath"

//---------------------------------------------------------------------
// ��1��
//---------------------------------------------------------------------

/// <summary>
///2�_��^����ꂽ�����̌X�����v�Z 
/// </summary>
/// <param name="P1">�_1��\���v�f��2��float�z��</param>
/// <param name="P2">�_1��\���v�f��2��float�z��</param>
/// <returns>2�_�Ԃ̒����̌X��</returns>
MathPhysicsAPI float slopeBetweenPoints(float *P1, float *P2)
{
	return (P2[1] - P1[1]) /
		(P2[0] - P1[0]);
}


/// <summary>
/// �^����ꂽ�����ɐ����Ȓ����̌X��
/// </summary>
/// <param name="slope">�^����ꂽ�����̌X��</param>
/// <returns>�^����ꂽ�����ɐ����Ȓ����̌X��</returns>
MathPhysicsAPI float perpSlope(float slope)
{
	return -1 / slope;
}

/// <summary>
/// 2�̒������������ǂ����𒲂ׂ�
/// </summary>
/// <param name="slope1">��1�̒����̌X��</param>
/// <param name="slope2">��2�̒����̌X��</param>
/// <returns>2�̒����������Ȃ��true�A
/// �����łȂ����false</returns>
MathPhysicsAPI bool arePerp(float slope1, float slope2)
{
	if (slope1 * slope2 == -1)
		return true;

	return false;
}


// �������i�[���邽�߂̔z�� temp
float temp[2] = { 0, 0 };
/// <summary>
/// �Q�̒����̌�_�����߂� 
/// </summary>
/// <param name="l1point">��1�̒������2d�̓_</param>
/// <param name="L1Slope">��1�̒����̌X��</param>
/// <param name="L2Point">��2�̒������2D�̓_</param>
/// <param name="L2Slope">��2�̒����̌X��</param>
/// <returns>���߂�_�̍��W���i�[����float�z��</returns>
MathPhysicsAPI float *lineIntersect(
	float *L1Point, float L1Slope, float *L2Point, float L2Slope)
{
//	temp[0] = 3;
//	temp[1] = 3;
	// x�ɂ��ĉ���
	temp[0] = (L1Slope * L1Point[0] - L2Slope * L2Point[0] + L2Point[1] - L1Point[1]) /
		 (L1Slope - L2Slope);
	// ����ꂽx�̒l�������āAy�̒l�����߂�
	temp[1] = L1Slope * (temp[0] - L1Point[0]) + L1Point[1];

	return temp;
}


//---------------------------------------------------------------------
// ��2��
//---------------------------------------------------------------------

/// <summary>
/// 2�_�Ԃ̋����̌v�Z 
/// </summary>
/// <param name="P1">�_1��\���v�f���Q��float�z��</param>
/// <param name="P2">�_2��\���v�f���Q��float�z��</param>
/// <returns>2�_�Ԃ̋���</returns>
MathPhysicsAPI float distance2D(float* P1, float* P2) {
    	
	//���߂鋗�����v�Z���āA���̒l��Ԃ�
	return (float)sqrt(
		pow(P2[0] - P1[0], 2) +
		pow(P2[1] - P1[1], 2)
	);
}

/// <summary>
/// 2�_�Ԃ̋����̌v�Z 
/// </summary>
/// <param name="P1">�_1��\���v�f���Q��float�z��</param>
/// <param name="P2">�_2��\���v�f���Q��float�z��</param>
/// <returns>2�_�Ԃ̋���</returns>
MathPhysicsAPI float distance3D(float* P1, float* P2) {
    	
	//���߂鋗�����v�Z���āA���̒l��Ԃ�
	return (float)sqrt(
		pow(P2[0] - P1[0], 2) +
		pow(P2[1] - P1[1], 2) +
		pow(P2[2] - P1[2], 2)
	);
}


// �������i�[���邽�߂̔z�� temp
 MathPhysicsAPI float find2DMidPoint_temp[2] = { 0, 0 };
/// <summary>
/// �����̒��S�̌v�Z
/// </summary>
/// <param name="P1">�_1��\���v�f���Q��float�z��</param>
/// <param name="P2">�_2��\���v�f���Q��float�z��</param>
/// <returns>2�_�Ԃ̒��S</returns>
 MathPhysicsAPI float* find2DMidPoint(float* P1, float* P2) {
	find2DMidPoint_temp[0] = (P1[0] + P2[0]) / 2.0f;
	find2DMidPoint_temp[1] = (P1[1] + P2[1]) / 2.0f;
	//������Ԃ�
	return find2DMidPoint_temp;
}


// �������i�[���邽�߂̔z�� temp
 MathPhysicsAPI float find3DMidPoint_temp[3] = { 0, 0, 0 };
/// <summary>
/// 3D�ɂ���������̒��S�̌v�Z
/// </summary>
/// <param name="P1">�_1��\���v�f��3��float�z��</param>
/// <param name="P2">�_2��\���v�f��3��float�z��</param>
/// <returns>2�_�Ԃ̒��_</returns>
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
/// 2�̋��̏Փˌ��m
/// </summary>
/// <param name="S1">��1�̋��A�Q�Ɠn��</param>
/// <param name="S2">��2�̋��A�Q�Ɠn��</param>
/// <returns>�Փ˂���ꍇ��true�A���Ȃ��ꍇ��false</returns>
 MathPhysicsAPI bool ColBetweenSpheres(sphere& S1, sphere& S2) {
	return (pow(S2.center[0] - S1.center[0], 2) +
		    pow(S2.center[1] - S1.center[1], 2) +
	        pow(S2.center[2] - S1.center[2], 2)) < pow(S1.radius + S2.radius, 2);
}

//---------------------------------------------------------------------
// ��3��
//---------------------------------------------------------------------

#define RadToDeg 57.29577951f
#define DegToRad 0.017453293f

//
////���͂���l���i�[
//float sin_table[360];
////�\�𐔒l�Ŗ��߂�
//for(int i = 0; i < 360; ++i) {
//	//�O�o��DegToRad #define�̒�`���m�F�B P1/180
//	sin_table[i] = sin(i * DegToRad);
//
//}

/// <summary>
/// 2D��Ԃɂ�����2�̕��̂̂Ȃ��p���v�Z
/// </summary>
/// <param name="P1">��1�̕��̂̈ʒu</param>
/// <param name="P2">��2�̕��̂̈ʒu</param>
/// <returns>�x�ŕ\�������̂̂Ȃ��p</returns>
 MathPhysicsAPI float calcAngle2D(float* P1, float* P2) {
	
	//�p�̌v�Z
	float ang = (float)atan((P2[1] - P1[1]) / (P2[0] - P1[0])) * RadToDeg;
	//�p����1�ی��ɂ���Ƃ�
	if (P2[1] < P1[1] && P2[0] > P1[0]) {
		return ang;
	}
	//�p����2�܂��͑�3�ی��ɂ���Ƃ�
	else if ((P2[1] < P1[1] && P2[0] < P1[0]) || (P2[1] > P1[1] && P2[0] < P1[0])) {
		return ang + 180;
	}
	else {
		return ang + 360;
	}
}

//---------------------------------------------------------------------
// ��4��
//---------------------------------------------------------------------

 //�x�N�g���𐬕��Ŋi�[����\����
 MathPhysicsAPI struct Vector2D_comp{

	 float x, y;
 };

 //�x�N�g����傫���ƌ������g�����\���Ŋi�[����\����
 MathPhysicsAPI struct Vector2D_polar
 {
	 float mag, dir;
 };

#define PI 3.14159265359

 /// <summary>
 /// �x�N�g����傫���ƌ������g�����\�����琬���\���ɕϊ�
 /// </summary>
 /// <param name="vec">�傫���ƌ������g���ĕ\�����x�N�g��</param>
 /// <returns>�ϊ���̃x�N�g��</returns>
 MathPhysicsAPI void PolarToCompConversion(Vector2D_polar vec, Vector2D_comp& temp){
	 //�������i�[����ꎞ�I�ϐ�
	 //�l����
	 temp.x = vec.mag * cos(vec.dir * PI / 180);
	 temp.y = vec.mag * sin(vec.dir * PI / 180);
	 //������Ԃ�
	 //return temp;
 };

  /// <summary>
 /// �x�N�g����傫���ƌ������g�����\�����琬���\���ɕϊ�
 /// </summary>
 /// <param name="vec">�傫���ƌ������g���ĕ\�����x�N�g��</param>
 /// <returns>�ϊ���̃x�N�g��</returns>
 MathPhysicsAPI void CompToPolarConversion(Vector2D_comp vec, Vector2D_polar& temp){
	 //�������i�[����ꎞ�I�ϐ�
	 //Vector2D_polar temp = { 0, 0 };
	 temp = { 0, 0 };
	 //�s�^�S���X�̒藝���g���ċ��߂�傫�����v�Z
	 temp.mag = sqrt(vec.x * vec.x + vec.y * vec.y);
	 //���̕����Ń[���Ŋ���Ƃ�����肪�����Ȃ��悤�Ƀ`�F�b�N
	 if (temp.mag == 0) {
		 // return temp;
	 }
	 //���߂�p���v�Z�B��1�܂��͑�4�ی��̊p��Ԃ�asin()���g��
	 temp.dir = (180 / PI) * asin(vec.y / temp.mag);
	 //�p����2�܂��͑�3�ی��ɂ���Ƃ��͒���
	 if (vec.x < 0) {
		 temp.dir = 180 - temp.dir;
	 }
	 //�p����4�ی��ɂ���Ƃ��͒���
	 else if (vec.x > 0 && vec.y < 0) {
		 temp.dir += 360;
	 }
	 //�V�����x�N�g����Ԃ�
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
//		 /// �R���X�g���N�^
//		 /// </summary>
//		 /// <param name="ex">�x�N�g����i����</param>
//		 /// <param name="why">�x�N�g����j����</param>
//		 /// <param name="zee">�x�N�g����k����</param>
//		 /// �o�́@�Ȃ�
//		 Vector3D(float ex = 0, float why = 0, float zee = 0) {
//			 x = ex; y = why; z = zee;
//		 }
//
//		 /// <summary>
//		 /// �f�X�g���N�^
//		 /// </summary>
//		 /// <returns>�Ȃ�</returns>
//		 ~Vector3D(){}
//
//		 /// <summary>
//		 /// �Ăяo���x�N�g���̑傫�����v�Z
//		 /// </summary>
//		 /// <returns></returns>
//		 float getMagnitude() {
//			 return sqrtf(x * x + y * y + z * z);
//		 }
//
//		 /// <summary>
//		 /// �x�N�g���ɃX�J���[�l���|����
//		 /// </summary>
//		 /// <param name="num">�x�N�g���Ɋ|����X�J���[�l</param>
//		 /// <returns>�V�����ł����x�N�g��</returns>
//		 Vector3D operator*(float num) const {
//			 return Vector3D(x * num, y * num, z * num);
//		 }
//
//		 /// <summary>
//		 /// �x�N�g���ɃX�J���[�l���|����
//		 /// </summary>
//		 /// <param name="num">�x�N�g���Ɋ|����X�J���[�l</param>
//		 /// <param name="vec">�X�J���[�l���|����x�N�g��</param>
//		 /// <returns>�V�����ׂ����x�N�g��</returns>
//		 friend Vector3D operator*(float num, const Vector3D& vec) {
//			 return Vector3D(vec.x * num, vec.y * num, vec.z * num);
//		 }
//
//		 /// <summary>
//		 /// �Q�̃x�N�g���̑����Z
//		 /// </summary>
//		 /// <param name="vec">�Ăяo���I�u�W�F�N�g�ɉ�����x�N�g��</param>
//		 /// <returns>�Q�̃x�N�g���̘a</returns>
//		 Vector3D operator+(const Vector3D& vec) const {
//			 return Vector3D(x + vec.x, y + vec.y, z + vec.z);
//		 }
//
//		 /// <summary>
//		 /// �Q�̃x�N�g���̈����Z
//		 /// </summary>
//		 /// <param name="vec">�Ăяo���I�u�W�F�N�g��������x�N�g��</param>
//		 /// <returns>�Q�̃x�N�g���̍�</returns>
//		 Vector3D operator-(const Vector3D& vec) const {
//			 return Vector3D(x - vec.x, y - vec.y, z - vec.z);
//		 }
//
//		 /// <summary>
//		 /// �Ăяo���x�N�g���̐��K���B����ɂ���ČĂяo���x�N�g�����ς��
//		 /// </summary>
//		 /// <param name="">�Ȃ�</param>
//		 /// <returns>�Ȃ�</returns>
//		 void normalizeVector3D(void) {
//			 float mag = sqrtf(x * x + y * y + z * z);
//			 x /= mag; y /= mag; z /= mag;
//		 }
//
//		 /// <summary>
//		 /// �Q�̃x�N�g���̓���
//		 /// </summary>
//		 /// <param name="vec">�Ăяo���I�u�W�F�N�g�Ɠ��ς���x�N�g��</param>
//		 /// <returns>2�̃x�N�g������ς����l</returns>
//		 float dotVector3D(const Vector3D& vec) const {
//			 return x * vec.x + y * vec.y + z * vec.z;
//		 }
//
//		 /// <summary>
//		 /// �Q�̃x�N�g���̊O��
//		 /// </summary>
//		 /// <param name="vec">�Ăяo���I�u�W�F�N�g�ƊO�ς���x�N�g��</param>
//		 /// <returns>�V�����ł����x�N�g��</returns>
//		 Vector3D crossVector3D(const Vector3D& vec) const {
//			 return Vector3D(
//				 y * vec.z - z * vec.y, z * vec.x - x * vec.z, x * vec.y - y * vec.x
//			 );
//		 }
//
//		 //const �����ƃG���[�ɂȂ�
//		 float angleBetween3DVectors( Vector3D& vec)  {
//			 return (acos(dotVector3D(vec) / (getMagnitude() * vec.getMagnitude())) * (180 / PI));
//		 }
// };


//---------------------------------------------------------------------
// ��5��
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

	//�s�񂪓��������ǂ����̃`�F�b�N������
	if (errorFlag == 1) {
		return false;
	}
	else {
		return true;
	}
}
