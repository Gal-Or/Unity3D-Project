using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class drawer01Motion : MonoBehaviour
{
    public Animator animator;
    private AudioSource drawerSound;

    // for crossHair open/close
    public GameObject camera;
    public GameObject seeThroughCrosshair;
    public GameObject touchCrosshair;
    public Text whatToDo;
    private bool isDrawerOpened = false, isFocusOn = false;



    // Start is called before the first frame update
    void Start()
    {
        drawerSound = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
        if(Physics.Raycast(camera.transform.position, camera.transform.forward, out hit)) //check what object is in our focus
        {
            if(hit.transform.gameObject != null && hit.distance <5)
            {
                // check that the obj in camera focus is THIS
                if(this.transform.gameObject == hit.transform.gameObject)
                {
                    if(!isFocusOn)
                    {
                        isFocusOn = true;
                        // change crosshair
                        seeThroughCrosshair.SetActive(false);
                        touchCrosshair.SetActive(true);
                    }
                    

                    //show right msg to player
                    if (isDrawerOpened)
                        whatToDo.text = "Press [E] To Close The Drawer";
                    else
                        whatToDo.text = "Press [E] To Open The Drawer";

                    whatToDo.gameObject.SetActive(true);

                    
                }
                else //this.transform.gameObject != hit.transform.gameObject
                {
                    if(isFocusOn)
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

        //allow action on drawer
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("open", !isDrawerOpened);
            isDrawerOpened = !isDrawerOpened;


        }



    }
}
