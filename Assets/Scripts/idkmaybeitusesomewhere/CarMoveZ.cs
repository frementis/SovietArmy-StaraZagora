using UnityEngine;

public class CarMoveZ : MonoBehaviour
{
    public float speed = 2.0f; // Скорость перемещения объекта
    public float distance = 12.0f; // Расстояние, на которое нужно переместить объект

    private Vector3 startPosition; // Начальная позиция объекта
    private Vector3 targetPosition; // Конечная позиция объекта
    private float startTime; // Время начала перемещения

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
