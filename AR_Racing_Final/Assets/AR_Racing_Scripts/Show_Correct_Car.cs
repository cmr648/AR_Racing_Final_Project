using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Show_Correct_Car : MonoBehaviour
{
    public GameObject[] Possible_Cars;
    public Start_Game_Manager My_Start_Game_Manager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for (int i = 0; i < Possible_Cars.Length; i++)
        {
            if(PlayerPrefs.GetInt("Car_Selection") == i)
            {
                Possible_Cars[i].SetActive(true);
            }
            else
            {
                Possible_Cars[i].SetActive(false);
            }
        }
    }
}
