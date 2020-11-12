using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitPopulation : MonoBehaviour
{
    public PopulationInd populationInd;
    public Transform parentGO;
    public List<PopulationInd> ListOfPopulation;

    //Init population
    public void Init(int populationSize)
    {
        for (int i = 0; i < populationSize; i++)
        {
            PopulationInd ind = CreateIndividual(i);
            ListOfPopulation.Add(ind);
        }
    }

    //set up and return a fresh population individual
    private PopulationInd CreateIndividual(int i)
    {
        PopulationInd ind = Instantiate(populationInd,transform.position, transform.rotation);

        //organize in UNITY ide catalogized for inspection
        ind.transform.SetParent(parentGO);
        ind.InitIndividual(i);
        return ind;
    }
}