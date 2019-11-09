using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    private DataBaseAddUsers _addUsers = new DataBaseAddUsers();
    private CheckerIputData _checker = new CheckerIputData();
    [SerializeField]
    private Button _registrationOnClick;
    [SerializeField]
    private InputField _login;
    [SerializeField]
    private InputField _password;
    [SerializeField]
    private InputField _email;
    [SerializeField]
    private Text _bugText;


    private void Awake()
    {
        _registrationOnClick.onClick.AddListener(() => Rigistration());
    }

    private void Rigistration()
    {

        if(_checker.CheckUserName(_login.text) && _checker.CheckUserPassword(_password.text) &&_checker.CheckUserEmail(_email.text))
        {
            _addUsers.Connection(_login.text, _password.text, _email.text);
            _login.text = "";
            _password.text = "";
            _email.text = "";
        }
        else
        {
             _bugText.text = _checker.ErrorInputData(_login.text, _password.text, _email.text);


        }
        

    }




}
