using UnityEngine;

public class a1move : MonoBehaviour
{
    // Нижний и верхний предел зоны по X
    public float xMin = -88f;
    public float xMax = -1f;
    private bool isPaused = true;


    // Скорость перемещения объекта
    public float moveSpeed = 10f;

    void Update()
    {
        if (isPaused)
        {
            // Получаем текущую позицию объекта
            Vector3 position = transform.position;

            // Если объект находится в зоне по X, двигаем его
            if (position.x > xMin && position.x < xMax)
            {
                position.x = Mathf.MoveTowards(position.x, xMin, moveSpeed * Time.deltaTime);
                transform.position = position;
            }
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
