using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Set_Active : MonoBehaviour
{
    public float Time_To_Set_Active;
    public GameObject Gameobject_To_Activate;


    // Start is called before the first frame update
    void Start()
    {
        Gameobject_To_Activate.SetActive(false);
        StartCoroutine("Set_Gameobject_Active");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Set_Gameobject_Active()
    {
        yield return new WaitForSeconds(Time_To_Set_Active);
        Gameobject_To_Activate.SetActive(true);
    }
}
