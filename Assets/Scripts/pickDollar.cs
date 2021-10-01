using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //for text

public class pickDollar : MonoBehaviour
{
    public GameObject dollarInDrawer;
    private AudioSource pickSound;

    public Text dollarText;
    public static int numDollar;

   


    // Start is called before the first frame update
    void Start()
    {
        numDollar = 0;
        pickSound = GetComponent<AudioSource>();
      
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnMouseDown()
    {
        dollarInDrawer.SetActive(false);
        pickSound.PlayDelayed(0.4f);
        numDollar++;
        dollarText.text = "Money: " + numDollar*100 +"$";

    }

}
