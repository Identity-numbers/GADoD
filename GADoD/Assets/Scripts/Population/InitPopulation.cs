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

    private PopulationInd CreateIndividual(int i)
    {
        PopulationInd ind = Instantiate(populationInd,transform.position, transform.rotation);
        ind.transform.SetParent(parentGO);
        ind.InitIndividual(i);
        return ind;
    }
}