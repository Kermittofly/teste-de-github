using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private bool isGrounded = false;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //reconhecer o movimento horizontal
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);//vai aplicar a velocidade no rigidbody

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(new Vector2(0f, 5f), ForceMode2D.Impulse); // vai dar força ao pulo

        }
    }

    private void OnCollisionEnter2D( Collision2D collision)
    {
       if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; //Vai reconhecer quando o jogador estiver no chão
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; //Vai reconhecer quando o jogador não estiver no chão
        }
    }



}
