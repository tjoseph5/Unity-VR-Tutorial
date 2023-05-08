using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetShatter : MonoBehaviour
{
    public GameObject shatterObj;


    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ball")
        {
            GameObject destroyed = Instantiate(shatterObj, gameObject.transform.position, gameObject.transform.rotation, null);
            destroyed.transform.localScale = this.transform.localScale;

            Destroy(gameObject);
        }
    }

    private void OnDestroy()
    {
        
    }
}
