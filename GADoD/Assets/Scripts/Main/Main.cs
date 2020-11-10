using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public InitPopulation initPopulation;
    public RandomClass randomClass;

    public int populationSize = 100;

    /*
    //TODO:

    -Init population
        -seed population
    -create random class, return normal dist of values

    -create test environment
    -Class that returns random numbers between 0 and 1 on a normal distribution curve.
    -Collect formulas and statistically measure number of signs and their occurences.
        -how to box each number?
        -how to add parenthesis?
    -favor well behaved expansion, terminate unwell behaved if growing to fast.
    -favor closeness to value, skip values or not? search scrambled values or not?
    -favor shorter formulas
    -separate ev of formulas from values?
    -linear,sequence mapping of tree mapping?
    - define target? linear or tree mapping?

    - get average fitness for total population
    */

    private void Start()
    {
        //Debug.Log(randomClass.EvenRandom());
        for (int i = 0; i < 30; i++)
        {        
            Debug.Log(randomClass.stdDevRandom());
        }
        //init population
        initPopulation.Init();

        //loop generations
            //evaluate
            //breed
    }
}
