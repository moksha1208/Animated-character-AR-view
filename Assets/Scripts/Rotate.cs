using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
	Vector3 vect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vect = new Vector3(50, 50, 50);
		transform.Rotate(vect * Time.deltaTime);
    }
}
