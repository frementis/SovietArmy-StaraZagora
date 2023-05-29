using UnityEngine;

public class RotateOnMoveBack : MonoBehaviour
{
    public float rotationSpeed = 200f; // скорость вращения объекта
    private Vector3 previousPosition; // предыдущая позиция объекта
    private bool isPaused = false;

    private void Start()
    {
        previousPosition = transform.position; // сохраняем начальную позицию объекта
    }

    private void Update()
    {
        if (isPaused)
        {
            Vector3 currentPosition = transform.position; // текущая позиция объекта
            float distance = Vector3.Distance(currentPosition, previousPosition); // расстояние между предыдущей и текущей позицией

            if (distance > 0) // если объект двигается
            {
                float rotationAngle = rotationSpeed * Time.deltaTime; // угол поворота за кадр
                transform.Rotate(Vector3.forward, rotationAngle); // вращаем объект по оси Z
            }

            previousPosition = currentPosition; // обновляем предыдущую позицию
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
