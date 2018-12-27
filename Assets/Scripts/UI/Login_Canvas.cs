﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Login_Canvas : CanvasNavigation 
{
#pragma warning disable
    [Header("UI References")]
    [SerializeField] private Button loginButton;
    [SerializeField] private Button signUpButton;
    [SerializeField] private Button freeTrialButton;

    [SerializeField] private InputField emailInput;
    [SerializeField] private InputField passwordInput;
    [SerializeField] private Text feedbackText;
	public GameObject bgTemp;

	private void Start()
	{
        if (loginButton) loginButton.onClick.AddListener(LoginPressed);
        if (signUpButton) signUpButton.onClick.AddListener(SignUpPressed);
        if (freeTrialButton) freeTrialButton.onClick.AddListener(FreeTrialPressed);


        //mController = GameObject.Find("mathController").GetComponent<MathController>();

        if (feedbackText) feedbackText.text = "";
	}

    void LoginPressed()
    {
        if (feedbackText) feedbackText.text = "";

        //TODO: Implement databaseManager in sprout
        /*if (DatabaseManager.instance == null) return;

        if (emailInput.text == "") // || passwordInput.text == "")
        {
            feedbackText.text = "All fields must be entered.";
            return;
        }

        if(DatabaseManager.instance.IsEmailValid(emailInput.text) == false)
        {
            feedbackText.text = "Email not found.";
            return;
        }*/

        /*if(DatabaseManager.instance.IsPasswordValid(emailInput.text, passwordInput.text) == false)
        {
            feedbackText.text = "Incorrect password entered!";
            return;
        }*/

        Debug.Log("Login Successful!");
		//LocalUserData.SetUserEmail (emailInput.text.ToLower ());
        //PlayerPrefs.SetString("playerName", DatabaseManager.instance.GetUserName(emailInput.text.ToLower()));
		if (FindObjectOfType<SubscriptionCanvas> ())
			FindObjectOfType<SubscriptionCanvas> ().Refresh ();
		Destroy (this.gameObject);
		Destroy (bgTemp);
    }

    void FreeTrialPressed()
    {
        Destroy(this.gameObject);
        Destroy(bgTemp);
    }

    void SignUpPressed()
    {
		GoToNextCanvas ();
    }
}