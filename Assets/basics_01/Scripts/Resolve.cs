using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolve : MonoBehaviour {

    private bool drive;
    private bool situp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(drive == true) {
            GameObject[] l_vehicles = GameObject.FindGameObjectsWithTag("Vehicle");
            GameObject[] o_vehicles = GameObject.FindGameObjectsWithTag("O_Vehicle");

            int count = 10;

            for (int i = 0; i < count; i++)
            {
                if(i < l_vehicles.Length)
                {
                    l_vehicles[i].transform.Translate(Vector3.forward * -7 * Time.deltaTime);
                    if (l_vehicles[i].transform.position.z > 700f) { Destroy(l_vehicles[i]); }
                }

                if (i < o_vehicles.Length)
                {
                    o_vehicles[i].transform.Translate(Vector3.forward * -7 * Time.deltaTime);
                    if (o_vehicles[i].transform.position.z < 0f) { Destroy(o_vehicles[i]); }
                }
            }
        }

        if(situp == true)
        {
            GameObject player = GameObject.Find("Player");  //.transform.position = new Vector3(-4.75f, 2.9f, 93f);
                                                            //.transform.position = new Vector3(-5.5f, 2.25f, 93f);
            if(player.transform.position.x < -4.75f) {
                player.transform.position += new Vector3(.025f, .02f, 0f);
            }
            else
            {
                this.situp = false;
            }
        }
    }

    public void RelocateCar()
    {
        GameObject.Find("Player").transform.position = new Vector3(2.26f, 2.8f, 0f);
        GameObject.Find("car_01").transform.position = new Vector3(3.2f, 1.35f, 0.3f);
        GameObject.Find("car_01").transform.Rotate(Vector3.up * 30);
        GameObject.Find("steering_wheel").GetComponent<MeshCollider>().enabled = false;
    }

    public void DestroyConsole()
    {
        Destroy(GameObject.Find("center_console"));
    }

    public void RelocateOncoming()
    {
        GameObject.Find("o_01").transform.position = new Vector3(-3f, 1.34f, 114f);
        GameObject.Find("o_02").transform.position = new Vector3(-8f, 1.34f, 130f);
        // GameObject.Find("o_03").transform.position = new Vector3(-8f, 1.34f, 210f);
        //GameObject.Find("o_04").transform.position = new Vector3(-3f, 1.34f, 265f);
        //GameObject.Find("o_05").transform.position = new Vector3(-8f, 1.34f, 315f);
        GameObject.Find("o_06").transform.position = new Vector3(-3f, 1.34f, 325f);
        GameObject.Find("o_07").transform.position = new Vector3(-8f, 1.34f, 375f);
        //GameObject.Find("o_08").transform.position = new Vector3(-3f, 1.34f, 400f);
        //GameObject.Find("o_09").transform.position = new Vector3(-8f, 1.34f, 85f);
        GameObject.Find("o_10").transform.position = new Vector3(-3f, 1.34f, 30f);
    }

    public void DestroyPhone()
    {
        Destroy(GameObject.Find("smartphone"));
    }

    public void ClearPassengerCar()
    {
        Destroy(GameObject.Find("car_02"));
    }

    public void DestroyLaptop()
    {
        Destroy(GameObject.Find("laptop"));
        Destroy(GameObject.Find("screen"));
    }

    public void ClearSideStreet()
    {
        Destroy(GameObject.Find("side_cars"));
    }

    public void DestroyFood()
    {
        Destroy(GameObject.Find("cola_can"));
        Destroy(GameObject.Find("travel_mug"));
    }

    public void ClearFireSmoke()
    {
        Destroy(GameObject.Find("Fire"));
        Destroy(GameObject.Find("Fire Smoke"));
    }

    public void DestroyPets()
    {
        Destroy(GameObject.Find("cat_Eat"));
    }

    public void RelocateLaneTraffic()
    {
        GameObject.Find("l_01").transform.position = new Vector3(3f, 1.34f, 68f);
        GameObject.Find("l_02").transform.position = new Vector3(8f, 1.34f, 25f);
        GameObject.Find("l_03").transform.position = new Vector3(8f, 1.34f, 175f);
      ////  GameObject.Find("l_04").transform.position = new Vector3(3f, 1.34f, 215f);
      //  GameObject.Find("l_05").transform.position = new Vector3(8f, 1.34f, 280f);
        GameObject.Find("l_06").transform.position = new Vector3(3f, 1.34f, 325f);
        //GameObject.Find("l_07").transform.position = new Vector3(8f, 1.34f, 375f);

    }

    public void DriveTime()
    {
        this.drive = true;
    }


    public void SitUp()
    {
        //        GameObject.Find("Player").transform.position = new Vector3(-4.75f, 2.9f, 93f);
        this.situp = true;
    }
}
