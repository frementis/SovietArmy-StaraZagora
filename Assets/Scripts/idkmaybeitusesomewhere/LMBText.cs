using UnityEngine;

public class LMBText : MonoBehaviour
{
    public GameObject replacementObject;

    private void OnMouseDown()
    {
        // ������ ������� ������
        gameObject.SetActive(false);

        // ������� ����� ������ � ��� �� �����
        Instantiate(replacementObject, transform.position, transform.rotation);
    }
}
