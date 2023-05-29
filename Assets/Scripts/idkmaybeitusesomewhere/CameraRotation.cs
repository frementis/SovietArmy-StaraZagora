using UnityEngine;
using UnityEngine.EventSystems;

public class CameraRotation : MonoBehaviour
{
    public float sensitivity = 5f; // Чувствительность мыши
    private bool cursorLocked = true; // Блокировка курсора

    private void Update()
    {
        // Проверяем, находится ли курсор на UI элементах
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // Блокируем вращение камеры
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            // Разблокируем вращение камеры
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            // Обрабатываем вращение камеры
            float mouseX = Input.GetAxis("Mouse X") * sensitivity;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
            transform.Rotate(Vector3.up, mouseX);
            transform.Rotate(Vector3.right, -mouseY);
        }
    }
}
