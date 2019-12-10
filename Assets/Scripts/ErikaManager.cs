using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErikaManager : MonoBehaviour
{
    Animator Erika;
        
    // Start is called before the first frame update
    void Start()
    {
        Erika = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Erika.SetInteger("state", 0);
        if (Input.GetKey("up"))
        {
            Erika.SetInteger("state", 1);
        }

        if (Input.GetKey("left"))
        {
            Erika.SetInteger("state", 2);
        }

        if (Input.GetKey("right"))
        {
            Erika.SetInteger("state", 3);
        }

        if (Input.GetKey("down"))
        {
            Erika.SetInteger("state", 4);
        }

        
    }
}
