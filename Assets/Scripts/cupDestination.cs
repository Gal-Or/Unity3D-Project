using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupDestination : MonoBehaviour
{

    public int pivotPoint;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            if (pivotPoint == 7)
            {

                pivotPoint = 0;

            }
            if (pivotPoint == 6)
            {
                this.gameObject.transform.position = new Vector3(39, 2, -43);
                pivotPoint = 7;

            }
            if (pivotPoint == 5)
            {
                this.gameObject.transform.position = new Vector3(20, 2, -45);
                pivotPoint = 6;

            }
            if (pivotPoint == 4)
            {
                this.gameObject.transform.position = new Vector3(18, 11, -50);
                pivotPoint =5;
                
            }
            if (pivotPoint == 3)
            {
                this.gameObject.transform.position = new Vector3(20, 2, -43);
                pivotPoint = 4;
            }
            if (pivotPoint == 2)
            {
                this.gameObject.transform.position = new Vector3(3, 2, -43);
                pivotPoint = 3;
            }
            if (pivotPoint == 1)
            {
                this.gameObject.transform.position = new Vector3(3, 2, -62);
                pivotPoint = 2;
            }
            if (pivotPoint == 0)
            {
               this.gameObject.transform.position = new Vector3(39, 2, -62);
                pivotPoint = 1;
            }
           
           
        }
    }


}
