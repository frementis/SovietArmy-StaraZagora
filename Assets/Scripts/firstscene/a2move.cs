using UnityEngine;

public class a2move : MonoBehaviour
{
    // ������ � ������� ������ ���� �� X
    public float xMin = -90f;
    public float xMax = -95f;
    private bool isPaused = true;


    // �������� ����������� �������
    public float moveSpeed = 6f;

    void Update()
    {
        if (isPaused)
        {
            // �������� ������� ������� �������
            Vector3 position = transform.position;

            // ���� ������ ��������� � ���� �� X, ������� ���
            if (position.x > xMin && position.x < xMax)
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
