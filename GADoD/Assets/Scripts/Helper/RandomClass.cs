using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomClass : MonoBehaviour
{
    private double waitvalue = 0;
    private double deviationValue = 1;

    //return val on normal dist from 0-1
    public double stdDevRandom()
    {
        double firstpart = 1/(deviationValue*System.Math.Sqrt(2*System.Math.PI));
        double secondPart =  System.Math.Pow(System.Math.E, -(System.Math.Pow((EvenRandom() - waitvalue),2)/(2*deviationValue)));
        double combined = firstpart * secondPart;
        return System.Math.Abs(combined);
    }

    //return even random 0-1
    public float EvenRandom()
    {
        //System.Random rand = new System.Random();
        float rand = Random.Range(0.0f,1.0f);
        return(rand);
    }

    //return pyramid random 0-1, 0.5 most common
    public float PyramidRandom()
    {
        return((EvenRandom() + EvenRandom())/2.0f);
    }

}