using UnityEngine;


public class EnemyBall3D : MonoBehaviour
{
    [Header("Balance (Inspector)")]
    [Tooltip("Distancia en metros para activar la persecuci�n")]
    [SerializeField] private float detectionRange = 10f;
    [Tooltip("Fuerza de empuje para rodar hacia el jugador")]
    [SerializeField] private float rollForce = 15f;
    [Tooltip("Velocidad m�xima para que no se acelere infinito")]
    [SerializeField] private float maxSpeed = 8f;

    [Header("Referencias")]
    [SerializeField] private Transform playerTransform;

    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        // Opcional: ajustar masa o drag si rueda muy raro
        rb.linearDamping = 0.5f;
        rb.angularDamping = 0.5f;
    }

    void Start()
    {
        if (playerTransform == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj != null)
            {
                playerTransform = playerObj.transform;
            }
            else
            {
                Debug.LogWarning("EnemyBall3D: Asigna el Player o usa la Tag 'Player'.");
            }
        }
    }

    void FixedUpdate()
    {
        if (playerTransform == null) return;

        // Distancia 3D en el espacio (X, Y, Z)
        float distance = Vector3.Distance(transform.position, playerTransform.position);

        if (distance <= detectionRange)
        {
            // Direcci�n 3D hacia el jugador
            Vector3 direction = (playerTransform.position - transform.position).normalized;

            // Aplicar fuerza f�sica de rodamiento
            rb.AddForce(direction * rollForce, ForceMode.Force);

            // Limitar velocidad horizontal para control de balance
            Vector3 horizontalVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);
            if (horizontalVelocity.magnitude > maxSpeed)
            {
                horizontalVelocity = horizontalVelocity.normalized * maxSpeed;
                rb.linearVelocity = new Vector3(horizontalVelocity.x, rb.linearVelocity.y, horizontalVelocity.z);
            }
        }
    }

    // Esfera roja 3D de 10 metros en el Editor
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}