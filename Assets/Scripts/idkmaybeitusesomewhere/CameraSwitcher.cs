using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera firstCamera;
    public Camera secondCamera;

    private Vector3 firstCameraPos;
    private Vector3 secondCameraPos;
    private Quaternion firstCameraRot;
    private Quaternion secondCameraRot;
    private bool isFirstCameraActive = true;
    private bool starter = true;
    private void Start()
    {
        // Сохраняем начальную позицию и вращение каждой камеры
        firstCameraPos = firstCamera.transform.position;
        secondCameraPos = secondCamera.transform.position;
        firstCameraRot = firstCamera.transform.rotation;
        secondCameraRot = secondCamera.transform.rotation;

        // Активируем первую камеру
        firstCamera.enabled = true;
        secondCamera.enabled = false;
        Invoke("EnableMovement", 3f);
    }

    private void Update()
    {
        if (starter)
        {
            // Переключаем камеры по нажатию клавиши "1"
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                isFirstCameraActive = !isFirstCameraActive;

                // Сохраняем позицию и вращение неактивной камеры
                if (isFirstCameraActive)
                {
                    secondCameraPos = secondCamera.transform.position;
                    secondCameraRot = secondCamera.transform.rotation;
                }
                else
                {
                    firstCameraPos = firstCamera.transform.position;
                    firstCameraRot = firstCamera.transform.rotation;
                }

                // Активируем нужную камеру и восстанавливаем ее позицию и вращение
                firstCamera.enabled = isFirstCameraActive;
                secondCamera.enabled = !isFirstCameraActive;

                if (isFirstCameraActive)
                {
                    firstCamera.transform.position = firstCameraPos;
                    firstCamera.transform.rotation = firstCameraRot;
                }
                else
                {
                    secondCamera.transform.position = secondCameraPos;
                    secondCamera.transform.rotation = secondCameraRot;
                }
            }
        }
    }
    private void EnableMovement()
    {
        starter = true;
    }
}
