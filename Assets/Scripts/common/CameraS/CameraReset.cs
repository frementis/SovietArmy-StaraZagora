using UnityEngine;

public class CameraReset : MonoBehaviour
{
    private Vector3 startPosition;
    private Quaternion startRotation;

    private void Start()
    {
        // ��������� ��������� ������� � ������� ������
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            // ���������� ������ �� ��������� ������� � �������
            transform.position = startPosition;
            transform.rotation = startRotation;
        }
    }
}
