using UnityEngine;
using UnityEngine.UI;

public class TimeSliderBack : MonoBehaviour
{
    public Slider slider;
    public float speed = 1.0f;
    private float timePassed = 0.0f;
    private bool isPaused = false;

    void Update()
    {
        if (isPaused)
        {
            timePassed += Time.deltaTime;
            if (timePassed >= 0.01f)
            {
                slider.value += -0.01f;
                timePassed = 0.0f;

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

