using UnityEngine;
using UnityEngine.UI;

public class HotKey : MonoBehaviour
{
    public KeyCode targetKey;
    public Button selectedButton;

    private void Update()
    {
        if (Input.GetKeyDown(targetKey))
        {
            if (selectedButton != null)
            {
                selectedButton.onClick.Invoke();
            }
        }
    }
}
