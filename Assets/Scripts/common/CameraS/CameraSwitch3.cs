using UnityEngine;

public class CameraSwitch3 : MonoBehaviour
{
    public Camera[] cameras; // ������ �����
    private int currentCameraIndex = 0; // ������ ������� ������

    void Start()
    {
        // �������� ������ ������
        cameras[currentCameraIndex].gameObject.SetActive(true);

        // ��������� ��� ��������� ������
        for (int i = 0; i < cameras.Length; i++)
        {
            if (i != currentCameraIndex)
            {
                cameras[i].gameObject.SetActive(false);
            }
        }
    }

    void Update()
    {
        // ������������ ����� � ������� ������ 1, 2 � 3
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchCamera(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchCamera(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchCamera(2);
        }
    }

    // ����� ������������ �����
    private void SwitchCamera(int index)
    {
        // ���� ������ �� � ��������� �������, ������� �� ������
        if (index < 0 || index >= cameras.Length)
        {
            return;
        }

        // ��������� ������� ������
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // �������� ����� ������
        cameras[index].gameObject.SetActive(true);

        // ��������� ������ ������� ������
        currentCameraIndex = index;
    }
}
