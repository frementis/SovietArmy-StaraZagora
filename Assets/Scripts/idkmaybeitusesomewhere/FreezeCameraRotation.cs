using UnityEngine;
using UnityEngine.EventSystems;

public class FreezeCameraRotation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool cameraRotationEnabled = true;

    private void Update()
    {
        // Проверяем, разрешено ли вращение камеры
        if (cameraRotationEnabled)
        {
            // Обрабатываем вращение камеры с помощью мыши
            // Напишите здесь свой код для вращения камеры
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // Курсор мыши попал на UI Button, отключаем вращение камеры
        cameraRotationEnabled = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // Курсор мыши покинул UI Button, включаем вращение камеры
        cameraRotationEnabled = true;
    }
}
