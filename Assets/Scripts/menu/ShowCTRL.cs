using UnityEngine;

public class ShowCTRL : MonoBehaviour
{
    public GameObject uiElement;

    private void Start()
    {
        // Показываем скрытый UI элемент и всех его детей
        ShowUIElement(uiElement);
    }

    public void ShowUIElement(GameObject element)
    {
        // Устанавливаем активность элемента в true
        element.SetActive(true);

        // Проверяем дочерние объекты элемента и вызываем рекурсивно этот же метод
        foreach (Transform child in element.transform)
        {
            ShowUIElement(child.gameObject);
        }
    }
}
