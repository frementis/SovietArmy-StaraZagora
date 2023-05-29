using UnityEngine;

public class BlinkingLight : MonoBehaviour
{
    public float minIntensity = 0.5f;
    public float maxIntensity = 1.5f;
    public float speed = 1.0f;

    private Light light;

    void Start()
    {
        light = GetComponent<Light>();
    }

    void Update()
    {
        float intensity = Mathf.PingPong(Time.time * speed, maxIntensity - minIntensity) + minIntensity;
        light.intensity = intensity;
    }
}
