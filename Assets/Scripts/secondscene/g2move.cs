using UnityEngine;

public class g2move : MonoBehaviour
{
    // ������ � ������� ������ ���� �� z
    public float xMin = 20f;
    public float xMax = 73f;
    public float Z = 73f;

    // �������� ����������� �������
    public float moveSpeed = 10f;
    private bool isPaused = true;

    void Update()
    {
        if (isPaused)
        {
            // �������� ������� ������� �������
            Vector3 position = transform.position;

            // ���� ������ ��������� � ���� �� Z, ������� ���
            if (position.x > xMin && position.x < xMax && position.z > Z)
            {
                position.x = Mathf.MoveTowards(position.x, xMin, moveSpeed * Time.deltaTime);
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
