using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform player;
    public Rigidbody rb;
    public float ForwardSpeed;
    public float SideSpeed;
    public bool MoveRight;
    public bool MoveLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Runs every frame of the game.  (put user input here)
    private void Update()
    {
        if (Input.GetKey("d"))
        {
            MoveRight = true;
        }
        else
        {
            MoveRight = false;
        }
        if (Input.GetKey("a"))
        {
            MoveLeft = true;
        }
        else
        {
            MoveLeft = false;
        }
        if (Input.GetKey("q"))
        {
            Application.Quit();
        }
    }

    // Update is called once per frame
    //FixedUpdate is used for physics
    void FixedUpdate()
    {
        rb.AddForce(0, 0, ForwardSpeed * Time.deltaTime);

        if (MoveRight == true)
        {
            rb.AddForce(SideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            transform.localRotation = Quaternion.Euler(0, 15, 0);
            //player.rotation.Set(player.rotation.x, 10, player.rotation.z, player.rotation.w);



        }
        else
        {
            transform.localRotation = Quaternion.Euler(0,0,0);
        }

        if (MoveLeft == true)
        {
            //ForceMode velocitychange allows us to ignore player mass.  (Better input response)
            rb.AddForce(-SideSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
            transform.localRotation = Quaternion.Euler(0, -15, 0);
        }

        if (rb.position.y < -1.7f)
        {
           
            FindObjectOfType<GameManager>().GameOver();

        }

    }
}
