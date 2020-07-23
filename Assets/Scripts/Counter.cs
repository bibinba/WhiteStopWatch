using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{

public UnityEngine.UI.Text TimeText;

public static float countTime;

private int a;

    // Start is called before the first frame update
    void Start()
    {
        countTime = 0;
        a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(a == 1){
           countTime += Time.deltaTime; 
        }
        if(a == 2){
           countTime = countTime; 
        }
        if(a == 0){
           countTime = 0; 
        }

    TimeText.text = countTime.ToString ("F2");
 
    }

   public void OnClickStart(){
        a = 1;
   }
   public void OnClickStop(){
        a = 2;
   }
   public void OnClickReset(){
        a = 0;
   }
}
