using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] prefabs; //Prefabs to spawn

    Camera c;
    int selectedPrefab = 0;

    // Start is called before the first frame update
    public void Start()
    {
        c = GetComponent<Camera>();
        if (prefabs.Length == 0)
        {
            Debug.LogError("You haven't assigned any Prefabs to spawn");
        }
    }

    // Update is called once per frame
    public void StartSpawn()
    {
        selectedPrefab = Random.Range(0, prefabs.Length);
        GameObject go = Instantiate(prefabs[selectedPrefab], GameObject.FindGameObjectWithTag("reticle").transform.position, Quaternion.identity);
        go.name += " _instantiated";
    }


}