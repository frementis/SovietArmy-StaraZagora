using UnityEngine;

public class g1move : MonoBehaviour
{
    // ������ � ������� ������ ���� �� z
    public float zMin = 20f;
    public float zMax = 73f;

    // �������� ����������� �������
    public float moveSpeed = 10f;
    private bool isPaused = true;

    void Update()
    {
        if (isPaused)
        {
            Vector3 position = transform.position;

            // ���� ������ ��������� � ���� �� Z, ������� ���
            if (position.z > zMin && position.z < zMax)
            {
                position.z = Mathf.MoveTowards(position.z, zMax, moveSpeed * Time.deltaTime);
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