using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class bloodPool : MonoBehaviour
{
    [SerializeField] private GameObject bloodPrefab;
    [SerializeField] private int poolSize = 30;

    private List<GameObject> pool = new List<GameObject>();
    
    void Start()
    {
        for(int i = 0; i < poolSize; i++)
        {
            GameObject Newblood = Instantiate(bloodPrefab);
            Newblood.SetActive(false);
            pool.Add(Newblood);
        }
    }

    public  GameObject UpdateBlood()
    {
        for (int i = 0;i < pool.Count; i++)
        {
            if(pool[i].activeInHierarchy)
            {
                return pool[i];
            }
        }

        GameObject additional = Instantiate(bloodPrefab);
        pool.Add(additional);
        return additional;
    }
   
}
