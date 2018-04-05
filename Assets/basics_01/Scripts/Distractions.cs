using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distractions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void EnterConsole()
    {
        GameObject.Find("Canvas").transform.Find("center_console_text").gameObject.SetActive(true);
    }

    public void ExitConsole()
    {
        GameObject.Find("center_console_text").SetActive(false);
    }

    public void EnterPhone()
    {
        GameObject.Find("Canvas").transform.Find("phone_text").gameObject.SetActive(true);
    }

    public void ExitPhone()
    {
        GameObject.Find("phone_text").SetActive(false);
    }

    public void EnterLaptop()
    {
        GameObject.Find("Canvas").transform.Find("laptop_text").gameObject.SetActive(true);
    }

    public void ExitLaptop()
    {
        GameObject.Find("laptop_text").SetActive(false);
    }

    public void EnterFood()
    {
        GameObject.Find("Canvas").transform.Find("food_text").gameObject.SetActive(true);
    }

    public void ExitFood()
    {
        GameObject.Find("food_text").SetActive(false);
    }

    public void EnterGeneral()
    {
        GameObject.Find("Canvas").transform.Find("general_text").gameObject.SetActive(true);
    }

    public void ExitGeneral()
    {
        GameObject.Find("general_text").SetActive(false);
    }

    public void EnterPets()
    {
        GameObject.Find("Canvas").transform.Find("pets_text").gameObject.SetActive(true);
    }

    public void ExitPets()
    {
        GameObject.Find("pets_text").SetActive(false);
    }

    public void EnterCarOut1()
    {
        GameObject.Find("Canvas").transform.Find("entry_01_text").gameObject.SetActive(true);
    }

    public void ExitCarOut1()
    {
        GameObject.Find("entry_01_text").SetActive(false);
    }

    public void EnterCarIn1()
    {
        if(GameObject.Find("steering_wheel").GetComponent<MeshCollider>().enabled == true)
        {
            GameObject.Find("Canvas").transform.Find("exit_01_text_a").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("Canvas").transform.Find("exit_01_text_b").gameObject.SetActive(true);
        }
    }

    public void ExitCarIn1()
    {
        if (GameObject.Find("steering_wheel").GetComponent<MeshCollider>().enabled == true)
        {
            GameObject.Find("exit_01_text_a").SetActive(false);
        }
        else
        {
            GameObject.Find("exit_01_text_b").SetActive(false);
        }
    }

    public void EnterCarOut2()
    {
        GameObject.Find("Canvas").transform.Find("entry_02_text").gameObject.SetActive(true);
    }

    public void ExitCarOut2()
    {
        GameObject.Find("entry_02_text").SetActive(false);
    }

    public void EnterCarIn2()
    {
        GameObject.Find("Canvas").transform.Find("exit_02_text").gameObject.SetActive(true);
    }

    public void ExitCarIn2()
    {
        GameObject.Find("exit_02_text").SetActive(false);
    }

    public void SitUp1()
    {
        GameObject.Find("Canvas").transform.Find("sit_up_text").gameObject.SetActive(true);
    }

    public void SitUp2()
    {
        GameObject.Find("sit_up_text").SetActive(false);
    }
}
