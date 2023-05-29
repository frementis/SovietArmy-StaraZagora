using UnityEngine;
using UnityEngine.UI;

public class HideCTRL : MonoBehaviour
{
    public GameObject uiElement; // Ссылка на выбранный UI элемент

    private Button button;

    private void Start()
    {
        // Получаем ссылку на компонент Button
        button = GetComponent<Button>();

        // Добавляем метод-обработчик на событие нажатия кнопки
        button.onClick.AddListener(HideUIElement);
    }

    public void HideUIElement()
    {
        // Скрываем выбранный UI элемент
        uiElement.SetActive(false);
    }
}
