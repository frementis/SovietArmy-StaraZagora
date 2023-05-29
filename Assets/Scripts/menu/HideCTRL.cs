using UnityEngine;
using UnityEngine.UI;

public class HideCTRL : MonoBehaviour
{
    public GameObject uiElement; // ������ �� ��������� UI �������

    private Button button;

    private void Start()
    {
        // �������� ������ �� ��������� Button
        button = GetComponent<Button>();

        // ��������� �����-���������� �� ������� ������� ������
        button.onClick.AddListener(HideUIElement);
    }

    public void HideUIElement()
    {
        // �������� ��������� UI �������
        uiElement.SetActive(false);
    }
}
