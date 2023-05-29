using UnityEngine;

public class CarMove : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Скорость перемещения объекта
    [SerializeField] private Vector3 targetPosition; // Конечная позиция объекта

    private Vector3 startPosition; // Начальная позиция объекта
    private float startTime; // Время начала перемещения

    private void Start()
    {
        // Сохраняем начальную позицию объекта
        startPosition = transform.position;
    }

    private void Update()
    {
        // Вычисляем текущую позицию объекта в зависимости от прошедшего времени и скорости
        float distance = Vector3.Distance(startPosition, targetPosition);
        float duration = distance / speed;
        float timeSinceStarted = Time.time - startTime;
        float percentageComplete = timeSinceStarted / duration;

        // Плавно перемещаем объект к конечной позиции
        transform.position = Vector3.Lerp(startPosition, targetPosition, percentageComplete);

        // Если объект достиг конечной позиции, сбрасываем время начала перемещения и начальную позицию
        if (percentageComplete >= 1.0f)
        {
            startTime = Time.time;
            startPosition = transform.position;
        }
    }

    // Метод для задания новой конечной позиции объекта
    public void SetTargetPosition(Vector3 position)
    {
        targetPosition = position;
        startTime = Time.time;
        startPosition = transform.position;
    }
}
