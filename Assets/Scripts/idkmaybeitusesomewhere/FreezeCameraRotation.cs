using UnityEngine;
using UnityEngine.EventSystems;

public class FreezeCameraRotation : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private bool cameraRotationEnabled = true;

    private void Update()
    {
        // ���������, ��������� �� �������� ������
        if (cameraRotationEnabled)
        {
            // ������������ �������� ������ � ������� ����
            // �������� ����� ���� ��� ��� �������� ������
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        // ������ ���� ����� �� UI Button, ��������� �������� ������
        cameraRotationEnabled = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        // ������ ���� ������� UI Button, �������� �������� ������
        cameraRotationEnabled = true;
    }
}
