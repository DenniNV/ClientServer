using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    private DataBaseAddUsers _addUsers = new DataBaseAddUsers();
    [SerializeField]
    private Button _registrationOnClick;
    [SerializeField]
    private InputField _login;
    [SerializeField]
    private InputField _password;
    [SerializeField]
    private InputField _email;


    private void Awake()
    {
        _registrationOnClick.onClick.AddListener(() => Rigistration());
    }

    private void Rigistration()
    {

        if(_login.text != "" && _password.text !="" && _email.text != "")
        {
            _addUsers.Connection(_login.text, _password.text, _email.text);
            _login.text = "";
            _password.text = "";
            _email.text = "";
        }

    }
}
