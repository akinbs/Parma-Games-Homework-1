using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class My_box : MonoBehaviour
{
    // Start is called before the first frame update
    public static My_box Instance; 
    public void Awake()
    {
        Instance = this;
        
    }

    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(90*Time.deltaTime,0,0);
    }
}
