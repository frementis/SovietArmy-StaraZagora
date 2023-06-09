using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class README : MonoBehaviour
{
    
    void Start()
    {
        /* ----���� ���-�� ����� �������� � ��� � �������-----------
         * ��-������ �������� �� �������� �����. ����������� �������� ��������� ������������� � ����������� ���� �� ������� �������, ���� - �����.
         *
         *������ ���� ��� ���� � ������� ����� ������ � �����. ��� ����������� � ������� �����. � ������ ������� ����� ������, ��  � �� ��������� ���, �.�
         * � ����� ���� �������� ��������� ����� ������ � ��� ������������� � ���� �������, ��� ��������� ������������ �� ����, ����, ���� � ���� ������
         * �� �������� ������������� � ���������. ���� ���� �� ����������� � ��������, ������� �������� 50% ������ ��������, �� ��� �� ��� �� �����
         * 
         * � ������� ������� �������� �� ������� ����� �������, �� ���� �� ������� ��������, ���� ���� ����� � ������ �������� ������. ������ ��� ������
         *�� ������ ��� ����� �������� � ������� �������
         *
         *� ������ ���� ������� � ��� ���� ���������� � ������� ������ ����� ���� ������ ����. ��� �� ���� ���-�� ���������. 
         *
         *� ������ � ������� �� ����� �����, � �������� ����������� ������ �� ����������.������� ������ � ���� ������ ���� �������.  � ����� ���� ������� ���, ����� ���
         *�������������� ��� �����
         * 
         * ����� �� ������������ ���.
         * 
         * ------------------------� ������----------------------------
         * ��������� �1move  � �� ������������ ������� ��������. ������� ���������, ���� ��������� � ������������ ������. ������ ����� �������� �� �������� ������, �������� - �����.
         * �� ��������� ����������: �1move == b4move, �.�. � ������� ��������� � �����. ������ �1 ����� �� �������� ���� �����  �4. ������ �������� � �����, ��� � ���� ���� ���������
         * � ������� ������ 4 � ���� ������� � 4 � ������, 1, ������� ����� ��������� ����� ��� �������� � �� ����� � �������. �� � ����� ������ ���� ��������� ��� �������������.
         * ����� ������ 2: 1 ������ � 1 �����. + ������ ���������� ������ ����������.
         * 
         * ������ CameraRotationLock �� ����� ���� �� Lock, � ������ �� ��������� � ��������, ��� ��� ������ �������� ������ �����. ������ ����� ����� � ���, ��� ���� �� ��������
         * ����, �� � ������ ���������.
         * 
         * ������� �� ���. �� ����� ��� ��� ������������. �������� �� ������� 2 ���� � ���������� �1 �2. ��� ������� ������� �������. ��� �� ������������. �� ������ �� �� �� �������,
         * ������ ��� �������-����� ��� �� ��� ������.
         *
         * ����� �� ���������� ������ � ��� � ���� ����� ������� ��������. �� ����� third scene ��������� � main 3,second scene - main 1, main 2 ��������� �� �������� ������� �����
         * ���� 2 �������� ��� �� smh. ��� ��� ������� ������ ������� �� ������ ������ ���������� � ���. ���� �� ������, �� ������ ��� ��������� �������� �� �����
         * ������ �� ����� brick �� ������������
         * 
         * Cursor manager- ������� ������, ���� ������ �� �� ��. �������� ����� �����, ����� ����� �������� ������.
         * 
         * Tarbo-City-traffic, ������ ������������ ������ � ���������. ��������� ��������� � ��� ������ ������� ���� � �������� (����� �������� ��)
         * Trafficstuff ��� ��� ����� ���� ��������. ������ ������� � �������� ����� ���������� � ���� ��� � ������� ���������� ������ �������� �� 4 ���� �� ����.
         * 
         * ����� ���������� � �������� ������ - ���. � ��� ��� ��������� ������ � ������-�� ������ ������������� ������
         * 
         * Polygon city park, cars - ����. ������ ������������ 80% ������� � ����������. ����� ����. ������� ��� (���� floor ���� ������)
         * 
         * �� ����� ������������ �� NoparkingRoadSign.
         * 
         * Distans land ������� ���������. ������������� � ������ ������. ���� ��� �������� �����������, ��-�� ���� ��� �������� �������� �������, � ������ - ������
         * 
         * Broken vector - �������
         * 
         * testpolygon - ������� �������� �������
         * 
         * ������ ����������� � ������� �� ����� ������, �������� �������� ��������� ����� �������, �� � ��������
         * 
         * ������ ����������� ����������� �������� - �����-������ ������� � ����� ������������� ���� ������. ����� ���� �� ���� ������ ��� ����� �����.
         * 
         * ����������� ������ ����� � ����� start/diplomchik
         * ----��������� (���)---------------------
         * ��� �� ����� �������� ���� �� �� ���� ������� ���� � ��������. � �� �������, � � ��� ��� ����� �������. ��� ��������� ������������ ����������� � ������������ ���������
         * �����. ������ ������� - ��������� �� ������ � ������ ��� � �� ���� 4 ����� ��� ���� �������� ������.
         * 
         * � ��� ����� ��� ������������-������������!! ����� ��� �� �������� � ������� 1� �������������.
         * 
         * P.S. ���� �� ��� ��������� � � ��� �������� ��������� �������, �� ������ ��� � �� @sveenopass. �� ��� ������ ��� ��������, ������� �����
         * ������, ��� � ����, ���� � ������������ � �������, ����� ���-�� ��������
         * P.�.S. �������� 3 ������ ���� � 4 ���� ��� ���� -- ���� feat. ���� ����� - Bring Me To Life (Evanescence AI cover) --
        */
    }


    void Update()
    {
        
    }
}
