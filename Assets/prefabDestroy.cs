using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabDestroy : MonoBehaviour
{
    private GameObject unitychan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.unitychan = GameObject.Find("unitychan");

        Debug.Log(this.unitychan.transform.position.z);
        if (unitychan.transform.position.z - 4 > this.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}
