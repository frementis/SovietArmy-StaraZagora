using UnityEngine;

public class aturn : MonoBehaviour
{
    public Material material1;
    public Material material2;

    public float maxX = -50f;
    public float minX = -100f;
    public float maxZ = 31f;
    public float minZ = 13f;

    private Renderer rendererComponent;

    private bool isInZone = false;
    private bool isMaterial1 = true;
    private float timer = 0f;

    void Start()
    {
        rendererComponent = GetComponent<Renderer>();
    }

    void Update()
    {
        // Получаем текущие координаты объекта
        Vector3 pos = transform.position;

        // Проверяем, находимся ли мы в зоне для изменения материала
        if (pos.x < maxX && pos.x > minX && pos.z > minZ && pos.z < maxZ)
        {
            isInZone = true;
        }
        else
        {
            isInZone = false;
        }

        // Если мы находимся в зоне, запускаем таймер и меняем материал каждую секунду
        if (isInZone)
        {
            timer += Time.deltaTime;

            if (timer > 0.5f)
            {
                isMaterial1 = !isMaterial1;

                if (isMaterial1)
                {
                    rendererComponent.material = material1;
                }
                else
                {
                    rendererComponent.material = material2;
                }

                timer = 0f;
            }
        }
        // Если мы не находимся в зоне, возвращаем первоначальный материал
        else
        {
            rendererComponent.material = material1;
            isMaterial1 = true;
            timer = 0f;
        }
    }
}
