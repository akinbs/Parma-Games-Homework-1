using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameButton : MonoBehaviour
{
    public bool isHit = false; 
    public Counter counter;
    float a;
    void update()
    { 
        a = Mathf.Abs(My_box.Instance.transform.rotation.eulerAngles.x);
    }
    // Start is called before the first frame update
    public void onButtonClick()
    {
        if(((a <= 5 || (a>=85 && a<=95) || (a>=175 && a<=180) )&& !isHit)) 

        {
            counter.IncreaseCounter(); 
            isHit = true; 
            StartCoroutine(ResetHit());

        }
    }

    // Update is called once per frame
    public IEnumerator ResetHit()
    {
        yield return new WaitForSeconds(0.5f); 
        isHit = false; 
    }
}
