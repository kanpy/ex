using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap4Move : MonoBehaviour
{
    public Rigidbody rb;    //trap
    public Rigidbody Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Player.position.z > 46)
        {
            rb.AddForce(0, -20, 0, ForceMode.Impulse);
        }
    }
}
