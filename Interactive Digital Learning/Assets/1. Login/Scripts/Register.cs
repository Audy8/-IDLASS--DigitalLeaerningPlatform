using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;
public class Register : MonoBehaviour {
	public GameObject username;
	public GameObject email;
	public GameObject password;
	public GameObject passwordConformation;
	public string Name;
	private string Email;
	private string Password;
	private string PasswordConformation;
	private string Form;
	private bool EmailValid = false;
	void Start(){
		username.transform.GetChild(2).GetComponent<CanvasRenderer>().SetAlpha(0f);
		email.transform.GetChild(2).GetComponent<CanvasRenderer>().SetAlpha(0f);
		password.transform.GetChild(2).GetComponent<CanvasRenderer>().SetAlpha(0f);
	}
	
	public void RegisterButton(){
		bool N = false;
		bool E = false;
		bool P = false;
		bool PC = false;
		EmailValid = false;
		if (Name != ""){
			if (!System.IO.File.Exists(@"D:\IDLASS Project\-IDLASS--DigitalLeaerningPlatform\Users\"+Name+".txt")){
				N = true;
				username.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.green);
				username.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
			} else {
				username.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
				username.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
				Debug.LogWarning("Username Has Been Taken");
			}
		} else {
			username.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
			username.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
			Debug.LogWarning("Username Field is empty");
		}
		if (Email != ""){
			EmailValid = Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
			if (EmailValid == true){
				if(Email.Contains("@") == true){
					if(Email.Contains(".") == true){
						E = true;
						email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
						email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.green);
					} else {
						email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
						email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
						Debug.LogWarning("Email Field is Incorrect");
					}
				} else {
					email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
					email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
					Debug.LogWarning("Email Field is Incorrect");
				}
			} else {
				email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
				email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
				Debug.LogWarning("Email Field is Incorrect");
			}
		} else {
			email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
			email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
			Debug.LogWarning("Email Field is empty or Incorrect");
		}
		if (Password != ""){
			if (Password.Length > 5){
				P = true;
			} else {
				password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
				password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
				Debug.LogWarning("Password Must at least be 6 characters long");
			}
		} else {
			password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
			password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
			Debug.LogWarning("Password Field is empty");
		}
		if (Password == PasswordConformation){
			PC = true;
			if (P == true){
				password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.green);
				password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
			}
		} else {
			password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetColor(Color.red);
			password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0.7f);
			Debug.LogWarning("Passwords Don't Match");
		}
		if (N == true && E == true && P == true && PC == true){
			int i = 1;
			bool Clear = true;
			foreach(char c in Password){
				i++;
				if (Clear){
					Password = "";
					Clear = false;
				}
				char Encrypted = (char)(c * i);
				Password += Encrypted.ToString();
			}
			
			Form = (Name+Environment.NewLine+Email+Environment.NewLine+Password);
			System.IO.File.WriteAllText(@"D:\IDLASS Project\-IDLASS--DigitalLeaerningPlatform\Users\"+Name+".txt", Form);
			print ("Registration Successful");
			username.GetComponent<InputField>().text = "";
			email.GetComponent<InputField>().text = "";
			password.GetComponent<InputField>().text = "";
			passwordConformation.GetComponent<InputField>().text = "";
			username.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0f);
			email.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0f);
			password.transform.GetChild(3).GetComponent<CanvasRenderer>().SetAlpha(0f);
		}
	}
	
	void Update () {
		if (Input.GetKeyDown(KeyCode.Tab)){
			if (username.GetComponent<InputField>().isFocused){
				email.GetComponent<InputField>().Select();
			}
			if (email.GetComponent<InputField>().isFocused){
				password.GetComponent<InputField>().Select();
			}
			if (password.GetComponent<InputField>().isFocused){
				passwordConformation.GetComponent<InputField>().Select();
			}
		}
		if (Input.GetKeyDown(KeyCode.Return)){
			if (PasswordConformation != ""&&Password != ""&&Email != ""&&Name != ""){
				RegisterButton();
			}
		}
		Name = username.GetComponent<InputField>().text;
		Email = email.GetComponent<InputField>().text;
		Password = password.GetComponent<InputField>().text;
		PasswordConformation = passwordConformation.GetComponent<InputField>().text;
		
		
	}
}