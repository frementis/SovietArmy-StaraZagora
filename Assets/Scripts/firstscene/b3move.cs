using UnityEngine;

public class b3move : MonoBehaviour
{
    // Нижний и верхний предел зоны по z
    public float xMin = 20f;
    public float xMax = 73f;

    // Скорость перемещения объекта
    public float moveSpeed = 10f;
    private bool isPaused = false;

    void Update()
    {
        if (isPaused)
        {
            // Получаем текущую позицию объекта
            Vector3 position = transform.position;

            // Если объект находится в зоне по Z, двигаем его
            if (position.x > xMin && position.x < xMax && position.z < 18)
            {
                position.x = Mathf.MoveTowards(position.x, xMax, moveSpeed * Time.deltaTime);
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
