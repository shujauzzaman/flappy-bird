using UnityEngine;

public class BackgroundRepeat : MonoBehaviour
{

    Vector3 startPos;
    BoxCollider2D collider;

    [SerializeField] float moveSpeed;
    float repeatWidth;

    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider2D>().size.x / 2;
        // Debug.Log(startPos);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if(transform.position.x < startPos.x - repeatWidth){
            transform.position = startPos;
        }
    }

}
