using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] int leftBound;

    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);   

        if(transform.position.x < leftBound && gameObject.CompareTag("Obstacle")){
            Destroy(gameObject);
        } 
    }
}
