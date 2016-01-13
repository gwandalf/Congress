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
    private List<GameObject> persons;

    /// <summary>
    /// Person Prefab.
    /// </summary>
    public GameObject personPrefab;

	// Use this for initialization
	void Start () {
        persons = new List<GameObject>();
        createPersons(initialSize);
	}

    /// <summary>
    /// Update the person number to the specified one.
    /// </summary>
    /// <param name="number">New person number.</param>
    public void resize(int number)
    {
        if (number > persons.Count)
            createPersons(number - persons.Count);
        else if (number < persons.Count)
            deletePersons(persons.Count - number);
        else return;
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

    /// <summary>
    /// Deletes a number of persons equal to the specified parameter.
    /// </summary>
    /// <param name="number">Number of persons to delete.</param>
    public void deletePersons(int number)
    {
        for (int i = 0; i < number; i++)
        {
            int index = (int) (Random.value * (persons.Count - 1));
            GameObject go = persons[index];
            persons.Remove(go);
            Destroy(go);
        }
    }

}
