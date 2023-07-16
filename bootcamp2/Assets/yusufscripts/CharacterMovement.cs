using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Vector3 previousPosition;
     private float teleportCooldown = 5f;
    private float teleportTimer = 0f;


    private void Start()
    {
        previousPosition = transform.position;
    }

    private void Update()
    {
        // Karakterin hareketini algılayan kodu burada yazın.
        // Örneğin:
        float moveSpeed = 5f;
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        // Belirli bir tuşa basıldığında ışınlama işlemini yapacak kodu burada yazın.
        // Örneğin:
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.position = previousPosition;
        }
        if (Input.GetKeyDown(KeyCode.Space) && teleportTimer <= 0f)
        {
            transform.position = previousPosition;
            teleportTimer = teleportCooldown;
        }


        // Karakterin mevcut konumunu previousPosition değişkenine kaydedin.
        previousPosition = transform.position;

        if (teleportTimer > 0f)
        {
            teleportTimer -= Time.deltaTime;
        }
    }
}
