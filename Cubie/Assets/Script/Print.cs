using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Print : MonoBehaviour
{   
    public Text inty;

   // public static int staticScore;
    // Start is called before the first frame update
    public CheckButton mathScore;
    void Start()
    { 
      inty.text = "" + mathScore.maXScore ; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
