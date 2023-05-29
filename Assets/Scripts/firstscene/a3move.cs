using UnityEngine;

public class a3move : MonoBehaviour
{
    // Нижний и верхний предел зоны по X
    public float xMin = -88f;
    public float xMax = 99f;
    public float Z = 20f;
    // Скорость перемещения объекта
    public float moveSpeed = 10f;
    private bool isPaused = true;

    void Update()
    {
        if (isPaused)
        {
            // Получаем текущую позицию объекта
            Vector3 position = transform.position;

            // Если объект находится в зоне по X, двигаем его по Z
            if (position.x > xMin && position.x < xMax && position.z < Z)
            {
                position.z = Mathf.MoveTowards(position.z, Z, moveSpeed * Time.deltaTime);
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
