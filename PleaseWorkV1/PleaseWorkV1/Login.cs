using Android.App;
using Android.Widget;
using Android.OS;

namespace PleaseWorkV1
{
    [Activity(Label = "PleaseWorkV1", MainLauncher = true, Icon = "@drawable/icon")]
    public class Login : Activity
    {
        public DataSets.User userOne = new DataSets.User();
        
        public EditText username;
        public EditText password;
        public Button loginButton;
        public TextView forgotPass;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Login);

            //Link with axml 
            username = FindViewById<EditText>(Resource.Id.UsernameET);
            password = FindViewById<EditText>(Resource.Id.PasswordET);
            loginButton = FindViewById<Button>(Resource.Id.MyButton);
            forgotPass = FindViewById<TextView>(Resource.Id.ForgotPassword);

            // set onclick listener here, by deleting some process
            loginButton.Click += delegate {
                logonButtonClick();

            };

            forgotPass.Click += delegate
            {
                forgotPassClick();
            };

        }

        public void logonButtonClick()
        {
            userOne.StudentNumber = username.Text;
            userOne.Password = password.Text;

            if (ValidateDetails() == true)
            {
                Toast.MakeText(this, "Move To Next", ToastLength.Long).Show();

                StartActivity(typeof(Menu));


            }
        }

        private void forgotPassClick()
        {
            Toast.MakeText(this, "Your Fucked", ToastLength.Long).Show();
        }

        public bool ValidateDetails()
        {
            //Username Correct
            if (userOne.ValidateUsername(username.Text) == true)
            {

                if (userOne.Password.Length != 0)
                {
                    if (userOne.withinDatabase() == true)
                    {
                        // Check within Database
                        Toast.MakeText(this, "Details Correct", ToastLength.Long).Show();
                        return true;
                    }
                    else
                    {
                        Toast.MakeText(this, "Details Incorrect", ToastLength.Long).Show();
                        return false;
                    }
                }
                else
                {
                    Toast.MakeText(this, "Password Field Empty", ToastLength.Long).Show();
                    return false;
                }
            }

            else
            {
                Toast.MakeText(this, "Username Incorrect Format", ToastLength.Long).Show();
                return false;
            }
        }
    }
}


