using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRotation : MonoBehaviour
{
    public float sensitivity = 5f; // ���������������� ����
    private bool cursorLocked = true; // ���������� �������

    private void Update()
    {
        // ���������, ��������� �� ������ �� UI ���������
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // ��������� �������� ������
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            // ������������ �������� ������
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            // ������������ �������� ������
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
            transform.Rotate(Vector3.up, mouseX);
            transform.Rotate(Vector3.right, -mouseY);
        }
    }
}
