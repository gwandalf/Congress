using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Manages the person number UI.
/// </summary>
public class PersonNumberConfig : MonoBehaviour {

    /// <summary>
    /// GameObject holding the person set.
    /// </summary>
    public GameObject personSetHolder;

    public GameObject field;

    /// <summary>
    /// The observed PersonSetModel.
    /// </summary>
    private PersonSetModel observed;

	// Use this for initialization
	void Start () {
        observed = (PersonSetModel)personSetHolder.GetComponent(typeof(PersonSetModel));
	}
	
    /// <summary>
    /// Draws a field and a validation button.
    /// </summary>
	public void OnClick()
    {
        observed.resize(2);
    }

}
