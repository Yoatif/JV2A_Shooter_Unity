using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReplacementOnDestroy : MonoBehaviour
{
    public GameObject replacementObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MAchinTrucs()
    {
        if (replacementObject != null)
        {
            Instantiate(replacementObject, transform.position, transform.rotation);
        }
    }
}
