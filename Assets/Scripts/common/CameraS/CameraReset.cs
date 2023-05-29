using UnityEngine;

public class CameraReset : MonoBehaviour
{
    private Vector3 startPosition;
    private Quaternion startRotation;

    private void Start()
    {
        // сохраняем стартовую позицию и поворот камеры
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            // перемещаем камеру на стартовую позицию и поворот
            transform.position = startPosition;
            transform.rotation = startRotation;
        }
    }
}
