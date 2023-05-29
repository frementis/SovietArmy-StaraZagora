using UnityEngine;

public class h2move : MonoBehaviour
{
    // ������ � ������� ������ ���� �� z
    public float zMin = 20f;
    public float zMax = 73f;
    public float X = -100f;

    // �������� ����������� �������
    public float moveSpeed = 10f;
    private bool isPaused = false;

    void Update()
    {
        if (isPaused)
        {
            Vector3 position = transform.position;

            // ���� ������ ��������� � ���� �� Z, ������� ���
            if (position.z > zMin && position.z < zMax && position.x > X)
            {
                position.z = Mathf.MoveTowards(position.z, zMin, moveSpeed * Time.deltaTime);
                transform.position = position;
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