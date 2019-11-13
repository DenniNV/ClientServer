using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    private DataBaseAddUsers _addUsers = new DataBaseAddUsers();
    private CheckerIputData _checker = new CheckerIputData();
    private ControllerPanels _controllerPanels;
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
        _controllerPanels = GetComponentInParent<ControllerPanels>();
    }

    private void Rigistration()
    {
        if(_checker.CheckUserName(_login.text) && _checker.CheckUserPassword(_password.text) &&_checker.CheckUserEmail(_email.text))
        {
             StartCoroutine( _addUsers.Connection(_login.text, _password.text, _email.text));
            _login.text = "";
            _password.text = "";
            _email.text = "";
            _bugText.text = _addUsers.Error;
            if (_addUsers.RegistrationOk)
            {
                _controllerPanels._loginPanel.SetActive(true);
                gameObject.SetActive(false);
            }
            
        }
        else
        {
             _bugText.text = _checker.ErrorInputData(_login.text, _password.text, _email.text);
        }
    }




}
