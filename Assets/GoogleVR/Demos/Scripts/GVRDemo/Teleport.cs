// Copyright 2014 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;
using System;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class Teleport : MonoBehaviour
{
    private Vector3 startingPosition;
    private GameObject[] stations;

    public Material inactiveMaterial;
    public Material gazedAtMaterial;

    void Start()
    {
        //startingPosition = transform.localPosition;
        //SetGazedAt(false);
        this.stations = GameObject.FindGameObjectsWithTag("Teleport");
    }

    public void SetGazedAt(bool gazedAt)
    {
        if (inactiveMaterial != null && gazedAtMaterial != null)
        {
            GetComponent<Renderer>().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
            return;
        }
        GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
    }

    public void Reset()
    {
        transform.localPosition = startingPosition;
    }

    public void Recenter()
    {
#if !UNITY_EDITOR
        GvrCardboardHelpers.Recenter();
#else
    GvrEditorEmulator emulator = FindObjectOfType<GvrEditorEmulator>();
    if (emulator == null) {
      return;
    }
    emulator.Recenter();
#endif  // !UNITY_EDITOR
    }

//    public void TeleportRandomly()
//    {
//        Vector3 direction = Random.onUnitSphere;
//        direction.y = Mathf.Clamp(direction.y, 0.5f, 1f);
//        float distance = 2 * Random.value + 1.5f;
//        transform.localPosition = direction * distance;
//    }

    public void TeleportTo()
    {
        //        GameObject player = GameObject.Find("Player");
        float t_x;
        float t_z;
        float p_x = transform.position.x;
        float p_z = transform.position.z;
        Vector3 location = transform.localPosition;
        Vector3 player = GameObject.Find("Player").transform.position;
 
        GameObject.Find("Player").transform.position = new Vector3(location.x, 4f, location.z);

        foreach (GameObject tele in this.stations)
        {
            t_x = tele.transform.position.x;
            t_z = tele.transform.position.z;

            if(Math.Abs(t_x - p_x) < 9.5f && Math.Abs(t_z - p_z) < 9.5f)
            {
                tele.gameObject.SetActive(true);
            }
            else
            {
                tele.SetActive(false);
            }
        }
    }

    public void TeleportToDriver()
    {
        GameObject.Find("Player").transform.position = new Vector3(-1.8f, 2.8f, 87.75f);
    }

    public void TeleportOutDriver()
    {
        GameObject.Find("Player").transform.position = new Vector3(11.5f, 4f, 145.5f);//11.3f, 4f, 96.6f);
    }

    public void TeleportToPassenger()
    {
        GameObject.Find("Player").transform.position = new Vector3(-5.5f, 2.25f, 92.9f);
    }

    public void TeleportOutPassenger()
    {
        GameObject.Find("Player").transform.position = new Vector3(-11.2f, 4f, 95.3f);
    }
}