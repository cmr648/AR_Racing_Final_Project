using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Game_Manager : MonoBehaviour
{
    public GameObject Opening_Objects;
    public GameObject Select_Car_Objects;

    public int Car_selecting_Index; // creating an index for our car selection
    public int Car_Max_Selection; // creating an index for our maximum car selection

    public Pokemon_Shader_Transtion Transition_Manager;

    // Start is called before the first frame update
    void Start()
    {
        Opening_Objects.SetActive(true);
        Select_Car_Objects.SetActive(false);

        Car_selecting_Index = 0;

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        PlayerPrefs.SetInt("Car_Selection", Car_selecting_Index); // setting our car selection to our current car selecting index every farame

        if(Car_selecting_Index > Car_Max_Selection-1)
        {
            Car_selecting_Index = 0;
        }

        if (Car_selecting_Index < 0)
        {
            Car_selecting_Index = Car_Max_Selection-1;
        }

    }

    public void Touch_To_Begin()
    {
        Opening_Objects.SetActive(false);
        Select_Car_Objects.SetActive(true);
    }

    public void Reset_Menu()
    {
        Opening_Objects.SetActive(true);
        Select_Car_Objects.SetActive(false);
    }

    public void Select_Car_Right()
    {
        Car_selecting_Index += 1;
    }

    public void Select_Car_Left()
    {
        Car_selecting_Index -= 1;
    }

    public void Transition_Now()
    {
        Transition_Manager.Can_Transition = true;
    }



}
