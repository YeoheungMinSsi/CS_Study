namespace MediatorPattern2.homework;

public class Program
{
    public static void Main(string[] args)
    {
        var form = new FormController();

        var email = new TextInput(form, "email");
        var password = new TextInput(form, "password");
        var terms = new CheckBox(form, "terms");
        var submit = new Button(form, "submit");
        
        form.Register(email, password, terms, submit);
        
        email.Charged("input");
        password.Charged("input");
        terms.Charged("clicked");
    }
}