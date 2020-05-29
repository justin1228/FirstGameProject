
using UnityEngine;

public class Player1 : MonoBehaviour
{
    
    public Rigidbody rb;

    public float forwardForce = 500f;
    public float sideForce = 1000f;
    public float verticalForce = 9800f;

    

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
        
    }
    //We marked this as "Fixed"Update because we
    //ar using it to mess with physics
    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime); // Add a force of 1000 on the z-axis
        rb.AddForce(0,0,forwardForce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce*Time.deltaTime,0,0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideForce*Time.deltaTime,0,0);
        }
        
        if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-forwardForce*Time.deltaTime);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(0,verticalForce*Time.deltaTime,0);
        }
        if(Input.GetKeyDown(KeyCode.Escape)){
            Application.Quit();
        }
    }
}
