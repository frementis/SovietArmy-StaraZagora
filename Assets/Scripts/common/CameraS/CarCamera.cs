using UnityEngine;

public class CarCamera : MonoBehaviour
{

    public float sensitivity = 5.0f;
    public float minY = -30.0f;
    public float maxY = 30.0f;

    private float rotationY = 0.0f;

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotationY += mouseX;
        rotationY = Mathf.Clamp(rotationY, minY, maxY);

        transform.localEulerAngles = new Vector3(0, rotationY, 0);
    }
}
