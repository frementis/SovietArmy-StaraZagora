using UnityEngine;

public class g1move : MonoBehaviour
{
    // Нижний и верхний предел зоны по z
    public float zMin = 20f;
    public float zMax = 73f;

    // Скорость перемещения объекта
    public float moveSpeed = 10f;
    private bool isPaused = true;

    void Update()
    {
        if (isPaused)
        {
            Vector3 position = transform.position;

            // Если объект находится в зоне по Z, двигаем его
            if (position.z > zMin && position.z < zMax)
            {
                position.z = Mathf.MoveTowards(position.z, zMax, moveSpeed * Time.deltaTime);
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