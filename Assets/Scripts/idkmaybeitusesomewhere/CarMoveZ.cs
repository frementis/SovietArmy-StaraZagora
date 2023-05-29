using UnityEngine;

public class CarMoveZ : MonoBehaviour
{
    public float speed = 2.0f; // �������� ����������� �������
    public float distance = 12.0f; // ����������, �� ������� ����� ����������� ������

    private Vector3 startPosition; // ��������� ������� �������
    private Vector3 targetPosition; // �������� ������� �������
    private float startTime; // ����� ������ �����������

    void Start()
    {
        startPosition = transform.position;
        targetPosition = new Vector3(startPosition.x , startPosition.y, startPosition.z + distance);
        startTime = Time.time;
    }

    void Update()
    {
        float distanceCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distanceCovered / distance;
        transform.position = Vector3.Lerp(startPosition, targetPosition, fractionOfJourney);
    }
}
