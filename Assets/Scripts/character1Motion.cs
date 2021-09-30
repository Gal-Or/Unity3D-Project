using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class character1Motion : MonoBehaviour
{

    private Animator animator;

    // for crossHair open/close
    public GameObject camera;
    public GameObject seeThroughCrosshair;
    public GameObject touchCrosshair;
    public Text whatToDo;
    private bool isSayingHay = false, isFocusOn = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit)) //check what object is in our focus
        {
            if (hit.transform.gameObject != null && hit.distance < 5)
            {
                // check that the obj in camera focus is THIS
                if (this.transform.gameObject == hit.transform.gameObject)
                {
                    if (!isFocusOn)
                    {
                        isFocusOn = true;
                        // change crosshair
                        seeThroughCrosshair.SetActive(false);
                        touchCrosshair.SetActive(true);
                    }


                    //show right msg to player
                    if (!isSayingHay)
                        whatToDo.text = "Press [X] To Say Hay";
                    else
                        whatToDo.text = "Press [z] To Stop Say Hay";

                    whatToDo.gameObject.SetActive(true);

                    //allow action on drawer
                    if (Input.GetKeyDown(KeyCode.Z))
                    {
                        animator.SetInteger("state", 0);
                        isSayingHay = false;
                    }  
                    else if (Input.GetKeyDown(KeyCode.X))
                    {
                        animator.SetInteger("state", 1);
                        isSayingHay = true;

                    }

                }
                
            }
            else //this.transform.gameObject != hit.transform.gameObject
            {
                if (isFocusOn)
                {
                    isFocusOn = false;
                    // change crosshair
                    seeThroughCrosshair.SetActive(true);
                    touchCrosshair.SetActive(false);
                    whatToDo.gameObject.SetActive(false);

                }


            }
        }


    }
}
