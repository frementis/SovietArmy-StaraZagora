using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;

    private Vector3 firstCameraPos;
    private Vector3 secondCameraPos;
    private Quaternion firstCameraRot;
    private Quaternion secondCameraRot;
    private bool isFirstCameraActive = true;
    private bool starter = true;
    private void Start()
    {
        // ��������� ��������� ������� � �������� ������ ������
        firstCameraPos = firstCamera.transform.position;
        secondCameraPos = secondCamera.transform.position;
        firstCameraRot = firstCamera.transform.rotation;
        secondCameraRot = secondCamera.transform.rotation;

        // ���������� ������ ������
        firstCamera.enabled = true;
        secondCamera.enabled = false;
        Invoke("EnableMovement", 3f);
    }

    private void Update()
    {
        if (starter)
        {
            // ����������� ������ �� ������� ������� "1"
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                isFirstCameraActive = !isFirstCameraActive;

                // ��������� ������� � �������� ���������� ������
                if (isFirstCameraActive)
                {
                    secondCameraPos = secondCamera.transform.position;
                    secondCameraRot = secondCamera.transform.rotation;
                }
                else
                {
                    firstCameraPos = firstCamera.transform.position;
                    firstCameraRot = firstCamera.transform.rotation;
                }

                // ���������� ������ ������ � ��������������� �� ������� � ��������
                firstCamera.enabled = isFirstCameraActive;
                secondCamera.enabled = !isFirstCameraActive;

                if (isFirstCameraActive)
                {
                    firstCamera.transform.position = firstCameraPos;
                    firstCamera.transform.rotation = firstCameraRot;
                }
                else
                {
                    secondCamera.transform.position = secondCameraPos;
                    secondCamera.transform.rotation = secondCameraRot;
                }
            }
        }
    }
    private void EnableMovement()
    {
        starter = true;
    }
}
