using UnityEngine;

public class PlayerController : MonoBehaviour {

    private readonly string HORIZONTAL = "Horizontal";
    private readonly string VERTICAL = "Vertical";
    private Vector2 directionVector;
    private Rigidbody2D rb2D;
    private Animator animator;


    void Start() {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update() {
        directionVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W)) directionVector += Vector2.up;
        if (Input.GetKey(KeyCode.S)) directionVector += Vector2.down;
        if (Input.GetKey(KeyCode.D)) directionVector += Vector2.right;
        if (Input.GetKey(KeyCode.A)) directionVector += Vector2.left;
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            GameManager.Instance.AddScore(10);
        }
        
        if (Input.GetKeyDown(KeyCode.Q)) {
            LevelManager.Instance.Print();
        }
        
        animator.SetFloat(HORIZONTAL, directionVector.x);
        animator.SetFloat(VERTICAL, directionVector.y);
    }
    
    void FixedUpdate() {
        rb2D.MovePosition(rb2D.position + directionVector.normalized * (5 * Time.deltaTime));
    }
    
}
