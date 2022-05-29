using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public Light  luzlinterna;
    bool activelight;
   // public GameObject player;
    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.F))
        {
            //transform.LookAt(player.transform);
            activelight = !activelight;
            if (activelight == true)
            {
                luzlinterna.enabled = true;
            }
            if (activelight == false)
            {
                luzlinterna.enabled = false;
            }
        }
    }
}
