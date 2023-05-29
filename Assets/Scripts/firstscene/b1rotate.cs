using UnityEngine;

public class b1rotate : MonoBehaviour
{
    public float zMin = -99f;
    public float zMax = -86f;
    public float rotationAngle = 270f;
    public float rotationSpeed = 5f;
    private bool isPaused = false;
    void Update()
    {
        if (isPaused)
        {
            if (transform.position.z >= zMin && transform.position.z <= zMax)
            {
                Quaternion targetRotation = Quaternion.Euler(0f, rotationAngle, 0f);
                transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
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

