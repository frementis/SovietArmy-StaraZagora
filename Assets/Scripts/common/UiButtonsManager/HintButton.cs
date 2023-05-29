using UnityEngine;
using UnityEngine.UI;

public class HintButton : MonoBehaviour
{
    public MeshRenderer[] objectsToToggle;
    public Button toggleButton;

    private bool isMeshRendererEnabled = false;

    private void Start()
    {
        // ��������� ������� ToggleMeshRenderer ��� ���������� ������� ����� ������
        toggleButton.onClick.AddListener(ToggleMeshRenderer);
    }

    public void ToggleMeshRenderer()
    {
        isMeshRendererEnabled = !isMeshRendererEnabled;

        // ����������� ��������� ���������� MeshRenderer ��� ������� ������� � �������
        foreach (MeshRenderer obj in objectsToToggle)
        {
            obj.enabled = isMeshRendererEnabled;
        }
    }
}
