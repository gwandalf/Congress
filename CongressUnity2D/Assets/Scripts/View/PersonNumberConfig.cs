using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

/// <summary>
/// Manages the person number UI.
/// </summary>
public class PersonNumberConfig : MonoBehaviour {

    /// <summary>
    /// GameObject holding the person set.
    /// </summary>
    public GameObject personSetHolder;

    /// <summary>
    /// Input Field.
    /// </summary>
    public InputField field;

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
        string input = field.text;
        int value = Int32.Parse(input);
        observed.resize(value);
    }

}
