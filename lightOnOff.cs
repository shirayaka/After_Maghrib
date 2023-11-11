using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightOnOff : MonoBehaviour
{

    [SerializeField] private GameObject light;
    [SerializeField] private bool toggle;
    
    // Start is called before the first frame update
    void Start()
    {
        if (toggle == false)
        {
            light.SetActive(false);
        }
        if (toggle == true)
        {
            light.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            toggle = !toggle;
            if (toggle == false)
            {
                light.SetActive(false);
            }
            if (toggle == true)
            {
                light.SetActive(true);
            }
        }
    }
}
