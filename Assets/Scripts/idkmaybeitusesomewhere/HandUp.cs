using UnityEngine;

public class HandUp : MonoBehaviour
{
    public float rotationSpeed = 35.0f;
    public float targetAngle = 70.0f;
    public float delay = 2.0f;

    private bool shouldRotate = false;
    private float currentAngle = 0.0f;
    private float elapsedTime = 0.0f;

    private void Start()
    {
        Invoke("StartRotation", delay);
    }

    private void Update()
    {
        if (shouldRotate)
        {
            elapsedTime += Time.deltaTime;
            float rotationStep = rotationSpeed * Time.deltaTime;

            if (currentAngle > targetAngle)
            {
                transform.Rotate(Vector3.up, rotationStep);
                currentAngle -= rotationStep;
            }
            else
            {
                shouldRotate = false;
            }
        }
    }

    private void StartRotation()
    {
        shouldRotate = true;
    }
}
