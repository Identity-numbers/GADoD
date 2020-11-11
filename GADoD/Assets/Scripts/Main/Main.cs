using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public InitPopulation initPopulation;
    public RandomClass randomClass;

    public int populationSize;

    /*
    //TODO:
    -Class that returns random numbers between 0 and 1 on a normal distribution curve.
    -separate ev of formulas from values?

    POPULATION
    -Init population
        -seed population
        -create random class, return normal dist of values

    -Collect formulas and statistically measure number of signs and their occurences.
        -how to box each number?
        -how to add parenthesis?

    FITNESS
    -create test environment
    -linear,sequence mapping of tree mapping?
    -define target? linear or tree mapping?
    -check mean global fitness to relate mution and creep
    -favor sequences with integers, or close to integers... 
    -favor well behaved expansion, terminate unwell behaved if growing to fast.
    -favor closeness to value, skip values or not? search scrambled values or not?
    -favor shorter formulas
    // the amount of terms and operators must cost some energy to optimize length
    // a shorter solution is given more evaluation points.

    CROSSOVER


    */

    private void Start()
    {
        //init population
        initPopulation.Init(populationSize);

        //Debug.Log(randomClass.EvenRandom());
        /*
        for (int i = 0; i < 30; i++)
        {        
            Debug.Log(randomClass.stdDevRandom());
        }
        */

        //loop generations
            //evaluate
            //breed
    }


}
