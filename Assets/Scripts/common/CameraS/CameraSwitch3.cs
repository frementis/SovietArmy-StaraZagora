using UnityEngine;

public class CameraSwitch3 : MonoBehaviour
{
    public Camera[] cameras; // массив камер
    private int currentCameraIndex = 0; // индекс текущей камеры

    void Start()
    {
        // Включаем первую камеру
        cameras[currentCameraIndex].gameObject.SetActive(true);

        // Выключаем все остальные камеры
        for (int i = 0; i < cameras.Length; i++)
        {
            if (i != currentCameraIndex)
            {
                cameras[i].gameObject.SetActive(false);
            }
        }
    }

    void Update()
    {
        // Переключение камер с помощью клавиш 1, 2 и 3
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchCamera(0);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchCamera(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchCamera(2);
        }
    }

    // Метод переключения камер
    private void SwitchCamera(int index)
    {
        // Если индекс не в диапазоне массива, выходим из метода
        if (index < 0 || index >= cameras.Length)
        {
            return;
        }

        // Выключаем текущую камеру
        cameras[currentCameraIndex].gameObject.SetActive(false);

        // Включаем новую камеру
        cameras[index].gameObject.SetActive(true);

        // Обновляем индекс текущей камеры
        currentCameraIndex = index;
    }
}
