using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationInd : MonoBehaviour
{
    //what is a population ind?

    // a population individual contains both symbols and operators.
    // symbols might be numeric or constants.
    // operators might be plus, minus, times didivde, exponential etc

    // the amount of terms and operators must cost some energy to optimize length
    // a shorter solution is given more evaluation points.

    public double fitnessValue = 0;


    //Init population
    public void InitIndividual()
    {

    }

    //alter some values with a small change, relative value to fitness
    public void SmallCreepMe()
    {

    }

    //alter some values with a greater change, relative value to fitness
    public void BigCreepMe()
    {

    }

}