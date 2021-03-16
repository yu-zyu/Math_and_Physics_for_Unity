#include "pch.h"
#include "stdlib.h"
#include "Math_and_Physics.h"

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

/// <summary>
/// �Q�̒����̌�_�����߂� 
/// </summary>
/// <param name="L1Point">��1�̒������2D�̓_</param>
/// <param name="L1Slope">��1�̒����̌X��</param>
/// <param name="L2Point">��2�̒������2D�̓_</param>
/// <param name="L2Slope">��2�̒����̌X��</param>
/// <returns>���߂�_�̍��W���i�[����float�z��</returns>
MathPhysicsAPI float *lineIntersect(
	float *L1Point, float L1Slope, float *L2Point, float L2Slope)
{
	// �������i�[���邽�߂̔z�� temp
	float temp[2] = { 0, 0 };
	// x�ɂ��ĉ���
	temp[0] = (L1Slope * L1Point[0] - L2Slope * L2Point[0] + L2Point[1] - L1Point[1]) /
		 (L1Slope - L2Slope);
	// ����ꂽx�̒l�������āAy�̒l�����߂�
	temp[1] = L1Slope * (temp[0] - L1Point[0]) + L1Point[1];

	return temp;
}
