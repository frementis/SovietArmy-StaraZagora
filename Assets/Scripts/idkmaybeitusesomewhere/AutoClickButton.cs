using UnityEngine;
using UnityEngine.UI;

public class AutoClickButton : MonoBehaviour
{
    public Button button;

    private void Start()
    {
        button.Select();
    }
}
