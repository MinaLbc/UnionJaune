using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    public int c_count;

    void Start()
    {
    	c_count = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("character"))
   		{
		   	c_count = c_count + 1;

		   		if(c_count >= 2)
		   		{
		   			shelter();
		   		}
	   	}	
    }

    void shelter()
    {
    	Debug.Log("you win");
    }



}
