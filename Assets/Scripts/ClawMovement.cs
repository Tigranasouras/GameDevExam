using UnityEngine;

public class ClawMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public Vector2 newPosition;
    public Vector3 mousePosG;
    private Rigidbody2D body;
    private Camera cam;

    public float start;
    public float baseSpeed = 2.0f;

    public GameObject candyPrefab;
    public GameObject claw;
    public bool spawning;
    public float spawnDuration = 0.3f;
    public float cooldownRate = 1.0f;


    public float cooldown = 0.0f;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        cam = Camera.main;
        if (cam == null)
        {
            Debug.Log("Camer not found, Bozo.");
        }

        GameObject claw = GameObject.FindWithTag("Claw");
        if (claw == null)
        {
            Debug.Log("Claw boy not found");
        }
        
    }


    void Update()
    {
        mousePosG = cam.ScreenToWorldPoint(Input.mousePosition);
        candySpawn();
    }

    void FixedUpdate()
    {
        newPosition = Vector2.MoveTowards(transform.position, mousePosG, speed * Time.fixedDeltaTime);
        body.MovePosition(newPosition);
    }

    private void candySpawn()
    {
        if (Input.GetMouseButton(0))
        {
            
            Debug.Log("Spawning!");
            GameObject newBall = Instantiate(candyPrefab, claw.transform);
            
        }
    }

    private void CandySpawn2(){
        if (spawning == true){
             Debug.Log("Nah.");
        }
    }


}
