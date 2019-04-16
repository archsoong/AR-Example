using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

    public bool isOpen;
    public GameObject light;
	
	void Start () 
	{
        isOpen = false;
        light.SetActive(false);
	}

    private void OnMouseUpAsButton()
    {
        light.SetActive(light.activeInHierarchy ? false : true);
        isOpen = isOpen ? false : true;

        if (isOpen)
        {
            this.transform.localScale = new Vector3(1, 1, 0.5f);
        }
        else
        {
            this.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
