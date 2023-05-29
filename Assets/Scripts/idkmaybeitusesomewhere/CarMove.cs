using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // �������� ����������� �������
    [SerializeField] private Vector3 targetPosition; // �������� ������� �������

    private Vector3 startPosition; // ��������� ������� �������
    private float startTime; // ����� ������ �����������

    private void Start()
    {
        // ��������� ��������� ������� �������
        startPosition = transform.position;
    }

    private void Update()
    {
        // ��������� ������� ������� ������� � ����������� �� ���������� ������� � ��������
        float distance = Vector3.Distance(startPosition, targetPosition);
        float duration = distance / speed;
        float timeSinceStarted = Time.time - startTime;
        float percentageComplete = timeSinceStarted / duration;

        // ������ ���������� ������ � �������� �������
        transform.position = Vector3.Lerp(startPosition, targetPosition, percentageComplete);

        // ���� ������ ������ �������� �������, ���������� ����� ������ ����������� � ��������� �������
        if (percentageComplete >= 1.0f)
        {
            startTime = Time.time;
            startPosition = transform.position;
        }
    }

    // ����� ��� ������� ����� �������� ������� �������
    public void SetTargetPosition(Vector3 position)
    {
        targetPosition = position;
        startTime = Time.time;
        startPosition = transform.position;
    }
}
