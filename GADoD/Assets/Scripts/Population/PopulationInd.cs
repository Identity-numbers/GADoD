using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationInd : MonoBehaviour
{
    //use random class to access random values
    public RandomClass randomClass;
    public FormulaClass formulaClass;

    //what is my fitness
    public float fitnessValue = 0;

    //creation id, for sorting?
    public int creationID;

    //formulalist contains paranthesis and operators between
    //private List<FormulaClass> FormulaList = new List<FormulaClass>();

    // what is a population ind?
        // a population individual contains both symbols and operators.
        // symbols might be numeric or constants.
        // operators might be plus, minus, times didivde, exponential etc
        //fitnessValue = randomClass.EvenRandom();

    //Init individual
    public void InitIndividual(int i)
    {
        //add unique creation ID.
        creationID = i;

        //init individual random formula
        InitFormulaList();
    }

    //init individual random formula
    public void InitFormulaList()
    {
        //add formulaclass
        //PopulationInd ind = Instantiate(populationInd,transform.position, transform.rotation);
        FormulaClass formClass = 
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