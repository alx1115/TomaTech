using UnityEngine;

public class PlayerSprites : MonoBehaviour
{

    public Sprite R;
    public Sprite RUp;
    private SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer.sprite == null) 
            spriteRenderer.sprite = R;
    }

    // Input.GetKeyDown (KeyCode.Space)
    void Update(){
        deltaSprite();
    }
    void deltaSprite(){
        if (Input.GetAxis ("Horizontal")>0){
            spriteRenderer.sprite = R;
            spriteRenderer.flipX = false;
        }else if(Input.GetAxis ("Horizontal")<0){
            spriteRenderer.sprite = R;
            spriteRenderer.flipX = true;
        }else if(Input.GetAxis ("Horizontal")==0){
            spriteRenderer.sprite = RUp;
        }
    }
}



       
   
     

