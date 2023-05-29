using UnityEngine;

public class CameraRotationLock : MonoBehaviour
{
    // Переменные для хранения углов поворота только для этой камеры
    private float pitch = 0f;
    private float yaw = 0f;
    private float roll = 0f;

    // Чувствительность камеры
    public float sensitivity = 100f;

    // Метод для получения ввода от мыши
    private void Update()
    {
        // Проверяем, является ли эта камера текущей активной камерой
        if (Camera.current != GetComponent<Camera>())
        {
            // Если нет, то не обрабатываем ввод от мыши
            return;
        }

        // Получаем ввод от мыши по осям X и Y
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        // Изменяем углы поворота камеры на основе ввода от мыши
        yaw += mouseX;
        pitch -= mouseY;
        pitch = Mathf.Clamp(pitch, -90f, 90f);

        // Применяем поворот камеры
        transform.rotation = Quaternion.Euler(pitch, yaw, roll);
    }
}
