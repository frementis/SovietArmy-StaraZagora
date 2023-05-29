using UnityEngine;

public class LMBText : MonoBehaviour
{
    public GameObject replacementObject;

    private void OnMouseDown()
    {
        // Скрыть текущий объект
        gameObject.SetActive(false);

        // Создать новый объект в том же месте
        Instantiate(replacementObject, transform.position, transform.rotation);
    }
}
