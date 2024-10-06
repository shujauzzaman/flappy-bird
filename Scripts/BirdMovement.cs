using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdMovement : MonoBehaviour
{
    // references 
    Rigidbody2D player;
    AudioManager audioManager;
    MainMenu menu;

    // movement settings
    [SerializeField] float jumpForce;
    [SerializeField] float rotSpeed;
    [SerializeField] int rotAngle;

    void Awake()
    {
        player = GetComponent<Rigidbody2D>();
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        menu = Camera.main.GetComponent<MainMenu>();
    }

    void Update()
    {
        if(player.velocity.y > 0){
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0, rotAngle), Time.deltaTime * rotSpeed);
        }else if(player.velocity.y < 0){
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0,0, -rotAngle), Time.deltaTime * rotSpeed);
        }     
    }

    public void Jump(InputAction.CallbackContext context){
        if(context.performed){
            audioManager.PlaySFX(audioManager.fly);
            player.velocity = new Vector2(player.velocity.x, jumpForce);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle")){
            audioManager.PlaySFX(audioManager.death);
            menu.ShowEndGameUI();
        }
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Score")){
            audioManager.PlaySFX(audioManager.score);
            menu.UpdateScore();
        }
    }

}
