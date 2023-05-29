using UnityEngine;

public class c1rotate : MonoBehaviour
{
    public float xMin = -99f;
    public float xMax = -86f;
    public float rotationAngle = 270f;
    public float rotationSpeed = 5f;
    private bool isPaused = true;
    void Update()
    {
        if (isPaused)
        {
            if (transform.position.x >= xMin && transform.position.x <= xMax)
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

