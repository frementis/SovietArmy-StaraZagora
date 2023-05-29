using UnityEngine;
using UnityEngine.UI;

public class HintButton : MonoBehaviour
{
    public MeshRenderer[] objectsToToggle;
    public Button toggleButton;

    private bool isMeshRendererEnabled = false;

    private void Start()
    {
        // Назначить функцию ToggleMeshRenderer как обработчик события клика кнопки
        toggleButton.onClick.AddListener(ToggleMeshRenderer);
    }

    public void ToggleMeshRenderer()
    {
        isMeshRendererEnabled = !isMeshRendererEnabled;

        // Переключить видимость компонента MeshRenderer для каждого объекта в массиве
        foreach (MeshRenderer obj in objectsToToggle)
        {
            obj.enabled = isMeshRendererEnabled;
        }
    }
}
