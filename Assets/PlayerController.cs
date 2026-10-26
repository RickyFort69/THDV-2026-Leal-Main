using UnityEngine;
using UnityEngine.InputSystem; 

namespace MyProject
{
    public class PlayerController : MonoBehaviour
    {
        [Header("Movimiento")]
        public float speed = 30f;
        public float maxVelocityX = 8f; // Límite de velocidad horizontal de Mario
        
        [Header("Salto")]
        public float jumpForce = 12f;
        public float fallMultiplier = 2.5f; // Para un salto más pesado y controlado tipo arcade
        public Transform groundCheck; // Un objeto vacío en los pies de Mario
        public LayerMask groundLayer; // Capa asignada al suelo ProBuilder
        public float groundCheckRadius = 0.2f;

        private Rigidbody rb;
        private Vector2 moveInput;
        private bool jumpRequested = false;
        private bool isGrounded = false;

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            
            // Congela las rotaciones para que Mario no se caiga de lado al chocar
            rb.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
        }

        void Update()
        {
            // 1. Entrada de movimiento horizontal
            if (Keyboard.current != null)
            {
                float moveX = 0f;
                float moveZ = 0f;

                if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed) moveZ = 1f;
                if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed) moveZ = -1f;
                if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed) moveX = -1f;
                if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed) moveX = 1f;

                moveInput = new Vector2(moveX, moveZ).normalized;

                // 2. Entrada de Salto (Se detecta en Update para no perder la pulsación)
                if ((Keyboard.current.spaceKey.wasPressedThisFrame) && isGrounded)
                {
                    jumpRequested = true;
                }
            }
        }

        void FixedUpdate()
        {
            // 3. Verificar si está tocando el suelo
            if (groundCheck != null)
            {
                isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);
            }
            else
            {
                // Failsafe por si te olvidas de asignar el GroundCheck en el Inspector
                isGrounded = Mathf.Abs(rb.linearVelocity.y) < 0.01f; 
            }

            // 4. Aplicar movimiento horizontal controlado
            Vector3 movement = new Vector3(moveInput.x, 0f, moveInput.y);
            rb.AddForce(movement * speed);

            // Limitar la velocidad máxima en X para que no acelere infinitamente
            float clampedX = Mathf.Clamp(rb.linearVelocity.x, -maxVelocityX, maxVelocityX);
            rb.linearVelocity = new Vector3(clampedX, rb.linearVelocity.y, rb.linearVelocity.z);

            // 5. Ejecutar el Salto
            if (jumpRequested)
            {
                // Reseteamos la velocidad vertical antes de saltar para que siempre salte con la misma fuerza
                rb.linearVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                jumpRequested = false;
            }

            // 6. Gravedad mejorada (Mario cae más rápido de lo que sube, como en el juego original)
            if (rb.linearVelocity.y < 0)
            {
                rb.linearVelocity += Vector3.up * Physics.gravity.y * (fallMultiplier - 1) * Time.fixedDeltaTime;
            }
        }

        // Dibuja la esfera de detección en el editor para que puedas calibrarla visualmente
        private void OnDrawGizmosSelected()
        {
            if (groundCheck != null)
            {
                Gizmos.color = Color.green;
                Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius);
            }
        }
    }
}
