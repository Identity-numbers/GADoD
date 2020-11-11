using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationInd : MonoBehaviour
{
    //use random class to access random values
    public RandomClass randomClass;

    //what is my fitness
    public float fitnessValue = 0;

    //creation id, for sorting?
    public int creationID;

    //formulalist contains paranthesis and operators between
    private List<FormulaClass> FormulaList = new List<FormulaClass>();


    // what is a population ind?
        // a population individual contains both symbols and operators.
        // symbols might be numeric or constants.
        // operators might be plus, minus, times didivde, exponential etc

    //Init individual
    public void InitIndividual(int i)
    {
        creationID = i;
        //fitnessValue = randomClass.EvenRandom();
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