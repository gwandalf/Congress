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
    /// Initial period.
    /// </summary>
    public GameObject initialPeriod;

    /// <summary>
    /// Current period.
    /// </summary>
    private Period currentPeriod;

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
        currentPeriod = (Period)initialPeriod.GetComponent(typeof(Period));
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
    /// Creates a number of persons equal to the specified integer.
    /// </summary>
    /// <param name="number">Number of persons to create.</param>
    public void createPersons(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Activity act = currentPeriod.GetRandomActivity();
            float x = Random.Range(act.xMin, act.xMax);
            float y = Random.Range(act.yMin, act.yMax);
            GameObject go = (GameObject)Instantiate(personPrefab, new Vector3(x, y, 0), Quaternion.Euler(90, 0, 0));
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

    /// <summary>
    /// Moves all persons to other activities.
    /// </summary>
    /// <param name="period">Container of the new activities.</param>
    public void Move(Period period)
    {
        currentPeriod = period;
        foreach(GameObject p in persons)
        {
            Activity act = currentPeriod.GetRandomActivity();
            float x = Random.Range(act.xMin, act.xMax);
            float y = Random.Range(act.yMin, act.yMax);
            p.transform.position = new Vector3(x, y, 0);
        }
    }

}
