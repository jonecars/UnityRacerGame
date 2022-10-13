using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideToSide : MonoBehaviour
{
    public Transform barrel;
    private float SideSpeed;
    public Rigidbody barrelMovement;

    // Start is called before the first frame update
    void Start()
    {

        SideSpeed = -15;
        

    }

    // Update is called once per frame
    void Update()
    {
        

        
        if (barrel.position.x > -30f & barrel.position.x < -28.5 )
        {
            SideSpeed = 15;
            Debug.Log("I am passed 30");
        }
        else if (barrel.position.x < 4f & barrel.position.x > 2.5)
        {
            SideSpeed = -15;
        }

        barrelMovement.AddForce(SideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);







    }
}
