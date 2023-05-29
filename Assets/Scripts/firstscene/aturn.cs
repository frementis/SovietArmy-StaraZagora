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
        // �������� ������� ���������� �������
        Vector3 pos = transform.position;

        // ���������, ��������� �� �� � ���� ��� ��������� ���������
        if (pos.x < maxX && pos.x > minX && pos.z > minZ && pos.z < maxZ)
        {
            isInZone = true;
        }
        else
        {
            isInZone = false;
        }

        // ���� �� ��������� � ����, ��������� ������ � ������ �������� ������ �������
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
        // ���� �� �� ��������� � ����, ���������� �������������� ��������
        else
        {
            rendererComponent.material = material1;
            isMaterial1 = true;
            timer = 0f;
        }
    }
}
