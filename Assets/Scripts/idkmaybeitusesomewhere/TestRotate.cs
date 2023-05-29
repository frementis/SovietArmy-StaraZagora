using UnityEngine;
public class TestRotate : MonoBehaviour
{
    public float turnSpeed = 10f; // скорость поворота автомобиля

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // поворот автомобиля по оси Y
        float turnAmount = horizontalInput * turnSpeed * Time.fixedDeltaTime;
        Quaternion turnOffset = Quaternion.Euler(0f, turnAmount, 0f);
        rb.MoveRotation(rb.rotation * turnOffset);

        // движение автомобиля вперед/назад
        Vector3 moveDirection = transform.forward * verticalInput;
        float moveSpeed = 10f;
        rb.AddForce(moveDirection * moveSpeed, ForceMode.VelocityChange);
    }
}
