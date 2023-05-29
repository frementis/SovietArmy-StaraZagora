using UnityEngine;
using UnityEngine.EventSystems;

public class CameraController : MonoBehaviour
{
    public float speed = 5.0f;

    private bool isCursorOverUI;

    private void Update()
    {
        if (!isCursorOverUI)
        {
            float horizontal = Input.GetAxis("Horizontal") * speed;
            float vertical = Input.GetAxis("Vertical") * speed;

            transform.Rotate(-vertical, horizontal, 0.0f);
        }
    }

    public void OnPointerEnterUI()
    {
        isCursorOverUI = true;
    }

    public void OnPointerExitUI()
    {
        isCursorOverUI = false;
    }
}
