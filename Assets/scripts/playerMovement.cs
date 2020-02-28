using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    rb.AddForce(0,200,500);
    //}

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
