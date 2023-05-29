using UnityEngine;

public class a3move : MonoBehaviour
{
    // ������ � ������� ������ ���� �� X
    public float xMin = -88f;
    public float xMax = 99f;
    public float Z = 20f;
    // �������� ����������� �������
    public float moveSpeed = 10f;
    private bool isPaused = true;

    void Update()
    {
        if (isPaused)
        {
            // �������� ������� ������� �������
            Vector3 position = transform.position;

            // ���� ������ ��������� � ���� �� X, ������� ��� �� Z
            if (position.x > xMin && position.x < xMax && position.z < Z)
            {
                position.z = Mathf.MoveTowards(position.z, Z, moveSpeed * Time.deltaTime);
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
