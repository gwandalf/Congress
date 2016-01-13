using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Person Set.
/// </summary>
public class PersonSetModel : MonoBehaviour {

    /// <summary>
    /// Intial Number of persons.
    /// </summary>
    public int initialSize;

    /// <summary>
    /// Person set.
    /// </summary>
    private HashSet<GameObject> persons;

    /// <summary>
    /// Person Prefab.
    /// </summary>
    public GameObject personPrefab;

	// Use this for initialization
	void Start () {
        persons = new HashSet<GameObject>();
        createPersons(initialSize);
	}
	
    /// <summary>
    /// Creates a number of persons equal to the specified parameter.
    /// </summary>
    /// <param name="number">Number of persons to create.</param>
	public void createPersons(int number)
    {
        for (int i = 0; i < number; i++)
        {
            float x = Random.value * 20 - 10;
            float y = Random.value * 10 - 5;
            GameObject go = (GameObject)Instantiate(personPrefab, new Vector3(x, y, 0), Quaternion.identity);
            persons.Add(go);
        }
    }

}
