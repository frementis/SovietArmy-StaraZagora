using UnityEngine;

public class CameraRotationLock : MonoBehaviour
{
    // ���������� ��� �������� ����� �������� ������ ��� ���� ������
    private float pitch = 0f;
    private float yaw = 0f;
    private float roll = 0f;

    // ���������������� ������
    public float sensitivity = 100f;

    // ����� ��� ��������� ����� �� ����
    private void Update()
    {
        // ���������, �������� �� ��� ������ ������� �������� �������
        if (Camera.current != GetComponent<Camera>())
        {
            // ���� ���, �� �� ������������ ���� �� ����
            return;
        }

        // �������� ���� �� ���� �� ���� X � Y
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // �������� ���� �������� ������ �� ������ ����� �� ����
        yaw += mouseX;
        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        // ��������� ������� ������
        transform.rotation = Quaternion.Euler(pitch, yaw, roll);
    }
}
