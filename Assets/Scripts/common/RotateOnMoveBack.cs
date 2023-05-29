using UnityEngine;

public class RotateOnMoveBack : MonoBehaviour
{
    public float rotationSpeed = 200f; // �������� �������� �������
    private Vector3 previousPosition; // ���������� ������� �������
    private bool isPaused = false;

    private void Start()
    {
        previousPosition = transform.position; // ��������� ��������� ������� �������
    }

    private void Update()
    {
        if (isPaused)
        {
            Vector3 currentPosition = transform.position; // ������� ������� �������
            float distance = Vector3.Distance(currentPosition, previousPosition); // ���������� ����� ���������� � ������� ��������

            if (distance > 0) // ���� ������ ���������
            {
                float rotationAngle = rotationSpeed * Time.deltaTime; // ���� �������� �� ����
                transform.Rotate(Vector3.forward, rotationAngle); // ������� ������ �� ��� Z
            }

            previousPosition = currentPosition; // ��������� ���������� �������
        }
    }

    public void PauseScript()
    {
        isPaused = false;
    }

    public void ResumeScript()
    {
        isPaused = true;
    }

}
