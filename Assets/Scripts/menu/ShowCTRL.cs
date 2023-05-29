using UnityEngine;

public class ShowCTRL : MonoBehaviour
{
    public GameObject uiElement;

    private void Start()
    {
        // ���������� ������� UI ������� � ���� ��� �����
        ShowUIElement(uiElement);
    }

    public void ShowUIElement(GameObject element)
    {
        // ������������� ���������� �������� � true
        element.SetActive(true);

        // ��������� �������� ������� �������� � �������� ���������� ���� �� �����
        foreach (Transform child in element.transform)
        {
            ShowUIElement(child.gameObject);
        }
    }
}
