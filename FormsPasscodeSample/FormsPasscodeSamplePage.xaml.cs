using Xamarin.Forms;

namespace FormsPasscodeSample
{
    public partial class FormsPasscodeSamplePage : ContentPage
    {
        private int passcodeNumber = 0;
        private string passcode = string.Empty;
        //TODO test passcode value
        private string samplePasscode = "123456";
        public FormsPasscodeSamplePage()
        {
            InitializeComponent();
        }

        void PasscodeButton_Clicked(object sender, System.EventArgs e)
        {
            passcodeNumber++;
            var button = sender as Button;
            switch(button.Image.File)
            {
                case "ic_circle_1.png":
                    passcode = passcode + "1";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_2.png":
                    passcode = passcode + "2";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_3.png":
                    passcode = passcode + "3";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_4.png":
                    passcode = passcode + "4";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_5.png":
                    passcode = passcode + "5";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_6.png":
                    passcode = passcode + "6";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_7.png":
                    passcode = passcode + "7";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_8.png":
                    passcode = passcode + "8";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_9.png":
                    passcode = passcode + "9";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_0.png":
                    passcode = passcode + "0";
                    FillPasscodeField(passcodeNumber);
                    break;
                case "ic_circle_clear.png":
                    FillPasscodeField(0);
                    passcode = string.Empty;
                    if (passcodeNumber > 0)
                        passcodeNumber--;
                    break;
                default:
                    if (!string.IsNullOrEmpty(passcode))
                    {
                        ResetPasscodeImages(passcode.Length);
                        passcode = passcode.Remove(passcode.Length - 1);
                    }
                    if (passcodeNumber > 0)
                        passcodeNumber--;
                    break;
            }
        }

        private async void FillPasscodeField(int input)
        {
            switch(input)
            {
                case 1:
                    img1.Source = "ic_circle_unlock";
                    break;
                case 2:
                    img2.Source = "ic_circle_unlock";
                    break;
                case 3:
                    img3.Source = "ic_circle_unlock";
                    break;
                case 4:
                    img4.Source = "ic_circle_unlock";
                    break;
                case 5:
                    img5.Source = "ic_circle_unlock";
                    break;
                case 6:
                    img6.Source = "ic_circle_unlock";
                    if (samplePasscode.Equals(passcode))
                    {
                        passcodeNumber = 0;
                        await Navigation.PushModalAsync(new PasscodeSuccessPage());
                    }
                    else
                    {
                        ClearPasscodeImages();
                        await DisplayAlert("Alert", "Invalid Passcode, try again", "OK");
                    }
                    break;
                default:
                    ClearPasscodeImages();
                    break;
            }
        }

        private void ResetPasscodeImages(int passcodeLen)
        {
            if(passcodeLen > 0 && passcodeLen < 6)
            {
                switch(passcodeLen)
                {
                    case 5:
                        img5.Source = "ic_circle_lock";
                        break;
                    case 4:
                        img4.Source = "ic_circle_lock";
                        break;
                    case 3:
                        img3.Source = "ic_circle_lock";
                        break;
                    case 2:
                        img2.Source = "ic_circle_lock";
                        break;
                    default:
                        img1.Source = "ic_circle_lock";
                        break;
                }
            }
        }

        private void ClearPasscodeImages()
        {
            if (!string.IsNullOrEmpty(passcode))
            {
                img1.Source = "ic_circle_lock";
                img2.Source = "ic_circle_lock";
                img3.Source = "ic_circle_lock";
                img4.Source = "ic_circle_lock";
                img5.Source = "ic_circle_lock";
                img6.Source = "ic_circle_lock";
                passcodeNumber = 0;
                passcode = string.Empty;
            }

        }
    }
}
