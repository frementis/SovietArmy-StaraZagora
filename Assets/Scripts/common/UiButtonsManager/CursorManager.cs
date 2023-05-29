using UnityEngine;
using UnityEngine.EventSystems;

public class CursorManager : MonoBehaviour
{
    public CarCamera myScript;
    public CarCamera myScript1;
    public CameraRotationLock myScript2;
    // Переменная для хранения состояния курсора
    private bool cursorIsHidden = true;


    // Метод для скрытия курсора
    private void Hide()
    {
        Cursor.visible = false;
        cursorIsHidden = true;
    }

    // Метод для отображения курсора
    private void Show()
    {
        Cursor.visible = true;
        cursorIsHidden = false;
    }

    // Обновление каждый кадр
    private void Update()
    {
        // Проверка, находится ли мышь над UI элементом
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // Если да, то отображаем курсор
            if (cursorIsHidden)
            {
                myScript.enabled = false;
                myScript1.enabled = false;
                myScript2.enabled = false;
                Show();
            }
        }
        else
        {
            // Иначе скрываем курсор
            if (!cursorIsHidden)
            {
                myScript.enabled = true;
                myScript1.enabled = true;
                myScript2.enabled = true;
                Hide();
            }
        }
    }
}
