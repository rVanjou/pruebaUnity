using UnityEngine;

public class MovimientoBola2D : MonoBehaviour
{
    public float fuerzaMovimiento = 5f;
    public float velocidadImpulso = 8f;

    public enum TipoControl
    {
        WASD,
        Flechas
    }

    [Header("Tipo de control")]
    public TipoControl tipoControl = TipoControl.WASD;

    private Rigidbody2D rb;

    private bool impulsoPedido = false;
    private Vector2 direccionImpulso = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (tipoControl == TipoControl.WASD && Input.GetKeyDown(KeyCode.LeftShift))
        {
            float horizontalInput = (Input.GetKey(KeyCode.A) ? -1 : 0) + (Input.GetKey(KeyCode.D) ? 1 : 0);
            float verticalInput = (Input.GetKey(KeyCode.W) ? 1 : 0) + (Input.GetKey(KeyCode.S) ? -1 : 0);

            if (horizontalInput != 0 || verticalInput != 0)
            {
                impulsoPedido = true;
                direccionImpulso = new Vector2(horizontalInput, verticalInput);
            }
        }
        else if (tipoControl == TipoControl.Flechas && Input.GetKeyDown(KeyCode.RightShift))
        {
            float h = (Input.GetKey(KeyCode.LeftArrow) ? -1 : 0) + (Input.GetKey(KeyCode.RightArrow) ? 1 : 0);
            float v = (Input.GetKey(KeyCode.UpArrow) ? 1 : 0) + (Input.GetKey(KeyCode.DownArrow) ? -1 : 0);

            if (h != 0 || v != 0)
            {
                impulsoPedido = true;
                direccionImpulso = new Vector2(h, v);
            }
        }
    }

    void FixedUpdate()
    {
        float inputHorizontal = 0f;
        float inputVertical = 0f;

        if (tipoControl == TipoControl.WASD)
        {
            inputHorizontal = (Input.GetKey(KeyCode.A) ? -1 : 0) + (Input.GetKey(KeyCode.D) ? 1 : 0);
            inputVertical = (Input.GetKey(KeyCode.W) ? 1 : 0) + (Input.GetKey(KeyCode.S) ? -1 : 0);
        }
        else if (tipoControl == TipoControl.Flechas)
        {
            inputHorizontal = (Input.GetKey(KeyCode.LeftArrow) ? -1 : 0) + (Input.GetKey(KeyCode.RightArrow) ? 1 : 0);
            inputVertical = (Input.GetKey(KeyCode.UpArrow) ? 1 : 0) + (Input.GetKey(KeyCode.DownArrow) ? -1 : 0);
        }

        Vector2 direccionMovimiento = new Vector2(inputHorizontal, inputVertical);

        rb.AddForce(direccionMovimiento * fuerzaMovimiento);

        if (impulsoPedido)
        {
            rb.velocity = direccionImpulso * velocidadImpulso;
            impulsoPedido = false;
        }
    }
}
