using UnityEngine;
using UnityEngine.EventSystems;

public class CursorManager : MonoBehaviour
{
    public CarCamera myScript;
    public CarCamera myScript1;
    public CameraRotationLock myScript2;
    // ���������� ��� �������� ��������� �������
    private bool cursorIsHidden = true;


    // ����� ��� ������� �������
    private void Hide()
    {
        Cursor.visible = false;
        cursorIsHidden = true;
    }

    // ����� ��� ����������� �������
    private void Show()
    {
        Cursor.visible = true;
        cursorIsHidden = false;
    }

    // ���������� ������ ����
    private void Update()
    {
        // ��������, ��������� �� ���� ��� UI ���������
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // ���� ��, �� ���������� ������
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
            // ����� �������� ������
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
