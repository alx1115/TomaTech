using UnityEngine;

public class PlayerCntrl : MonoBehaviour{

    public float speed = 20f;
    private Rigidbody2D rb;

    void Start(){
        rb = GetComponent<Rigidbody2D> ();
    }

    void Update(){
        float moveX = Input.GetAxis ("Horizontal");
        rb.MovePosition (rb.position + Vector2.right * moveX * Time.deltaTime * speed);
        }
}