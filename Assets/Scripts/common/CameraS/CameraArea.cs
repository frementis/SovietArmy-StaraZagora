using UnityEngine;

public class CameraArea : MonoBehaviour
{
    private Vector3 startPosition;

    public float maxY = 6f;
    public float minY = -3f;
    public float maxX = 21f;
    public float minX = -14f;
    public float maxZ = 10f;
    public float minZ = -10f;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void LateUpdate()
    {
        Vector3 currentPosition = transform.position;

        // Ограничиваем перемещение по оси Y
        if (currentPosition.y > startPosition.y + maxY)
            currentPosition.y = startPosition.y + maxY;
        else if (currentPosition.y < startPosition.y + minY)
            currentPosition.y = startPosition.y + minY;

        // Ограничиваем перемещение по оси X
        if (currentPosition.x > startPosition.x + maxX)
            currentPosition.x = startPosition.x + maxX;
        else if (currentPosition.x < startPosition.x + minX)
            currentPosition.x = startPosition.x + minX;

        // Ограничиваем перемещение по оси Z
        if (currentPosition.z > startPosition.z + maxZ)
            currentPosition.z = startPosition.z + maxZ;
        else if (currentPosition.z < startPosition.z + minZ)
            currentPosition.z = startPosition.z + minZ;

        transform.position = currentPosition;
    }
}
